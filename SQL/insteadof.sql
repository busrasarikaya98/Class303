create trigger updatecontrol
on kitap2
after update
as
begin
update updatee set sayac=sayac+1 --edit tablosunda sayav� 1 artt�
end
update kitap2 set kitappuani=55 where kitapadi='Karamazov Karde�ler'
select*from kitap2

create trigger insteadofdeneme
on kitap2
instead of update 
as
begin
select 'Ekleme i�lemi oldu'
end
insert into kitap2(kitapadi,kitapyazari)
values('tutunamayanlar','o�uz atay')
select*from kitap2

create trigger insteadofdenemes
on kitap2
instead of 
as
begin
select 'de�i�im i�lemi oldu'
end
insert update kitap2 set kitapadi='busra' where kitappuani='55'
select*from kitap2