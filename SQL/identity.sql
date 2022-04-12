--is identity
use SCHOOL
create table DENEME(
ID int not null identity(1,1) primary key, --boþ geçmesin bir bir geçsin biz elle yazamýyoruz kendisi yazýyor
Ad varchar(50),
Soyad varchar(50)
)
set identity_Insert deneme on
insert deneme(ID,Ad,Soyad) values(1,'BÜÞRA','SARIKAYA') --set ile identity veriye ekleme izni aldýk 

set identity_Insert deneme off
insert deneme(Ad,Soyad) values('MÝRAYET','MÜFTÜOÐLU') --set i kapattýk
