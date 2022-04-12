--tablo tipi de�i�kenler
--bellekte sanal tip tablo olu�turulur ve kullan�l�r

declare @musteriler table(
musteri_no int,
musteri_ad varchar(20),
musteri_soyad varchar(30),
musteri_sehir varchar(30),
medeni_durum varchar(10),
cinsiyet varchar(10)
)
insert into @musteriler values(1,'B��ra','Sar�kaya','Maras','Bekar','Kad�n')
insert into @musteriler values(2,'�isem','T�rko�lu','K�rklareli','Bekar','Kad�n')
insert into @musteriler values(3,'Mertkan','��kurt','Trabzon','Bekar','Erkek')
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
print 'Toplam:'+cast(@toplam as varchar(10)) -- cast int veriyi string yazmak icin cevirmeye yar�yor
print 'Fark:'+cast(@fark as varchar(10))
print '�arp�m:'+cast(@carpim as varchar(10))
print 'B�l�m:'+cast(@bolum as varchar(10))




