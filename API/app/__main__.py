from fastapi import FastAPI, Depends, HTTPException
from sqlalchemy import select, delete, DateTime
from sqlalchemy.orm import Session
from sqlalchemy.exc import IntegrityError
from typing import Optional

from .database import engine, SessionLocal
from app import models
from datetime import datetime
import uvicorn

from urllib.parse import unquote


# Создаем таблицы в базе данных (если они еще не существуют)
# models.Base.metadata.drop_all(bind=engine)
models.Base.metadata.create_all(bind=engine)

app = FastAPI()

# Зависимость для получения сессии базы данных
def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()



# Создание визита
@app.post("/visit/")
def create_visit(client_name: str, visits_date:datetime, status: str, db: Session = Depends(get_db)):
    db_visits = models.Visit(client_name=client_name, visits_date=visits_date, status=status)
    db.add(db_visits)
    db.commit()
    db.refresh(db_visits)
    return db_visits


# Создание мастера
@app.post("/master/")
def create_master(name: str, surname:str, specialization: str, db: Session = Depends(get_db)):
    db_master = models.Master(name=name, surname=surname, specialization=specialization)
    db.add(db_master)
    db.commit()
    db.refresh(db_master)
    return db_master

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
            raise HTTPException(status_code=404, detail="Service not founded")

        if name:
            master.name=name
        if surname:
            master.surname=surname
        if specialization:
             master.specialization=specialization

        db.commit()
        

# Создание услуги
@app.post("/service/", status_code=201)
def create_service(name: str, price: float, master_id: int, db: Session = Depends(get_db)):
    name = unquote(name) 
    try:
        db_service = models.Service(name=name, price=price)
        db.add(db_service)
        db.flush()

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
    try:
        service = db.query(models.Service).filter(models.Service.id == id).first()
        if service is None:
            raise HTTPException(status_code=404, detail="Service not found")
        stmt = delete(models.Service).where(models.Service.id == id)
        db.execute(stmt)
        db.commit()
        return {"detail": "Service deleted successfully"}
    except:
        raise HTTPException(
            status_code=523,
            detail=f"Database unreachable"
        )


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

# Получение всех мастеров
@app.get("/masters/get/")
def get_masters(db: Session = Depends(get_db)):
    stmt = select(models.Master)
    masters = db.scalars(stmt).all()
    return masters

# Получение всех специализаций
@app.get("/masters/specialization/")
def get_masters_specialization(db: Session = Depends(get_db)):
    stmt=select(models.Master.specialization)
    masters=db.scalars(stmt).all()
    return masters

# Получение всех услуг
@app.get("/services/get/")
def get_services(db: Session = Depends(get_db)):
    stmt=select(models.Service)
    services=db.scalars(stmt).all()
    return services

if __name__ == "__main__":
    uvicorn.run(app, host="0.0.0.0", port=8000)