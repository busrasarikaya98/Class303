create table Kisiler(
KisiNo tinyint,
Ad varchar(20),
Soyad varchar(30),
Meslek varchar(30),
Sehir varchar(15),
Maas money
)
select Meslek,count(ad) as 'Personel Say�s�' from Kisiler group by Meslek order by meslek desc
--meslege g�re kisi say�s� �ektik

select Sehir,count(ad) as 'Ki�i Say�s�' from Kisiler group by Sehir 
--�ehirlere g�re ki�i say�s� �ektik

select Meslek,count(ad) 'Personel Say�s�',
sum(maas) 'Toplam Kazan�',
avg(maas) 'Ortalama'
from kisiler group by Meslek order by Meslek
--mesleklerin ki�i say�lar�na g�re toplam kazan�lar� ortalamalar�

select Meslek,max(maas) 'MAX',
min(maas) 'M�N' from Kisiler group by Meslek 
--mesleklerin min max maas degerleri

