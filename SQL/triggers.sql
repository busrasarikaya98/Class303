--TRIGGERS TETIKLEYICILER
-- bir tabloda ger�eklesen sorgu sonucuna g�re ba�ka bir sorgunun �al��mas�n� sa�lar
--procedure den fark� kullan�c� taraf�ndan tetiklenmemesidir
--trigger 2 �ekilde �al���r:
--1.instead off ana sorguyu engeller --pasife cekip yerine tetikleyici kullanmak
--2.after for sorgular birlikte �al���r 
-- '''diyelim bir tablodan bir key sildik, diger baska tablodan da ayni keyi silmek icin kullaniriz veya ekleme'''
--instead kullanmak; diger tablodan veri silmek yerine pasife cekeriz
--after kullanmak; diger tablodan da silmek

create trigger test1
on kitap2
after insert as
begin
select 'yeni kay�t yap�ld�'
end --buraya kadar �ek
insert into kitap2 values(7,'Madam Bovary','Gustaev Flaubert','Roman','T�rk�e',85) --kay�t mesaj�n� verdi ekledi
select*from kitap2


create trigger dene1
on kitap2
after insert as
begin
select kitapadi,kitapyazari,kitappuani,kitappuan=kitappuani+10
from kitap2
where kitappuani=30
end
insert into kitap2 (kitapadi,kitapyazari,kitappuani)  values('�nsan ne ile Yasar','Tolstoy',95)
select*from kitap2

