USE [master]
GO
/****** Object:  Database [DBTESTKATMAN]    Script Date: 8.09.2020 22:40:08 ******/
CREATE DATABASE [DBTESTKATMAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTESTKATMAN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBTESTKATMAN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBTESTKATMAN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBTESTKATMAN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DBTESTKATMAN] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBTESTKATMAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBTESTKATMAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBTESTKATMAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBTESTKATMAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBTESTKATMAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBTESTKATMAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBTESTKATMAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET RECOVERY FULL 
GO
ALTER DATABASE [DBTESTKATMAN] SET  MULTI_USER 
GO
ALTER DATABASE [DBTESTKATMAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBTESTKATMAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBTESTKATMAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBTESTKATMAN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBTESTKATMAN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBTESTKATMAN] SET QUERY_STORE = OFF
GO
USE [DBTESTKATMAN]
GO
/****** Object:  Table [dbo].[TBLKULUP]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLKULUP](
	[KULUPID] [tinyint] IDENTITY(1,1) NOT NULL,
	[KULUPAD] [varchar](20) NULL,
 CONSTRAINT [PK_TBLKULUP] PRIMARY KEY CLUSTERED 
(
	[KULUPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLNOTLAR]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLNOTLAR](
	[OGRID] [smallint] NOT NULL,
	[SINAV1] [tinyint] NOT NULL,
	[SINAV2] [tinyint] NULL,
	[SINAV3] [tinyint] NULL,
	[PROJE] [tinyint] NULL,
	[ORTALAMA] [decimal](18, 2) NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_TBLNOTLAR] PRIMARY KEY CLUSTERED 
(
	[OGRID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLOGRENCİ]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLOGRENCİ](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](50) NULL,
	[SOYAD] [varchar](50) NULL,
	[FOTOGRAF] [varchar](50) NULL,
	[KULUPID] [tinyint] NULL,
 CONSTRAINT [PK_TBLOGRENCİ] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBLKULUP] ON 
GO
INSERT [dbo].[TBLKULUP] ([KULUPID], [KULUPAD]) VALUES (1, N'KÜTÜPHANE')
GO
INSERT [dbo].[TBLKULUP] ([KULUPID], [KULUPAD]) VALUES (2, N'TRAFIK VE ILK YARDIM')
GO
INSERT [dbo].[TBLKULUP] ([KULUPID], [KULUPAD]) VALUES (3, N'SAĞLIK')
GO
INSERT [dbo].[TBLKULUP] ([KULUPID], [KULUPAD]) VALUES (4, N'ÇEVRE')
GO
INSERT [dbo].[TBLKULUP] ([KULUPID], [KULUPAD]) VALUES (5, N'BİLİŞİM')
GO
INSERT [dbo].[TBLKULUP] ([KULUPID], [KULUPAD]) VALUES (9, N'SATRANc')
GO
SET IDENTITY_INSERT [dbo].[TBLKULUP] OFF
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (1, 80, 65, 70, 90, CAST(76.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (2, 50, 65, 15, 70, CAST(50.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (3, 74, 85, 50, 50, CAST(64.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (4, 44, 66, 85, 50, CAST(61.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (5, 45, 33, 68, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (6, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (7, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (9, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (10, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (11, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (12, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (13, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (14, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (15, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (16, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (17, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (18, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (19, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (20, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (21, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (22, 50, 50, 50, 50, CAST(50.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (23, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (24, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[TBLNOTLAR] ([OGRID], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (25, 0, 0, 0, 0, CAST(0.00 AS Decimal(18, 2)), 0)
GO
SET IDENTITY_INSERT [dbo].[TBLOGRENCİ] ON 
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (1, N'ALİ', N'ÇINAR', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (2, N'MEHMET', N'ASLAN', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (3, N'EDA', N'ÖZTÜRK', N'TEST', 2)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (4, N'AYŞE', N'YILDIZ', N'TEST', 3)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (5, N'VEYSEL', N'ÇINAR', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (6, N'BARAN', N'YÜCEDAĞ', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (7, N'EYLÜL', N'YÜCEDAĞ', N'TEST', 5)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (8, N'TUNA', N'YILMAZ', N'TEST', 2)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (9, N'CEMAL', N'MEŞE', N'TEST', 4)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (10, N'HAKAN', N'KARA', N'TEST', 3)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (11, N'HASAN', N'GUNES', N'TEST', 2)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (12, N'MERVE', N'YILDIZ', N'', 5)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (13, N'MERVE', N'YILDIZ', N'', 5)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (14, N'ENDER', N'BURSALI', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (15, N'ALI', N'KONYALI', N'TEST', 3)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (16, N'MUSTAFA', N'KAHRIMAN', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (17, N'Ali', N'Veli', N'test', 5)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (18, N'asdf', N'aaaa', N'test', 2)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (19, N'omer', N'eser', N'test', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (20, N'HATICE', N'AAaa', N'asd', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (21, N'OMER', N'ESER', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (22, N'OMER', N'ESER', N'TEST', 1)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (23, N'Yunus Emre', N'Agca', N'test', 5)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (24, N'Yunus Emre', N'Agca', N'test', 3)
GO
INSERT [dbo].[TBLOGRENCİ] ([ID], [AD], [SOYAD], [FOTOGRAF], [KULUPID]) VALUES (25, N'Betül', N'Taskan', N'tesT', 9)
GO
SET IDENTITY_INSERT [dbo].[TBLOGRENCİ] OFF
GO
ALTER TABLE [dbo].[TBLNOTLAR] ADD  CONSTRAINT [DF_TBLNOTLAR_SINAV1]  DEFAULT ((0)) FOR [SINAV1]
GO
ALTER TABLE [dbo].[TBLNOTLAR] ADD  CONSTRAINT [DF_TBLNOTLAR_SINAV2]  DEFAULT ((0)) FOR [SINAV2]
GO
ALTER TABLE [dbo].[TBLNOTLAR] ADD  CONSTRAINT [DF_TBLNOTLAR_SINAV3]  DEFAULT ((0)) FOR [SINAV3]
GO
ALTER TABLE [dbo].[TBLNOTLAR] ADD  CONSTRAINT [DF_TBLNOTLAR_PORJE]  DEFAULT ((0)) FOR [PROJE]
GO
ALTER TABLE [dbo].[TBLNOTLAR] ADD  CONSTRAINT [DF_TBLNOTLAR_ORTALAMA]  DEFAULT ((0)) FOR [ORTALAMA]
GO
ALTER TABLE [dbo].[TBLNOTLAR] ADD  CONSTRAINT [DF_TBLNOTLAR_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TBLNOTLAR]  WITH CHECK ADD  CONSTRAINT [FK_TBLNOTLAR_TBLOGRENCİ] FOREIGN KEY([OGRID])
REFERENCES [dbo].[TBLOGRENCİ] ([ID])
GO
ALTER TABLE [dbo].[TBLNOTLAR] CHECK CONSTRAINT [FK_TBLNOTLAR_TBLOGRENCİ]
GO
ALTER TABLE [dbo].[TBLOGRENCİ]  WITH CHECK ADD  CONSTRAINT [FK_TBLOGRENCİ_TBLKULUP] FOREIGN KEY([KULUPID])
REFERENCES [dbo].[TBLKULUP] ([KULUPID])
GO
ALTER TABLE [dbo].[TBLOGRENCİ] CHECK CONSTRAINT [FK_TBLOGRENCİ_TBLKULUP]
GO
/****** Object:  StoredProcedure [dbo].[KULUPEKLE]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[KULUPEKLE]
@KULUPAD varchar(20)
as
insert into TBLKULUP(KULUPAD) values(@KULUPAD)
GO
/****** Object:  StoredProcedure [dbo].[KULUPGUNCELLE]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KULUPGUNCELLE]
@KULUPAD VARCHAR(20),
@KULUPID TINYINT
AS
UPDATE TBLKULUP SET KULUPAD=@KULUPAD
WHERE
KULUPID=@KULUPID
GO
/****** Object:  StoredProcedure [dbo].[KULUPLISTESİ]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KULUPLISTESİ]
AS
SELECT * FROM TBLKULUP
GO
/****** Object:  StoredProcedure [dbo].[KULUPSIL]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KULUPSIL]
@KULUPID TINYINT
AS
DELETE FROM TBLKULUP WHERE KULUPID=@KULUPID
GO
/****** Object:  StoredProcedure [dbo].[NOTGUNCELLE]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NOTGUNCELLE]
@OGRID SMALLINT,
@SINAV1 TINYINT,
@SINAV2 TINYINT,
@SINAV3 TINYINT,
@PROJE TINYINT,
@ORTALAMA DECIMAL(18,2),
@DURUM BIT
AS
UPDATE TBLNOTLAR SET SINAV1=@SINAV1,
					 SINAV2=@SINAV2,
					 SINAV3=@SINAV3,
					 PROJE=@PROJE,
					 ORTALAMA=@ORTALAMA,
					 DURUM=@DURUM
					 WHERE OGRID=@OGRID
GO
/****** Object:  StoredProcedure [dbo].[NOTLISTESI]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NOTLISTESI]
AS
SELECT OGRID,AD,SOYAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM 
FROM TBLNOTLAR INNER JOIN TBLOGRENCİ
ON TBLOGRENCİ.ID=TBLNOTLAR.OGRID
GO
/****** Object:  StoredProcedure [dbo].[OGRENCIEKLE]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OGRENCIEKLE]
@AD VARCHAR(20),
@SOYAD VARCHAR(30),
@FOTOGRAF VARCHAR(50),
@KULUPID smallint
AS
INSERT INTO TBLOGRENCİ(AD, SOYAD, FOTOGRAF,KULUPID)
VALUES
(@AD, @SOYAD,@FOTOGRAF,@KULUPID)
GO
/****** Object:  StoredProcedure [dbo].[OGRENCIGUNCELLE]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OGRENCIGUNCELLE]
@AD VARCHAR(20),
@SOYAD VARCHAR(30),
@FOTOGRAF VARCHAR(50),
@KULUPID smallint,
@ID int
AS
UPDATE TBLOGRENCİ SET AD=@AD, SOYAD=@SOYAD,FOTOGRAF=@FOTOGRAF,KULUPID=@KULUPID
WHERE ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[OGRENCILISTESI]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OGRENCILISTESI]
AS
SELECT * FROM TBLOGRENCİ
GO
/****** Object:  StoredProcedure [dbo].[OGRENCISIL]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OGRENCISIL]
@ID int
AS
DELETE FROM TBLOGRENCİ WHERE ID=@ID
GO
/****** Object:  Trigger [dbo].[OGRENCINOT]    Script Date: 8.09.2020 22:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[OGRENCINOT]
ON [dbo].[TBLOGRENCİ]
AFTER INSERT
AS
DECLARE @ID SMALLINT
SELECT @ID=ID FROM INSERTED 
INSERT INTO TBLNOTLAR(OGRID)VALUES(@ID)
GO
ALTER TABLE [dbo].[TBLOGRENCİ] ENABLE TRIGGER [OGRENCINOT]
GO
USE [master]
GO
ALTER DATABASE [DBTESTKATMAN] SET  READ_WRITE 
GO
