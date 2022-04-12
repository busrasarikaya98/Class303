--TARÝH ÝÞLEMLERÝ
--1.getdate()
select getdate() --þuanki tarihi gösteriyor

--2.Datepart
use KÝTAPLIK
select DATEPART(year,getdate()) as 'YIL' --sadece yýlý aldýk
select datepart(month,getdate()) as 'AY' --tek select yazarsak AYNI satýra yazdýrýr sütunlar þeklinde-her satýra yazarsak FARKLI sütunlara yazar
select datepart(day,getdate()) as 'GÜN'  --as den sonrasý sütunun adý oluyor
select datepart(week,getdate()) as 'HAFTA'
select datepart(quarter,getdate()) as 'ÇEYREK'
select datepart(year,'2021-09-06') --yazýlan tarihin yýlýný veriyor

select*from KÝTAP where datepart(year,kitaptarih)=2020 --yayýn tarihi 2020 olan kitaplarý çektik
select*from KÝTAP where datepart(month,kitaptarih)=6 --yayýn tarihi 6. ayda olan kitaplarý çektik

--3.DateDiff ve DateAdd Fonk.
select DATEDIFF(year,'1919-05-19','2022-02-02') as 'KAÇ YIL OLDU?',
DATEDIFF(month,'2001-09-09','2022-02-02') as 'KAÇ AY OLDU?',
DATEDIFF(day,'2021-01-01','2022-02-02') as 'KAÇ GÜN OLDU?'
select DATEDIFF(year,'1923-10-29',getdate()) --bu tarihten günümüze kaç yýl geçti

select dateadd(day,15,getdate()) --günümüz tarihine 15 gün ekle

