USE [master]
GO

/****** Object:  Database [VTRACKERDB]    Script Date: 1/14/2022 8:28:53 PM ******/
CREATE DATABASE [VTRACKERDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VTRACKERDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQL2019\MSSQL\DATA\VTRACKERDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VTRACKERDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQL2019\MSSQL\DATA\VTRACKERDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VTRACKERDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [VTRACKERDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [VTRACKERDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [VTRACKERDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [VTRACKERDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [VTRACKERDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [VTRACKERDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [VTRACKERDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [VTRACKERDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [VTRACKERDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [VTRACKERDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [VTRACKERDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [VTRACKERDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [VTRACKERDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [VTRACKERDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [VTRACKERDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [VTRACKERDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [VTRACKERDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [VTRACKERDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [VTRACKERDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [VTRACKERDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [VTRACKERDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [VTRACKERDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [VTRACKERDB] SET RECOVERY FULL 
GO

ALTER DATABASE [VTRACKERDB] SET  MULTI_USER 
GO

ALTER DATABASE [VTRACKERDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [VTRACKERDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [VTRACKERDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [VTRACKERDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [VTRACKERDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [VTRACKERDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [VTRACKERDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [VTRACKERDB] SET  READ_WRITE 
GO


