-- case
select kitapadi, kitappuani, --bunlar� tabloda yazd�r
'DURUM'= --durum s�tunu olustur
case kitappuani --buna g�re
when 60 then '�OK BE�EN�LEN' --60 oldu�unda .. yazd�r
when 30 then 'BE�EN�LEN'
when 20 then 'BE�EN�LMEYEN'
end --durumlar� yazd�r
from Kitap2

select kitapismi, KitapBaskiSayisi, --bunlar� tabloda yazd�r
'Bask�'= --durum s�tunu olustur
case --buna g�re
when KitapBaskiSayisi>=50 then '�OK BASIM' 
when 25<KitapBaskiSayisi and KitapBaskiSayisi<49 then 'ORTA BASIM'
when KitapBaskiSayisi<=25 then 'AZ BASIM'
end --durumlar� yazd�r
from Kitap3

