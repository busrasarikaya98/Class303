--transaction
use KÝTAPLÝK
begin transaction --iþlem baþlar
update kitap set kitapsayfa=300 --hepsi 300 oldu
update kitap set kitapfiyat=100 --hepsi 100 oldu
select * from kitap --deðiþikliði yazdýrdý
rollback --kalýcý olmuyor --veri koruyor
select * from kitap
commit  -- deðiþiklikleri kalýcý yapýyor 

begin transaction --islem basladý
update kitap3 set KitapDil='Türkçe' --kitap3 ün dilleri türkce
commit --kalýcý yap
select *from kitap3 --yazdýr

--declare -- deðiþken tanýmlama --deðiþkenin baþýna @ --anlýk islemler
declare @ulke nvarchar(30)
set @ulke = 'TÜRKÝYE'
select @ulke as Ulke --deðiþkenin tablodaki adý as ile yazýlýr
print @ulke -- tablo olarak deðil mesaj olarak yazdýrmasý için 

declare @ulkesi nvarchar(30)
set @ulkesi = 'HOLLANDA'
declare @baskenti nvarchar(30)
set @baskenti = 'AMSTERDAM'
print @ulkesi + ' ' +  @baskenti -- tek satýra yazdý


