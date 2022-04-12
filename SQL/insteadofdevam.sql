use KÝTAPLÝK
create trigger instdof
on kitap2
instead of delete
as 
begin
update kitap2 set kitapadi='Ezilenler' where kitapadi='Karamazov Kardeþler'
end
delete from kitap2 where kitapadi='karamazov kardeþler'
select*from kitap2


use KÝTAPLÝK
create trigger degistirelim
on kitap3
instead of update
as
begin
select 'KAYIT GÜNCELLENEBÝLÝR'
end
update kitap3 set kitapbaskisayisi='40' where kitapismi='momo' --mesajý gösterdi
select*from kitap3
