use softura
go

create table Registrationfrom
(
 
EmployeeID int identity(2001,1)constraint  pk_emp primary key(EmployeeID),
FirstName varchar(20),
LastName  varchar(20),
Gender char(7) constraint chk_Gender check(Gender in ('Male','Female')),
Date_of_birth varchar(10),
Phone_No   varchar(10),
Street varchar(25),
city varchar(20),
State varchar(20),
pincode varchar(7),
Qualification varchar(6) constraint chk_Qua check(Qualification in ('Be','B Tech','BCA','Mcom','MTech')),
Department varchar(5)   constraint chk_dep check(Department in ('CSE','ECE','EEE','Mech','Aro')),
Expenices_Details varchar(20),
Email varchar(20),
FilledDate date default getdate()
)
select *from[Registrationfrom]
insert Registrationfrom(FirstName,LastName ,Gender,Date_of_birth,Phone_No,Street,city,State,pincode,Qualification,Department,Expenices_Details,Email)
values('Pavan','Kumar','male','15-08-1999',9966252999,'Korlagunta main road','tirupati','Andhar pradesh',517501,'B Tech','cse','5years','pavankumar@gmail.com')
insert Registrationfrom(FirstName,LastName ,Gender,Date_of_birth,Phone_No,Street,city,State,pincode,Qualification,Department,Expenices_Details,Email)
values('sudhu','Akhil','male','6-04-2001',9966252989,'Ashoknagar ','vijaywada','Andhar pradesh',517501,'B Tech','cse','4years','Akhil@gmail.com')
exec sp_help [Registrationfrom]
