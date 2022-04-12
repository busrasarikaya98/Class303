create table Kisiler(
KisiNo tinyint,
Ad varchar(20),
Soyad varchar(30),
Meslek varchar(30),
Sehir varchar(15),
Maas money
)
select Meslek,count(ad) as 'Personel Sayýsý' from Kisiler group by Meslek order by meslek desc
--meslege göre kisi sayýsý çektik

select Sehir,count(ad) as 'Kiþi Sayýsý' from Kisiler group by Sehir 
--þehirlere göre kiþi sayýsý çektik

select Meslek,count(ad) 'Personel Sayýsý',
sum(maas) 'Toplam Kazanç',
avg(maas) 'Ortalama'
from kisiler group by Meslek order by Meslek
--mesleklerin kiþi sayýlarýna göre toplam kazançlarý ortalamalarý

select Meslek,max(maas) 'MAX',
min(maas) 'MÝN' from Kisiler group by Meslek 
--mesleklerin min max maas degerleri

