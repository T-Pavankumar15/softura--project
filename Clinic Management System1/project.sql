USE [Project]
GO

CREATE TABLE [dbo].[Logintable](
	[username] [varchar](10) NULL,
	[firstname] [varchar](20) NULL,
	[lastname] [varchar](20) NULL,
	[Passwrd] [varchar](10) NULL
) ON [PRIMARY]
GO

ALTER proc [dbo].[inlog]
@user varchar(10),
@pass varchar(10)
as
select username from Logintable where Username like @user and Passwrd=@pass
-----------------------------------------

CREATE TABLE [dbo].[Doctor](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[Sex] [varchar](7) NULL,
	[Specialization] [varchar](25) NULL,
	[Visiting_Hours] [varchar](20) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [chk_sex] CHECK  (([Sex]='Others' OR [Sex]='Female' OR [Sex]='Male'))
GO

ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [chk_sex]
GO


ALTER proc [dbo].[addoc]
@n varchar(20),
@n1 varchar(20),
@s varchar(7),
@Spe varchar(25),
@vi varchar(20)
as
insert into Doctor(FirstName,LastName,Sex,Specialization,Visiting_Hours)
 values(@n,@n1,@s,@spe,@vi)

 ALTER proc [dbo].[getdoc]
as
select [DoctorId],[FirstName],[LastName],[Sex],[Specialization],[Visiting_Hours]
from[dbo].[Doctor]
drop table doctor
 
-------------------------------------------------------------------------------

CREATE TABLE [dbo].[Patient](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[Sex] [varchar](7) NULL,
	[Age] [int] NULL,
	[Date_of_birth] [date] NULL
) ON [PRIMARY]
GO
Drop table Patient

ALTER proc [dbo].[Addpat]
@fname varchar(20),
@lname varchar(20),
@sex varchar(7),
@dob date
as
begin
declare @age int
set @age=(select DATEDIFF(YEAR,@dob,getdate()))
insert into Patient(FirstName,LastName,Sex,Age,Date_of_Birth)
values(@fname,@lname,@sex,@age,@dob)
end

ALTER proc [dbo].[getpat]
as
select [PatientId],[FirstName],[LastName],[Sex],[Age],CONVERT(varchar(15),format(Date_of_Birth,'d','en-IN'))as [Date_of_birth]
from [dbo].[Patient]
---------------------------------------------------------------------------

CREATE TABLE [dbo].[Appointment](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[Specialization] [varchar](25) NULL,
	[Doctor] [varchar](25) NULL,
	[VisitDate] [varchar](25) NULL,
	[AppointmentTime] [varchar](20) NULL
) ON [PRIMARY]
GO

ALTER proc [dbo].[Schpro]
@sp varchar(25),
@name varchar(25),
@date varchar(25),
@t varchar(20)
as
insert into Appointment(Specialization,Doctor,VisitDate,AppointmentTime)
values(@sp,@name,@date,@t)

ALTER proc [dbo].[Delapp]
 @id int
 as 
 delete from Appointment where PatientId=@id