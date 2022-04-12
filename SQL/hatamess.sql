use KÝTAPLÝK
alter table kisiler add cinsiyet varchar(6)null --tabloya sütun ekleme
-------- TRIGGER OLUSTURMA -----------------
create trigger guncelle on kisiler
after update
as begin
if
(exists(select*from inserted,deleted where inserted.kisino=deleted.kisino and inserted.cinsiyet!=deleted.cinsiyet))
begin
raiserror('Cinsiyet Güncellenemez',16,1) --('hata mesajýnýz',error_severity,error_state) 
--1 ile 10 arasý bilg mesajý/11 ile 16 arasý kullanýcý kaynaklý hatalar
rollback transaction
end
end
select*from kisiler where kisino=1  
update kisiler set cinsiyet='Erkek' where kisino=1

--------------------------------------------------
--**SÝSTEM HATA MESAJLARI
use master
select*from sys.messages

---------------------------------------------------
--KULLANICI TANIMLI HATA EKLEME
use master
exec sp_addmessage
@msgnum=60001,
@severity=16,
@msgtext='INVALID PROCESS',
@lang='us_english' --ingilizce ekledik
select*from sys.messages where message_id=60001 

exec sp_addmessage
@msgnum=60001,
@severity=16,
@msgtext='Geçersiz Ýþlem',
@lang='Turkish' --türkçe ekledik
select*from sys.messages where message_id=60001 
-----
exec sp_dropmessage
@msgnum=60001

--KULLANICI TANIMLI HATAYI SÝLME
exec sp_dropmessage
@msgnum=60001,
@lang='Turkish' --sadece türkçe olaný sildik







