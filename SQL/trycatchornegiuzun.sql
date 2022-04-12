create database HEPSIBIZDE

use hepsýbýzde
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
begin transaction --beginin içinde önce trans. basladi --güvenli degisimi sagladi hata varsa tabloya ekleme yapmýyor

begin try --aradaki try basladi
begin transaction
save transaction baslangic
insert into adresler(mahalle,binano,sehir) values('Yeni Dünya Mah.','2/1','Istanbul')
set @adres_id=SCOPE_IDENTITY() --açtýðýmýz kolonun son atanma üretilme satýrýný gösterimi saðlýyor
commit
end try --aradaki try bitti
begin catch
rollback transaction baslangic --tekrar baþa dön
select 'Adres Girilirken Hata Oluþtu:'+ERROR_MESSAGE()
end catch --ara catch bitti

insert into uyeler(uyeadi,uyesoyadi,cinsiyet,adresno)values ('Mertkan','Ýþkurt','Cinsiyet:Erkek',@adres_id) --ikinci try devam
commit
end try --ikinci try bitti
begin catch --ikinci catch basladi
select*from adresler a
rollback --hatalý islem gördügünde islemi basa döndürür
select 'Üye Girilirken Hata Oluþtu:'+ERROR_MESSAGE()
select*from adresler a
end catch --ikinci catch bitti