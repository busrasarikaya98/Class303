---DDL ve CONSTRAINT KISITLAMALAR
create database SCHOOL
use SCHOOL
create table STUDENT
(
OgrNo int not null primary key,
OgrAdi varchar(15),
OgrSoyadi varchar(20),
OgrSinif varchar(2),
OgrAdres varchar(50),
OgrIlce varchar(20) default 'Pozantý',
OgrSinav1 tinyint check(OgrSinav1>0),
OgrSinav2 int,
constraint chck check(OgrSinav2>0 and OgrSinav2<=100),
OgrKolu varchar(30),
constraint chcks check(OgrKolu='BÝLÝÞÝM' or OgrKolu='ÇEVRE' or OgrKolu='TRAFÝK' or OgrKolu='SAÐLIK') --ogrkol in(....) diyebilirdik
)

