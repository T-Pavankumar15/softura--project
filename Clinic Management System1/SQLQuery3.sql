USE [Project]
GO
/****** Object:  StoredProcedure [dbo].[getpat]    Script Date: 23-05-2022 09:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[getpat]
as
select [PatientId],[FirstName],[LastName],[Sex],[Age],CONVERT(varchar(15),format(Date_of_Birth,'d','en-IN'))as [Date_of_birth]
from [dbo].[Patient]

exec [dbo].[getpat]