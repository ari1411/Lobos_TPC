USE [master]
GO
/****** Object:  Database [LOBOS_DB]    Script Date: 11/18/2018 18:56:23 ******/
CREATE DATABASE [LOBOS_DB] ON  PRIMARY 
( NAME = N'LOBOS_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\LOBOS_DB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LOBOS_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\LOBOS_DB_log.ldf' , SIZE = 6912KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LOBOS_DB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LOBOS_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LOBOS_DB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [LOBOS_DB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [LOBOS_DB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [LOBOS_DB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [LOBOS_DB] SET ARITHABORT OFF
GO
ALTER DATABASE [LOBOS_DB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [LOBOS_DB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [LOBOS_DB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [LOBOS_DB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [LOBOS_DB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [LOBOS_DB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [LOBOS_DB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [LOBOS_DB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [LOBOS_DB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [LOBOS_DB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [LOBOS_DB] SET  DISABLE_BROKER
GO
ALTER DATABASE [LOBOS_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [LOBOS_DB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [LOBOS_DB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [LOBOS_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [LOBOS_DB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [LOBOS_DB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [LOBOS_DB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [LOBOS_DB] SET  READ_WRITE
GO
ALTER DATABASE [LOBOS_DB] SET RECOVERY FULL
GO
ALTER DATABASE [LOBOS_DB] SET  MULTI_USER
GO
ALTER DATABASE [LOBOS_DB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [LOBOS_DB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'LOBOS_DB', N'ON'
GO
USE [LOBOS_DB]
GO
/****** Object:  Table [dbo].[Universidades]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Universidades](
	[idUniversidad] [int] IDENTITY(1,1) NOT NULL,
	[Universidad] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[IdMunicipio] [int] NULL,
	[Telefono] [varchar](50) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Universidades] PRIMARY KEY CLUSTERED 
(
	[idUniversidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paises](
	[IdPais] [int] IDENTITY(1,1) NOT NULL,
	[Pais] [varchar](20) NOT NULL,
	[Nacionalidad] [varchar](20) NULL,
	[NacionalidadM] [varchar](20) NULL,
	[NacionalidadF] [varchar](20) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Paises] ON
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (1, N'ARGENTINA', N'ARGENTINO/A', N'ARGENTINO', N'ARGENTINA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (2, N'URUGUAY', N'URUGUAYO/A', N'URUGUAYO', N'URUGUAYA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (3, N'BRASIL', N'BRASILERO/A', N'BRASILERO', N'BRASILERA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (4, N'PARAGUAY', N'PARAGUAYO/A', N'PARAGUAYO', N'PARAGUAYA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (5, N'BOLIVIA', N'BOLIVIANO/A', N'BOLIVIANO', N'BOLIVIANA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (6, N'CHILE', N'CHILENO/A', N'CHILENO', N'CHILENA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (7, N'PERU', N'PERUANO/A', N'PERUANO', N'PERUANA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (8, N'VENEZUELA', N'VENEZOLANO/A', N'VENEZOLANO', N'VENEZOLANA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (9, N'COLOMBIA', N'COLOMBIANO/A', N'COLOMBIANO', N'COLOMBIANA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (10, N'ECUADOR', N'ECUATORIANO/A', N'ECUATORIANO', N'ECUATORIANA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (11, N'GUYANA', N'GUYANES/A', N'GUYANES', N'GUYANESA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (12, N'SURINAM', N'SURINAMES/A', N'SURINAMES', N'SURINAMESA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (13, N'GUAYANA FRANCESA', N'FRANCOGUYANES/A', N'FRANCOGUYANES', N'FRANCOGUYANESA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (14, N'INGLATERRA', N'INGLES/A', N'INGLES', N'INGLESA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (15, N'ESPAÑA', N'ESPAÑOL/A', N'ESPAÑOL', N'ESPAÑOLA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (16, N'FRANCIA', N'FRANCES/A', N'FRANCES', N'FRANCESA', 1)
INSERT [dbo].[Paises] ([IdPais], [Pais], [Nacionalidad], [NacionalidadM], [NacionalidadF], [Estado]) VALUES (17, N'ITALIA', N'ITALIANO/A', N'ITALIANO', N'ITALIANA', 1)
SET IDENTITY_INSERT [dbo].[Paises] OFF
/****** Object:  Table [dbo].[Especialidades]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Especialidades](
	[IdEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[Especialidad] [varchar](50) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdminAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdminModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdminBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED 
(
	[IdEspecialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidades] ON
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (1, N'CLINICA MEDICA', CAST(0x0000A99C010BB2E9 AS DateTime), 1, CAST(0x0000A99C010BB2E9 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (2, N'TRAUMATOLOGIA', CAST(0x0000A99C010BC11C AS DateTime), 1, CAST(0x0000A99C010BC11C AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (3, N'DERMATOLOGIA', CAST(0x0000A99C010BD724 AS DateTime), 1, CAST(0x0000A99C010BD724 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (4, N'KINESIOLOGIA', CAST(0x0000A99C010E9644 AS DateTime), 1, CAST(0x0000A99C010E9644 AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
/****** Object:  Table [dbo].[Cargos]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cargos](
	[IdCargo] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Cargos] PRIMARY KEY CLUSTERED 
(
	[IdCargo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cargos] ON
INSERT [dbo].[Cargos] ([IdCargo], [Cargo], [Estado]) VALUES (1, N'Dueño', 1)
INSERT [dbo].[Cargos] ([IdCargo], [Cargo], [Estado]) VALUES (2, N'Presidente', 1)
INSERT [dbo].[Cargos] ([IdCargo], [Cargo], [Estado]) VALUES (3, N'Gerente', 1)
INSERT [dbo].[Cargos] ([IdCargo], [Cargo], [Estado]) VALUES (4, N'Referente', 1)
INSERT [dbo].[Cargos] ([IdCargo], [Cargo], [Estado]) VALUES (6, N'Administrativo', 1)
SET IDENTITY_INSERT [dbo].[Cargos] OFF
/****** Object:  Table [dbo].[Sexo]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sexo](
	[Idsexo] [int] IDENTITY(1,1) NOT NULL,
	[Sexo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[Idsexo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Sexo] ON
INSERT [dbo].[Sexo] ([Idsexo], [Sexo]) VALUES (0, N'INDEFINIDO')
INSERT [dbo].[Sexo] ([Idsexo], [Sexo]) VALUES (1, N'MASCULINO')
INSERT [dbo].[Sexo] ([Idsexo], [Sexo]) VALUES (2, N'FEMENINO')
SET IDENTITY_INSERT [dbo].[Sexo] OFF
/****** Object:  Table [dbo].[RazonesSociales]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RazonesSociales](
	[IdRazonSocial] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocialPlan] [varchar](50) NOT NULL,
	[CUIT] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdmAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdmModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdmBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_RazonesSociales] PRIMARY KEY CLUSTERED 
(
	[IdRazonSocial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[RazonesSociales] ON
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (1, N'PAMI', N'123', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (2, N'ENSALUD - OSBARA', N'456', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (3, N'ENSALUD - GAMA PRIVADO', N'789', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (4, N'ENSALUD - OBSBA', N'147', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (5, N'PREMEDIC', N'258', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (6, N'OSCHOCA', N'369', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (7, N'IMA - MADERA', N' ', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (8, N'IMA - CAUCHO', N'654', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (9, N'IOMA', N'321', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[RazonesSociales] ([IdRazonSocial], [RazonSocialPlan], [CUIT], [Telefono], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (12, N'SANCOR SALUD - 3000', N'014', NULL, CAST(0x0000A97D00000000 AS DateTime), 1, CAST(0x0000A97D00000000 AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[RazonesSociales] OFF
/****** Object:  Table [dbo].[Provincias]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincias](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[Provincia] [varchar](50) NOT NULL,
	[IdPais] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Provincias] ON
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (1, N'BUENOS AIRES', 1, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (2, N'ENTRE RIOS', 1, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (3, N'CORDOBA', 1, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (4, N'SANTA FE', 1, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (5, N'SANTIAGO DEL ESTERO', 1, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (6, N'PROVINCIA PRUEBA', 15, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (7, N'CAPITAL', 7, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (8, N'AMSTERDAM', 14, 1)
INSERT [dbo].[Provincias] ([IdProvincia], [Provincia], [IdPais], [Estado]) VALUES (9, N'CAPITAL', 16, 1)
SET IDENTITY_INSERT [dbo].[Provincias] OFF
/****** Object:  View [dbo].[VW_ESPECIALIDADES_MEDICAS]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_ESPECIALIDADES_MEDICAS] as select top 100 IdEspecialidad, Especialidad from Especialidades where Estado=1 order by Especialidad asc
GO
/****** Object:  View [dbo].[VW_CARGOS]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_CARGOS] as select top 100 c.IdCargo, c.Cargo from Cargos as c where c.Estado=1 order by c.Cargo asc
GO
/****** Object:  View [dbo].[VW_PAISES]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_PAISES] AS SELECT top 1000 P.IDPAIS, P.NACIONALIDAD FROM Paises AS P ORDER BY NACIONALIDAD ASC
GO
/****** Object:  View [dbo].[VW_NACIONALIDAD]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_NACIONALIDAD] AS SELECT top 1000 P.IDPAIS, P.NACIONALIDAD FROM Paises AS P where p.Estado=1 ORDER BY NACIONALIDAD ASC
GO
/****** Object:  View [dbo].[vw_RazonSocial]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vw_RazonSocial] as select top 1000 idrazonsocial, RazonSocialPlan + ' [' + CUIT + ']' as 'Nombre' from RazonesSociales where Estado=1 order by RazonSocialPlan asc
GO
/****** Object:  View [dbo].[VW_PROVINCIAS]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_PROVINCIAS] AS SELECT TOP 1000 P.IDPROVINCIA, P.PROVINCIA + ' - ' + PA.PAIS AS 'PROVINCIAS' FROM Provincias AS P inner join Paises AS PA ON P.IdPais=PA.IdPais where p.Estado=1 ORDER BY P.Provincia ASC
GO
/****** Object:  Table [dbo].[Partidos]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Partidos](
	[IdPartido] [int] IDENTITY(1,1) NOT NULL,
	[Partido] [varchar](50) NOT NULL,
	[IdProvincia] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Partidos] PRIMARY KEY CLUSTERED 
(
	[IdPartido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Partidos] ON
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (1, N'JOSE C PAZ', 1, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (2, N'SAN MIGUEL', 1, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (3, N'MALVINAS ARGENTINAS', 1, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (5, N'ROSARIO', 4, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (6, N'PARANA', 2, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (7, N'CALAMUCHITA', 3, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (9, N'POTOSI', 5, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (10, N'TIGRE', 1, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (11, N'CARLOS PAZ', 3, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (12, N'LIMA', 7, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (14, N'AMSTERDAM', 8, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (16, N'PARIS', 9, 1)
INSERT [dbo].[Partidos] ([IdPartido], [Partido], [IdProvincia], [Estado]) VALUES (17, N'MORENO', 1, 1)
SET IDENTITY_INSERT [dbo].[Partidos] OFF
/****** Object:  Table [dbo].[Municipios]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Municipios](
	[IdMunicipio] [int] IDENTITY(1,1) NOT NULL,
	[Municipio] [varchar](50) NOT NULL,
	[CP] [varchar](6) NOT NULL,
	[IdPartido] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Municipio] PRIMARY KEY CLUSTERED 
(
	[IdMunicipio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Municipios] ON
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (1, N'JOSE C PAZ', N'1665', 1, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (2, N'SAN MIGUEL', N'1663', 2, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (3, N'BELLA VISTA', N'1663', 2, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (4, N'PABLO NOGUES', N'1613', 3, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (5, N'POLVORINES', N'55', 3, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (6, N'GRAND BOURG', N'66', 3, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (7, N'DERQUI', N'71', 7, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (8, N'EL TALAR DE PACHECO', N'1617', 10, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (9, N'PACHECO', N'1618', 10, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (10, N'LOS TRONCOS DEL TALAR', N'10', 10, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (11, N'SANTA ROSA', N'11', 7, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (12, N'PILAR', N'32', 7, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (13, N'MORENO', N'23', 12, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (15, N'TIERRA DEL FUEGO', N'14', 10, 1)
INSERT [dbo].[Municipios] ([IdMunicipio], [Municipio], [CP], [IdPartido], [Estado]) VALUES (16, N'SAN ISIDRO', N'123', 10, 1)
SET IDENTITY_INSERT [dbo].[Municipios] OFF
/****** Object:  View [dbo].[VW_PARTIDOS]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_PARTIDOS] AS SELECT TOP 1000 P.IDPARTIDO, P.PARTIDO + ' - ' + PR.PROVINCIA + ' - ' + PA.PAIS AS 'PARTIDOS' FROM Partidos AS P inner join Provincias AS PR ON P.IdProvincia=PR.IdProvincia inner join Paises AS PA ON PR.IdPais=PA.IdPais where p.Estado=1 ORDER BY P.Partido ASC
GO
/****** Object:  View [dbo].[VW_MUNICIPIOS]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_MUNICIPIOS] AS SELECT TOP 1000 M.IDMUNICIPIO, '('+M.CP+') '+M.Municipio+' - '+P.PARTIDO+' - '+PR.PROVINCIA AS 'MUNICIPIOS' FROM Municipios AS M inner join PARTIDOS AS P ON M.IDPARTIDO=P.IDPARTIDO inner join PROVINCIAS AS PR ON P.IDPROVINCIA=PR.IDPROVINCIA where m.Estado=1 ORDER BY M.Municipio ASC, PR.Provincia ASC, P.Partido ASC, M.CP ASC
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personas](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](9) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[IdSexo] [int] NOT NULL,
	[FechaNac] [date] NOT NULL,
	[IdNacionalidad] [int] NOT NULL,
	[Calle] [varchar](50) NOT NULL,
	[Numero] [varchar](10) NULL,
	[Piso] [varchar](10) NULL,
	[Depto] [varchar](10) NULL,
	[IdMunicipio] [int] NOT NULL,
	[TelCelular] [varchar](15) NULL,
	[TelFijo] [varchar](15) NULL,
	[Mail] [varchar](50) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdminAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdminModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdminBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Personas] ON
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (1, N'11111111', N'ADMINISTRADOR', N'ADMIN', 0, CAST(0xBC3E0B00 AS Date), 1, N'HIPOLITO IRIGOYEN', N'100', NULL, NULL, 9, N'1168641585', NULL, N'ARI1411.LOBOS@GMAIL.COM', CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A98F0022DCE5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (2, N'22222222', N'MIRANDA', N'CARLOS', 1, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 10, NULL, NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (3, N'33333333', N'MARQUEZ', N'MARIA', 2, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 9, NULL, NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (4, N'44444444', N'SUAREZ', N'LUCAS', 1, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 3, NULL, NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (5, N'55555555', N'OLMEDO', N'JONATAN', 1, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 2, NULL, NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (6, N'66666666', N'LLANOS', N'ALEJANDRA', 2, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 2, NULL, NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (7, N'77777777', N'MONZALVO', N'VANESA', 2, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 5, N'923456789', NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (8, N'88888888', N'BELIZAN', N'GISELA', 2, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 5, NULL, NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (9, N'99999999', N'BASUALDO', N'AUGUSTO', 1, CAST(0x07240B00 AS Date), 1, N'desconocido', NULL, NULL, NULL, 3, NULL, NULL, NULL, CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A97C00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (10, N'90120125', N'GALARZA', N'ALEX', 1, CAST(0x5CF20A00 AS Date), 7, N'GRAND BOURG', N'105', N'10', N'B', 6, NULL, NULL, N'ALE.GALARZA@YAHOO.COM.AR', CAST(0x0000A97C00000000 AS DateTime), 1, CAST(0x0000A98F0021CB95 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (11, N'11111111', N'VILLACORTA', N'ROGER', 1, CAST(0x10D60A00 AS Date), 5, N'CALLE ESCONDIDA', N'465', N'1', N'D', 9, N'1148997654', N'44632949', N'VILLACORTA.ROGER@LIVE.COM.AR', CAST(0x0000A98400000000 AS DateTime), 1, CAST(0x0000A98400000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (12, N'11111111', N'CASIMIRO', N'MARCOS', 1, CAST(0x54E60A00 AS Date), 7, N'CALLE ESCONDIDA', N'465', N'2', N'B', 9, N'1150648894', N'44632949', N'CASIMIRO.MARCOS@HOTMAIL.COM.AR', CAST(0x0000A98400000000 AS DateTime), 1, CAST(0x0000A98400000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (13, N'11111111', N'FRERS', N'CARLOTA', 0, CAST(0xBC3E0B00 AS Date), 3, N'AV CENTENARIO', N'1746', N'5', N'F', 6, N'1546215618', N'769588513', N'CARLOTA.FRERS@GMAIL.COM', CAST(0x0000A98501372B73 AS DateTime), 1, CAST(0x0000A98501372B73 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (14, N'11111111', N'CAYO', N'EMMANUEL', 1, CAST(0x1E0F0B00 AS Date), 1, N'MIGUEL CANE', N'126', NULL, NULL, 1, N'1164857596', N'02320-600450', N'CAYOEMANUEL@GMAIL.COM', CAST(0x0000A985016397C3 AS DateTime), 1, CAST(0x0000A99A01114464 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (15, N'11111111', N'VILLACORTA', N'ROGER', 1, CAST(0x10D60A00 AS Date), 5, N'CALLE ESCONDIDA', N'465', N'1', N'D', 9, N'1148997654', N'44632949', N'VILLACORTA.ROGER@LIVE.COM.AR', CAST(0x0000A98400000000 AS DateTime), 1, CAST(0x0000A986013EBA37 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (16, N'11111111', N'BERON', N'BERENICE', 2, CAST(0x10D60A00 AS Date), 5, N'CALLE ESCONDIDA', N'465', N'1', N'D', 9, N'1148997654', N'44632949', N'VILLACORTA.ROGER@LIVE.COM.AR', CAST(0x0000A98400000000 AS DateTime), 1, CAST(0x0000A986016223C5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (17, N'11111111', N'CHURA', N'ROBERTO', 1, CAST(0xC93D0B00 AS Date), 1, N'ALSKNVN', N'23165', N'1', N'B', 5, N'2315', N'32135', N'23AS3V135ASV12', CAST(0x0000902400000000 AS DateTime), 1, CAST(0x0000901A00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (18, N'11111111', N'FLYNN', N'GUILERMO', 1, CAST(0xBC3E0B00 AS Date), 1, N'ASF', N'3215', N'1', N'2', 1, N'23151', N'3153', N'ASFA35456AS1F', CAST(0x0000A986016A961F AS DateTime), 1, CAST(0x0000A986016A961F AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (19, N'35755753', N'LOBOS', N'ELIAS SEBASTIAN', 1, CAST(0x12230B00 AS Date), 1, N'CALDERON DE LA BARCA', N'4024', NULL, NULL, 1, N'1123068546', N'02320600450', N'ELIASLOBOS.15@GMAIL.COM', CAST(0x0000A968015CABC2 AS DateTime), 1, CAST(0x0000A99A015B71D5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (22, N'22222222', N'CASTAÑO', N'CACHO', 0, CAST(0xB1DC0A00 AS Date), 6, N'ALGUNA CALLE', N'1234', NULL, NULL, 5, N'12315', N'21561', N'ASFJNAS23135', CAST(0x0000901A00000000 AS DateTime), 1, CAST(0x0000901A00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (24, N'11121111', N'ASLKNASF', N'LKANSVL', 0, CAST(0xBC3E0B00 AS Date), 1, N'ASLKN', N'465', N'32', N'12', 1, N'11222', N'33321555', N'FVASV2315', CAST(0x0000A986016CBB8C AS DateTime), 1, CAST(0x0000A986016CBB8C AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (26, N'35755757', N'LOBOS', N'ARIEL GUSTAVO', 1, CAST(0xC3160B00 AS Date), 1, N'SAN LORENZO', N'4459', NULL, NULL, 1, N'1168641585', N'1168497160', N'ARI1411.LOBOS@GMAIL.COM', CAST(0x0000A98601777286 AS DateTime), 1, CAST(0x0000A99401438C12 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (27, N'34072702', N'CHURA SUNA', N'GABRIELA ALEJANDRA', 2, CAST(0x01140B00 AS Date), 1, N'SAN LORENZO', N'4459', NULL, NULL, 1, N'1168497160', N'1168641585', N'GABRIELACHURA@GMAIL.COM', CAST(0x0000A986017858D0 AS DateTime), 1, CAST(0x0000A98F00216C57 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (28, N'52120120', N'LOBOS', N'MIA ISABELLA', 2, CAST(0x033B0B00 AS Date), 1, N'SAN LORENZO', N'4459', NULL, NULL, 1, N'1168641585', N'1168497160', N'FLIA.LOBOS@GMAIL.COM', CAST(0x0000A986017FB8D4 AS DateTime), 1, CAST(0x0000A98F0023220E AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (30, N'92180332', N'PAREDES PAUCARI', N'MIRIAN SIXTA', 2, CAST(0xA6F80A00 AS Date), 5, N'CALDERON DE LA BARCA', N'4024', N' ', N' ', 1, N'1163068805', N'02320600450', N'MIRIANSIXTA@GMAIL.COM', CAST(0x0000A987005BE8A0 AS DateTime), 1, CAST(0x0000A98F001EDBEA AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (31, N'47451591', N'CHURA SUNA', N'JUAN PABLO', 1, CAST(0x6C2D0B00 AS Date), 1, N'TAPI', N'251', NULL, NULL, 1, NULL, NULL, NULL, CAST(0x0000A987005BEBCC AS DateTime), 1, CAST(0x0000A98F0149747D AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (32, N'24', N'AD', N'DSAD', 0, CAST(0xBC3E0B00 AS Date), 13, N'DSADC', N'12', N'S', N'2', 13, N'4534', N'3433', N'SCASC', CAST(0x0000A987005F3AEE AS DateTime), 1, CAST(0x0000A987005F3AEE AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (33, N'10000001', N'APELLIDO', N'NOMBRE', 0, CAST(0xBC3E0B00 AS Date), 1, N'CALLE', N'123', NULL, NULL, 10, NULL, NULL, NULL, CAST(0x0000A9870072D9DC AS DateTime), 1, CAST(0x0000A9870072D9DC AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (34, N'10000001', N'APELLIDO', N'NOMBRE', 0, CAST(0xBC3E0B00 AS Date), 1, N'CALLE', N'123', N'PISO', NULL, 10, NULL, NULL, NULL, CAST(0x0000A9870072E75D AS DateTime), 1, CAST(0x0000A9870072E75D AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (35, N'10000001', N'APELLIDO', N'NOMBRE', 0, CAST(0xBC3E0B00 AS Date), 1, N'CALLE', N'123', N'PISO', N'DPTO', 10, NULL, NULL, NULL, CAST(0x0000A9870072EF72 AS DateTime), 1, CAST(0x0000A9870072EF72 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (36, N'10000001', N'APELLIDO', N'NOMBRE', 0, CAST(0xBC3E0B00 AS Date), 1, N'CALLE', N'123', N'PISO', N'DPTO', 10, NULL, NULL, N'MAIL', CAST(0x0000A9870072F44F AS DateTime), 1, CAST(0x0000A9870072F44F AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (37, N'10000001', N'APELLIDO', N'NOMBRE', 0, CAST(0xBC3E0B00 AS Date), 1, N'CALLE', N'123', N'PISO', N'DPTO', 10, N'MOV', NULL, N'MAIL', CAST(0x0000A9870072FAFE AS DateTime), 1, CAST(0x0000A9870072FAFE AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (38, N'10000001', N'APELLIDO', N'NOMBRE', 0, CAST(0xBC3E0B00 AS Date), 1, N'CALLE', N'123', N'PISO', N'DPTO', 10, N'MOV', N'FIJO', N'MAIL', CAST(0x0000A987007307F2 AS DateTime), 1, CAST(0x0000A987007307F2 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (39, N'10000001', N'APELLIDO', N'NOMBRE', 0, CAST(0xBC3E0B00 AS Date), 1, N'CALLE', N'123', N'PISO', N'DPTO', 10, N'MOV', N'FIJO', NULL, CAST(0x0000A98700731343 AS DateTime), 1, CAST(0x0000A98700731343 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (40, N'3513512', N'ANTUNEZ', N'LUCAS', 1, CAST(0x91170B00 AS Date), 1, N'AV. GASPAR CAMPOS', N'1864', N'7', N'B', 2, N'1142376429', NULL, N'LUCAS.ANTUNEZ@OUTLOOK.COM.AR', CAST(0x0000A9890116767F AS DateTime), 1, CAST(0x0000A995000C9C22 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (41, N'18031211', N'LOBOS', N'MONICA GLADYS', 2, CAST(0x86F40A00 AS Date), 1, N'CANGALLO', N'4099', NULL, NULL, 4, N'1534871473', N'20078973', N'MONICALOBOS105@GMAIL.COM', CAST(0x0000A98E011FBDDF AS DateTime), 1, CAST(0x0000A98E011FBDDF AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (42, N'35021592', N'LOBOS', N'MAXIMILIANO EZEQUIEL', 1, CAST(0xD6150B00 AS Date), 1, N'CANGALLO', N'4099', NULL, NULL, 4, N'1132980162', N'20078973', N'MAXI.LOBOS@GMAIL.COM', CAST(0x0000A98E0121EDCD AS DateTime), 1, CAST(0x0000A98E0121EDCD AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (43, N'55343212', N'ALFONSI', N'JAKY', 0, CAST(0x033B0B00 AS Date), 1, N'SAN LORENZO', N'4459', NULL, NULL, 1, N'1168641585', N'1168497160', N'FLIA.LOBOS@GMAIL.COM', CAST(0x0000A98F00100EC1 AS DateTime), 1, CAST(0x0000A98F00238ABB AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (44, N'55343212', N'S', N'ALGUIEN', 0, CAST(0xBC3E0B00 AS Date), 5, N'ASCLKNASV', N'32135', N'2', N'1', 10, N'2', N'112', N'ASV321', CAST(0x0000A98F0010E0CA AS DateTime), 1, CAST(0x0000A98F00237AD2 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (45, N'22541321', N'GONZALEZ', N'MANOLO', 1, CAST(0xDFE80A00 AS Date), 15, N'CASTELLI', N'2046', N'9', N'A', 11, NULL, N'46248895', N'MANU1958@LIVE.COM.AR', CAST(0x0000A995001A9DFC AS DateTime), 1, CAST(0x0000A995001A9DFC AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (46, N'51', N'ASKLN', N'LKNAS', 0, CAST(0xEF3E0B00 AS Date), 1, N'SV', N'2', NULL, NULL, 3, N'321', NULL, N'ASV', CAST(0x0000A995002C6915 AS DateTime), 1, CAST(0x0000A995002C6915 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (47, N'51', N'ASKLN', N'LKNAS', 0, CAST(0xEF3E0B00 AS Date), 1, N'SV', N'2', NULL, NULL, 3, N'321', NULL, N'ASV', CAST(0x0000A995002C6915 AS DateTime), 1, CAST(0x0000A995002C6915 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (48, N'12345655', N'ASF', N'SF', 0, CAST(0xEF3E0B00 AS Date), 1, N'FDASV', N'3213', NULL, NULL, 3, N'351321', NULL, NULL, CAST(0x0000A995002CB410 AS DateTime), 1, CAST(0x0000A995002CB410 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (49, N'12345655', N'ASF', N'SF', 0, CAST(0xEF3E0B00 AS Date), 1, N'FDASV', N'3213', NULL, NULL, 3, N'351321', NULL, NULL, CAST(0x0000A995002CB410 AS DateTime), 1, CAST(0x0000A995002CB410 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (50, N'34755757', N'GONZALEZ', N'MARIANO EZEQUIEL', 1, CAST(0xFD150B00 AS Date), 6, N'CAPITAN MARTINEZ', N'48', NULL, NULL, 4, N'1167666867', N'44632938', N'GONZA.CARP@GMAIL.COM', CAST(0x0000A995011B3E9D AS DateTime), 1, CAST(0x0000A995011B3E9D AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (51, N'34755757', N'GONZALEZ', N'MARIANO EZEQUIEL', 1, CAST(0xFD150B00 AS Date), 6, N'CAPITAN MARTINEZ', N'48', NULL, NULL, 4, N'1167666867', N'44632938', N'GONZA.CARP@GMAIL.COM', CAST(0x0000A995011BAF46 AS DateTime), 1, CAST(0x0000A995011BAF46 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (52, N'34755757', N'GONZALEZ', N'MARIANO EZEQUIEL', 1, CAST(0xFD150B00 AS Date), 6, N'CAPITAN MARTINEZ', N'48', NULL, NULL, 4, N'1167666867', N'44632938', N'GONZA.CARP@GMAIL.COM', CAST(0x0000A995011BDC81 AS DateTime), 1, CAST(0x0000A995011BDC81 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (53, N'32433218', N'BALESTRELLI', N'JUAN IGNACIO', 1, CAST(0x06010B00 AS Date), 16, N'CABILDO', N'141', NULL, NULL, 16, NULL, NULL, NULL, CAST(0x0000A99501201E7A AS DateTime), 1, CAST(0x0000A99501201E7A AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (54, N'20466859', N'MARTORELL', N'ANDRES', 1, CAST(0x29DD0A00 AS Date), 2, N'CONIGLIO', N'4658', N'10', N'5', 10, N'1468759133', NULL, NULL, CAST(0x0000A99501215657 AS DateTime), 1, CAST(0x0000A99501215657 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (55, N'12355545', N'LA VENCIDA', N'LA TERCERA', 0, CAST(0xF03E0B00 AS Date), 5, N'ASFLN321', N'321', NULL, NULL, 3, NULL, NULL, NULL, CAST(0x0000A9950122AAD5 AS DateTime), 1, CAST(0x0000A9950122AAD5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (56, N'12354456', N'ASKN', N'LKANSV', 0, CAST(0xF03E0B00 AS Date), 3, N'ASLFKN', N'3515', NULL, NULL, 3, NULL, NULL, N'321351', CAST(0x0000A995012351F6 AS DateTime), 1, CAST(0x0000A995012351F6 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (57, N'32151351', N'ASKJFN', N'LJFNSLAF', 2, CAST(0xF03E0B00 AS Date), 6, N'ASFLKN', N'32165', NULL, NULL, 2, NULL, NULL, NULL, CAST(0x0000A9950128498F AS DateTime), 1, CAST(0x0000A9950128498F AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (58, N'3215133', N'SEISDEDOS', N'LORENA', 2, CAST(0xA0160B00 AS Date), 1, N'MONTEAGUDO', N'537', NULL, NULL, 1, NULL, N'02320446326', N'LORE.6DDOS@LIVE.COM.AR', CAST(0x0000A9950128BBE1 AS DateTime), 1, CAST(0x0000A9950128BBE1 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (59, N'14241621', N'SALVATIERRA', N'PRISCILA', 2, CAST(0x16140B00 AS Date), 6, N'HIPOLITO YRIGOYEN', N'3468', N'1', N'A', 4, NULL, NULL, N'SALVATIERRA.PRIS@OUTLOOK.COM', CAST(0x0000A995012A6ABD AS DateTime), 1, CAST(0x0000A995012A6ABD AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (60, N'321351', N'MARITATO', N'GONZALO', 1, CAST(0x6B240B00 AS Date), 1, N'CONSTITUCION', N'102', NULL, NULL, 1, N'1164858974', NULL, NULL, CAST(0x0000A995012B36FF AS DateTime), 1, CAST(0x0000A995012B36FF AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (61, N'42542665', N'LOBOS', N'LULU', 0, CAST(0xF33E0B00 AS Date), 1, N'SAN LORENZO', N'4459', NULL, NULL, 3, NULL, NULL, NULL, CAST(0x0000A99C00B78C8A AS DateTime), 1, CAST(0x0000A99C00B78C8A AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Personas] OFF
/****** Object:  Table [dbo].[Profesionales]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesionales](
	[IdProfesional] [int] NOT NULL,
	[IdPersona] [int] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdminAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdminModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdminBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Profesionales] PRIMARY KEY CLUSTERED 
(
	[IdProfesional] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (2, 2, CAST(0x0000A99C01234A38 AS DateTime), 1, CAST(0x0000A99C01234A38 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (26, 26, CAST(0x0000A99C00C126B0 AS DateTime), 1, CAST(0x0000A99C00C12C24 AS DateTime), 1, CAST(0x0000A99C00C12C24 AS DateTime), 1, 0)
/****** Object:  Table [dbo].[Pacientes]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[IdPaciente] [int] NOT NULL,
	[IdPersona] [int] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdminAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdminModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdminBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[IdPaciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (1, 1, CAST(0x0000A86200000000 AS DateTime), 1, CAST(0x0000A99A012B795A AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (2, 2, CAST(0x0000A99C01235485 AS DateTime), 1, CAST(0x0000A99C01235485 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (5, 5, CAST(0x0000A99A0129A1B7 AS DateTime), 1, CAST(0x0000A99A0129A3F3 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (19, 19, CAST(0x0000A995002C691A AS DateTime), 1, CAST(0x0000A995002C691A AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (26, 26, CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99C00C12E87 AS DateTime), 1, CAST(0x0000A99C00C12E87 AS DateTime), 1, 0)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (27, 27, CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99A016802E5 AS DateTime), 1, CAST(0x0000A99A0167FD7B AS DateTime), 1, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (28, 28, CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99000000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (57, 57, CAST(0x0000A99501284993 AS DateTime), 1, CAST(0x0000A99501284993 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (58, 58, CAST(0x0000A9950128BBE5 AS DateTime), 1, CAST(0x0000A9950128BBE5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (60, 60, CAST(0x0000A995012B3BD3 AS DateTime), 1, CAST(0x0000A995012B3BD3 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (61, 61, CAST(0x0000A99C00B78C94 AS DateTime), 1, CAST(0x0000A99C00BD1E31 AS DateTime), 1, CAST(0x0000A99C00BD1089 AS DateTime), 1, 1)
/****** Object:  Table [dbo].[Administrativos]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrativos](
	[IdAdmin] [int] NOT NULL,
	[IdPersona] [int] NOT NULL,
	[IdCargo] [int] NOT NULL,
	[Sector] [varchar](50) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdminAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdminModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[idAdminBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Administrativos] PRIMARY KEY CLUSTERED 
(
	[IdAdmin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (1, 1, 2, N'ADMINISTRADOR', CAST(0x0000A99A00000000 AS DateTime), 1, CAST(0x0000A99A00000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (2, 2, 4, N'KINESIOLOGIA', CAST(0x0000A99C00BCE021 AS DateTime), 1, CAST(0x0000A99C01236EB4 AS DateTime), 1, CAST(0x0000A99C01235709 AS DateTime), 1, 1)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (19, 19, 2, N'CLINICA', CAST(0x0000A99A00000000 AS DateTime), 1, CAST(0x0000A99C00C7BACC AS DateTime), 1, CAST(0x0000A99C00C77928 AS DateTime), 1, 0)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (26, 26, 1, N'PROGRAMADOR', CAST(0x0000A99A0156790A AS DateTime), 1, CAST(0x0000A99C00C74FB8 AS DateTime), 1, CAST(0x0000A99C00C29CE7 AS DateTime), 1, 1)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (27, 27, 2, N'VENTAS', CAST(0x0000A99A0167744A AS DateTime), 1, CAST(0x0000A99A016977AC AS DateTime), 1, CAST(0x0000A99A016977AC AS DateTime), 1, 0)
/****** Object:  Table [dbo].[HistoriaClinica]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoriaClinica](
	[IdHistoriaClinica] [int] IDENTITY(1,1) NOT NULL,
	[IdRazonSocial] [int] NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[NumAfiliado] [varchar](50) NOT NULL,
	[FechaVtoCarnet] [datetime] NULL,
	[Motivo] [varchar](50) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdmAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdmModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdmBaja] [int] NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_HistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[IdHistoriaClinica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HistoriaClinica] ON
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (4, 4, 27, N'123456789', CAST(0x0000A9C700000000 AS DateTime), N'CONSULTA', CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99000000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (5, 12, 28, N'12315151', CAST(0x0000AAA500000000 AS DateTime), N'CUADRO GRIPAL', CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99000000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (6, 2, 26, N'0-35755757-3', CAST(0x0000A9B200000000 AS DateTime), N'DOLOR DE MUELA', CAST(0x0000A994014727C4 AS DateTime), 1, CAST(0x0000A994014727C4 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (7, 2, 26, N'0-35755757-3', CAST(0x0000A9B200000000 AS DateTime), N'PRESION ALTA', CAST(0x0000A99401470BA7 AS DateTime), 1, CAST(0x0000A99401470BA7 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (8, 2, 28, N'000', CAST(0x0000A9CE00000000 AS DateTime), N'SCSSA', CAST(0x0000A9940142A8FF AS DateTime), 1, CAST(0x0000A9940142A8FF AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (9, 3, 26, N'321351', CAST(0x0000A99400000000 AS DateTime), N'DERMATITIS', CAST(0x0000A9940142F9FF AS DateTime), 1, CAST(0x0000A99401649358 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (10, 3, 26, N'32165', CAST(0x0000A99400000000 AS DateTime), N'TRAUMATISMO DE RODILLA', CAST(0x0000A99401431D3C AS DateTime), 1, CAST(0x0000A994016451D7 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [Estado]) VALUES (12, 12, 26, N'123454646', CAST(0x0000AB1500000000 AS DateTime), N'ESTRES', CAST(0x0000A99C00BCA250 AS DateTime), 1, CAST(0x0000A99C00BCA250 AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[HistoriaClinica] OFF
/****** Object:  Table [dbo].[EspecialidadXProf]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EspecialidadXProf](
	[IdExP] [int] IDENTITY(1,1) NOT NULL,
	[IdProfesional] [int] NOT NULL,
	[IdEspecialidad] [int] NOT NULL,
	[MatriculaNac] [varchar](20) NULL,
	[VtoMatNac] [datetime] NULL,
	[MatriculaProv] [varchar](20) NULL,
	[VtoMatProv] [datetime] NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdminAlta] [int] NOT NULL,
	[FechaModif] [datetime] NOT NULL,
	[IdAdminModif] [int] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdminBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_EspecialidadXProf] PRIMARY KEY CLUSTERED 
(
	[IdProfesional] ASC,
	[IdEspecialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[EspecialidadXProf] ON
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (1, 2, 4, NULL, NULL, NULL, NULL, CAST(0x0000A99C0124E5AF AS DateTime), 1, CAST(0x0000A99C0124E5AF AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[EspecialidadXProf] OFF
/****** Object:  Table [dbo].[Turnos]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[IdTurno] [int] IDENTITY(1,1) NOT NULL,
	[IdProfesional] [int] NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[IdHistoriaClinica] [int] NOT NULL,
	[FechaHoraTurno] [datetime] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdAdminAlta] [int] NOT NULL,
	[FechaLiberacion] [datetime] NULL,
	[IdAdminLibera] [int] NULL,
	[FechaCancelado] [datetime] NULL,
	[IdAdminCancela] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED 
(
	[IdTurno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evoluciones]    Script Date: 11/18/2018 18:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evoluciones](
	[IdEvolucion] [int] IDENTITY(1,1) NOT NULL,
	[IdPersona] [int] NOT NULL,
	[IdProfesional] [int] NULL,
	[IdAdmin] [int] NULL,
	[IdHistoriaClinica] [int] NOT NULL,
	[IdTurno] [int] NULL,
	[Evolucion] [varchar](100) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[FechaModif] [datetime] NULL,
	[IdAdminModif] [int] NULL,
	[FechaBaja] [datetime] NULL,
	[IdAdminBaja] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Evoluciones] PRIMARY KEY CLUSTERED 
(
	[IdEvolucion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Provincias_Paises]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Provincias]  WITH CHECK ADD  CONSTRAINT [FK_Provincias_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Provincias] CHECK CONSTRAINT [FK_Provincias_Paises]
GO
/****** Object:  ForeignKey [FK_Partidos_Provincias]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Partidos]  WITH CHECK ADD  CONSTRAINT [FK_Partidos_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Partidos] CHECK CONSTRAINT [FK_Partidos_Provincias]
GO
/****** Object:  ForeignKey [FK_Municipio_Partidos]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Municipios]  WITH CHECK ADD  CONSTRAINT [FK_Municipio_Partidos] FOREIGN KEY([IdPartido])
REFERENCES [dbo].[Partidos] ([IdPartido])
GO
ALTER TABLE [dbo].[Municipios] CHECK CONSTRAINT [FK_Municipio_Partidos]
GO
/****** Object:  ForeignKey [FK_Personas_Municipios]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Municipios] FOREIGN KEY([IdMunicipio])
REFERENCES [dbo].[Municipios] ([IdMunicipio])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Municipios]
GO
/****** Object:  ForeignKey [FK_Profesionales_Personas1]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Profesionales]  WITH CHECK ADD  CONSTRAINT [FK_Profesionales_Personas1] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Profesionales] CHECK CONSTRAINT [FK_Profesionales_Personas1]
GO
/****** Object:  ForeignKey [FK_Pacientes_Personas1]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Personas1] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Personas1]
GO
/****** Object:  ForeignKey [FK_Administrativos_Personas]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Administrativos]  WITH CHECK ADD  CONSTRAINT [FK_Administrativos_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Administrativos] CHECK CONSTRAINT [FK_Administrativos_Personas]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_Pacientes]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Pacientes] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Pacientes]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_RazonesSociales]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_RazonesSociales] FOREIGN KEY([IdRazonSocial])
REFERENCES [dbo].[RazonesSociales] ([IdRazonSocial])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_RazonesSociales]
GO
/****** Object:  ForeignKey [FK_EspecialidadXProf_Especialidades]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[EspecialidadXProf]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadXProf_Especialidades] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[Especialidades] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[EspecialidadXProf] CHECK CONSTRAINT [FK_EspecialidadXProf_Especialidades]
GO
/****** Object:  ForeignKey [FK_EspecialidadXProf_Profesionales]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[EspecialidadXProf]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadXProf_Profesionales] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesionales] ([IdProfesional])
GO
ALTER TABLE [dbo].[EspecialidadXProf] CHECK CONSTRAINT [FK_EspecialidadXProf_Profesionales]
GO
/****** Object:  ForeignKey [FK_Turnos_HistoriaClinica]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_HistoriaClinica] FOREIGN KEY([IdHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([IdHistoriaClinica])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_Turnos_Pacientes]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Pacientes] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Pacientes]
GO
/****** Object:  ForeignKey [FK_Turnos_Profesionales]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Profesionales] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesionales] ([IdProfesional])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Profesionales]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Administrativos]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Administrativos] FOREIGN KEY([IdAdmin])
REFERENCES [dbo].[Administrativos] ([IdAdmin])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Administrativos]
GO
/****** Object:  ForeignKey [FK_Evoluciones_HistoriaClinica]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_HistoriaClinica] FOREIGN KEY([IdHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([IdHistoriaClinica])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Personas]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Personas]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Profesionales]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Profesionales] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesionales] ([IdProfesional])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Profesionales]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Turnos]    Script Date: 11/18/2018 18:56:23 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Turnos] FOREIGN KEY([IdTurno])
REFERENCES [dbo].[Turnos] ([IdTurno])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Turnos]
GO
