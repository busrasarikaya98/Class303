use K�TAPLIK
--OPERAT�RLER
select * from K�TAP where KitapAd ='K�RL�K' --k�t�phaneden se�tiriyoruz
select * from K�TAP where KitapYay�nEvi ='CAN' and KitapSayfa>=183 --iki �art� da sa�lamak zorunda
select * from K�TAP where KitapSayfa<=112 or KitapSayfa>=65 or KitapYazar='Paulo Coelho' --ikisinden birini sa�lamas� yeterli
select * from K�TAP where KitapSayfa in(96,182,120) --parantez i�ini sa�layan verileri getiriyor --birebir
select * from K�TAP where KitapAd like '%a%' and KitapSayfa in(120) and KitapFiyat>=37 --kitab�n i�inde a ge�mek zorunda
select * from K�TAP where KitapAd like '�%' --kitap ad� � ile ba�lamal�
select * from K�TAP where KitapAd like '%I' --kitap ad� I ile bitmeli
select * from K�TAP where KitapYazar like '[JMS]%' --i�inde jms harfleri ge�enler
select * from K�TAP where KitapYazar like '[A-G]%' --a ile g aras�ndaki harfler 
select * from K�TAP where KitapYazar like '[^A-G]%' --a ile g harfleri arsa�ndaki d���ndakiler
select * from K�TAP where KitapAd like 'S______' --bo�luk kadar karakterli olanlar� yazd�r�r bo�luklar da say�l�r
select top 4 * from K�TAP --tablodaki ilk dort kaydi veriyor
select top 4 * from K�TAP order by KitapNo desc --s�ralamadaki ilk dort


--insert ekleme
insert into K�TAP values(16,'ANNA KARENINA','TOLSTOY',300,48.00,'2014-05-09','CAN') --16.olarak bunu ekledik

insert into K�TAP(KitapNo,KitapAd,KitapYazar,KitapSayfa,KitapFiyat,KitapTarih,KitapYay�nEvi) --bu �ekilde de ekleyebiliriz
values(17,'B�R �M�R NASIL YA�ANIR','�LBER ORTAYLI',300,55,'2011-04-06','KOR�DOR')
insert into K�TAP values(18,'X','Y',100,10,'2012-05-05','CAN')
insert into K�TAP values(19,'OLA�AN�ST� B�R GECE','STEFAN ZWEIG',120,65,'2014-05-10','DENE')
insert into K�TAP values (20,'L�NMEYEN B�R KADININ MEKTUBU','STEFAN ZWEIG',220,55,'2018-06-22','DENE')

--update
update K�TAP set KitapTarih='2020-05-14' where KitapAd='B�R �M�R NASIL YA�ANIR'
update K�TAP set KitapYay�nEvi='�� BANKASI' where KitapAd='DENEME'
update K�TAP set KitapNo=16 where KitapAd='ola�an�st� bir gece'

--delete 
delete from K�TAP where KitapNo=18 --S�LD�K

--tekrar eden verilerde sadece birini al�r - ka� �e�it var sorusu gibi
select distinct kitapyay�nevi from K�TAP where KitapYazar='STEFAN ZWEIG' --stefan zwe�g�n yay�nevleri 3adet 2�e�it

--alfabetik listeleme or artan denebilir
select * from K�TAP order by KitapAd 
select * from K�TAP order by KitapAd desc --tersten or azalan denebilir
select * from K�TAP order by KitapFiyat desc 


--as komutu bu yerine bu
select KitapAd as 'K�TAP �SM�' , KitapFiyat as 'K�TAP �CRET�' from K�TAP

select KitapAd, KitapYazar,KitapFiyat,KitapFiyat/2 as 'YEN� F�YAT' from K�TAP --kitap fiyat�n� yar�ya indirip yeni fiyat olarak yazd�rd�k
select KitapAd, KitapYazar,KitapFiyat,KitapFiyat+10 as 'YEN� F�YAT' from K�TAP --sadece yazd�klar�m�z� g�steriyor

--tarih sorgular� 
select*from K�TAP where KitapYay�nEvi in ('CAN','KOR�DOR','SEL') and KitapTarih>='2014-01-01'order by KitapYazar desc

--between 
select * from K�TAP where KitapFiyat between 60 and 75
