--PRIMARY KEY & FOREIGN KEY
create database SIRKET
use SIRKET
create table DEPARTMAN(
DeptID int primary key,--dept id giremedik --designda identity yes yaptýk kendisi artmasý icin
Ad varchar(50) not null,
Adres varchar(200) not null,
)
create table PERSONEL(
ID int primary key,
SiraNo varchar(50) not null, --aday anahtar--
Ad varchar(50) not null,
KayitNo varchar(50) unique, --aday anahtar--
Adres varchar(200) not null,
DeptID int foreign key references DEPARTMAN(DeptID) --BÝRLEÞTÝRME KODU
)
-- ÝKÝ TABLO BÝRLESTÝRME
select PERSONEL.ID, PERSONEL.Ad,PERSONEL.SiraNo,PERSONEL.KayitNo,
PERSONEL.Adres,DEPARTMAN.Ad from PERSONEL --PERSONEL TABLOSUNDAN BUNLAR GELSÝN
inner join
DEPARTMAN
on 
PERSONEL.DeptID=DEPARTMAN.DeptID --DEPT IDLERI ESIT OLANLAR ESITLENSIN