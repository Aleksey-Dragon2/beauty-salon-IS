from sqlalchemy import Column, Integer, String, ForeignKey, Numeric, DateTime, text, Date
from sqlalchemy.orm import Mapped, mapped_column
from .database import Base
from typing import Annotated, Optional
from datetime import datetime

intpk = Annotated[int, mapped_column(primary_key=True, unique=True, nullable=False)]
intnotnull=Annotated[int, mapped_column(nullable=False)]
date=Annotated[datetime,mapped_column(server_default=text("DATE_ADD(now(), INTERVAL 3 HOUR)"))]

str_30=Annotated[str, mapped_column(String(30))]
str_255=Annotated[str, mapped_column(String(255))]

ustr_30=Annotated[str, mapped_column(String(30),unique=True)]
ustr_255=Annotated[str, mapped_column(String(255),unique=True)]


class Service(Base):
    __tablename__="services"
    id: Mapped[intpk]
    name: Mapped[ustr_255]=mapped_column(nullable=False)
    price: Mapped[float]=mapped_column(Numeric(10,2))

# Модель для таблицы masters
class Master(Base):
    __tablename__ = "masters"
    id: Mapped[intpk]
    name: Mapped[str_30]
    surname: Mapped[str_30]
    specialization: Mapped[str_255]

class MasterService(Base):
    __tablename__= "master_services"
    id: Mapped[intpk]
    master_id: Mapped[int]=mapped_column(ForeignKey("masters.id", ondelete="CASCADE"),nullable=False)
    service_id: Mapped[int]=mapped_column(ForeignKey("services.id", ondelete="CASCADE"),nullable=False)

class Visit(Base):
    __tablename__='visits'
    id:Mapped[intpk]
    client_name: Mapped[str_30]
    visits_date:Mapped[date]=mapped_column(index=True)
    status: Mapped[str]=mapped_column(String(15), default="Ожидает")

class ProvidedService(Base):
    __tablename__='provided_services'

    id:Mapped[intpk]
    visit_id: Mapped[intnotnull]=mapped_column(ForeignKey("visits.id"))
    service_id: Mapped[intnotnull]=mapped_column(ForeignKey("services.id"))
    master_id: Mapped[intnotnull]=mapped_column(ForeignKey("masters.id"))
    service_price: Mapped[float]=mapped_column(Numeric(10,2), nullable=False)

class PriceCoefficient(Base):
    __tablename__='price_coefficients'
    
    id:Mapped[intpk]
    application_date: Mapped[Date] = mapped_column(Date, nullable=False)
    value: Mapped[float]=mapped_column(Numeric(10,2),nullable=True)

