from app import models
from collections import defaultdict
from .database import engine, SessionLocal
from sqlalchemy.orm import Session
from fastapi import Depends
def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()

def get_sample_data(visit_id: int, db: Session):
    # Запрос данных о визите
    visit = db.query(models.Visit).filter(models.Visit.id == visit_id).first()
    if not visit:
        raise ValueError(f"Visit with ID {visit_id} not found")

    # Запрос предоставленных услуг с мастерами и ценами
    provided_services = (
        db.query(
            models.ProvidedService,
            models.Service.name.label("service_name"),
            models.Master.name.label("master_name"),
            models.Master.surname.label("master_surname"),
        )
        .join(models.Service, models.ProvidedService.service_id == models.Service.id)
        .join(models.Master, models.ProvidedService.master_id == models.Master.id)
        .filter(models.ProvidedService.visit_id == visit_id)
        .all()
    )

    # Сбор данных
    master_services = defaultdict(list)
    for ps, service_name, master_name, master_surname in provided_services:
        master_full_name = f"{master_surname} {master_name}"
        master_services[master_full_name].append({"name": service_name, "price": float(ps.service_price)})

    # Формирование итоговой структуры
    sample_data = {
        "number": f"2024-{visit.id:04d}",
        "date": visit.visits_date.strftime("%Y-%m-%d"),
        "time": visit.visits_date.strftime("%H:%M"),
        "services": [
            {"master": master, "items": items} for master, items in master_services.items()
        ],
    }

    return sample_data