--AKIÞ KONTROLLERÝ
--IF ELSE
use KÝTAPLÝK
declare @adet tinyint
select @adet = count(kitapturu) from Kitap2
where kitapturu='Roman'
if(@adet<=1)
begin
print 'Yetersiz Adet Kitap:'+cast(@adet as varchar(3))
end

else if(@adet>=2 and @adet<3)
begin
print 'Orta Adet Kitap:'+cast(@adet as varchar(3))
end

else
begin
print 'Çok Sayýda Kitap:'+cast(@adet as varchar(3))
end