
------------------------------------------------------
create trigger yenileme
on kitap2
after insert as
begin
select 'update ger�ekle�ti'
end --buraya kadar �ek
update kitap2 set kitappuani=40 where kitapadi='momo'
select*from kitap2