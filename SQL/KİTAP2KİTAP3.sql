use KÝTAPLIK
create table KÝTAP2
(
KitapNo int not null, --boþ geçilmemeli
KitapAdi varchar(50),
KitapYazari varchar(30),
KitapTürü varchar(25),
)
insert into KÝTAP2 values(1,'OLAÐANÜSTÜ BÝR GECE','STEFAN ZWEIG','ROMAN')
insert into KÝTAP2 values(2,'FAHRENHEIT 451','RAY BRADBURY','DÝSTOPÝK')
insert into KÝTAP2 values(3,'MOMO','MICHEL ENDE','DÝSTOPÝK')
insert into KÝTAP2 values(4,'BENJAMIN BUTTON''IN TUHAF HÝKAYESÝ','F.SCOTT','ROMAN')
insert into KÝTAP2 values(5,'THEOYA MEKTUPLAR','VINCENT VAN GOGH','ROMAN')

create table KÝTAP3
(
KitapNo int not null, --boþ geçilmemeli
KitapAdi varchar(50),
KitapYazari varchar(30),
KitapDili varchar(10),
KitapBaskiSayisi int,
KitapHamurTipi varchar(50)
)
select KÝTAP2.KitapAdi,KÝTAP3.KitapDili from KÝTAP2,KÝTAP3 --ÝKÝ FARKLI TABLODAN SEÇÝLENLERÝ YAZDIRIYOR
select * from KÝTAP where KitapAd like '[AE]%'
select * from KÝTAP where KitapYazar like '[A-H]%'
select * from KÝTAP where  KitapAd like '[%]%'
select * from KÝTAP where KitapSayfa>=100 order by KitapSayfa
select top 3 * from KÝTAP order by KitapTarih

