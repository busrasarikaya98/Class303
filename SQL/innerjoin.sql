select kitapadi,kitapyazari,KitapTürü from KÝTAP2 k2
inner join KÝTAP3 k3 on k3.Kitapismi=k2.KitapAdi
--ortak olan kitap adýna göre yazarýný ve türünü yazdýrdý

select kitapadi,kitapyazari,KitapTürü from KÝTAP2 k2
inner join KÝTAP3 k3 on k3.KitapNum=k2.KitapNosu
select kitapad,kitapyazar from KÝTAP k
inner join KÝTAP2 k2 on k.KitapNo=k2.KitapNosu
--ortak numaradaki sayýlarý alýyor bunlarýn k2deki deðerlerini yazdýrýyor

select kitapadi,kitapyazari,KitapTürü,KitapBaskiSayisi from KÝTAP2 k2
inner join KÝTAP3 k3 on k3.KitapÝsmi=k2.KitapAdi
--kitap isimlerine göre eþleþtirdi buna göre bu kitabýn kitap2deki deðelerlerini yazdýrdý

select sum(kitapfiyat) as 'TOPLAM FÝYAT',
tür from KÝTAP k inner join KÝTAP2 k2 
on k.KitapAd=k2.KitapAdi group by tür 
--türleri ayný olanlarýn toplam fiyatlarýný yazdýrdý



