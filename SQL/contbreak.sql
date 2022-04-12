--CONTINUE
declare @sayi int
set @sayi=1
while(@sayi<=12) --döngü þartý

begin --baþlat

if(@sayi=6) --sayý 6ya geldiðinde
begin --baþlat
set @sayi+=1 --sayýyý 1 atla yazdýrma
continue
end 

print cast(@sayi as varchar(10))+'-->Karesi:' +cast(@sayi*@sayi as varchar(5)) --sayýlarýn karesini yazdýr
set @sayi+=1 --sayýyý 1 arttýr
end --bitir


--CONTINUE ORNEK
declare @ssayac int=0
while @ssayac<12 --sayaç 12den küçük
begin
set @ssayac+=1
if @ssayac=7 --7ye geldiðinde dur yazdýrma
continue
if @ssayac=9 --9 a geldiðinde býrak
break
print @ssayac --sayaçlarý yazdýr
end


--GOTO
declare @sayac tinyint
set @sayac=1"
dön:
print 'SAYAÇ:'+cast(@sayac as varchar(2))
set @sayac+=1
while (@sayac<=8)
goto dön


