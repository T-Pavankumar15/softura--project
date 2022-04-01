use AdventureWorks2019
go
-------------------------task1----
select FirstName,LastName,Title
from Person.Person
where Title is not null
---task2----------------------------------------------------------------
select FirstName,LastName
from Person.Person
where FirstName like '%a'and LastName like '%a'
--------------------task4----------------------------------------
create view vx_HR_dept
as
select [DepartmentID],[Name],[GroupName],[ModifiedDate]
from [HumanResources].[Department]
go
select *from vx_HR_dept

--task3----------------------------------------------------------------
select [CurrencyCode],name
from [Sales].[Currency]
where  =(select [CurrencyCode]
from [Sales].[CountryRegionCurrency])
-----task5-------------------------------------------------------------------
create table task
(
Sno int identity(1,1)  ,
firstname varchar(20),
lastname varchar(20),
phoneno varchar(10),
email varchar(20)
constraint pk_enrol primary key(Sno) 
)
insert task values('pavan','kumar',9966252999,'pavankumar@gmail.com')
go
create proc sp_instask
@firstname varchar(20)
as
insert into task(firstname)
values(@firstname)
exec sp_instask 'yuvaraj'
 exec sp_instask 'charan'
 exec sp_instask 'hara'
 exec sp_instask 'ram'
 exec sp_instask 'krishna'
 exec sp_instask 'staya'
select *from task 
update  task set lastname='kumar',phoneno =1237450000,email='123456@gmail.com'
where Sno=2
update  task set lastname='kumar',phoneno =1237450000,email='123@gmail.com'where Sno=3
-------task6---------------------------------------------------------------------------------------------------------------
select emp.BusinessEntityID,[AddressID]
from [HumanResources].[Department] dep
join [HumanResources].[EmployeeDepartmentHistory] emp
on dep.[DepartmentID]=emp.DepartmentID
join [Person].[BusinessEntityAddress] bus
on bus.BusinessEntityID=emp.BusinessEntityID

 ------task11---------------------------------------------------------------------------------
select  max([TaxRate]) max_taxrate
from [Sales].[SalesTaxRate]
-------task7------------------------------------------------------------------
select distinct [GroupName]
from [HumanResources].[Department]
-----------task-8-------------------------------------------------------------
select [DocumentNode],pro.[StandardCost]
from [Production].[Document] doc
cross join [Production].[ProductCostHistory] prohis
join [Production].[Product] pro
on pro.[ProductID]=prohis.ProductID
-----------task16---------------------------------------------------------------
select FirstName,MiddleName,Title,dhis.BusinessEntityID
from Person.BusinessEntityAddress dhis
left outer join Person.Person pp
on pp.BusinessEntityID=dhis.BusinessEntityID
where title is not null
--------------task19------------------------------------------------------
select [AddressID],[AddressLine1],[AddressLine2],adde.[StateProvinceID],[StateProvinceCode],[CountryRegionCode]
from [Person].[Address] adde
join [Person].[StateProvince] sta
on adde.[StateProvinceID]=sta.[StateProvinceID]
--------------task17--------------------------------------------------
select [ProductID],[LocationID],[Shelf] 
from[Production].[ProductInventory]
where ProductID>300 and ProductID <350 and Shelf like '%e'
-----------------task9--------------------------------------------------
select datediff (YY,StartDate,EndDate) as YOA
from HumanResources.EmployeeDepartmentHistory
------------------task14------------------------------------
SELECT count(*) no_of_row_hs
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]
-----------------task12-----------------------------------------------------
select hd.BusinessEntityID,dept.DepartmentID,ShiftID,He.BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age
from HumanResources.Employee He
join HumanResources.EmployeeDepartmentHistory hd
on he.BusinessEntityID=hd.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=hd.DepartmentID

-------------------task13------------------------------------------------------
create view vx_name_age
as
select hd.BusinessEntityID,dept.DepartmentID,ShiftID,He.BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age
from HumanResources.Employee He
join HumanResources.EmployeeDepartmentHistory hd
on he.BusinessEntityID=hd.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=hd.DepartmentID
go
select*from vx_name_age
---------------------task18------------------------------------------------------------------------
select pro.[LocationID],[Shelf],[Name]
from [Production].[Location] pro
join [Production].[ProductInventory] proin
on pro.LocationID=proin.LocationID
---------------------task10------------------------------------------------
select sum(SalesQuota)
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota
--------------------task15-------------------------------------
select max(rate) as MaxSalary,Name
from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis
on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
GRoup By name
----------------------task20-----------------------------------
select sum([SubTotal]),sum([TaxAmt])
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]