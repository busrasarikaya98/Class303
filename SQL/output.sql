--OUTPUT 
--birden fazla de�er d�nd�rmek i�in kullan�yoruz!!
--return, tek de�er d�ner ikisi aras�nda fark budur!!
use OKUL
declare @neww table(
adi varchar(15),
soyadi varchar(30),
medenidurum bit
)
insert into Dene
output inserted.Ad , inserted.Soyad, inserted.medenidurum --ekleme komutlar�
into @neww 
values('Halil','Sezai',0) --sanal tablo olu�turduk --buradan tabloya bilgi ekledik
select*from @neww --kal�c� oldu

------------------------------------------------------
declare @clear table(
adi varchar(15),
soyadi varchar(30),
medenidurumu bit
)
delete from dene
output deleted.ad,deleted.soyad,deleted.medenidurum --silme komutlar�
into @clear 
where ad='halil'
select*from @clear
select*from dene --tablodan teoman isimli sat�r� sildik

