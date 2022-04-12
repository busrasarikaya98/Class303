--ARÝTMETÝK OPERATÖRLER VE FONKSÝYONLAR
select 15+4 as 'TOPLAM',80-29 as 'FARK',48/12 as 'BÖLÜM' --aþaðýda çýktý veriyor tabloyu kendi yapýyor
--BÝRLEÞTÝRME
select kitapad + '-' + kitapyazar as 'kitaplýk' from KÝTAP --kitap adý ve yazrýný kitaplýk tabanýndan çekerek yeni kitaplýk tablomuza yazdýrdýk
--1.SUBSTRING FONKSIYON
select substring(kitapad,1,5) as 'substring' from KÝTAP --adý parçaladýk ilk beþ karakteri getirdi
--2.LEFT
select left(kitapad,8) from KÝTAP -- soldan sekiz tanesini aldýk gerisini sildi
--3.RIGHT 
select right(kitapad,4) from KÝTAP
--4.UPPER VE LOWER
select upper(kitapad) 'BÜYÜKHARF',lower(kitapad) as'KÜÇÜK HARF' from KÝTAP --küçük ve büyük harfe çeviri tamamý
--5.LENGTH
select kitapad, len(kitapad) as 'KARAKTER SAYISI' from KÝTAP --kelimelerin karakter uzunluðunu verdi
select kitapad,len(kitapad) as 'KARAKTER SAYISI' from KÝTAP where len(kitapad)<15 --karakter uzunluðu 15ten küçük olanlar
--6.REPLACE
select kitapad,replace(kitapyazar,'fyodor dostoyevskI','f.m. dostoyevski') as 'yazar adý' from KÝTAP --anlýk deðiþimler bu yerine bu
--7.REVERSE
select reverse(kitapad) from KÝTAP --yazýlarý terse çevirdik


--SAYISAL FONKSIYONLAR
--1.ABSOLUTE MUTLAK
select abs(kitapfiyat) as 'GÜNCEL KÝTAP FÝYATLARI' from KÝTAP where KitapNo=1 --bu deðerdeki sayýyý mutlak deðere al
--2.YUVARLAMA
--a.ceiling
select ceiling(kitapfiyat) as 'FÝYAT',kitapfiyat,kitapad from KÝTAP --küsüratlarý yuvarlýyor
--b.floor asagý yuvarlama
select floor(kitapfiyat) as 'FÝYAT',kitapfiyat,kitapad from KÝTAP --küsüratlarýasagý yuvarlýyor
--c.round en yakýn tamsayýya yuvarlama
select kitapad,kitapfiyat,round(kitapfiyat,1) as 'YENÝ FÝYAT' from KÝTAP --en yakýn ondalýða yuvarlýyor
--power üs alma
select power (3,4) as 'ÜS'
--karekök alma
select sqrt (121)
--toplama
select sum(kitapfiyat) as 'TOPLAM' from KÝTAP --fiyatlarý topluyor
select sum(kitapfiyat) as 'TOPLAM' from KÝTAP where KitapFiyat>50 --50den büyük olanlarý topluyor
select kitapad,kitapfiyat from KÝTAP where KitapFiyat>=55 --fiyatý 55ten büyük olanlar kitaplar
--average
select avg(kitapfiyat) as 'ORTALAMA' from KÝTAP --kitap fiyatlarýnýn ortralamsý
--maks ve min 
select min(kitapfiyat) as 'MÝNÝMUM MÝKTAR',max(kitapfiyat) as 'MAKSÝMUM MÝKTAR' from KÝTAP --min ve maks degerler
--count 
select count(kitapad) from KÝTAP --kaç veri var

