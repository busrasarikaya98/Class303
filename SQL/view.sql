use Northwind
---view oluþturma
alter view orderlist
as
select orderID,customerID,orderDate,ShipAddress,ShipCity,ShipCountry from Orders --sadece bu bilgileri gösterdi viewda
---view çaðýrma
select*from orderlist --yazdir

--alter view
alter view orderlist
as
select
c.customerID,c.Contactname,O.orderID,o.orderdate,o.shipaddress,o.shipcity,o.shipcountry --bu bilgileri istedik
from orders as O -- o ile orders a seslendik
join customers as c --c ile customera seslendik
on c.customerID=o.customerID --iki tablodaki ayni customer idleri tek bi kere cagiriyoruz
select*from orderlist --yazdir
-------------
drop view orderlist
select*from orderlist

--sifreli view olusturma
create view orderlist
with encryption --sifreledik
as
select
c.customerID,c.Contactname,O.orderID,o.orderdate,o.shipaddress,o.shipcity,o.shipcountry --bu bilgileri istedik
from orders as O -- o ile orders a seslendik
join customers as c --c ile customera seslendik
on c.customerID=o.customerID --iki tablodaki ayni customer idleri tek bi kere cagiriyoruz
select*from orderlist 




