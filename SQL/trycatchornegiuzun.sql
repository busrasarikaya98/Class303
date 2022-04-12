create database HEPSIBIZDE

use heps�b�zde
create table uyeler(
uyeadi varchar(20),
uyesoyadi varchar(30),
cinsiyet varchar(5),
adresno varchar(500)
)
create table adresler(
mahalle varchar(50) not null,
binano varchar(50) not null,
sehir varchar(50)
)
----------------------
declare @adres_id int 
begin try --ikinci try basladi
begin transaction --beginin i�inde �nce trans. basladi --g�venli degisimi sagladi hata varsa tabloya ekleme yapm�yor

begin try --aradaki try basladi
begin transaction
save transaction baslangic
insert into adresler(mahalle,binano,sehir) values('Yeni D�nya Mah.','2/1','Istanbul')
set @adres_id=SCOPE_IDENTITY() --a�t���m�z kolonun son atanma �retilme sat�r�n� g�sterimi sa�l�yor
commit
end try --aradaki try bitti
begin catch
rollback transaction baslangic --tekrar ba�a d�n
select 'Adres Girilirken Hata Olu�tu:'+ERROR_MESSAGE()
end catch --ara catch bitti

insert into uyeler(uyeadi,uyesoyadi,cinsiyet,adresno)values ('Mertkan','��kurt','Cinsiyet:Erkek',@adres_id) --ikinci try devam
commit
end try --ikinci try bitti
begin catch --ikinci catch basladi
select*from adresler a
rollback --hatal� islem g�rd�g�nde islemi basa d�nd�r�r
select '�ye Girilirken Hata Olu�tu:'+ERROR_MESSAGE()
select*from adresler a
end catch --ikinci catch bitti