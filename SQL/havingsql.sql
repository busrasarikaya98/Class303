--HAVING
--dönen deðere koþul yazýlmak istenilirse kullanýlýr
--group by ile kullanýlýr
--where yetersiz olduðu için group by having kullanýlmaktadýr

alter table KÝTAP
add Vergi int --kitap a vergi sütunu ekledik

select kitapyayýnevi,count(kitapad) as 'KitapSayýsý',
sum(kitapfiyat) as 'TOPLAM KAZANÇ',
sum(Vergi) as 'VERGÝ BORCU',
sum(kitapfiyat)-sum(Vergi) as 'NET KAZANÇ' from KÝTAP group by KitapYayýnEvi having count(kitapad)>=2
--kitap sayýsý 2den fazla olan yayýnevlerinin vergi borçlarý ve net kazançlarý