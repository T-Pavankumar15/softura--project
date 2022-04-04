----3----
use AdventureWorks2019
go

create view  Vx_dept1
as
select [DepartmentID],[Name],[GroupName]
from[HumanResources].[Department]
go

select*from [HumanResources].[Department]

insert Vx_dept1 ([Name],[GroupName])
values('prodcution','abc');

insert [HumanResources].[Department] ([Name],[GroupName])
values('pavankumar','psoftura')

select *from Vx_dept1
--------------6---------------------
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]
-------------1-------------------
select  COUNT(+[StandardCost]) Totalnoofrows
from [Production].[ProductCostHistory]
-- SUM()
select SUM([StandardCost]) SumCost
from [Production].[ProductCostHistory]
-- DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--ADDDATE()
SELECT DATEADD(year, 3, '2014/08/25') AS DateAdd
-- CONVERT()
SELECT CONVERT(int,98.53);
--USING LEFT()
SELECT LEFT('pavan', 3) AS ExtractString;
--USING LEN()
select LEN('pavankumar')
--USING REVERSE()
select REVERSE('pavan kumar')
----------------2-------------
create function fn_Rupees1(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'$'+@amount)
end
select BusinessEntityID,dbo.fn_Rupees1(rate) as Rupee
from HumanResources.EmployeePayHistory
--------------4--------------------
use softura
go
create proc sp_insert
@name varchar(20)
as
insert into Fest(sFullName)
values(@name)

 exec sp_insert'pavankumar'

 
 update  [dbo].[Fest]
 set sFullName='satya krishna' ,sfullname='pavankumar'
 where sno=104
 go
 select *from [dbo].[Fest]

 delete [dbo].[Fest]
 where sFullName='pavankumar'


 -----------7-------------
 use AdventureWorks2019
 go
 select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name
-----------5-----------
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))