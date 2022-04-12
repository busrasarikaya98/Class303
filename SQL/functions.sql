--**FUNCTIONS
--**KULLANICI TANIMLI FONKS�YONLAR
--1.SCALAR FONKS�YONLAR
--return geriye tek de�er d�nd�r�r
--returns birden fazla de�er d�nd�rmek i�in kullan�l�r

-- kelimeleri b�y�k harf yapma
create function buyukharf(@gelendeger varchar(15)) --b�y�k harf metodu cal�st�rd�k
returns varchar(15)
as
begin
return upper(@gelendeger) --b�y�k yapt�
end --burada cal�st�r
select dbo.buyukharf(kitapt�r) from kitap --ayr� cal�st�r --hangileri b�y�k olacak

--parametre olarak d��ardan veri g�nderme
create function kayitsayisi(@kitaptur varchar(15)) --kayit sayisi adli parametre olusturduk
returns int
as
begin 
declare @sayi int
select @sayi = count(kitapturu) from kitap2 where kitapturu=@kitaptur --kitap turune gore sayma olusturduk
return @sayi
end --buradan cek
select dbo.kayitsayisi('roman') as 'adet'--bunu ayr� cek roman olanlar�n say�s�

--table functions
create function kitappuan(@gelenpuan int) --kitappuan adli parametre
returns table
as
return(select*from kitap2 where kitappuani>@gelenpuan) --kittappuanina gore karsilastirma

select kitapadi,kitapyazari from dbo.kitappuan(30) --gelen puan 30, kitap adi ve yazarini versin

