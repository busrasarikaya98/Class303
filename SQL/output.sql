--OUTPUT 
--birden fazla deðer döndürmek için kullanýyoruz!!
--return, tek deðer döner ikisi arasýnda fark budur!!
use OKUL
declare @neww table(
adi varchar(15),
soyadi varchar(30),
medenidurum bit
)
insert into Dene
output inserted.Ad , inserted.Soyad, inserted.medenidurum --ekleme komutlarý
into @neww 
values('Halil','Sezai',0) --sanal tablo oluþturduk --buradan tabloya bilgi ekledik
select*from @neww --kalýcý oldu

------------------------------------------------------
declare @clear table(
adi varchar(15),
soyadi varchar(30),
medenidurumu bit
)
delete from dene
output deleted.ad,deleted.soyad,deleted.medenidurum --silme komutlarý
into @clear 
where ad='halil'
select*from @clear
select*from dene --tablodan teoman isimli satýrý sildik

