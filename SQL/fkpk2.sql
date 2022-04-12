--PRIMARY KEY & FOREIGN KEY
create database SIRKET
use SIRKET
create table DEPARTMAN(
DeptID int primary key,--dept id giremedik --designda identity yes yapt�k kendisi artmas� icin
Ad varchar(50) not null,
Adres varchar(200) not null,
)
create table PERSONEL(
ID int primary key,
SiraNo varchar(50) not null, --aday anahtar--
Ad varchar(50) not null,
KayitNo varchar(50) unique, --aday anahtar--
Adres varchar(200) not null,
DeptID int foreign key references DEPARTMAN(DeptID) --B�RLE�T�RME KODU
)
-- �K� TABLO B�RLEST�RME
select PERSONEL.ID, PERSONEL.Ad,PERSONEL.SiraNo,PERSONEL.KayitNo,
PERSONEL.Adres,DEPARTMAN.Ad from PERSONEL --PERSONEL TABLOSUNDAN BUNLAR GELS�N
inner join
DEPARTMAN
on 
PERSONEL.DeptID=DEPARTMAN.DeptID --DEPT IDLERI ESIT OLANLAR ESITLENSIN