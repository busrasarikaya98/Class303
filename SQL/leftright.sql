--LEFT VE RIGHT OUTER JOIN
--LEFT OUTER JOIN:1.TABLOYA G�RE ��LEM YAPAR
--2.TABLODA KAR�ILIK BULAMAZSA NULL ATAR
select*from K�TAP2 k2 left outer join K�TAP3 k3 on k2.KitapAdi=k3.Kitap�smi
--kitap2 nin tamam�n� yazd�rd� kitap3te sadece isme g�revortaklar� yazd�r�yor t�m bilgilerini veriyor
select*from K�TAP2 k2 right outer join K�TAP3 k3 on k3.Kitap�smi=k2.KitapAdi
--kitap3 �n tamam�n� yazd�r�yor kitap2nin isme g�re ortaklar�n� yazd�r�yor t�m bi�gilerini veriyor

select kitapismi,kitapdili,kitapbaskisayisi,kitaphamurtipi from K�TAP3 k3 left outer join K�TAP2 k2 on k2.KitapAdi=k3.Kitap�smi
--kitap2 bilgilerini yazd�rd�