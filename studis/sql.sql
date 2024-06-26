if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[WorkTuanDui_StudentsInfo]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[WorkTuanDui_StudentsInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[WorksInfo_StudentsInfo]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[WorksInfo_StudentsInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[WorksInfo_StudentsInfo_admin]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[WorksInfo_StudentsInfo_admin]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AdminInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[AdminInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Commernts]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Commernts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NewsInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[NewsInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[StudentsInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[StudentsInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[WorkTuanDui]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[WorkTuanDui]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[WorksInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[WorksInfo]
GO

CREATE TABLE [dbo].[AdminInfo] (
	[AdminID] [int] IDENTITY (1, 1) NOT NULL ,
	[AdminName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AdminPass] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Commernts] (
	[CommerntID] [int] IDENTITY (1, 1) NOT NULL ,
	[WorkID] [int] NULL ,
	[UserID] [int] NULL ,
	[CommentContent] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[CommerntTime] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[NewsInfo] (
	[NewsID] [int] IDENTITY (1, 1) NOT NULL ,
	[NewsTitle] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[NewsCate] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[NewsContent] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[NewsTime] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[NewsAuthor] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[StudentsInfo] (
	[UserID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserSex] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserNumber] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserPass] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserXy] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserZy] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserBj] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserAddTime] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[WorkTuanDui] (
	[WorkID] [int] IDENTITY (1, 1) NOT NULL ,
	[tdmc] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID_1] [int] NULL ,
	[UserID_1_des] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID_2] [int] NULL ,
	[UserID_2_des] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID_3] [int] NULL ,
	[UserID_3_des] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkCate] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkDes] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkTime] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkUrl] [text] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[WorksInfo] (
	[WorkID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserID] [int] NULL ,
	[WorkName] [varchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkCate] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkDes] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkTime] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkUrl] [text] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.WorkTuanDui_StudentsInfo
AS
SELECT a.*, b.UserName AS UserName
FROM dbo.WorkTuanDui a INNER JOIN
      dbo.StudentsInfo b ON a.UserID_1 = b.UserID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.WorksInfo_StudentsInfo
AS
SELECT b.WorkID, b.UserID, a.UserName, b.WorkName, b.WorkCate, b.WorkDes, 
      b.WorkTime, b.WorkUrl
FROM dbo.StudentsInfo a INNER JOIN
      dbo.WorksInfo b ON a.UserID = b.UserID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.WorksInfo_StudentsInfo_admin
AS
SELECT a.*, b.UserName AS UserName
FROM dbo.WorksInfo a INNER JOIN
      dbo.StudentsInfo b ON a.UserID = b.UserID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

