from fastapi import FastAPI, Depends
from sqlalchemy import select
from sqlalchemy.orm import Session
from .database import engine, SessionLocal
from app import models

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



# Создание мастера
@app.post("/masters/")
def create_master(name: str, surname:str, specialization: str, db: Session = Depends(get_db)):
    db_master = models.Master(name=name, surname=surname, specialization=specialization)
    db.add(db_master)
    db.commit()
    db.refresh(db_master)
    return db_master

# Создание услуги
@app.post("/service/")
def create_service(name: str, base_price: float, db: Session=Depends(get_db)):
    db_service=models.Service(name=name, base_price=base_price)
    db.add(db_service)
    db.commit()
    db.refresh(db_service)
    return db_service

# Получение всех мастеров
@app.get("/get_masters/")
def get_masters(db: Session = Depends(get_db)):
    stmt = select(models.Master)
    masters = db.scalars(stmt).all()
    return masters

# Получение всех услуг
@app.get("/get_services/")
def get_services(db: Session = Depends(get_db)):
    stmt=select(models.Service)
    services=db.scalars(stmt).all()
    return services