--tablo tipi deðiþkenler
--bellekte sanal tip tablo oluþturulur ve kullanýlýr

declare @musteriler table(
musteri_no int,
musteri_ad varchar(20),
musteri_soyad varchar(30),
musteri_sehir varchar(30),
medeni_durum varchar(10),
cinsiyet varchar(10)
)
insert into @musteriler values(1,'Büþra','Sarýkaya','Maras','Bekar','Kadýn')
insert into @musteriler values(2,'Çisem','Türkoðlu','Kýrklareli','Bekar','Kadýn')
insert into @musteriler values(3,'Mertkan','Ýþkurt','Trabzon','Bekar','Erkek')
select*from @musteriler

--matematiksel islemler
declare @sayi1 int,@sayi2 int,
@toplam int, @fark int, @carpim int, @bolum int
set @sayi1=144
set @sayi2=12
set @toplam=@sayi1+@sayi2
set @fark=@sayi1-@sayi2
set @carpim=@sayi1*@sayi2
set @bolum=@sayi1/@sayi2
print 'Toplam:'+cast(@toplam as varchar(10)) -- cast int veriyi string yazmak icin cevirmeye yarýyor
print 'Fark:'+cast(@fark as varchar(10))
print 'Çarpým:'+cast(@carpim as varchar(10))
print 'Bölüm:'+cast(@bolum as varchar(10))




