use K�TAPL�K
create procedure cek1
as
select*from kisiler where Meslek='bilgisayar m�hendisi'
execute cek1
--
create procedure kisilerim(@meslek varchar(30))
as
select * from kisiler where meslek=@meslek
exec kisilerim 'bilgisayar m�hendisi'

select value from STRING_SPLIT('bu sql bitmeli',' ')

create procedure carpimyap
(@sayi1 int, @sayi2 int,@sonuc int output) --degiskenler atadik
as
set @sonuc=@sayi1*@sayi2 --sonuc 
print 'SONUC:' + cast(@sonuc as varchar(15)) --sonucu string yaptik --buraya kadar cek
declare @m int --sonuc icin degisken tanimladik 
exec carpimyap 55,81,@m output --sonra kalan k�s�m decalre ve exec