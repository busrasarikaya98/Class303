use K�TAPL�K
create trigger instdof
on kitap2
instead of delete
as 
begin
update kitap2 set kitapadi='Ezilenler' where kitapadi='Karamazov Karde�ler'
end
delete from kitap2 where kitapadi='karamazov karde�ler'
select*from kitap2


use K�TAPL�K
create trigger degistirelim
on kitap3
instead of update
as
begin
select 'KAYIT G�NCELLENEB�L�R'
end
update kitap3 set kitapbaskisayisi='40' where kitapismi='momo' --mesaj� g�sterdi
select*from kitap3
