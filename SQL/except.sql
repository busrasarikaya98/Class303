--intersect kesim alanlarý verir ortak olan verileri verdi
use KÝTAPLÝK
select kitapad from kitap
intersect 
select kitapadi from kitap2

--except kitap2 deki ortaklarýný çýkarýp sadece kitap ý veriyor
select kitapad from kitap
except 
select kitapadi from kitap2
--except kitaptaki ortaklarýný çýkarýp sadece kitap2yi veriyor
select kitapadi from kitap2
except 
select kitapad from kitap

--union -union all
select KitapAd from Kitap
union 
select kitapadi from kitap2

select distinct KitapAd from KÝTAP
