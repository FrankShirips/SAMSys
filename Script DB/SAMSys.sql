USE [SAMSys]
GO
/****** Object:  Table [dbo].[Cat_CuentasBanc]    Script Date: 1/8/2020 04:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cat_CuentasBanc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[N_Empl] [varchar](6) NOT NULL,
	[N_Cuenta_Bancaria] [int] NULL,
	[Nombre] [varchar](80) NULL,
	[C_or_USD] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cat_DeducionesClinic]    Script Date: 1/8/2020 04:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cat_DeducionesClinic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[N_Empl] [varchar](6) NOT NULL,
	[Proyecto] [varchar](50) NULL,
	[N_Factura] [varchar](50) NULL,
	[Nombre] [varchar](80) NULL,
	[MontoCordobas] [decimal](9, 2) NULL,
	[Concepto] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cat_DeducionesHerrEPP]    Script Date: 1/8/2020 04:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cat_DeducionesHerrEPP](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[N_Empl] [varchar](6) NULL,
	[Proyecto] [varchar](50) NULL,
	[Monto] [decimal](9, 2) NULL,
	[Nombre] [varchar](80) NULL,
	[Fecha] [datetime] NULL,
	[Concepto] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cat_VacacionesOPermisos]    Script Date: 1/8/2020 04:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cat_VacacionesOPermisos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Empleado] [varchar](10) NULL,
	[fechaIni] [datetime] NULL,
	[fechaFin] [datetime] NULL,
	[ConceptoOTipo] [int] NULL,
	[Duracion] [int] NULL,
	[TipoDuracion] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[Usuario] [int] NULL,
	[Equipo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConceptoOTipo]    Script Date: 1/8/2020 04:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConceptoOTipo](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Dat_ImpuestoSobreLaRenta]    Script Date: 1/8/2020 04:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Dat_ImpuestoSobreLaRenta](
	[nCodAño] [int] NULL,
	[fFechaInicia] [datetime] NULL,
	[fFechaFinal] [datetime] NULL,
	[nMinimo] [numeric](18, 2) NULL,
	[nMaximo] [numeric](18, 2) NULL,
	[nPorcAplica] [numeric](18, 2) NULL,
	[nImpuestoBase] [numeric](18, 2) NULL,
	[nSobreExceso] [numeric](18, 2) NULL,
	[fFechaRegistro] [datetime] NULL,
	[cEquipoRegistra] [varchar](300) NULL,
	[nUsuarioRegistra] [int] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDuracion]    Script Date: 1/8/2020 04:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDuracion](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cat_DeducionesClinic] ON 

INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1005, CAST(N'2020-07-04 00:00:00.000' AS DateTime), N'dgugfu', N'vgxch', N'vjscghvs', N'vsfvdf', CAST(90000.00 AS Decimal(9, 2)), N'Todos tenemos sueños y se lograran tarde io temprano')
INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1006, CAST(N'2020-07-10 00:00:00.000' AS DateTime), N' vbvhg', N'vhgvhvh', N'njhbjh', N'Twecea', CAST(30000.22 AS Decimal(9, 2)), N'Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó u')
INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1007, CAST(N'2020-07-09 00:00:00.000' AS DateTime), N'vhvh', N'nbjbjb54', N' bjvjh', N'Cuarta', CAST(50000.00 AS Decimal(9, 2)), N'Es un hecho establecido hace demasiado tiempo que un lector se distraerá con el contenido del texto de un sitio mientras que mira su diseño. El punto de usar Lorem Ipsum es que tiene una distribución más o menos normal de las letras, al contrario de usar ')
INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1008, CAST(N'2020-07-08 00:00:00.000' AS DateTime), N'kjkj', N'bjhvjh', N' cg cg', N'Quintra', CAST(40000.00 AS Decimal(9, 2)), N'Al contrario del pensamiento popular, el texto de Lorem Ipsum no es simplemente texto aleatorio. Tiene sus raices en una pieza cl´sica de la literatura del Latin, que data del año 45 antes de Cristo, haciendo que este adquiera mas de 2000 años de antigued')
INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1009, CAST(N'2020-07-07 00:00:00.000' AS DateTime), N'fcgf', N' vhhh', N'lml', N'Sexta', CAST(48465.00 AS Decimal(9, 2)), N'El trozo de texto estándar de Lorem Ipsum usado desde el año 1500 es reproducido debajo para aquellos interesados. Las secciones 1.10.32 y 1.10.33 de "de Finibus Bonorum et Malorum" por Cicero son también reproducidas en su forma original exacta, acompaña')
INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1010, CAST(N'2020-07-06 00:00:00.000' AS DateTime), N'nkjn', N'bjbjhbjh', N' g cf', N'Setjm a', CAST(55458.00 AS Decimal(9, 2)), N'Hay muchas variaciones de los pasajes de Lorem Ipsum disponibles, pero la mayoría sufrió alteraciones en alguna manera, ya sea porque se le agregó humor, o palabras aleatorias que no parecen ni un poco creíbles. Si vas a utilizar un pasaje de Lorem Ipsum,')
INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1011, CAST(N'2020-07-05 00:00:00.000' AS DateTime), N'nkhkj', N' hvvhg', N'hchgcf', N'Obtaba', CAST(55565.00 AS Decimal(9, 2)), N'Todos los generadores de Lorem Ipsum que se encuentran en Internet tienden a repetir trozos predefinidos cuando sea necesario, haciendo a este el único generador verdadero (válido) en la Internet. Usa un diccionario de mas de 200 palabras provenientes del')
INSERT [dbo].[Cat_DeducionesClinic] ([Id], [Fecha], [N_Empl], [Proyecto], [N_Factura], [Nombre], [MontoCordobas], [Concepto]) VALUES (1012, CAST(N'2020-07-28 00:00:00.000' AS DateTime), N'NEMPL', N'PROYECTO1', N'FACTURA1', N'NOMBRE DE PRUEBA', CAST(10000.00 AS Decimal(9, 2)), N'ESTE ES UN CONCEPTO')
SET IDENTITY_INSERT [dbo].[Cat_DeducionesClinic] OFF
SET IDENTITY_INSERT [dbo].[Cat_DeducionesHerrEPP] ON 

INSERT [dbo].[Cat_DeducionesHerrEPP] ([Id], [N_Empl], [Proyecto], [Monto], [Nombre], [Fecha], [Concepto]) VALUES (1004, N'BHBH', N'YGY', CAST(526.14 AS Decimal(9, 2)), N'Jorge', CAST(N'2020-07-28 00:00:00.000' AS DateTime), N'HYGYUGGUGUY')
INSERT [dbo].[Cat_DeducionesHerrEPP] ([Id], [N_Empl], [Proyecto], [Monto], [Nombre], [Fecha], [Concepto]) VALUES (1005, N'FGDF', N'RHRTHR', CAST(8963.25 AS Decimal(9, 2)), N'RWERW', CAST(N'2020-07-27 00:00:00.000' AS DateTime), N'FFGDFFFFFFFFFFFFFFFFFFFFFFFFF')
INSERT [dbo].[Cat_DeducionesHerrEPP] ([Id], [N_Empl], [Proyecto], [Monto], [Nombre], [Fecha], [Concepto]) VALUES (1006, N'EMPLEA', N'ESTE PROYECTO', CAST(256.25 AS Decimal(9, 2)), N'ESTE NOMBRE', CAST(N'2020-07-28 00:00:00.000' AS DateTime), N'ESTE CONCEPTO')
INSERT [dbo].[Cat_DeducionesHerrEPP] ([Id], [N_Empl], [Proyecto], [Monto], [Nombre], [Fecha], [Concepto]) VALUES (1007, N'sam85', N'NEW', CAST(526.14 AS Decimal(9, 2)), N'Jorge', CAST(N'2020-07-07 00:00:00.000' AS DateTime), N'ESTE ES UN CONCEPTO')
INSERT [dbo].[Cat_DeducionesHerrEPP] ([Id], [N_Empl], [Proyecto], [Monto], [Nombre], [Fecha], [Concepto]) VALUES (1008, N'sam85', N'NEW', CAST(526.14 AS Decimal(9, 2)), N'Jorge', CAST(N'2020-07-04 00:00:00.000' AS DateTime), N'dgfdfdfnhtytegre')
SET IDENTITY_INSERT [dbo].[Cat_DeducionesHerrEPP] OFF
SET IDENTITY_INSERT [dbo].[Cat_VacacionesOPermisos] ON 

INSERT [dbo].[Cat_VacacionesOPermisos] ([Id], [Empleado], [fechaIni], [fechaFin], [ConceptoOTipo], [Duracion], [TipoDuracion], [FechaRegistro], [Usuario], [Equipo]) VALUES (1, N'N23015', CAST(N'2020-08-01 00:00:00.000' AS DateTime), CAST(N'2020-07-20 00:00:00.000' AS DateTime), 6, 3, 1, CAST(N'2020-08-01 14:02:44.270' AS DateTime), 1, N'DESKTOP-JGV78E0')
INSERT [dbo].[Cat_VacacionesOPermisos] ([Id], [Empleado], [fechaIni], [fechaFin], [ConceptoOTipo], [Duracion], [TipoDuracion], [FechaRegistro], [Usuario], [Equipo]) VALUES (1002, N'N070290', CAST(N'2020-08-01 00:00:00.000' AS DateTime), CAST(N'2020-08-01 00:00:00.000' AS DateTime), 3, 1, 2, CAST(N'2020-08-01 13:36:14.027' AS DateTime), 1, N'DESKTOP-JGV78E0')
SET IDENTITY_INSERT [dbo].[Cat_VacacionesOPermisos] OFF
INSERT [dbo].[ConceptoOTipo] ([Id], [Descripcion]) VALUES (1, N'Vacaciones descansadas')
INSERT [dbo].[ConceptoOTipo] ([Id], [Descripcion]) VALUES (2, N'Vacaciones Pagadas')
INSERT [dbo].[ConceptoOTipo] ([Id], [Descripcion]) VALUES (3, N'Permiso sin goce de salario')
INSERT [dbo].[ConceptoOTipo] ([Id], [Descripcion]) VALUES (4, N'Permiso con goce de salario')
INSERT [dbo].[ConceptoOTipo] ([Id], [Descripcion]) VALUES (5, N'Subsidio por enfermedad comun')
INSERT [dbo].[ConceptoOTipo] ([Id], [Descripcion]) VALUES (6, N'Subsidio por accidente laboral')
INSERT [dbo].[ConceptoOTipo] ([Id], [Descripcion]) VALUES (7, N'Suspension')
SET IDENTITY_INSERT [dbo].[Tbl_Dat_ImpuestoSobreLaRenta] ON 

INSERT [dbo].[Tbl_Dat_ImpuestoSobreLaRenta] ([nCodAño], [fFechaInicia], [fFechaFinal], [nMinimo], [nMaximo], [nPorcAplica], [nImpuestoBase], [nSobreExceso], [fFechaRegistro], [cEquipoRegistra], [nUsuarioRegistra], [Id]) VALUES (2020, CAST(N'2020-08-01 00:00:00.000' AS DateTime), CAST(N'2020-08-01 00:00:00.000' AS DateTime), CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(N'2020-08-01 15:59:25.470' AS DateTime), N'DESKTOP-JGV78E0', 1, 1)
SET IDENTITY_INSERT [dbo].[Tbl_Dat_ImpuestoSobreLaRenta] OFF
INSERT [dbo].[TipoDuracion] ([Id], [Descripcion]) VALUES (1, N'Hora')
INSERT [dbo].[TipoDuracion] ([Id], [Descripcion]) VALUES (2, N'Dia')
/****** Object:  Index [Tbl_Dat_ImpuestoSobreLaRenta_pk]    Script Date: 1/8/2020 04:40:05 ******/
ALTER TABLE [dbo].[Tbl_Dat_ImpuestoSobreLaRenta] ADD  CONSTRAINT [Tbl_Dat_ImpuestoSobreLaRenta_pk] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
