--SENARYO
create database BUSRAYAZILIM
use BUSRAYAZILIM
create table Calisanlar(
CalisanID int primary key,
AD varchar(10),
SOYAD varchar(20),
POZÝSYON varchar(20),
MAAS int
)

create table KisiselBilgiler(
KisiID int primary key,
AD varchar(10),
SOYAD varchar(20),
CÝNSÝYET varchar(20),
YAÞ int,
MEDENÝHALÝ varchar(10),
)
select*from KisiselBilgiler
select*from Calisanlar

select KisiselBilgiler.AD,KisiselBilgiler.SOYAD,KisiselBilgiler.CÝNSÝYET,KisiselBilgiler.YAÞ,KisiselBilgiler.MEDENÝHALÝ,Calisanlar.POZÝSYON,Calisanlar.MAAS 
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
rollback --kalýcý olmuyor --veri koruyor
*

create trigger guncellenmez on calisanlar
after update
as begin
if
(exists(select*from inserted,deleted where inserted.CalisanID=deleted.CalisanID and inserted.maas!=deleted.maas))
begin
raiserror('MAAÞ DEÐÝÞTÝRÝLEMEZ',1,1) --('hata mesajýnýz',error_severity,error_state) 
--1 ile 10 arasý bilg mesajý/11 ile 16 arasý kullanýcý kaynaklý hatalar
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
delete from KisiselBilgiler where KisiID=4 --silinemez olduðunu gösterdim fk pk baðlý


