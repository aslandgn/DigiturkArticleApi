# DigiturkArticleApi
Digiturk Çok Katmanlı Mimari Makale Apisi
# Sorular ve Cevaplar
- Projede kullanıdığınız tasarım desenleri hangileridir? Bu desenleri neden kullandınız?
Service Oriented Architecture => Servis iç yapısının, servis kullanıcılarından gizlenmesi; Loosely Coupled bir yapı sağlamak.
Repository Pattern => Veritabanı işlemlerinin tek bir noktadan çıkmasını sağlamak, kod tekrarından kaçmak, ortak işlemlerin standartlaşması
- Kullandığınız teknoloji ve kütüphaneler hakkında daha önce tecrübeniz oldu mu? Tek tek
yazabilir misiniz? Evet, daha önce bir .Net Core projesinde kısa bir süre görev aldım.
Genel olarak temel Microsoft kütüphanelerini kullandım. Temel olarak .Net Core Web Api teknolojisini kulandım, Dependency Injection kütüphanesinden faydalandım.
- Daha geniş vaktiniz olsaydı projeye neler eklemek isterdiniz?
Dışarıdaki kullanıcılara daha anlaşılır bir api sunmak için swagger kütüphanesini eklemek isterdim.
Loglama ve yetkilendirme için bir ara katman(middleware) eklemek isterdim.
Kod fazlalığını ortadan kaldırmak için MvcAutoMapper kütüphanesini eklemek isterdim.
Daha güvenli ve okunabilir bir sonuçlar dönen api oluşturmak için ViewModel katmanı eklemek isterdim, veritabanından gelen sonuçları automapper yardımıyla
viewmodele basıp sonuç olarak view model dönerdim.
Veritabanına ekleme ve güncelleme işleri validasyon aspect yazmak isterdim.
Aspect Oriented Programming için bir temel hazırlamak isterdim(Log, Routing, Validation, Authorization vb).
- Eklemek istediğiniz bir yorumunuz var mı?
-
# Veritabanı Scripti
USE [master]
GO
/****** Object:  Database [DigiTurkArticleDB]    Script Date: 12.08.2020 00:46:01 ******/
CREATE DATABASE [DigiTurkArticleDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DigiTurkArticleDB', FILENAME = N'C:\Users\Dogancan ASLAN\DigiTurkArticleDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DigiTurkArticleDB_log', FILENAME = N'C:\Users\Dogancan ASLAN\DigiTurkArticleDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DigiTurkArticleDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DigiTurkArticleDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DigiTurkArticleDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DigiTurkArticleDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DigiTurkArticleDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DigiTurkArticleDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DigiTurkArticleDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DigiTurkArticleDB] SET  MULTI_USER 
GO
ALTER DATABASE [DigiTurkArticleDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DigiTurkArticleDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DigiTurkArticleDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DigiTurkArticleDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DigiTurkArticleDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DigiTurkArticleDB] SET QUERY_STORE = OFF
GO
USE [DigiTurkArticleDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DigiTurkArticleDB]
GO
/****** Object:  Schema [ARTICLE]    Script Date: 12.08.2020 00:46:01 ******/
CREATE SCHEMA [ARTICLE]
GO
/****** Object:  Table [ARTICLE].[Article]    Script Date: 12.08.2020 00:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ARTICLE].[Article](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HEADER] [nvarchar](50) NOT NULL,
	[CONTENT] [nvarchar](max) NOT NULL,
	[STATUS] [bit] NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DigiTurkArticleDB] SET  READ_WRITE 
GO
