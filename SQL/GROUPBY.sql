--GROUP BY
use K�TAPLIK
select kitapyazar,count(kitapad) as 'K�TAPSAYISI' from Kitap group by kitapyazar order by kitapsay�s�
--yazarlar� kitap say�lar�na g�re gruplad�k her yazar�n ka� kitab� var

select kitapad,count(kitapad) as 'KA� TANE BU K�TAPTAN VAR' from K�TAP group by KitapAd
--kitap ad�na g�re bu kaitaptan ka� kez girilmi�

select kitapyay�nevi,count(kitapad) as 'KA� ADET BASMI�' from K�TAP group by KitapYay�nEvi
--yay�nevi ka� adet kitap basm��

select kitapyay�nevi,sum(kitapfiyat) as 'TOPLAM KAZAN�' from K�TAP group by KitapYay�nEvi
--yay�nevleri kitap basmaktan ne kadar kazan� sa�lam��

select kitapyay�nevi,avg(kitapfiyat) as 'ORTALAMA KAZAN�' from K�TAP group by KitapYay�nEvi
--yay�nevinin kitap ba��na ortalama kazanc�

select kitapyay�nevi,max(kitapfiyat) as 'MAX F�YAT',
min(kitapfiyat) as 'M�N F�YAT' from kitap group by KitapYay�nEvi --ayn� sat�rda veriyor
--yay�nevinin kitaplar�n�n max ve min fiyat� 

select KitapYay�nEvi,count(KitapFiyat) as 'F�YATI 30DAN Y�KSEK OLANLAR' from K�TAP 
where KitapFiyat>=30 group by KitapYay�nEvi --COUNT ��� �NEML� DE��L 
--fiyat� 30dan y�ksek olan ka� kitap var ilgili yay�nevinde
