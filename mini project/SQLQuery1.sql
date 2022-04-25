use bill
go


select * from [dbo].[customer]
select *from [dbo].[Product]
create  table customer
(
custId int identity(1,1),
Name varchar(25),
Gender char(1),
DoB varchar(10),
ContactNo varchar(10),
Email varchar(50),
city varchar(10)
)

insert customer values('krishna','m','27-1-1983','8787874951','akhil@gmail.com','tirupati')
insert customer values('usha','f','26-2-2004','9848452424','usha@gmail.com','tirupati')

create table Purchase(Bill_No int identity(1,1),Cust_ID int,Prod_ID int,Quantity int,Pur_Date date,Total int)
select * from Purchase 
where total =Total*Quantity
insert Purchase values(101,1,2,GETDATE(),700)
insert Purchase valueS(102,2,4,GETDATE())
drop table Purchase


