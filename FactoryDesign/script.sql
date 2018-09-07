USE [master]
GO
/****** Object:  Database [ProductsDatabase]    Script Date: 9/7/2018 7:44:50 PM ******/
CREATE DATABASE [ProductsDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductsDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ProductsDatabase.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProductsDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ProductsDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProductsDatabase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductsDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductsDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductsDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductsDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductsDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductsDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductsDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductsDatabase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProductsDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductsDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductsDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductsDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductsDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductsDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductsDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductsDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductsDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProductsDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductsDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductsDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductsDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductsDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductsDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProductsDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductsDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProductsDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [ProductsDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductsDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductsDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductsDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ProductsDatabase]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 9/7/2018 7:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductFare] [numeric](18, 0) NOT NULL,
	[IsBooked] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Air]    Script Date: 9/7/2018 7:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Air](
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductFare] [nvarchar](50) NOT NULL,
	[IsBooked] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Car]    Script Date: 9/7/2018 7:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductFare] [numeric](18, 0) NOT NULL,
	[IsBooked] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 9/7/2018 7:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductFare] [nvarchar](50) NOT NULL,
	[IsBooked] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [ProductsDatabase] SET  READ_WRITE 
GO
