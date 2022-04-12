--TRY CATCH VE @@ERROR
select*from sys.messages --hata kodlarýný verdi neye karþýlýk geliyor

begin try
select 1/0 --iþlemi sunduk
end try
begin catch
select
ERROR_NUMBER() as Hata_no,
ERROR_SEVERITY() as Oncelik,
ERROR_LINE() as Hata_satiri,
ERROR_MESSAGE() as Hata_mesaji --0ýn bölünemediðini söyledi
end catch


begin try
drop table gazetee --olmayan bir table adý girdik
end try
begin catch
print 'HATA OLUÞTU'
print ERROR_NUMBER() 
print ERROR_MESSAGE() --böyle bir table olmadýðýný sç-öyledi
end catch

use okul
delete from dene where ad='busra'
print @@error

select*from sys.messages where message_id=245 --mesaj kodu sorgulama