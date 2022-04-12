
----------3---------------------
create function faktoriyel
(@sayim int)
returns bigint
as
begin
declare @i int=1;
while @sayim >1
begin 
set @i = @sayim*@i;
set @sayim=@sayim-1;
end
return @i;
end
select dbo.faktoriyel(7)

-------5-------------------
use KÝTAPLÝK
select top 1 *from kisiler order by newID()

--------- 8----------------
use SCHOOL
create function kolonbirlestir(@kelime1 varchar(20),@kelime2 varchar(20)) 
returns varchar(50)
as
begin
return rtrim(@kelime1)+space(1)+rtrim(@kelime2) 
end
select dbo.kolonbirlestir(OgrAdi,OgrSoyadi) from Student 

------------10---------
create function mailyazdir(@kullanici varchar(20),@mail varchar(20))
returns varchar(50)
as
begin
return (@kullanici)+'@'+(@mail)
end
select dbo.mailyazdir('büþra','hotmail.com')

-----------
create procedure carpim
(@a1 int, @a2 int, @a3 int,@sonuc int output) --degiskenler atadik
as
set @sonuc=@a1*@a2*@a3 --sonuc 
print 'SONUC:' + cast(@sonuc as varchar(15)) --sonucu string yaptik --buraya kadar cek
declare @m int --sonuc icin degisken tanimladik 
exec carpim 5,8,7,@m output --sonra kalan kýsým decalre ve exec

