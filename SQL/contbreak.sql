--CONTINUE
declare @sayi int
set @sayi=1
while(@sayi<=12) --d�ng� �art�

begin --ba�lat

if(@sayi=6) --say� 6ya geldi�inde
begin --ba�lat
set @sayi+=1 --say�y� 1 atla yazd�rma
continue
end 

print cast(@sayi as varchar(10))+'-->Karesi:' +cast(@sayi*@sayi as varchar(5)) --say�lar�n karesini yazd�r
set @sayi+=1 --say�y� 1 artt�r
end --bitir


--CONTINUE ORNEK
declare @ssayac int=0
while @ssayac<12 --saya� 12den k���k
begin
set @ssayac+=1
if @ssayac=7 --7ye geldi�inde dur yazd�rma
continue
if @ssayac=9 --9 a geldi�inde b�rak
break
print @ssayac --saya�lar� yazd�r
end


--GOTO
declare @sayac tinyint
set @sayac=1"
d�n:
print 'SAYA�:'+cast(@sayac as varchar(2))
set @sayac+=1
while (@sayac<=8)
goto d�n


