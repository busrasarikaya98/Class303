--is identity
use SCHOOL
create table DENEME(
ID int not null identity(1,1) primary key, --bo� ge�mesin bir bir ge�sin biz elle yazam�yoruz kendisi yaz�yor
Ad varchar(50),
Soyad varchar(50)
)
set identity_Insert deneme on
insert deneme(ID,Ad,Soyad) values(1,'B��RA','SARIKAYA') --set ile identity veriye ekleme izni ald�k 

set identity_Insert deneme off
insert deneme(Ad,Soyad) values('M�RAYET','M�FT�O�LU') --set i kapatt�k
