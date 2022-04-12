CREATE database KÝTAPLIK -- VERÝTABANI OLUÞTURDUK
use KÝTAPLIK -- hangi veritabanýnda olussun
CREATE TABLE KÝTAP( -- nesnemiz
KitapNo int,
KitapAd varchar(50),
KitapYazar varchar(30),
KitapSayfa smallint,
KitapFiyat smallmoney,
KitapTarih smalldatetime,
KitapYayýnEvi varchar(50) -- EDÝT TOP 200 ROWS KISMINDA BÝLGÝLER GÝRDÝK
)
select * from KÝTAP where KitapAd='SATRANÇ' -- GÝRDÝÐÝMÝZ BÝLGÝLERDEN BÝR KÝTABI ÝSTEDÝK EXC YAPIYORUZ AÞAÐIDA GÖSTERÝYOR
select * from KÝTAP where KitapFiyat>=30 -- fiyatý 30dan büyük olanlarý seçtik exc yaptýk
select * from KÝTAP where KitapSayfa>=200 -- sayfa sayýsý 200den büyükleri seçtikkkk
