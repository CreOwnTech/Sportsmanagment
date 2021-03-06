USE [master]
GO
/****** Object:  Database [DB_sportmanagement]    Script Date: 5/2/2019 2:55:50 PM ******/
CREATE DATABASE [DB_sportmanagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_sportmanagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_sportmanagement.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_sportmanagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_sportmanagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_sportmanagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_sportmanagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_sportmanagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_sportmanagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_sportmanagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_sportmanagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_sportmanagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_sportmanagement] SET  MULTI_USER 
GO
ALTER DATABASE [DB_sportmanagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_sportmanagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_sportmanagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_sportmanagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_sportmanagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DB_sportmanagement]
GO
/****** Object:  Table [dbo].[tbl_NewTest]    Script Date: 5/2/2019 2:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NewTest](
	[NewTest_Id] [int] IDENTITY(1,1) NOT NULL,
	[NewTest_Date] [date] NULL,
	[NewTest_Type] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tbl_NewTest] PRIMARY KEY CLUSTERED 
(
	[NewTest_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Role]    Script Date: 5/2/2019 2:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Role](
	[Role_Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tbl_Role] PRIMARY KEY CLUSTERED 
(
	[Role_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Test]    Script Date: 5/2/2019 2:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Test](
	[Test_Id] [int] IDENTITY(1,1) NOT NULL,
	[Test_Name] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tbl_Test] PRIMARY KEY CLUSTERED 
(
	[Test_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_TestDetails]    Script Date: 5/2/2019 2:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TestDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ranking] [nvarchar](50) NULL,
	[Distance] [numeric](18, 0) NULL,
	[IsActive] [bit] NULL,
	[NewTest_Id] [int] NULL,
 CONSTRAINT [PK_tbl_TestDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Users]    Script Date: 5/2/2019 2:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Users](
	[Users_Id] [int] IDENTITY(1,1) NOT NULL,
	[Users_Name] [nvarchar](50) NULL,
	[Users_RoleID] [int] NULL,
	[IsActive] [bit] NULL,
	[Passowrd] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Users] PRIMARY KEY CLUSTERED 
(
	[Users_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_NewTest] ON 

INSERT [dbo].[tbl_NewTest] ([NewTest_Id], [NewTest_Date], [NewTest_Type], [IsActive]) VALUES (1, CAST(N'2019-05-02' AS Date), 1, 1)
SET IDENTITY_INSERT [dbo].[tbl_NewTest] OFF
SET IDENTITY_INSERT [dbo].[tbl_Role] ON 

INSERT [dbo].[tbl_Role] ([Role_Id], [Role], [IsActive]) VALUES (1, N'Coach', 1)
INSERT [dbo].[tbl_Role] ([Role_Id], [Role], [IsActive]) VALUES (2, N'Athlete', 1)
SET IDENTITY_INSERT [dbo].[tbl_Role] OFF
SET IDENTITY_INSERT [dbo].[tbl_Test] ON 

INSERT [dbo].[tbl_Test] ([Test_Id], [Test_Name], [IsActive]) VALUES (1, N'Coopertest', 1)
INSERT [dbo].[tbl_Test] ([Test_Id], [Test_Name], [IsActive]) VALUES (2, N'sprint', 1)
SET IDENTITY_INSERT [dbo].[tbl_Test] OFF
SET IDENTITY_INSERT [dbo].[tbl_TestDetails] ON 

INSERT [dbo].[tbl_TestDetails] ([Id], [Ranking], [Distance], [IsActive], [NewTest_Id]) VALUES (1, N'Queen _Jacobi', CAST(4000 AS Numeric(18, 0)), 1, 1)
SET IDENTITY_INSERT [dbo].[tbl_TestDetails] OFF
SET IDENTITY_INSERT [dbo].[tbl_Users] ON 

INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (1, N'Mitchel_Fausto', 1, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (2, N'Queen _Jacobi', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (3, N'Magen_Faye', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (4, N'Delicia_Ledonne', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (5, N'Camille_Grantham', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (6, N'Marc_Voth', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (7, N'Randy_Rondon', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (8, N'Delora_Saville', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (9, N'Rosario_Reuben', 2, 1, N'123')
INSERT [dbo].[tbl_Users] ([Users_Id], [Users_Name], [Users_RoleID], [IsActive], [Passowrd]) VALUES (10, N'Lula_Uhlman', 2, 1, N'123')
SET IDENTITY_INSERT [dbo].[tbl_Users] OFF
ALTER TABLE [dbo].[tbl_TestDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TestDetails_tbl_NewTest] FOREIGN KEY([NewTest_Id])
REFERENCES [dbo].[tbl_NewTest] ([NewTest_Id])
GO
ALTER TABLE [dbo].[tbl_TestDetails] CHECK CONSTRAINT [FK_tbl_TestDetails_tbl_NewTest]
GO
/****** Object:  StoredProcedure [dbo].[sp_Delete_Test]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Delete_Test]
@Id int
as
begin
Update tbl_NewTest set IsActive=0 Where NewTest_Id=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAthelet_Test]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DeleteAthelet_Test]
@Id int
as
begin
Update tbl_TestDetails set IsActive=0 Where Id=@Id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_Edit_User]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Edit_User]
@User_Id int
as
begin
Select * from tbl_TestDetails Where id=@User_Id and IsActive=1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Inseart_NewTest]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Inseart_NewTest]
@NewTest_Type nvarchar(100),
@NewTest_Date date
as
begin
Insert into tbl_NewTest(NewTest_Date,NewTest_Type,IsActive) values(@NewTest_Date,@NewTest_Type,1)
end
 
GO
/****** Object:  StoredProcedure [dbo].[sp_Inseart_TestDetail]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Inseart_TestDetail]
@Ranking nvarchar(100),
@Distance int,
@NewTest_Id int
as
begin
Insert into tbl_TestDetails(Ranking,Distance,IsActive,NewTest_Id) values(@Ranking,@Distance,1,@NewTest_Id)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Login]
@UserName nvarchar(100),
@Password nvarchar(100)
as
begin
SELECT * from tbl_Users WHERE Users_Name=@UserName and Passowrd = @Password
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Test]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Select_Test]
as
begin

Select tbl_NewTest.NewTest_Date,tbl_Test.Test_Name,tbl_NewTest.NewTest_Id from tbl_NewTest join tbl_Test on tbl_NewTest.NewTest_Type=tbl_Test.Test_Id where tbl_NewTest.IsActive=1 and tbl_Test.IsActive=1
select NewTest_Id,count(*) as count_post from tbl_TestDetails  where tbl_TestDetails.IsActive=1 group by NewTest_Id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_Select_TestDetail]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Select_TestDetail]
@NewTest_Id int
as
begin
Select * from tbl_TestDetails Where IsActive=1 and NewTest_Id=@NewTest_Id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_Select_TestType]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Select_TestType]
as
begin
Select * from tbl_Test Where IsActive=1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Title]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Select_Title]
@NewTest_Id int
as
begin
Select tbl_NewTest.NewTest_Date,tbl_Test.Test_Name,tbl_NewTest.NewTest_Id from tbl_NewTest join tbl_Test on tbl_NewTest.NewTest_Type=tbl_Test.Test_Id where tbl_NewTest.IsActive=1 and tbl_Test.IsActive=1 and tbl_NewTest.NewTest_Id=@NewTest_Id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_Select_User]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Select_User]
as
begin
Select * from tbl_Users
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Update_TestDetail]    Script Date: 5/2/2019 2:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Update_TestDetail]
@Ranking nvarchar(100),
@Distance int,
@NewTest_Id int,
@id int
as
begin
update tbl_TestDetails set Ranking=@Ranking,Distance=@Distance Where id=@id
end

GO
USE [master]
GO
ALTER DATABASE [DB_sportmanagement] SET  READ_WRITE 
GO
