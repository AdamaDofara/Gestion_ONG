USE [master]
GO

CREATE DATABASE [bdONGBinome03] ON  PRIMARY 
GO
ALTER DATABASE [bdONGBinome03] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bdONGBinome03].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bdONGBinome03] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [bdONGBinome03] SET ANSI_NULLS OFF
GO
ALTER DATABASE [bdONGBinome03] SET ANSI_PADDING OFF
GO
ALTER DATABASE [bdONGBinome03] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [bdONGBinome03] SET ARITHABORT OFF
GO
ALTER DATABASE [bdONGBinome03] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [bdONGBinome03] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [bdONGBinome03] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [bdONGBinome03] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [bdONGBinome03] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [bdONGBinome03] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [bdONGBinome03] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [bdONGBinome03] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [bdONGBinome03] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [bdONGBinome03] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [bdONGBinome03] SET  DISABLE_BROKER
GO
ALTER DATABASE [bdONGBinome03] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [bdONGBinome03] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [bdONGBinome03] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [bdONGBinome03] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [bdONGBinome03] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [bdONGBinome03] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [bdONGBinome03] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [bdONGBinome03] SET  READ_WRITE
GO
ALTER DATABASE [bdONGBinome03] SET RECOVERY SIMPLE
GO
ALTER DATABASE [bdONGBinome03] SET  MULTI_USER
GO
ALTER DATABASE [bdONGBinome03] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [bdONGBinome03] SET DB_CHAINING OFF
GO
USE [bdONGBinome03]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Responsable](
	[RespoCode] [varchar](20) NOT NULL,
	[RespoNom] [varchar](50) NULL,
	[RespoPrenom] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RespoCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Agence](
	[AgenCode] [varchar](20) NOT NULL,
	[AgenVille] [varchar](30) NULL,
	[AgenPays] [varchar](30) NULL,
	[AgenContinent] [varchar](30) NULL,
	[RespoCode] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[AgenCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Responsable_UPDATE]
	@respocode varchar(20) ,@responom varchar(50),@respoprenom varchar (50)
AS
UPDATE       Responsable
SET                RespoCode = @respocode, RespoNom = @responom, RespoPrenom = @respoprenom
WHERE (RespoCode = respocode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Responsable_SELECT_ALL]
@respocode varchar(20)
AS
SELECT        RespoCode, RespoNom, RespoPrenom
FROM            Responsable
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Responsable_INSERT]
	@respocode varchar(20) ,@responom varchar(50),@respoprenom varchar (50)
AS
	INSERT INTO Responsable
                         (RespoCode, RespoNom, RespoPrenom)
VALUES        (@respocode,@responom,@respoprenom)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Responsable_GET_NAME]
@responom varchar(50)
AS
SELECT        RespoCode, RespoNom, RespoPrenom
FROM            Responsable
WHERE (RespoNom = @responom)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Responsable_GET]
@respocode varchar(20)
AS
SELECT        RespoCode, RespoNom, RespoPrenom
FROM            Responsable
WHERE (RespoCode = @respocode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Responsable_DELETE]
	@respocode varchar(20)
AS
DELETE FROM Responsable
WHERE (RespoCode = @respocode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Agence_UPDATE]
@agencode varchar(20),@agenville varchar(30),@agenpays varchar(30),@agencontinent varchar(30)
AS
UPDATE       Agence
SET                AgenCode = @agencode, AgenVille = @agenville, AgenPays = @agenpays, AgenContinent = @agencontinent
WHERE (AgenCode = @agencode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Agence_SELECT_ALL]
AS
SELECT        AgenCode, AgenVille, AgenPays, AgenContinent, RespoCode
FROM            Agence
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Agence_INSERT]
@agencode varchar(20),@agenville varchar(30),@agenpays varchar(30),@agencontinent varchar(30)
AS
INSERT INTO Agence
                         (AgenCode, AgenVille, AgenPays, AgenContinent)
VALUES        (@agencode,@agenville,@agenpays,@agencontinent)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Agence_GET]
@agencode varchar(20)
AS
SELECT        AgenCode, AgenVille, AgenPays, AgenContinent, RespoCode
FROM            Agence
WHERE (AgenCode = @agencode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Agence_DELETE]
@agencode varchar(20)
AS
DELETE FROM Agence
WHERE (AgenCode = @agencode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Activite](
	[ActiCode] [varchar](20) NOT NULL,
	[ActiDate] [datetime] NULL,
	[ActiRecette] [int] NULL,
	[ActiDepense] [int] NULL,
	[AgenCode] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ActiCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appreciation](
	[RespoCode] [varchar](20) NOT NULL,
	[ActiCode] [varchar](20) NOT NULL,
	[AppreciationActivite] [text] NULL,
	[JustifRecette] [text] NULL,
	[JustifDepense] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[RespoCode] ASC,
	[ActiCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Activite_UPDATE]
	@acticode varchar(20) ,@actidate DATETIME ,@actirecette INT ,@actidepense INT
AS
UPDATE       Activite
SET                ActiCode = @acticode, ActiDate = @actidate, ActiRecette = @actirecette, ActiDepense = @actidepense
WHERE (ActiCode = @acticode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Activite_SELECT_ALL]
AS
SELECT        ActiCode, ActiDate, ActiRecette, ActiDepense, AgenCode
FROM            Activite
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Activite_INSERT]
@acticode varchar(20) ,@actidate DATETIME ,@actirecette INT ,@actidepense INT
AS
	INSERT INTO Activite
                         (ActiCode, ActiDate, ActiRecette, ActiDepense)
VALUES        (@acticode,@actidate,@actirecette,@actidepense)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Activite_GET]
@acticode varchar(20)
AS
SELECT        ActiCode, ActiDate, ActiRecette, ActiDepense
FROM            Activite
WHERE (ActiCode = @acticode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Activite_DELETE]
	@acticode varchar(20)
AS
DELETE FROM Activite
WHERE ActiCode = @acticode
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Appreciation_UPDATE]
	@acticode varchar (20), @appreciationactivite text ,@justifrecette text ,@justifdepense text
AS
UPDATE       Appreciation
SET                AppreciationActivite = @appreciationactivite, JustifRecette = @justifrecette, JustifDepense = @justifdepense
WHERE (ActiCode = @acticode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Appreciation_INSERT]
	@acticode varchar (20), @appreciationactivite text ,@justifrecette text ,@justifdepense text
AS
INSERT INTO Appreciation
                         (AppreciationActivite, JustifRecette, JustifDepense)
VALUES        (@appreciationactivite,@justifrecette,@justifdepense)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Appreciation_GET]
	@acticode varchar (20)
AS
SELECT        AppreciationActivite, JustifRecette, JustifDepense
FROM            Appreciation
WHERE (ActiCode = @acticode)
	RETURN
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPX_Appreciation_DELETE]
	@acticode varchar (20)
AS
	DELETE FROM Appreciation
WHERE (ActiCode = @acticode)
	RETURN
GO

ALTER TABLE [dbo].[Agence]  WITH CHECK ADD FOREIGN KEY([RespoCode])
REFERENCES [dbo].[Responsable] ([RespoCode])
GO

ALTER TABLE [dbo].[Activite]  WITH CHECK ADD FOREIGN KEY([AgenCode])
REFERENCES [dbo].[Agence] ([AgenCode])
GO

ALTER TABLE [dbo].[Appreciation]  WITH CHECK ADD FOREIGN KEY([ActiCode])
REFERENCES [dbo].[Activite] ([ActiCode])
GO

ALTER TABLE [dbo].[Appreciation]  WITH CHECK ADD FOREIGN KEY([RespoCode])
REFERENCES [dbo].[Responsable] ([RespoCode])
GO
