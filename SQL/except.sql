--intersect kesim alanlar� verir ortak olan verileri verdi
use K�TAPL�K
select kitapad from kitap
intersect 
select kitapadi from kitap2

--except kitap2 deki ortaklar�n� ��kar�p sadece kitap � veriyor
select kitapad from kitap
except 
select kitapadi from kitap2
--except kitaptaki ortaklar�n� ��kar�p sadece kitap2yi veriyor
select kitapadi from kitap2
except 
select kitapad from kitap

--union -union all
select KitapAd from Kitap
union 
select kitapadi from kitap2

select distinct KitapAd from K�TAP
