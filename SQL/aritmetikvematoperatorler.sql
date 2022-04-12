--AR�TMET�K OPERAT�RLER VE FONKS�YONLAR
select 15+4 as 'TOPLAM',80-29 as 'FARK',48/12 as 'B�L�M' --a�a��da ��kt� veriyor tabloyu kendi yap�yor
--B�RLE�T�RME
select kitapad + '-' + kitapyazar as 'kitapl�k' from K�TAP --kitap ad� ve yazr�n� kitapl�k taban�ndan �ekerek yeni kitapl�k tablomuza yazd�rd�k
--1.SUBSTRING FONKSIYON
select substring(kitapad,1,5) as 'substring' from K�TAP --ad� par�alad�k ilk be� karakteri getirdi
--2.LEFT
select left(kitapad,8) from K�TAP -- soldan sekiz tanesini ald�k gerisini sildi
--3.RIGHT 
select right(kitapad,4) from K�TAP
--4.UPPER VE LOWER
select upper(kitapad) 'B�Y�KHARF',lower(kitapad) as'K���K HARF' from K�TAP --k���k ve b�y�k harfe �eviri tamam�
--5.LENGTH
select kitapad, len(kitapad) as 'KARAKTER SAYISI' from K�TAP --kelimelerin karakter uzunlu�unu verdi
select kitapad,len(kitapad) as 'KARAKTER SAYISI' from K�TAP where len(kitapad)<15 --karakter uzunlu�u 15ten k���k olanlar
--6.REPLACE
select kitapad,replace(kitapyazar,'fyodor dostoyevskI','f.m. dostoyevski') as 'yazar ad�' from K�TAP --anl�k de�i�imler bu yerine bu
--7.REVERSE
select reverse(kitapad) from K�TAP --yaz�lar� terse �evirdik


--SAYISAL FONKSIYONLAR
--1.ABSOLUTE MUTLAK
select abs(kitapfiyat) as 'G�NCEL K�TAP F�YATLARI' from K�TAP where KitapNo=1 --bu de�erdeki say�y� mutlak de�ere al
--2.YUVARLAMA
--a.ceiling
select ceiling(kitapfiyat) as 'F�YAT',kitapfiyat,kitapad from K�TAP --k�s�ratlar� yuvarl�yor
--b.floor asag� yuvarlama
select floor(kitapfiyat) as 'F�YAT',kitapfiyat,kitapad from K�TAP --k�s�ratlar�asag� yuvarl�yor
--c.round en yak�n tamsay�ya yuvarlama
select kitapad,kitapfiyat,round(kitapfiyat,1) as 'YEN� F�YAT' from K�TAP --en yak�n ondal��a yuvarl�yor
--power �s alma
select power (3,4) as '�S'
--karek�k alma
select sqrt (121)
--toplama
select sum(kitapfiyat) as 'TOPLAM' from K�TAP --fiyatlar� topluyor
select sum(kitapfiyat) as 'TOPLAM' from K�TAP where KitapFiyat>50 --50den b�y�k olanlar� topluyor
select kitapad,kitapfiyat from K�TAP where KitapFiyat>=55 --fiyat� 55ten b�y�k olanlar kitaplar
--average
select avg(kitapfiyat) as 'ORTALAMA' from K�TAP --kitap fiyatlar�n�n ortralams�
--maks ve min 
select min(kitapfiyat) as 'M�N�MUM M�KTAR',max(kitapfiyat) as 'MAKS�MUM M�KTAR' from K�TAP --min ve maks degerler
--count 
select count(kitapad) from K�TAP --ka� veri var

