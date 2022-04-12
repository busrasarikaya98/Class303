--TAR�H ��LEMLER�
--1.getdate()
select getdate() --�uanki tarihi g�steriyor

--2.Datepart
use K�TAPLIK
select DATEPART(year,getdate()) as 'YIL' --sadece y�l� ald�k
select datepart(month,getdate()) as 'AY' --tek select yazarsak AYNI sat�ra yazd�r�r s�tunlar �eklinde-her sat�ra yazarsak FARKLI s�tunlara yazar
select datepart(day,getdate()) as 'G�N'  --as den sonras� s�tunun ad� oluyor
select datepart(week,getdate()) as 'HAFTA'
select datepart(quarter,getdate()) as '�EYREK'
select datepart(year,'2021-09-06') --yaz�lan tarihin y�l�n� veriyor

select*from K�TAP where datepart(year,kitaptarih)=2020 --yay�n tarihi 2020 olan kitaplar� �ektik
select*from K�TAP where datepart(month,kitaptarih)=6 --yay�n tarihi 6. ayda olan kitaplar� �ektik

--3.DateDiff ve DateAdd Fonk.
select DATEDIFF(year,'1919-05-19','2022-02-02') as 'KA� YIL OLDU?',
DATEDIFF(month,'2001-09-09','2022-02-02') as 'KA� AY OLDU?',
DATEDIFF(day,'2021-01-01','2022-02-02') as 'KA� G�N OLDU?'
select DATEDIFF(year,'1923-10-29',getdate()) --bu tarihten g�n�m�ze ka� y�l ge�ti

select dateadd(day,15,getdate()) --g�n�m�z tarihine 15 g�n ekle

