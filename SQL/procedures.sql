--PROCEDURE TANIMLAMA --STORED PROCEDURE
create procedure test
as --procedure baþlar
select*from kitap where KitapSayfa>120 --kitap sayfasý 120den fazla olanlarý yazdýrdý
execute test 

--ALTER PROCEDURE AYNI ADLI PROCEDURE SORGUSU GUNCELLEME
alter procedure test  --eski procedure
as 
select*from kitap where kitapsayfa>200 --yeni sorgu
exec test

create procedure kitapbilgi --yeni procedure
as
select kitapadi,kitappuani from kitap2 k2 inner join --kitap2deki bilgiler
kitap3 k3 on 
k2.KitapAdi=k3.kitapismi --bu eslesmeyi saglayanlar
exec kitapbilgi --yazdir

--DROP PROCEDURE SILME
drop procedure kitapbilgi

--STORED PROCEDURE TABLODA KOLON ADI DEÐÝÞTÝRME
exec sp_rename 'Kisiler.Sehir','Memleket','Column' --kisiler tablosundaki sehir kolonunu memleket olarak degistir
exec sp_rename 'Kisiler.Adi','Ad','Column'

--
create procedure carpim
(@a1 int, @a2 int, @a3 int,@sonuc int output) --degiskenler atadik
as
set @sonuc=@a1*@a2*@a3 --sonuc 
print 'SONUC:' + cast(@sonuc as varchar(15)) --sonucu string yaptik
declare @m int --sonuc icin degisken tanimladik
exec carpim 5,8,7,@m output 
--
create procedure ortalama1
(@b1 float,@b2 float,@b3 float,@ort float output)
as
set @ort=((@b1+@b2+@b3)/3)
print 'ORTALAMA'+cast(@ort as varchar(10))
declare @n float
exec ortalama1 25,36,54,@n output
