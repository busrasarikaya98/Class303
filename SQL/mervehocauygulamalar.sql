--SENARYO
create database BUSRAYAZILIM
use BUSRAYAZILIM
create table Calisanlar(
CalisanID int primary key,
AD varchar(10),
SOYAD varchar(20),
POZ�SYON varchar(20),
MAAS int
)

create table KisiselBilgiler(
KisiID int primary key,
AD varchar(10),
SOYAD varchar(20),
C�NS�YET varchar(20),
YA� int,
MEDEN�HAL� varchar(10),
)
select*from KisiselBilgiler
select*from Calisanlar

select KisiselBilgiler.AD,KisiselBilgiler.SOYAD,KisiselBilgiler.C�NS�YET,KisiselBilgiler.YA�,KisiselBilgiler.MEDEN�HAL�,Calisanlar.POZ�SYON,Calisanlar.MAAS 
from KisiselBilgiler
inner join
Calisanlar
on 
KisiselBilgiler.KisiID=Calisanlar.CalisanID 
--SQL SORGULARI
*
begin transaction 
update Calisanlar set MAAS=30000
select * from Calisanlar 
rollback --kal�c� olmuyor --veri koruyor
*

create trigger guncellenmez on calisanlar
after update
as begin
if
(exists(select*from inserted,deleted where inserted.CalisanID=deleted.CalisanID and inserted.maas!=deleted.maas))
begin
raiserror('MAA� DE���T�R�LEMEZ',1,1) --('hata mesaj�n�z',error_severity,error_state) 
--1 ile 10 aras� bilg mesaj�/11 ile 16 aras� kullan�c� kaynakl� hatalar
rollback transaction
end
end
select*from Calisanlar where CalisanID=3
update Calisanlar set MAAS=1000 where CalisanID=3

*
create trigger kayitsil on kisiselbilgiler
after delete
as
begin
declare @id int
select @id =kisiID from KisiselBilgiler
delete from Calisanlar where CalisanID=@id
end
delete from KisiselBilgiler where KisiID=4 --silinemez oldu�unu g�sterdim fk pk ba�l�


