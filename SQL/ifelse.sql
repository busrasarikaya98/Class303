--AKI� KONTROLLER�
--IF ELSE
use K�TAPL�K
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
print '�ok Say�da Kitap:'+cast(@adet as varchar(3))
end