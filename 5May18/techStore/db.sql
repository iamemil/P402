/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [TechStore]    Script Date: 5/5/2018 1:45:26 PM ******/
CREATE DATABASE [TechStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SERVER2018\MSSQL\DATA\TechStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SERVER2018\MSSQL\DATA\TechStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TechStore] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TechStore] SET  MULTI_USER 
GO
ALTER DATABASE [TechStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TechStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TechStore] SET QUERY_STORE = OFF
GO
USE [TechStore]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [TechStore]
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 5/5/2018 1:45:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Display] [money] NOT NULL,
	[RAM] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Computers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Computers] ON 

INSERT [dbo].[Computers] ([Id], [Brand], [Model], [Display], [RAM]) VALUES (6, N'Lenovo', N'Yoga 920', 13.3000, N'16GB      ')
INSERT [dbo].[Computers] ([Id], [Brand], [Model], [Display], [RAM]) VALUES (7, N'Apple', N'Macbook Pro', 15.0000, N'16GB      ')
INSERT [dbo].[Computers] ([Id], [Brand], [Model], [Display], [RAM]) VALUES (12, N'Asus', N'Zenbook', 13.0000, N'8GB       ')
SET IDENTITY_INSERT [dbo].[Computers] OFF
USE [master]
GO
ALTER DATABASE [TechStore] SET  READ_WRITE 
GO
