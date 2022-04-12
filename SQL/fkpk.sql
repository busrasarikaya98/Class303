CREATE DATABASE KUTUPHANE
USE KUTUPHANE
CREATE TABLE Yazar(
Yazarno INT IDENTITY(1,1) NOT NULL PRIMARY KEY ,
Yazarad varchar(50),
DogumTarih date
)

CREATE TABLE Tur(
TurNo int identity(1,1) not null primary key,
TurAd varchar(50)
)

CREATE TABLE Kitap(
KitapNo int identity(1,1) not null primary key,
IsbNo varchar(50),
KitapAdi varchar(100),
YazarNo int foreign key references Yazar(YazarNo), --yazar tablosundan referans aldýk
TurNo int,
SayfaSayisi int
)
--sonradan foreign key ekleme
alter table kitap add constraint Fk_turno foreign key(turno) references tur(turno)

--tablolarda eklemeleri yaptýk
select Kitap.KitapNo,Kitap.KitapAdi,Tur.TurAd,Kitap.SayfaSayisi,Kitap.IsbNo,Yazar.Yazarno,Yazar.Yazarad,Yazar.DogumTarih from Yazar
inner join Kitap
on Kitap.YazarNo=Yazar.Yazarno
inner join Tur
on Kitap.TurNo=Tur.TurNo
