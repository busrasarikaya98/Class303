create trigger updatecontrol
on kitap2
after update
as
begin
update updatee set sayac=sayac+1 --edit tablosunda sayavç 1 arttı
end
update kitap2 set kitappuani=55 where kitapadi='Karamazov Kardeşler'
select*from kitap2

create trigger insteadofdeneme
on kitap2
instead of update 
as
begin
select 'Ekleme işlemi oldu'
end
insert into kitap2(kitapadi,kitapyazari)
values('tutunamayanlar','oğuz atay')
select*from kitap2

create trigger insteadofdenemes
on kitap2
instead of 
as
begin
select 'değişim işlemi oldu'
end
insert update kitap2 set kitapadi='busra' where kitappuani='55'
select*from kitap2