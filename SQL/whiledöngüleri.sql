--while
--1den 25e kadar olan sayýlarý yazdýralým
declare @number int
set @number=1
while(@number<=25)
begin
print @number --sayýyý yaz
set @number=@number+1 --1 arttýrarak devam et
end

--12ye kadar sayýlarýn karesi
declare @numbers int
set @numbers=1
while(@numbers<=12)
begin
print cast (@numbers as varchar(10)) +'in KARESÝ= ' +cast(@numbers*@numbers as varchar(5)) --sayýnýn karesini al 
set @numbers=@numbers+1 --1 arttýrarak devam et
end

--ekrana 10 defa yazý yazdýr
declare @yazdir int
set @yazdir=1
while(@yazdir<=10)
begin
print'GÜLE GÜLE SQL' --veya cast(@yazdir as varchar(20)) + nýn devamýna yazý
set @yazdir=@yazdir+1
end

--sayýlarý 40 azaltarak yazdýr
declare @sayacim int
set @sayacim=1000
while(@sayacim>=-80)
begin
print @sayacim --sayýyý yaz
set @sayacim=@sayacim-40 --1 arttýrarak devam et
end

--kelimeyi alt alta harflere bölme
declare @cumle varchar(500)='MERHABA DUNYA BEN BUSRA'
declare @karaktersayisi int=len(@cumle)
declare @sayac int=0
while(@sayac<=@karaktersayisi)
begin
print substring(@cumle,@sayac,1)
set @sayac+=1
end

