--alt sorgular
select * from kitap where
vergi=(select vergi from kitap where KitapAd='K���k Prens') --k���k prensin vergisine e�it olan vergileri sorgulad�k

select * from kitap2 where
kitappuani=(select kitappuani from Kitap2 where KitapYazari='Milan Kundera')
--parantez ici milan kunderan�n kitap puan�na esit olan puanlara sahip kitap bilgilerini yazd�rd�

select * from kitap where
KitapFiyat=(select kitappuani from kitap2 where KitapYazari='Milan Kundera')
--parantez ici milan kunderan�n kitap puan�n�n kitapta fiyat�na e�it olan bilgileri yazd�rd�

select * from kitap3 where
kitapbaskisayisi=(select kitappuani from kitap2 where KitapAdi='Momo')
--kitap2 de momonun kitap puan�n�n kitap3te kitapbask�say�s�na e�it olanlar�n bilgileri