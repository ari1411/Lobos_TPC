USE [LOBOS_DB]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 11/30/2018 03:36:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estados](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
 CONSTRAINT [PK_EstadoTurno] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (1, N'CANCELADO')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (2, N'DISPONIBLE')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (3, N'ASIGNADO')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (4, N'LIBERADO')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (5, N'ELIMINADO')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (6, N'ADMITIDO')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (7, N'REALIZADO')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (8, N'ALTA')
INSERT [dbo].[Estados] ([idEstado], [Estado]) VALUES (9, N'ACTIVO')
SET IDENTITY_INSERT [dbo].[Estados] OFF
/****** Object:  Table [dbo].[Especialidades]    Script Date: 11/30/2018 03:36:46 ******/
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
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (5, N'MEDICINA LABORAL', CAST(0x0000A99D0058EB82 AS DateTime), 1, CAST(0x0000A99D0058EB82 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (6, N'GUARDIA CLINICA', CAST(0x0000A99D0059C7BF AS DateTime), 1, CAST(0x0000A99D0059C7BF AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (7, N'CIRUGIA PLASTICA', CAST(0x0000A99D005A40D9 AS DateTime), 1, CAST(0x0000A99D005A40D9 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (8, N'CIRUGIA GENERAL', CAST(0x0000A99D005A603B AS DateTime), 1, CAST(0x0000A99D005A603B AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (9, N'PSICOLOGIA', CAST(0x0000A99D005AC4C3 AS DateTime), 1, CAST(0x0000A99D005AC4C3 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Especialidad], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (10, N'RADIOLOGIA', CAST(0x0000A9A30142C98D AS DateTime), 1, CAST(0x0000A9A30142C98D AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
/****** Object:  Table [dbo].[Cargos]    Script Date: 11/30/2018 03:36:46 ******/
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
/****** Object:  Table [dbo].[Paises]    Script Date: 11/30/2018 03:36:46 ******/
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
/****** Object:  Table [dbo].[Sexo]    Script Date: 11/30/2018 03:36:46 ******/
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
/****** Object:  Table [dbo].[RazonesSociales]    Script Date: 11/30/2018 03:36:46 ******/
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
/****** Object:  Table [dbo].[Provincias]    Script Date: 11/30/2018 03:36:46 ******/
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
/****** Object:  View [dbo].[VW_ESPECIALIDADES_MEDICAS]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VISTA ESPECIALIDADES MEDICAS
CREATE view [dbo].[VW_ESPECIALIDADES_MEDICAS] as select top 100 IdEspecialidad, Especialidad from Especialidades where Estado=1 order by Especialidad asc
GO
/****** Object:  View [dbo].[VW_CARGOS]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PARA DEVOLVER EL ID
--SELECT CAST(scope_identity() AS int)

--CONSULTA CARGOS
CREATE view [dbo].[VW_CARGOS] as select top 1000 c.IdCargo, c.Cargo from Cargos as c where c.Estado=1 order by c.Cargo asc
GO
/****** Object:  View [dbo].[VW_PAISES]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_PAISES] AS SELECT top 1000 P.IDPAIS, P.NACIONALIDAD FROM Paises AS P ORDER BY NACIONALIDAD ASC
GO
/****** Object:  View [dbo].[VW_NACIONALIDAD]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VISTA NACIONALIDAD
CREATE VIEW [dbo].[VW_NACIONALIDAD] AS SELECT top 1000 P.IDPAIS, P.NACIONALIDAD FROM Paises AS P where p.Estado=1 ORDER BY NACIONALIDAD ASC
GO
/****** Object:  View [dbo].[vw_RazonSocial]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VISTA RAZON SOCIAL
CREATE view [dbo].[vw_RazonSocial] as select top 1000 idrazonsocial, RazonSocialPlan + ' [' + CUIT + ']' as 'Nombre' from RazonesSociales where Estado=1 order by RazonSocialPlan asc
GO
/****** Object:  View [dbo].[VW_PROVINCIAS]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VISTA PROVINCIAS
CREATE VIEW [dbo].[VW_PROVINCIAS] AS SELECT TOP 1000 P.IDPROVINCIA, P.PROVINCIA + ' - ' + PA.PAIS AS 'PROVINCIAS' FROM Provincias AS P inner join Paises AS PA ON P.IdPais=PA.IdPais where p.Estado=1 ORDER BY P.Provincia ASC
GO
/****** Object:  Table [dbo].[Partidos]    Script Date: 11/30/2018 03:36:46 ******/
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
/****** Object:  Table [dbo].[Municipios]    Script Date: 11/30/2018 03:36:46 ******/
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
/****** Object:  View [dbo].[VW_PARTIDOS]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VISTA PARTIDOS
CREATE VIEW [dbo].[VW_PARTIDOS] AS SELECT TOP 1000 P.IDPARTIDO, P.PARTIDO + ' - ' + PR.PROVINCIA + ' - ' + PA.PAIS AS 'PARTIDOS' FROM Partidos AS P inner join Provincias AS PR ON P.IdProvincia=PR.IdProvincia inner join Paises AS PA ON PR.IdPais=PA.IdPais where p.Estado=1 ORDER BY P.Partido ASC
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 11/30/2018 03:36:46 ******/
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
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (22, N'22222222', N'LORENTE', N'GUADALUPE', 2, CAST(0x63080B00 AS Date), 2, N'ALGUNA CALLE', N'1234', NULL, NULL, 5, N'12315', N'21561', N'ASFJNAS23135', CAST(0x0000901A00000000 AS DateTime), 1, CAST(0x0000A99D005AA4A4 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (24, N'11121111', N'ALBERTOTTI', N'JUAN CARLOS', 1, CAST(0x29010B00 AS Date), 6, N'OLAVARRIA', N'4167', NULL, NULL, 9, NULL, NULL, N'JC_ALBERTOTTI@LIVE.COM.AR', CAST(0x0000A986016CBB8C AS DateTime), 1, CAST(0x0000A9A30143C369 AS DateTime), 1, NULL, NULL, 1)
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
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (62, N'32128654', N'LOBOS', N'KIARA', 2, CAST(0x43390B00 AS Date), 1, N'CALDERON DE LA BARCA', N'4024', NULL, NULL, 1, NULL, N'1163068805', NULL, CAST(0x0000A9A300CCF122 AS DateTime), 1, CAST(0x0000A9A300CCF122 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Personas] ([IdPersona], [DNI], [Apellido], [Nombre], [IdSexo], [FechaNac], [IdNacionalidad], [Calle], [Numero], [Piso], [Depto], [IdMunicipio], [TelCelular], [TelFijo], [Mail], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (63, N'24687594', N'MAGALLANES', N'LAURA', 2, CAST(0xBA000B00 AS Date), 2, N'JORGE NEWBERY', N'1126', N'10', N'B', 5, NULL, NULL, N'LAURA_MAGALLANES@YAHOO.COM.AR', CAST(0x0000A9A300CE3C0D AS DateTime), 1, CAST(0x0000A9A300CE3C0D AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Personas] OFF
/****** Object:  View [dbo].[VW_MUNICIPIOS]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VISTA MUNICIPIOS
CREATE VIEW [dbo].[VW_MUNICIPIOS] AS SELECT TOP 1000 M.IDMUNICIPIO, '('+M.CP+') '+M.Municipio+' - '+P.PARTIDO+' - '+PR.PROVINCIA AS 'MUNICIPIOS' FROM Municipios AS M inner join PARTIDOS AS P ON M.IDPARTIDO=P.IDPARTIDO inner join PROVINCIAS AS PR ON P.IDPROVINCIA=PR.IDPROVINCIA where m.Estado=1 ORDER BY M.Municipio ASC, PR.Provincia ASC, P.Partido ASC, M.CP ASC
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 11/30/2018 03:36:46 ******/
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
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (26, 26, CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A9A10125A757 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (27, 27, CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99A016802E5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (28, 28, CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99000000000 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (32, 32, CAST(0x0000A9A3014693A3 AS DateTime), 1, CAST(0x0000A9A3014693A3 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (57, 57, CAST(0x0000A99501284993 AS DateTime), 1, CAST(0x0000A99501284993 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (58, 58, CAST(0x0000A9950128BBE5 AS DateTime), 1, CAST(0x0000A9950128BBE5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (60, 60, CAST(0x0000A995012B3BD3 AS DateTime), 1, CAST(0x0000A995012B3BD3 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (61, 61, CAST(0x0000A99C00B78C94 AS DateTime), 1, CAST(0x0000A99C00BD1E31 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Pacientes] ([IdPaciente], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (62, 62, CAST(0x0000A9A300CCF122 AS DateTime), 1, CAST(0x0000A9A300CCF122 AS DateTime), 1, NULL, NULL, 1)
/****** Object:  Table [dbo].[Administrativos]    Script Date: 11/30/2018 03:36:46 ******/
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
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (1, 1, 3, N'CLINICA', CAST(0x0000A99A00000000 AS DateTime), 1, CAST(0x0000A9A301430805 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (2, 2, 4, N'KINESIOLOGIA', CAST(0x0000A99C00BCE021 AS DateTime), 1, CAST(0x0000A99C0146DB14 AS DateTime), 1, CAST(0x0000A99C0146B9A9 AS DateTime), 1, 1)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (19, 19, 2, N'CLINICA', CAST(0x0000A99A00000000 AS DateTime), 1, CAST(0x0000A99C00C7BACC AS DateTime), 1, CAST(0x0000A99C00C77928 AS DateTime), 1, 0)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (26, 26, 1, N'PROGRAMADOR', CAST(0x0000A99A0156790A AS DateTime), 1, CAST(0x0000A99C00C74FB8 AS DateTime), 1, CAST(0x0000A99C00C29CE7 AS DateTime), 1, 1)
INSERT [dbo].[Administrativos] ([IdAdmin], [IdPersona], [IdCargo], [Sector], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [idAdminBaja], [Estado]) VALUES (27, 27, 2, N'VENTAS', CAST(0x0000A99A0167744A AS DateTime), 1, CAST(0x0000A99A016977AC AS DateTime), 1, CAST(0x0000A99A016977AC AS DateTime), 1, 0)
/****** Object:  Table [dbo].[Profesionales]    Script Date: 11/30/2018 03:36:46 ******/
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
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (1, 1, CAST(0x0000A9A30142E3C4 AS DateTime), 1, CAST(0x0000A9A30142EEF7 AS DateTime), 1, CAST(0x0000A9A30142EEF7 AS DateTime), 1, 0)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (2, 2, CAST(0x0000A99C01234A38 AS DateTime), 1, CAST(0x0000A99C0146BA5B AS DateTime), 1, CAST(0x0000A99C0146BA5B AS DateTime), 1, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (3, 3, CAST(0x0000A99D005722FA AS DateTime), 1, CAST(0x0000A99D005722FA AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (14, 14, CAST(0x0000A9A30142BC66 AS DateTime), 1, CAST(0x0000A9A30142BC66 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (15, 15, CAST(0x0000A99D0059AE91 AS DateTime), 1, CAST(0x0000A99D0059AE91 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (22, 22, CAST(0x0000A99D005ABAAF AS DateTime), 1, CAST(0x0000A99D005ABAAF AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (24, 24, CAST(0x0000A9A30143CD4D AS DateTime), 1, CAST(0x0000A9A30143CD4D AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (26, 26, CAST(0x0000A99C00C126B0 AS DateTime), 1, CAST(0x0000A9A1015DD0FD AS DateTime), 1, CAST(0x0000A9A1015DD0FD AS DateTime), 1, 0)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (53, 53, CAST(0x0000A99D005A2F44 AS DateTime), 1, CAST(0x0000A99D005A2F44 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (54, 54, CAST(0x0000A99D005A521D AS DateTime), 1, CAST(0x0000A99D005A521D AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[Profesionales] ([IdProfesional], [IdPersona], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (63, 63, CAST(0x0000A9A300CE5705 AS DateTime), 1, CAST(0x0000A9A300CE5705 AS DateTime), 1, NULL, NULL, 1)
/****** Object:  Table [dbo].[HistoriaClinica]    Script Date: 11/30/2018 03:36:46 ******/
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
	[IdEstado] [int] NOT NULL,
 CONSTRAINT [PK_HistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[IdHistoriaClinica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HistoriaClinica] ON
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (4, 4, 27, N'123456789', CAST(0x0000A9C700000000 AS DateTime), N'CONSULTA', CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99000000000 AS DateTime), 1, NULL, NULL, 9)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (5, 12, 28, N'12315151', CAST(0x0000AAA500000000 AS DateTime), N'CUADRO GRIPAL', CAST(0x0000A99000000000 AS DateTime), 1, CAST(0x0000A99000000000 AS DateTime), 1, NULL, NULL, 9)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (6, 2, 26, N'0-35755757-3', CAST(0x0000A9B200000000 AS DateTime), N'DOLOR DE MUELA', CAST(0x0000A994014727C4 AS DateTime), 1, CAST(0x0000A994014727C4 AS DateTime), 1, NULL, NULL, 9)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (7, 2, 26, N'0-35755757-3', CAST(0x0000A9B200000000 AS DateTime), N'PRESION ALTA', CAST(0x0000A99401470BA7 AS DateTime), 1, CAST(0x0000A99401470BA7 AS DateTime), 1, NULL, NULL, 9)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (8, 2, 28, N'000', CAST(0x0000A9CE00000000 AS DateTime), N'SCSSA', CAST(0x0000A9940142A8FF AS DateTime), 1, CAST(0x0000A9940142A8FF AS DateTime), 1, NULL, NULL, 9)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (9, 3, 26, N'321351', CAST(0x0000A99400000000 AS DateTime), N'DERMATITIS', CAST(0x0000A9940142F9FF AS DateTime), 1, CAST(0x0000A99401649358 AS DateTime), 1, NULL, NULL, 9)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (10, 3, 26, N'32165', CAST(0x0000A99400000000 AS DateTime), N'TRAUMATISMO DE RODILLA', CAST(0x0000A99401431D3C AS DateTime), 1, CAST(0x0000A994016451D7 AS DateTime), 1, NULL, NULL, 9)
INSERT [dbo].[HistoriaClinica] ([IdHistoriaClinica], [IdRazonSocial], [IdPaciente], [NumAfiliado], [FechaVtoCarnet], [Motivo], [FechaAlta], [IdAdmAlta], [FechaModif], [IdAdmModif], [FechaBaja], [IdAdmBaja], [IdEstado]) VALUES (12, 12, 26, N'123454646', CAST(0x0000AB1500000000 AS DateTime), N'ESTRES', CAST(0x0000A99C00BCA250 AS DateTime), 1, CAST(0x0000A99C00BCA250 AS DateTime), 1, NULL, NULL, 9)
SET IDENTITY_INSERT [dbo].[HistoriaClinica] OFF
/****** Object:  View [dbo].[VW_PROFESIONALES]    Script Date: 11/30/2018 03:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_PROFESIONALES] as select top 1000 p.IdProfesional, per.Apellido + ', ' + per.Nombre as 'Apellido y Nombre' from Profesionales as p inner join Personas as per on p.IdPersona=per.IdPersona where p.Estado=1 and per.Estado=1 order by per.Apellido asc, per.Nombre asc, p.IdProfesional asc
GO
/****** Object:  Table [dbo].[EspecialidadXProf]    Script Date: 11/30/2018 03:36:46 ******/
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
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (4, 2, 1, N'142563', CAST(0x0000A9A800000000 AS DateTime), N'3211123', CAST(0x0000A9A700000000 AS DateTime), CAST(0x0000A99D0031E510 AS DateTime), 1, CAST(0x0000A9A30142A706 AS DateTime), 1, CAST(0x0000A9A30142A706 AS DateTime), 1, 0)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (5, 2, 2, N'123123', CAST(0x0000A9A800000000 AS DateTime), N'321321', CAST(0x0000A9A700000000 AS DateTime), CAST(0x0000A99D0048C804 AS DateTime), 1, CAST(0x0000A9A30142A93A AS DateTime), 1, CAST(0x0000A9A30142A93A AS DateTime), 1, 0)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (13, 2, 3, N'54', CAST(0x0000A99D00000000 AS DateTime), NULL, NULL, CAST(0x0000A99D00506DBA AS DateTime), 1, CAST(0x0000A9A30142A481 AS DateTime), 1, CAST(0x0000A9A30142A481 AS DateTime), 1, 0)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (1, 2, 4, NULL, NULL, NULL, NULL, CAST(0x0000A99C0124E5AF AS DateTime), 1, CAST(0x0000A99D004A9FF8 AS DateTime), 1, CAST(0x0000A99D0044E268 AS DateTime), 1, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (16, 3, 1, N'01-3215-12', CAST(0x0000ABCB00000000 AS DateTime), N'321-1153', CAST(0x0000A9F400000000 AS DateTime), CAST(0x0000A99D00576D8E AS DateTime), 1, CAST(0x0000A99D00576D8E AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (17, 3, 5, N'10-3510', CAST(0x0000A99D00000000 AS DateTime), NULL, NULL, CAST(0x0000A99D00599CA5 AS DateTime), 1, CAST(0x0000A99D00599CA5 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (23, 14, 10, NULL, NULL, NULL, NULL, CAST(0x0000A9A30142D5CC AS DateTime), 1, CAST(0x0000A9A30142D5CC AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (18, 15, 6, NULL, NULL, NULL, NULL, CAST(0x0000A99D0059DB24 AS DateTime), 1, CAST(0x0000A99D0059DB24 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (21, 22, 9, NULL, NULL, NULL, NULL, CAST(0x0000A99D005ACC18 AS DateTime), 1, CAST(0x0000A99D005ACC18 AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (25, 24, 1, NULL, NULL, NULL, NULL, CAST(0x0000A9A30143DCBA AS DateTime), 1, CAST(0x0000A9A30143DCBA AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (24, 24, 7, NULL, NULL, NULL, NULL, CAST(0x0000A9A30143D55E AS DateTime), 1, CAST(0x0000A9A30143D55E AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (19, 53, 7, NULL, NULL, NULL, NULL, CAST(0x0000A99D005A49BC AS DateTime), 1, CAST(0x0000A99D005A49BC AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (20, 54, 8, NULL, NULL, NULL, NULL, CAST(0x0000A99D005A639D AS DateTime), 1, CAST(0x0000A99D005A639D AS DateTime), 1, NULL, NULL, 1)
INSERT [dbo].[EspecialidadXProf] ([IdExP], [IdProfesional], [IdEspecialidad], [MatriculaNac], [VtoMatNac], [MatriculaProv], [VtoMatProv], [FechaAlta], [IdAdminAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (22, 63, 8, N'32-103213543215/01', CAST(0x0000AB0500000000 AS DateTime), N'32-103213543215/02', CAST(0x0000AB0500000000 AS DateTime), CAST(0x0000A9A300CE9D80 AS DateTime), 1, CAST(0x0000A9A300CE9D80 AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[EspecialidadXProf] OFF
/****** Object:  Table [dbo].[Turnos]    Script Date: 11/30/2018 03:36:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Turnos](
	[IdTurno] [int] IDENTITY(1,1) NOT NULL,
	[FechaHoraTurno] [datetime] NOT NULL,
	[IdProfesional] [int] NOT NULL,
	[IdEspecialidad] [int] NOT NULL,
	[IdPaciente] [int] NULL,
	[IdHistoriaClinica] [int] NULL,
	[Observaciones] [varchar](100) NULL,
	[FechaAsignado] [datetime] NULL,
	[IdAdminAsigna] [int] NULL,
	[FechaAdmitido] [datetime] NULL,
	[IdAdminAdmitio] [int] NULL,
	[FechaLiberacion] [datetime] NULL,
	[IdAdminLibera] [int] NULL,
	[FechaCancelado] [datetime] NULL,
	[IdAdminCancela] [int] NULL,
	[IdEstado] [int] NOT NULL,
 CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED 
(
	[IdTurno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Turnos] ON
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (1, CAST(0x0000A9A200735B40 AS DateTime), 22, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (2, CAST(0x0000A9A20083D600 AS DateTime), 22, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (3, CAST(0x0000A9A2009450C0 AS DateTime), 22, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (4, CAST(0x0000A9A200A4CB80 AS DateTime), 22, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (5, CAST(0x0000A9A200B54640 AS DateTime), 22, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (6, CAST(0x0000A9A400D63BC0 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (7, CAST(0x0000A9A400E6B680 AS DateTime), 2, 4, 26, 9, NULL, CAST(0x0000A9A30135D2F8 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (8, CAST(0x0000A9A400F73140 AS DateTime), 2, 4, 27, 4, NULL, CAST(0x0000A9A301369701 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (9, CAST(0x0000A9A40107AC00 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (10, CAST(0x0000A9A4011826C0 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (11, CAST(0x0000A9A40128A180 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (12, CAST(0x0000A9A500D63BC0 AS DateTime), 2, 4, 27, 4, N'MUCHO DOLOR DE CABEZA LUEGO DE UN GOLPE MUY FUERTE', CAST(0x0000A9A50155C04B AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (13, CAST(0x0000A9A500E6B680 AS DateTime), 2, 4, 26, 12, N'CERVICALGIA', CAST(0x0000A9A5015514F0 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (14, CAST(0x0000A9A500F73140 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (15, CAST(0x0000A9A50107AC00 AS DateTime), 2, 4, 26, 12, N'LUMBALGIA', CAST(0x0000A9A501553457 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (16, CAST(0x0000A9A5011826C0 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (17, CAST(0x0000A9A50128A180 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (19, CAST(0x0000A9A300C5C100 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (20, CAST(0x0000A9A300D63BC0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (21, CAST(0x0000A9A300E6B680 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (22, CAST(0x0000A9A300C5C100 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (23, CAST(0x0000A9A300D63BC0 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (24, CAST(0x0000A9A300E6B680 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (25, CAST(0x0000A9A300F73140 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (26, CAST(0x0000A9A30107AC00 AS DateTime), 2, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (27, CAST(0x0000A9A3011826C0 AS DateTime), 2, 4, 26, 9, NULL, CAST(0x0000A9A30146F8B1 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (28, CAST(0x0000A9A300C5C100 AS DateTime), 53, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (29, CAST(0x0000A9A300D63BC0 AS DateTime), 53, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (30, CAST(0x0000A9A300E6B680 AS DateTime), 53, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (31, CAST(0x0000A9A300F73140 AS DateTime), 53, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (32, CAST(0x0000A9A30107AC00 AS DateTime), 53, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (33, CAST(0x0000A9A3011826C0 AS DateTime), 53, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (34, CAST(0x0000A9A301391C40 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (35, CAST(0x0000A9A301499700 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (36, CAST(0x0000A9A3015A11C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (37, CAST(0x0000A9A3016A8C80 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (38, CAST(0x0000A9A3017B0740 AS DateTime), 15, 6, 27, 4, N'Consulta + justificativo medico', CAST(0x0000A9A30162E174 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (39, CAST(0x0000A9A400000000 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (40, CAST(0x0000A9A400107AC0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (41, CAST(0x0000A9A40020F580 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (42, CAST(0x0000A9A400317040 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (43, CAST(0x0000A9A40041EB00 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (44, CAST(0x0000A9A4005265C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (45, CAST(0x0000A9A40062E080 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (46, CAST(0x0000A9A400735B40 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (47, CAST(0x0000A9A40083D600 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (48, CAST(0x0000A9A4009450C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (49, CAST(0x0000A9A400A4CB80 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (50, CAST(0x0000A9A400B54640 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (51, CAST(0x0000A9A400C5C100 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (52, CAST(0x0000A9A400D63BC0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (53, CAST(0x0000A9A400E6B680 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (54, CAST(0x0000A9A400F73140 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (55, CAST(0x0000A9A40107AC00 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (56, CAST(0x0000A9A4011826C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (57, CAST(0x0000A9A40128A180 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (58, CAST(0x0000A9A300C5C100 AS DateTime), 24, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (59, CAST(0x0000A9A500C5C100 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (60, CAST(0x0000A9A500D63BC0 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (61, CAST(0x0000A9A500E6B680 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (62, CAST(0x0000A9A500F73140 AS DateTime), 24, 1, 28, 8, N'SADJKNFKDV', CAST(0x0000A9A501567ABD AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (63, CAST(0x0000A9A50107AC00 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (64, CAST(0x0000A9A5011826C0 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (65, CAST(0x0000A9A50128A180 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (66, CAST(0x0000A9A501391C40 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (67, CAST(0x0000A9A501499700 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (68, CAST(0x0000A9A5015A11C0 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (69, CAST(0x0000A9A5016A8C80 AS DateTime), 24, 1, 28, 8, N'GRIPE', CAST(0x0000A9A5015BA25B AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (70, CAST(0x0000A9A600C5C100 AS DateTime), 15, 6, 26, 12, N'ADMITIDO', CAST(0x0000A9A60168174A AS DateTime), 1, CAST(0x0000A9A601684A8A AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (71, CAST(0x0000A9A600D63BC0 AS DateTime), 15, 6, 26, 12, N'CANCELADO', CAST(0x0000A9A601683E9C AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(0x0000A9A6016852B4 AS DateTime), 1, 1)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (72, CAST(0x0000A9A600E6B680 AS DateTime), 15, 6, 26, 10, N'KK', CAST(0x0000A9A60168AFFF AS DateTime), 1, NULL, NULL, CAST(0x0000A9A6016859B4 AS DateTime), 1, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (73, CAST(0x0000A9A600F73140 AS DateTime), 15, 6, 26, 12, N'FIEBRE', CAST(0x0000A9A6015427BA AS DateTime), 1, CAST(0x0000A9A601543121 AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (74, CAST(0x0000A9A60107AC00 AS DateTime), 15, 6, 27, 4, N' ', CAST(0x0000A9A60146F4BD AS DateTime), 1, CAST(0x0000A9A601514590 AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (75, CAST(0x0000A9A6011826C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (76, CAST(0x0000A9A60128A180 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (77, CAST(0x0000A9A601391C40 AS DateTime), 15, 6, 28, 8, N'XCV ', CAST(0x0000A9A60153D70E AS DateTime), 1, CAST(0x0000A9A60153F22A AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (78, CAST(0x0000A9A601499700 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (79, CAST(0x0000A9A6015A11C0 AS DateTime), 15, 6, 28, 8, N'321', CAST(0x0000A9A60153A020 AS DateTime), 1, CAST(0x0000A9A60153AF6B AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (80, CAST(0x0000A9A6016A8C80 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (81, CAST(0x0000A9A6017B0740 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000A9A6016519EC AS DateTime), 1, NULL, NULL, 4)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (82, CAST(0x0000A9A700000000 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (83, CAST(0x0000A9A700107AC0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (84, CAST(0x0000A9A70020F580 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (85, CAST(0x0000A9A700317040 AS DateTime), 15, 6, 27, 4, N'S', CAST(0x0000A9A701231D61 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (86, CAST(0x0000A9A70041EB00 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (87, CAST(0x0000A9A7005265C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (88, CAST(0x0000A9A70062E080 AS DateTime), 15, 6, 26, 12, N'1ER PRUEBA', CAST(0x0000A9A70123B536 AS DateTime), 1, CAST(0x0000A9A70124B884 AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (89, CAST(0x0000A9A700735B40 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (90, CAST(0x0000A9A70083D600 AS DateTime), 15, 6, 26, 9, N'PRESION BAJA', CAST(0x0000A9A701232F24 AS DateTime), 1, CAST(0x0000A9A70124DD5F AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (91, CAST(0x0000A9A7009450C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (92, CAST(0x0000A9A700A4CB80 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (93, CAST(0x0000A9A700B54640 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (94, CAST(0x0000A9A700C5C100 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (95, CAST(0x0000A9A700D63BC0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (96, CAST(0x0000A9A700E6B680 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (97, CAST(0x0000A9A700F73140 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (98, CAST(0x0000A9A70107AC00 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (99, CAST(0x0000A9A7011826C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (100, CAST(0x0000A9A70128A180 AS DateTime), 15, 6, 28, 8, N'CHIQUI', CAST(0x0000A9A7012300FB AS DateTime), 1, CAST(0x0000A9A70124CA74 AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (101, CAST(0x0000A9A701391C40 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
GO
print 'Processed 100 total records'
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (102, CAST(0x0000A9A701499700 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (103, CAST(0x0000A9A7015A11C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (104, CAST(0x0000A9A7016A8C80 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (105, CAST(0x0000A9A7017B0740 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (106, CAST(0x0000A9A800000000 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (107, CAST(0x0000A9A800107AC0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (108, CAST(0x0000A9A80020F580 AS DateTime), 15, 6, 26, 12, N'FIEBRE', CAST(0x0000A9A80003AE03 AS DateTime), 1, CAST(0x0000A9A80003BD2A AS DateTime), 1, NULL, NULL, NULL, NULL, 7)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (109, CAST(0x0000A9A800317040 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (110, CAST(0x0000A9A80041EB00 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (111, CAST(0x0000A9A8005265C0 AS DateTime), 15, 6, 27, 4, N'xq si', CAST(0x0000A9A8000BB9F5 AS DateTime), 1, CAST(0x0000A9A8000BC436 AS DateTime), 1, NULL, NULL, CAST(0x0000A9A8000C9AB7 AS DateTime), NULL, 1)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (112, CAST(0x0000A9A80062E080 AS DateTime), 15, 6, 26, 9, N'DOLOR EN EL PIE IZQUIERDO', CAST(0x0000A9A80021B391 AS DateTime), 1, CAST(0x0000A9A80021C67B AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (113, CAST(0x0000A9A800735B40 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (114, CAST(0x0000A9A80083D600 AS DateTime), 15, 6, 28, 8, N'TOS', CAST(0x0000A9A8002110F5 AS DateTime), 1, CAST(0x0000A9A800211BA0 AS DateTime), 1, NULL, NULL, NULL, NULL, 7)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (115, CAST(0x0000A9A8009450C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (116, CAST(0x0000A9A800A4CB80 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (117, CAST(0x0000A9A800B54640 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (118, CAST(0x0000A9A800C5C100 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (119, CAST(0x0000A9A800D63BC0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (120, CAST(0x0000A9A800E6B680 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (121, CAST(0x0000A9A800F73140 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (122, CAST(0x0000A9A80107AC00 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (123, CAST(0x0000A9A8011826C0 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (124, CAST(0x0000A9A80128A180 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (125, CAST(0x0000A9A801391C40 AS DateTime), 15, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (126, CAST(0x0000A9A700A4CB80 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (127, CAST(0x0000A9A700B54640 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (128, CAST(0x0000A9A700C5C100 AS DateTime), 24, 1, 27, 4, N'S', CAST(0x0000A9A701242EB4 AS DateTime), 1, CAST(0x0000A9A7012528BB AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (129, CAST(0x0000A9A700D63BC0 AS DateTime), 24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (130, CAST(0x0000A9A700E6B680 AS DateTime), 24, 1, 26, 12, N'HOLA
', CAST(0x0000A9A701255DCD AS DateTime), 1, CAST(0x0000A9A70125670D AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (131, CAST(0x0000A9A7009450C0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (132, CAST(0x0000A9A700A4CB80 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (133, CAST(0x0000A9A700B54640 AS DateTime), 14, 10, 26, 7, N'2DO', CAST(0x0000A9A70124A268 AS DateTime), 1, CAST(0x0000A9A70124C218 AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (134, CAST(0x0000A9A700C5C100 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (135, CAST(0x0000A9A700D63BC0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (136, CAST(0x0000A9A700E6B680 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (137, CAST(0x0000A9A700F73140 AS DateTime), 14, 10, 26, 12, N'FX CODO', CAST(0x0000A9A701241596 AS DateTime), 1, CAST(0x0000A9A70124D2E7 AS DateTime), 1, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (138, CAST(0x0000A9A70107AC00 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (139, CAST(0x0000A9A7011826C0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (140, CAST(0x0000A9A70128A180 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (141, CAST(0x0000A9A701391C40 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (142, CAST(0x0000A9A701499700 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (143, CAST(0x0000A9A7015A11C0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (144, CAST(0x0000A9A7016A8C80 AS DateTime), 14, 10, 27, 4, N'S', CAST(0x0000A9A701248617 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (145, CAST(0x0000A9A7017B0740 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (146, CAST(0x0000A9A800000000 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (147, CAST(0x0000A9A800107AC0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (148, CAST(0x0000A9A80020F580 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (149, CAST(0x0000A9A800317040 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (150, CAST(0x0000A9A80041EB00 AS DateTime), 14, 10, 26, 12, N'RX TORAX', CAST(0x0000A9A800054479 AS DateTime), 1, CAST(0x0000A9A8000549A0 AS DateTime), 1, NULL, NULL, NULL, NULL, 7)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (151, CAST(0x0000A9A8005265C0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (152, CAST(0x0000A9A80062E080 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (153, CAST(0x0000A9A800735B40 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (154, CAST(0x0000A9A80083D600 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (155, CAST(0x0000A9A8009450C0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (156, CAST(0x0000A9A800A4CB80 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (157, CAST(0x0000A9A800B54640 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (158, CAST(0x0000A9A800C5C100 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (159, CAST(0x0000A9A800D63BC0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (160, CAST(0x0000A9A800E6B680 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (161, CAST(0x0000A9A800F73140 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (162, CAST(0x0000A9A80107AC00 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (163, CAST(0x0000A9A8011826C0 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (164, CAST(0x0000A9A80128A180 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Turnos] ([IdTurno], [FechaHoraTurno], [IdProfesional], [IdEspecialidad], [IdPaciente], [IdHistoriaClinica], [Observaciones], [FechaAsignado], [IdAdminAsigna], [FechaAdmitido], [IdAdminAdmitio], [FechaLiberacion], [IdAdminLibera], [FechaCancelado], [IdAdminCancela], [IdEstado]) VALUES (165, CAST(0x0000A9A801391C40 AS DateTime), 14, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[Turnos] OFF
/****** Object:  Table [dbo].[Evoluciones]    Script Date: 11/30/2018 03:36:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evoluciones](
	[IdEvolucion] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[IdAdmin] [int] NULL,
	[IdProfesional] [int] NULL,
	[IdEspecialidad] [int] NULL,
	[IdHistoriaClinica] [int] NOT NULL,
	[IdTurno] [int] NOT NULL,
	[Evolucion] [varchar](500) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[Evoluciones] ON
INSERT [dbo].[Evoluciones] ([IdEvolucion], [IdPaciente], [IdAdmin], [IdProfesional], [IdEspecialidad], [IdHistoriaClinica], [IdTurno], [Evolucion], [FechaAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (1, 26, NULL, 15, 6, 8, 79, N'paciente sano, solo queria molestar', CAST(0x0000A9A70161DDE6 AS DateTime), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Evoluciones] ([IdEvolucion], [IdPaciente], [IdAdmin], [IdProfesional], [IdEspecialidad], [IdHistoriaClinica], [IdTurno], [Evolucion], [FechaAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (3, 26, NULL, 24, 1, 12, 130, N'se sugiere ic con psiquiatra', CAST(0x0000A9A701845354 AS DateTime), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Evoluciones] ([IdEvolucion], [IdPaciente], [IdAdmin], [IdProfesional], [IdEspecialidad], [IdHistoriaClinica], [IdTurno], [Evolucion], [FechaAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (4, 26, NULL, 15, 6, 12, 108, N'presenta 38,5° se indica reposo y analgesicos', CAST(0x0000A9A8000407B8 AS DateTime), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Evoluciones] ([IdEvolucion], [IdPaciente], [IdAdmin], [IdProfesional], [IdEspecialidad], [IdHistoriaClinica], [IdTurno], [Evolucion], [FechaAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (5, 26, NULL, 14, 10, 12, 150, N'fx costilla', CAST(0x0000A9A80005721F AS DateTime), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Evoluciones] ([IdEvolucion], [IdPaciente], [IdAdmin], [IdProfesional], [IdEspecialidad], [IdHistoriaClinica], [IdTurno], [Evolucion], [FechaAlta], [FechaModif], [IdAdminModif], [FechaBaja], [IdAdminBaja], [Estado]) VALUES (6, 28, NULL, 15, 6, 8, 114, N'LEVE TOS, INDICO NEBULIZACIONES', CAST(0x0000A9A800217E09 AS DateTime), NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Evoluciones] OFF
/****** Object:  ForeignKey [FK_Administrativos_Cargos]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Administrativos]  WITH CHECK ADD  CONSTRAINT [FK_Administrativos_Cargos] FOREIGN KEY([IdCargo])
REFERENCES [dbo].[Cargos] ([IdCargo])
GO
ALTER TABLE [dbo].[Administrativos] CHECK CONSTRAINT [FK_Administrativos_Cargos]
GO
/****** Object:  ForeignKey [FK_Administrativos_Personas]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Administrativos]  WITH CHECK ADD  CONSTRAINT [FK_Administrativos_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Administrativos] CHECK CONSTRAINT [FK_Administrativos_Personas]
GO
/****** Object:  ForeignKey [FK_EspecialidadXProf_Especialidades]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[EspecialidadXProf]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadXProf_Especialidades] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[Especialidades] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[EspecialidadXProf] CHECK CONSTRAINT [FK_EspecialidadXProf_Especialidades]
GO
/****** Object:  ForeignKey [FK_EspecialidadXProf_Profesionales]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[EspecialidadXProf]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadXProf_Profesionales] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesionales] ([IdProfesional])
GO
ALTER TABLE [dbo].[EspecialidadXProf] CHECK CONSTRAINT [FK_EspecialidadXProf_Profesionales]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Administrativos]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Administrativos] FOREIGN KEY([IdAdmin])
REFERENCES [dbo].[Administrativos] ([IdAdmin])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Administrativos]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Especialidades]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Especialidades] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[Especialidades] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Especialidades]
GO
/****** Object:  ForeignKey [FK_Evoluciones_HistoriaClinica]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_HistoriaClinica] FOREIGN KEY([IdHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([IdHistoriaClinica])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Pacientes]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Pacientes] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Pacientes]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Profesionales]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Profesionales] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesionales] ([IdProfesional])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Profesionales]
GO
/****** Object:  ForeignKey [FK_Evoluciones_Turnos]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Evoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Evoluciones_Turnos] FOREIGN KEY([IdTurno])
REFERENCES [dbo].[Turnos] ([IdTurno])
GO
ALTER TABLE [dbo].[Evoluciones] CHECK CONSTRAINT [FK_Evoluciones_Turnos]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_Pacientes]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Pacientes] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Pacientes]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_RazonesSociales]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_RazonesSociales] FOREIGN KEY([IdRazonSocial])
REFERENCES [dbo].[RazonesSociales] ([IdRazonSocial])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_RazonesSociales]
GO
/****** Object:  ForeignKey [FK_Municipio_Partidos]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Municipios]  WITH CHECK ADD  CONSTRAINT [FK_Municipio_Partidos] FOREIGN KEY([IdPartido])
REFERENCES [dbo].[Partidos] ([IdPartido])
GO
ALTER TABLE [dbo].[Municipios] CHECK CONSTRAINT [FK_Municipio_Partidos]
GO
/****** Object:  ForeignKey [FK_Pacientes_Personas1]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Personas1] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Personas1]
GO
/****** Object:  ForeignKey [FK_Partidos_Provincias]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Partidos]  WITH CHECK ADD  CONSTRAINT [FK_Partidos_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Partidos] CHECK CONSTRAINT [FK_Partidos_Provincias]
GO
/****** Object:  ForeignKey [FK_Personas_Municipios]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Municipios] FOREIGN KEY([IdMunicipio])
REFERENCES [dbo].[Municipios] ([IdMunicipio])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Municipios]
GO
/****** Object:  ForeignKey [FK_Personas_Sexo]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Sexo] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[Sexo] ([Idsexo])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Sexo]
GO
/****** Object:  ForeignKey [FK_Profesionales_Personas1]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Profesionales]  WITH CHECK ADD  CONSTRAINT [FK_Profesionales_Personas1] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Profesionales] CHECK CONSTRAINT [FK_Profesionales_Personas1]
GO
/****** Object:  ForeignKey [FK_Provincias_Paises]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Provincias]  WITH CHECK ADD  CONSTRAINT [FK_Provincias_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Provincias] CHECK CONSTRAINT [FK_Provincias_Paises]
GO
/****** Object:  ForeignKey [FK_Turnos_Especialidades]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Especialidades] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[Especialidades] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Especialidades]
GO
/****** Object:  ForeignKey [FK_Turnos_EstadoTurno]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_EstadoTurno] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estados] ([idEstado])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_EstadoTurno]
GO
/****** Object:  ForeignKey [FK_Turnos_HistoriaClinica]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_HistoriaClinica] FOREIGN KEY([IdHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([IdHistoriaClinica])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_Turnos_Pacientes]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Pacientes] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Pacientes]
GO
/****** Object:  ForeignKey [FK_Turnos_Profesionales]    Script Date: 11/30/2018 03:36:46 ******/
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Profesionales] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesionales] ([IdProfesional])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Profesionales]
GO
