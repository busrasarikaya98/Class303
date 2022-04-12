-- case
select kitapadi, kitappuani, --bunlarý tabloda yazdýr
'DURUM'= --durum sütunu olustur
case kitappuani --buna göre
when 60 then 'ÇOK BEÐENÝLEN' --60 olduðunda .. yazdýr
when 30 then 'BEÐENÝLEN'
when 20 then 'BEÐENÝLMEYEN'
end --durumlarý yazdýr
from Kitap2

select kitapismi, KitapBaskiSayisi, --bunlarý tabloda yazdýr
'Baský'= --durum sütunu olustur
case --buna göre
when KitapBaskiSayisi>=50 then 'ÇOK BASIM' 
when 25<KitapBaskiSayisi and KitapBaskiSayisi<49 then 'ORTA BASIM'
when KitapBaskiSayisi<=25 then 'AZ BASIM'
end --durumlarý yazdýr
from Kitap3

