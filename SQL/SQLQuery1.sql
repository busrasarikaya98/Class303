--DDL VER� TANIMLAMA
--1.CREATE
--2.ALTER
--3.DROP

--1.CREATE
--CREATE DATABASE OKUL

--2.ALTER
--use OKUL
--alter table Ogrenci 
--alter column BaslamaTarihi datetime
--alter table Ogrenci add BitisTarihi smalldatetime 
use OKUL
CREATE TABLE OGRETMEN( 
OgrtmnNo int,
OgrAd varchar(12),
OgrtmnSoyad varchar(15),
OgrtmnBilgi text
)
alter table OGRETMEN alter column OgrtmnSoyad varchar(20) --char�n� de�i�tirdik
--drop 
ALTER TABLE OGRETMEN  
DROP COLUMN OgrtmnBilgi --bu bilgiyi sildik

--TRUNCATE --TABLO ���N� BO�ALTIR
TRUNCATE TABLE OGRETMEN
--DML KOMUTLARI
--SELECT
--INSERT
--UPDATE
--DELETE

use Northwind --bu veritab�n�ndan
select * from products
select CustomerID,CompanyName from customers --bu bilgileri se�tik a�a��da yazd�