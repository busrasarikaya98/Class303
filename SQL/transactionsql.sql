--transaction
use K�TAPL�K
begin transaction --i�lem ba�lar
update kitap set kitapsayfa=300 --hepsi 300 oldu
update kitap set kitapfiyat=100 --hepsi 100 oldu
select * from kitap --de�i�ikli�i yazd�rd�
rollback --kal�c� olmuyor --veri koruyor
select * from kitap
commit  -- de�i�iklikleri kal�c� yap�yor 

begin transaction --islem baslad�
update kitap3 set KitapDil='T�rk�e' --kitap3 �n dilleri t�rkce
commit --kal�c� yap
select *from kitap3 --yazd�r

--declare -- de�i�ken tan�mlama --de�i�kenin ba��na @ --anl�k islemler
declare @ulke nvarchar(30)
set @ulke = 'T�RK�YE'
select @ulke as Ulke --de�i�kenin tablodaki ad� as ile yaz�l�r
print @ulke -- tablo olarak de�il mesaj olarak yazd�rmas� i�in 

declare @ulkesi nvarchar(30)
set @ulkesi = 'HOLLANDA'
declare @baskenti nvarchar(30)
set @baskenti = 'AMSTERDAM'
print @ulkesi + ' ' +  @baskenti -- tek sat�ra yazd�


