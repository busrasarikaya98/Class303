--HAVING
--d�nen de�ere ko�ul yaz�lmak istenilirse kullan�l�r
--group by ile kullan�l�r
--where yetersiz oldu�u i�in group by having kullan�lmaktad�r

alter table K�TAP
add Vergi int --kitap a vergi s�tunu ekledik

select kitapyay�nevi,count(kitapad) as 'KitapSay�s�',
sum(kitapfiyat) as 'TOPLAM KAZAN�',
sum(Vergi) as 'VERG� BORCU',
sum(kitapfiyat)-sum(Vergi) as 'NET KAZAN�' from K�TAP group by KitapYay�nEvi having count(kitapad)>=2
--kitap say�s� 2den fazla olan yay�nevlerinin vergi bor�lar� ve net kazan�lar�