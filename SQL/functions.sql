--**FUNCTIONS
--**KULLANICI TANIMLI FONKSÝYONLAR
--1.SCALAR FONKSÝYONLAR
--return geriye tek deðer döndürür
--returns birden fazla deðer döndürmek için kullanýlýr

-- kelimeleri büyük harf yapma
create function buyukharf(@gelendeger varchar(15)) --büyük harf metodu calýstýrdýk
returns varchar(15)
as
begin
return upper(@gelendeger) --büyük yaptý
end --burada calýstýr
select dbo.buyukharf(kitaptür) from kitap --ayrý calýstýr --hangileri büyük olacak

--parametre olarak dýþardan veri gönderme
create function kayitsayisi(@kitaptur varchar(15)) --kayit sayisi adli parametre olusturduk
returns int
as
begin 
declare @sayi int
select @sayi = count(kitapturu) from kitap2 where kitapturu=@kitaptur --kitap turune gore sayma olusturduk
return @sayi
end --buradan cek
select dbo.kayitsayisi('roman') as 'adet'--bunu ayrý cek roman olanlarýn sayýsý

--table functions
create function kitappuan(@gelenpuan int) --kitappuan adli parametre
returns table
as
return(select*from kitap2 where kitappuani>@gelenpuan) --kittappuanina gore karsilastirma

select kitapadi,kitapyazari from dbo.kitappuan(30) --gelen puan 30, kitap adi ve yazarini versin

