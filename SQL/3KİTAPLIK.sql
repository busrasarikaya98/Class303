CREATE database K�TAPLIK -- VER�TABANI OLU�TURDUK
use K�TAPLIK -- hangi veritaban�nda olussun
CREATE TABLE K�TAP( -- nesnemiz
KitapNo int,
KitapAd varchar(50),
KitapYazar varchar(30),
KitapSayfa smallint,
KitapFiyat smallmoney,
KitapTarih smalldatetime,
KitapYay�nEvi varchar(50) -- ED�T TOP 200 ROWS KISMINDA B�LG�LER G�RD�K
)
select * from K�TAP where KitapAd='SATRAN�' -- G�RD���M�Z B�LG�LERDEN B�R K�TABI �STED�K EXC YAPIYORUZ A�A�IDA G�STER�YOR
select * from K�TAP where KitapFiyat>=30 -- fiyat� 30dan b�y�k olanlar� se�tik exc yapt�k
select * from K�TAP where KitapSayfa>=200 -- sayfa say�s� 200den b�y�kleri se�tikkkk
