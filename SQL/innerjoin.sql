select kitapadi,kitapyazari,KitapT�r� from K�TAP2 k2
inner join K�TAP3 k3 on k3.Kitapismi=k2.KitapAdi
--ortak olan kitap ad�na g�re yazar�n� ve t�r�n� yazd�rd�

select kitapadi,kitapyazari,KitapT�r� from K�TAP2 k2
inner join K�TAP3 k3 on k3.KitapNum=k2.KitapNosu
select kitapad,kitapyazar from K�TAP k
inner join K�TAP2 k2 on k.KitapNo=k2.KitapNosu
--ortak numaradaki say�lar� al�yor bunlar�n k2deki de�erlerini yazd�r�yor

select kitapadi,kitapyazari,KitapT�r�,KitapBaskiSayisi from K�TAP2 k2
inner join K�TAP3 k3 on k3.Kitap�smi=k2.KitapAdi
--kitap isimlerine g�re e�le�tirdi buna g�re bu kitab�n kitap2deki de�elerlerini yazd�rd�

select sum(kitapfiyat) as 'TOPLAM F�YAT',
t�r from K�TAP k inner join K�TAP2 k2 
on k.KitapAd=k2.KitapAdi group by t�r 
--t�rleri ayn� olanlar�n toplam fiyatlar�n� yazd�rd�



