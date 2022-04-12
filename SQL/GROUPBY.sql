--GROUP BY
use KÝTAPLIK
select kitapyazar,count(kitapad) as 'KÝTAPSAYISI' from Kitap group by kitapyazar order by kitapsayýsý
--yazarlarý kitap sayýlarýna göre grupladýk her yazarýn kaç kitabý var

select kitapad,count(kitapad) as 'KAÇ TANE BU KÝTAPTAN VAR' from KÝTAP group by KitapAd
--kitap adýna göre bu kaitaptan kaç kez girilmiþ

select kitapyayýnevi,count(kitapad) as 'KAÇ ADET BASMIÞ' from KÝTAP group by KitapYayýnEvi
--yayýnevi kaç adet kitap basmýþ

select kitapyayýnevi,sum(kitapfiyat) as 'TOPLAM KAZANÇ' from KÝTAP group by KitapYayýnEvi
--yayýnevleri kitap basmaktan ne kadar kazanç saðlamýþ

select kitapyayýnevi,avg(kitapfiyat) as 'ORTALAMA KAZANÇ' from KÝTAP group by KitapYayýnEvi
--yayýnevinin kitap baþýna ortalama kazancý

select kitapyayýnevi,max(kitapfiyat) as 'MAX FÝYAT',
min(kitapfiyat) as 'MÝN FÝYAT' from kitap group by KitapYayýnEvi --ayný satýrda veriyor
--yayýnevinin kitaplarýnýn max ve min fiyatý 

select KitapYayýnEvi,count(KitapFiyat) as 'FÝYATI 30DAN YÜKSEK OLANLAR' from KÝTAP 
where KitapFiyat>=30 group by KitapYayýnEvi --COUNT ÝÇÝ ÖNEMLÝ DEÐÝL 
--fiyatý 30dan yüksek olan kaç kitap var ilgili yayýnevinde
