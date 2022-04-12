--LEFT VE RIGHT OUTER JOIN
--LEFT OUTER JOIN:1.TABLOYA GÖRE ÝÞLEM YAPAR
--2.TABLODA KARÞILIK BULAMAZSA NULL ATAR
select*from KÝTAP2 k2 left outer join KÝTAP3 k3 on k2.KitapAdi=k3.KitapÝsmi
--kitap2 nin tamamýný yazdýrdý kitap3te sadece isme görevortaklarý yazdýrýyor tüm bilgilerini veriyor
select*from KÝTAP2 k2 right outer join KÝTAP3 k3 on k3.KitapÝsmi=k2.KitapAdi
--kitap3 ün tamamýný yazdýrýyor kitap2nin isme göre ortaklarýný yazdýrýyor tüm biþgilerini veriyor

select kitapismi,kitapdili,kitapbaskisayisi,kitaphamurtipi from KÝTAP3 k3 left outer join KÝTAP2 k2 on k2.KitapAdi=k3.KitapÝsmi
--kitap2 bilgilerini yazdýrdý