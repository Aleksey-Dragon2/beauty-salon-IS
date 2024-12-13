from fastapi import FastAPI, Depends, HTTPException
from fastapi.responses import StreamingResponse
from sqlalchemy import select, delete, and_, update, func, text, case, desc, extract
from sqlalchemy.orm import Session
from sqlalchemy.exc import IntegrityError
from typing import Optional


from collections import defaultdict
from .database import engine, SessionLocal
from app import models
from datetime import datetime, timedelta

from urllib.parse import unquote

from contextlib import asynccontextmanager

from app.cheque import BeautyReceiptPDF
from app.query import get_sample_data

import uvicorn
import asyncio
import io
# Создаем таблицы в базе данных (если они еще не существуют)
# models.Base.metadata.drop_all(bind=engine)
models.Base.metadata.create_all(bind=engine)


# Зависимость для получения сессии базы данных
def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()

@asynccontextmanager
async def lifespan(app: FastAPI):
    task = asyncio.create_task(periodic_task())
    yield
    task.cancel()
    try:
        await task
    except asyncio.CancelledError:
        print("Учет визитов остановлен.")

app = FastAPI(lifespan=lifespan)

async def periodic_task():
    while True:
        with SessionLocal() as db:
            updated_rows = update_status_to_expired(db)
            print(f"Визитов просрочено: {updated_rows}")
        await asyncio.sleep(600)

def update_status_to_expired(db: Session):
    one_hour_ago = func.date_sub(func.now(), text("INTERVAL 1 HOUR"))

    stmt = (
        update(models.Visit)
        .where(
            models.Visit.status == "Запланирован",
            models.Visit.visits_date < one_hour_ago
        )
        .values(status="Просрочен")
    )
    result = db.execute(stmt)
    db.commit()
    return result.rowcount

# Создание визита
@app.post("/visit/")
def create_visit(
    client_name: str,
    visits_date: str,
    status: str,
    services: str,
    db: Session = Depends(get_db)
) -> dict:
    try:
        # Декодируем и валидируем входные данные
        client_name = unquote(client_name).strip()
        visits_date = unquote(visits_date)
        status = unquote(status).strip()
        services_list = [unquote(service.strip()) for service in services.split(',') if service.strip()]
        
        if not client_name or not services_list:
            raise HTTPException(status_code=400, detail="Не указано имя клиента или услуги")

        try:
            format_visits_date = datetime.fromisoformat(visits_date)
        except ValueError:
            raise HTTPException(status_code=400, detail="Неверный формат даты")

        # if format_visits_date < datetime.now():
        #     raise HTTPException(status_code=400, detail="Дата визита не может быть в прошлом")

        # Получаем все необходимые услуги одним запросом
        services_query = select(models.Service).where(models.Service.name.in_(services_list))
        available_services = {service.name: service for service in db.execute(services_query).scalars().all()}

        # Проверяем наличие всех запрошенных услуг
        missing_services = set(services_list) - set(available_services.keys())
        if missing_services:
            raise HTTPException(
                status_code=404,
                detail=f"Услуги не найдены: {', '.join(missing_services)}"
            )

        # Создаем запись о визите
        db_visit = models.Visit(
            client_name=client_name,
            visits_date=format_visits_date,
            status=status
        )
        db.add(db_visit)
        db.flush()

        # Находим свободных мастеров для всех услуг
        one_hour_ago = format_visits_date - timedelta(hours=1)
        one_hour_after = format_visits_date + timedelta(hours=1)

        assigned_masters = {}
        for service_name in services_list:
            service = available_services[service_name]
            
            # Оптимизированный запрос для поиска свободного мастера
            busy_masters_subquery = (
                select(models.ProvidedService.master_id)
                .join(models.Visit)
                .where(
                    and_(
                        models.Visit.visits_date.between(one_hour_ago, one_hour_after),
                        models.Visit.id != db_visit.id  # Исключаем текущий визит
                    )
                )
            )

            master_query = (
                select(models.Master)
                .join(models.MasterService)
                .where(
                    and_(
                        models.MasterService.service_id == service.id,
                        ~models.Master.id.in_(busy_masters_subquery)
                    )
                )
                .limit(1)
            )
            
            master = db.execute(master_query).scalars().first()
            if not master:
                # Откатываем транзакцию в случае ошибки
                db.rollback()
                raise HTTPException(
                    status_code=409,
                    detail=f"Нет свободного мастера для услуги '{service_name}' на указанное время"
                )
            
            assigned_masters[service.id] = master.id

        # Создаем записи о предоставляемых услугах
        provided_services = [
            models.ProvidedService(
                visit_id=db_visit.id,
                service_id=service_id,
                master_id=master_id,
                service_price=available_services[service_name].price
            )
            for service_id, master_id in assigned_masters.items()
            for service_name, service in available_services.items()
            if service.id == service_id
        ]
        
        db.add_all(provided_services)
        db.commit()

        return {
            "visit_id": db_visit.id,
            "status": "Визит успешно создан",
            "scheduled_time": format_visits_date.isoformat(),
            "services_count": len(provided_services)
        }

    except HTTPException:
        db.rollback()
        raise
    except Exception as e:
        db.rollback()
        raise HTTPException(status_code=500, detail=f"Ошибка при создании визита: {str(e)}")

# Обновление визита
@app.post("/visit/update")
def update_visit(id: int, status : str, db: Session = Depends(get_db)):
    stmt=select(models.Visit).where(models.Visit.id==id)
    visit=db.scalars(stmt).one()
    if visit is None:
        raise HTTPException(status_code=406, detail="Visit not founded")
    if status:
        visit.status=status
    db.commit()
    return {
        "message":"Статус успешно обновлен",
    }

@app.post("/coefficient/")
def create_price_coefficient(value: float, db: Session = Depends(get_db)):
    try:
        db_coefficient = models.PriceCoefficient(value=value)
        db.add(db_coefficient)
        
        services = db.query(models.Service).all()

        for service in services:
            service.price = float(service.price) * value

        db.commit()
        return {"detail":"Services price update"}
    
    except IntegrityError:
        db.rollback()
        raise HTTPException(
            status_code=400,
            detail="Error creating price coefficient"
        )
    except Exception as e:
        db.rollback()
        raise HTTPException(
            status_code=500,
            detail=f"Error updating prices: {str(e)}"
        )


# Создание мастера
@app.post("/master/")
def create_master(name: str, surname: str, specialization: str, services: str, db: Session = Depends(get_db)):
    db_master = models.Master(name=name, surname=surname, specialization=specialization)
    db.add(db_master)
    db.flush()
    master_id = db_master.id
    service_names=services.split(',')
    for service_name in service_names:
        stmt = select(models.Service.id).where(models.Service.name == service_name)
        service_id = db.scalars(stmt).first()

        if service_id: 
            db_master_service = models.MasterService(master_id=master_id, service_id=service_id)
            db.add(db_master_service)
        else:
            raise HTTPException(status_code=404, detail=f"Service '{service_name}' not found")
        
    db.commit()
    db.refresh(db_master)

    return db_master

@app.get("/master_stats/{master_id}")
def get_master_stats(master_id: int, db: Session = Depends(get_db)):
    # Подзапрос: Считаем количество услуг, оказанных мастером за текущий год
    current_year = datetime.now().year
    service_count_subquery = (
        select(
            models.ProvidedService.service_id,
            func.count(models.ProvidedService.id).label("service_count")
        )
        .join(models.Visit, models.ProvidedService.visit_id == models.Visit.id)
        .filter(
            models.ProvidedService.master_id == master_id,
            extract("year", models.Visit.visits_date) == current_year
        )
        .group_by(models.ProvidedService.service_id)
        .subquery()
    )

    # Подзапрос: Выбираем наиболее популярную услугу мастера
    popular_service_subquery = (
        select(
            service_count_subquery.c.service_id
        )
        .order_by(service_count_subquery.c.service_count.desc())
        .limit(1)
        .subquery()
    )

    # Основной запрос: Получаем статистику по мастеру
    stmt = (
        select(
            models.Master.name,
            models.Master.surname,
            models.Master.specialization,
            func.count(models.ProvidedService.id).label("total_services"),
            models.Service.name.label("popular_service"),
            func.avg(models.ProvidedService.service_price).label("avg_service_price")
        )
        .join(models.ProvidedService, models.Master.id == models.ProvidedService.master_id)
        .join(models.Service, models.Service.id == models.ProvidedService.service_id)
        .join(models.Visit, models.ProvidedService.visit_id == models.Visit.id)
        .filter(
            models.Master.id == master_id,
            extract("year", models.Visit.visits_date) == current_year
        )
        .group_by(
            models.Master.id,
            models.Service.name
        )
    )

    result = db.execute(stmt).all()

    # Преобразуем результат в читаемый формат
    response = [
        {
            "master_name": f"{row.name} {row.surname}",
            "specialization": row.specialization,
            "total_services": row.total_services,
            "popular_service": row.popular_service,
            "avg_service_price": float(row.avg_service_price)
        }
        for row in result
    ]

    return response



# Добавление услуги в мастера
@app.post("/master/assign-service/")
def master_assign_service(master_id:int, service_id:int, db:Session=Depends(get_db)):
    db_master_services=models.MasterService(master_id=master_id, service_id=service_id)
    db.add(db_master_services)
    db.commit()
    db.refresh(db_master_services)
    return db_master_services

# Удаление услуги у мастера
@app.post("/master/remove-service/")
def master_remove_service(master_id: int, service_id: int, db: Session = Depends(get_db)):
    # Ищем запись для удаления
    stmt = select(models.MasterService).where(
        models.MasterService.master_id == master_id,
        models.MasterService.service_id == service_id
    )
    service = db.scalars(stmt).first()

    if service is None:
        raise HTTPException(status_code=404, detail="Service not found for the master")

    # Удаляем найденную запись
    delete_stmt = delete(models.MasterService).where(
        models.MasterService.master_id == master_id,
        models.MasterService.service_id == service_id
    )
    db.execute(delete_stmt)
    db.commit()

    return {"message": "Service removed successfully"}

# Обновление мастера
@app.post("/master/update/", status_code=202)
def update_master(
    id: int, 
    name: Optional[str] = None,
    surname: Optional[str] = None,
    specialization: Optional[str]=None,
    db: Session = Depends(get_db)):
        
        stmt = select(models.Master).where(models.Master.id == id)
        master=db.scalars(stmt).first()
        if master is None:
            raise HTTPException(status_code=406, detail="Master not founded")

        if name:
            master.name=name
        if surname:
            master.surname=surname
        if specialization:
             master.specialization=specialization

        db.commit()

# Создание услуги
@app.post("/service/", status_code=201)
def create_service(name: str, price: float, master_id: Optional[int] = None, db: Session = Depends(get_db)):
    name = unquote(name) 
    try:
        db_service = models.Service(name=name, price=price)
        db.add(db_service)
        db.flush()
        if master_id is None:
            db.commit()
            return db_service
        db_provided_service = models.MasterService(master_id=master_id, service_id=db_service.id)
        db.add(db_provided_service)
        db.commit()
        db.refresh(db_service)
        return db_service
    except IntegrityError:
        db.rollback() 
        raise HTTPException(
            status_code=406,
            detail=f"Service with name '{name}' already exists."
        )

# Удаление услуги
@app.delete("/service/{id}", status_code=204)
def delete_service_by_id(id: int, db:Session=Depends(get_db)):
        service = db.query(models.Service).filter(models.Service.id == id).first()
        if service is None:
            raise HTTPException(status_code=404, detail="Service not found")
        stmt = delete(models.Service).where(models.Service.id == id)
        db.execute(stmt)
        db.commit()
        return {"detail": "Service deleted successfully"}



# Обновление услуги
@app.post("/service/update/",status_code=200)
def update_service(
    id: int, 
    name: Optional[str] = None,
    price: Optional[float] = None,
    db: Session = Depends(get_db)):
        try:
            stmt = select(models.Service).where(models.Service.id == id)
            service=db.scalars(stmt).first()
            if service is None:
                raise HTTPException(status_code=404, detail="Service not founded")

            if name:
                service.name=name
            if price:
                service.price=price

            db.commit()
        except:
            raise HTTPException(
            status_code=406,
            detail=f"Service with name '{name}' already exists."
        )

@app.delete("/master/{id}", status_code=204)
def delete_master_by_id(id: int, db:Session=Depends(get_db)):
    try:
        master = db.query(models.Master).filter(models.Master.id == id).first()
        if master is None:
            raise HTTPException(status_code=404, detail="Service not found")
        stmt = delete(models.Master).where(models.Master.id == id)
        db.execute(stmt)
        db.commit()
        return {"detail": "Service deleted successfully"}
    except:
        raise HTTPException(
            status_code=523,
            detail=f"Database unreachable"
        )

# Получение всех мастеров
@app.get("/masters/get/")
def get_masters(db: Session = Depends(get_db)):
    stmt = select(models.Master)
    masters = db.scalars(stmt).all()
    return masters

# Получение всех мастеров
@app.get("/masters/get/specialization/")
def get_masters_by_specialization(specialization:str, db: Session = Depends(get_db)):
    stmt = select(models.Master).where(models.Master.specialization==specialization)
    masters = db.scalars(stmt).all()
    return masters

# Получение всех специализаций
@app.get("/masters/specialization/")
def get_masters_specialization(db: Session = Depends(get_db)):
    stmt = select(models.Master.specialization).distinct()
    masters=db.scalars(stmt).all()
    return masters

# Получение всех услуг
@app.get("/services/get/")
def get_services(db: Session = Depends(get_db)):
    stmt=select(models.Service)
    services=db.scalars(stmt).all()
    return services

@app.get("/coefficient/")
def get_coefficient(db: Session = Depends(get_db)):
    stmt = (
        select(models.PriceCoefficient)
        .order_by(desc(models.PriceCoefficient.application_date))
        .limit(5)
    )
    coefficients = db.scalars(stmt).all()
    return coefficients

# Получение всех визитов
@app.get("/visits/")
def get_visits(db: Session = Depends(get_db)):
    order = case(
        (models.Visit.status == "Просрочен", 1),
        (models.Visit.status == "Завершен", 2),
        (models.Visit.status == "Запланирован", 3),
        (models.Visit.status == "Выполняется", 4),
        else_=5
    )
    stmt = select(models.Visit).order_by(order)
    masters = db.scalars(stmt).all()
    return masters


@app.get("/visits/date/")
def get_visits_by_date(date: str, db: Session = Depends(get_db)):
    visits_date = unquote(date)
    try:
        format_visits_date = datetime.strptime(visits_date, "%Y-%m-%d").date()
    except ValueError:
        raise HTTPException(status_code=400, detail="Неверный формат даты")
        
    order = case(
        (models.Visit.status == "Просрочен", 1),
        (models.Visit.status == "Завершен", 2),
        (models.Visit.status == "Запланирован", 3),
        (models.Visit.status == "Выполняется", 4),
        else_=5
    )

    stmt = (
        select(models.Visit)
        .where(func.date(models.Visit.visits_date) == format_visits_date)
        .order_by(order)
    )
    visits = db.scalars(stmt).all()
    return visits


@app.get("/visit/{visit_id}")
def get_visit_data(visit_id: int, db: Session = Depends(get_db)):
    # Создаём запрос с фильтром по id визита
    stmt = (
        select(
            models.Visit.client_name,
            models.Visit.visits_date,
            models.Service.name.label("service_name"),
            models.ProvidedService.service_price.label("service_price")
        )
        .join(models.ProvidedService, models.Visit.id == models.ProvidedService.visit_id)
        .join(models.Service, models.ProvidedService.service_id == models.Service.id)
        .where(models.Visit.id == visit_id)  # Условие фильтрации по visit_id
    )

    # Выполняем запрос
    result = db.execute(stmt).all()

    # Преобразуем результат в список словарей для удобного вывода
    visit_data = [
        {
            "client_name": row.client_name,
            "visit_date": row.visits_date,
            "service_name": row.service_name,
            "service_price": row.service_price
        }
        for row in result
    ]
    
    # Если ничего не найдено, вернуть сообщение об отсутствии данных
    if not visit_data:
        return {"message": "Visit not found"}

    return visit_data

# Отправка чека
@app.get("/visit/cheque/")
def get_cheque(visit_id: int, db: Session = Depends(get_db)):
    data = get_sample_data(visit_id=visit_id, db=db)

    receipt = BeautyReceiptPDF()
    buffer = io.BytesIO()
    receipt.generate_receipt(buffer, data)
    buffer.seek(0)
    
    return StreamingResponse(buffer, media_type="application/pdf", headers={
        "Content-Disposition": f"attachment; filename=cheque_{visit_id}.pdf"
    })

if __name__ == "__main__":
    uvicorn.run(app, host="0.0.0.0", port=8000)