use KÝTAPLIK
--OPERATÖRLER
select * from KÝTAP where KitapAd ='KÖRLÜK' --kütüphaneden seçtiriyoruz
select * from KÝTAP where KitapYayýnEvi ='CAN' and KitapSayfa>=183 --iki þartý da saðlamak zorunda
select * from KÝTAP where KitapSayfa<=112 or KitapSayfa>=65 or KitapYazar='Paulo Coelho' --ikisinden birini saðlamasý yeterli
select * from KÝTAP where KitapSayfa in(96,182,120) --parantez içini saðlayan verileri getiriyor --birebir
select * from KÝTAP where KitapAd like '%a%' and KitapSayfa in(120) and KitapFiyat>=37 --kitabýn içinde a geçmek zorunda
select * from KÝTAP where KitapAd like 'Þ%' --kitap adý þ ile baþlamalý
select * from KÝTAP where KitapAd like '%I' --kitap adý I ile bitmeli
select * from KÝTAP where KitapYazar like '[JMS]%' --içinde jms harfleri geçenler
select * from KÝTAP where KitapYazar like '[A-G]%' --a ile g arasýndaki harfler 
select * from KÝTAP where KitapYazar like '[^A-G]%' --a ile g harfleri arsaýndaki dýþýndakiler
select * from KÝTAP where KitapAd like 'S______' --boþluk kadar karakterli olanlarý yazdýrýr boþluklar da sayýlýr
select top 4 * from KÝTAP --tablodaki ilk dort kaydi veriyor
select top 4 * from KÝTAP order by KitapNo desc --sýralamadaki ilk dort


--insert ekleme
insert into KÝTAP values(16,'ANNA KARENINA','TOLSTOY',300,48.00,'2014-05-09','CAN') --16.olarak bunu ekledik

insert into KÝTAP(KitapNo,KitapAd,KitapYazar,KitapSayfa,KitapFiyat,KitapTarih,KitapYayýnEvi) --bu þekilde de ekleyebiliriz
values(17,'BÝR ÖMÜR NASIL YAÞANIR','ÝLBER ORTAYLI',300,55,'2011-04-06','KORÝDOR')
insert into KÝTAP values(18,'X','Y',100,10,'2012-05-05','CAN')
insert into KÝTAP values(19,'OLAÐANÜSTÜ BÝR GECE','STEFAN ZWEIG',120,65,'2014-05-10','DENE')
insert into KÝTAP values (20,'LÝNMEYEN BÝR KADININ MEKTUBU','STEFAN ZWEIG',220,55,'2018-06-22','DENE')

--update
update KÝTAP set KitapTarih='2020-05-14' where KitapAd='BÝR ÖMÜR NASIL YAÞANIR'
update KÝTAP set KitapYayýnEvi='ÝÞ BANKASI' where KitapAd='DENEME'
update KÝTAP set KitapNo=16 where KitapAd='olaðanüstü bir gece'

--delete 
delete from KÝTAP where KitapNo=18 --SÝLDÝK

--tekrar eden verilerde sadece birini alýr - kaç çeþit var sorusu gibi
select distinct kitapyayýnevi from KÝTAP where KitapYazar='STEFAN ZWEIG' --stefan zweýgýn yayýnevleri 3adet 2çeþit

--alfabetik listeleme or artan denebilir
select * from KÝTAP order by KitapAd 
select * from KÝTAP order by KitapAd desc --tersten or azalan denebilir
select * from KÝTAP order by KitapFiyat desc 


--as komutu bu yerine bu
select KitapAd as 'KÝTAP ÝSMÝ' , KitapFiyat as 'KÝTAP ÜCRETÝ' from KÝTAP

select KitapAd, KitapYazar,KitapFiyat,KitapFiyat/2 as 'YENÝ FÝYAT' from KÝTAP --kitap fiyatýný yarýya indirip yeni fiyat olarak yazdýrdýk
select KitapAd, KitapYazar,KitapFiyat,KitapFiyat+10 as 'YENÝ FÝYAT' from KÝTAP --sadece yazdýklarýmýzý gösteriyor

--tarih sorgularý 
select*from KÝTAP where KitapYayýnEvi in ('CAN','KORÝDOR','SEL') and KitapTarih>='2014-01-01'order by KitapYazar desc

--between 
select * from KÝTAP where KitapFiyat between 60 and 75
