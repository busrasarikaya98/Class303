--TRY CATCH VE @@ERROR
select*from sys.messages --hata kodlar�n� verdi neye kar��l�k geliyor

begin try
select 1/0 --i�lemi sunduk
end try
begin catch
select
ERROR_NUMBER() as Hata_no,
ERROR_SEVERITY() as Oncelik,
ERROR_LINE() as Hata_satiri,
ERROR_MESSAGE() as Hata_mesaji --0�n b�l�nemedi�ini s�yledi
end catch


begin try
drop table gazetee --olmayan bir table ad� girdik
end try
begin catch
print 'HATA OLU�TU'
print ERROR_NUMBER() 
print ERROR_MESSAGE() --b�yle bir table olmad���n� s�-�yledi
end catch

use okul
delete from dene where ad='busra'
print @@error

select*from sys.messages where message_id=245 --mesaj kodu sorgulama