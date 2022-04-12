--TRIGGERS TETIKLEYICILER
-- bir tabloda gerçeklesen sorgu sonucuna göre baþka bir sorgunun çalýþmasýný saðlar
--procedure den farký kullanýcý tarafýndan tetiklenmemesidir
--trigger 2 þekilde çalýþýr:
--1.instead off ana sorguyu engeller --pasife cekip yerine tetikleyici kullanmak
--2.after for sorgular birlikte çalýþýr 
-- '''diyelim bir tablodan bir key sildik, diger baska tablodan da ayni keyi silmek icin kullaniriz veya ekleme'''
--instead kullanmak; diger tablodan veri silmek yerine pasife cekeriz
--after kullanmak; diger tablodan da silmek

create trigger test1
on kitap2
after insert as
begin
select 'yeni kayýt yapýldý'
end --buraya kadar çek
insert into kitap2 values(7,'Madam Bovary','Gustaev Flaubert','Roman','Türkçe',85) --kayýt mesajýný verdi ekledi
select*from kitap2


create trigger dene1
on kitap2
after insert as
begin
select kitapadi,kitapyazari,kitappuani,kitappuan=kitappuani+10
from kitap2
where kitappuani=30
end
insert into kitap2 (kitapadi,kitapyazari,kitappuani)  values('Ýnsan ne ile Yasar','Tolstoy',95)
select*from kitap2

