use K�TAPLIK
create table K�TAP2
(
KitapNo int not null, --bo� ge�ilmemeli
KitapAdi varchar(50),
KitapYazari varchar(30),
KitapT�r� varchar(25),
)
insert into K�TAP2 values(1,'OLA�AN�ST� B�R GECE','STEFAN ZWEIG','ROMAN')
insert into K�TAP2 values(2,'FAHRENHEIT 451','RAY BRADBURY','D�STOP�K')
insert into K�TAP2 values(3,'MOMO','MICHEL ENDE','D�STOP�K')
insert into K�TAP2 values(4,'BENJAMIN BUTTON''IN TUHAF H�KAYES�','F.SCOTT','ROMAN')
insert into K�TAP2 values(5,'THEOYA MEKTUPLAR','VINCENT VAN GOGH','ROMAN')

create table K�TAP3
(
KitapNo int not null, --bo� ge�ilmemeli
KitapAdi varchar(50),
KitapYazari varchar(30),
KitapDili varchar(10),
KitapBaskiSayisi int,
KitapHamurTipi varchar(50)
)
select K�TAP2.KitapAdi,K�TAP3.KitapDili from K�TAP2,K�TAP3 --�K� FARKLI TABLODAN SE��LENLER� YAZDIRIYOR
select * from K�TAP where KitapAd like '[AE]%'
select * from K�TAP where KitapYazar like '[A-H]%'
select * from K�TAP where  KitapAd like '[%]%'
select * from K�TAP where KitapSayfa>=100 order by KitapSayfa
select top 3 * from K�TAP order by KitapTarih

