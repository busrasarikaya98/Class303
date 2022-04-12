--alt sorgular
select * from kitap where
vergi=(select vergi from kitap where KitapAd='Küçük Prens') --küçük prensin vergisine eþit olan vergileri sorguladýk

select * from kitap2 where
kitappuani=(select kitappuani from Kitap2 where KitapYazari='Milan Kundera')
--parantez ici milan kunderanýn kitap puanýna esit olan puanlara sahip kitap bilgilerini yazdýrdý

select * from kitap where
KitapFiyat=(select kitappuani from kitap2 where KitapYazari='Milan Kundera')
--parantez ici milan kunderanýn kitap puanýnýn kitapta fiyatýna eþit olan bilgileri yazdýrdý

select * from kitap3 where
kitapbaskisayisi=(select kitappuani from kitap2 where KitapAdi='Momo')
--kitap2 de momonun kitap puanýnýn kitap3te kitapbaskýsayýsýna eþit olanlarýn bilgileri