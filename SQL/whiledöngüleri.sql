--while
--1den 25e kadar olan say�lar� yazd�ral�m
declare @number int
set @number=1
while(@number<=25)
begin
print @number --say�y� yaz
set @number=@number+1 --1 artt�rarak devam et
end

--12ye kadar say�lar�n karesi
declare @numbers int
set @numbers=1
while(@numbers<=12)
begin
print cast (@numbers as varchar(10)) +'in KARES�= ' +cast(@numbers*@numbers as varchar(5)) --say�n�n karesini al 
set @numbers=@numbers+1 --1 artt�rarak devam et
end

--ekrana 10 defa yaz� yazd�r
declare @yazdir int
set @yazdir=1
while(@yazdir<=10)
begin
print'G�LE G�LE SQL' --veya cast(@yazdir as varchar(20)) + n�n devam�na yaz�
set @yazdir=@yazdir+1
end

--say�lar� 40 azaltarak yazd�r
declare @sayacim int
set @sayacim=1000
while(@sayacim>=-80)
begin
print @sayacim --say�y� yaz
set @sayacim=@sayacim-40 --1 artt�rarak devam et
end

--kelimeyi alt alta harflere b�lme
declare @cumle varchar(500)='MERHABA DUNYA BEN BUSRA'
declare @karaktersayisi int=len(@cumle)
declare @sayac int=0
while(@sayac<=@karaktersayisi)
begin
print substring(@cumle,@sayac,1)
set @sayac+=1
end

