USE [DBControlActivos]
GO
/****** Object:  UserDefinedFunction [dbo].[ContarActivosPorClasificacion]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ContarActivosPorClasificacion](
@IdClasificaion nvarchar(10)
)
RETURNS INT
AS
BEGIN
	DECLARE @Resultado INT;
	SELECT 
		@Resultado = COUNT(ac.id_activo)
	FROM tb_activos ac
	INNER JOIN tb_categorias_activos ct ON ac.id_categoria_ac = ct.id_categoria_ct
	INNER JOIN tb_clasificacion_activos cl ON ac.id_clasificacion_ac = cl.id_clasificacion_ca
	WHERE cl.id_clasificacion_ca = @IdClasificaion;

	RETURN @Resultado;
END
GO
/****** Object:  UserDefinedFunction [dbo].[FN_ObtenerUltimoIDActivos]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_ObtenerUltimoIDActivos]()
RETURNS INT
AS 
BEGIN
	DECLARE @UltimoID INT

	SELECT TOP 1 @UltimoID = ac.id_activo FROM tb_activos ac
	ORDER BY ac.id_activo DESC

	RETURN @UltimoID
END
GO
/****** Object:  UserDefinedFunction [dbo].[FN_ObtenerUltimoIDDepreciaciones]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_ObtenerUltimoIDDepreciaciones]()
RETURNS INT
AS 
BEGIN
	DECLARE @UltimoID INT

	SELECT TOP 1 @UltimoID = da.id_depreciacion_activo FROM tb_depreciacion_activos da
	ORDER BY da.id_depreciacion_activo DESC

	RETURN @UltimoID
END
GO
/****** Object:  UserDefinedFunction [dbo].[FN_ObtenerUltimoIDOperarios]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_ObtenerUltimoIDOperarios]()
RETURNS INT
AS 
BEGIN
    DECLARE @UltimoID INT

    SELECT TOP 1 @UltimoID = da.id_operario FROM tb_operarios da
    ORDER BY da.id_operario DESC

    RETURN @UltimoID
END
GO
/****** Object:  UserDefinedFunction [dbo].[FN_ObtenerUltimoIDUsuarios]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_ObtenerUltimoIDUsuarios]()
RETURNS INT
AS 
BEGIN
	DECLARE @UltimoID INT

	SELECT TOP 1 @UltimoID = id_usuario FROM tb_usuarios
	ORDER BY id_usuario DESC

	RETURN @UltimoID
END
GO
/****** Object:  Table [dbo].[tb_clasificacion_activos]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_clasificacion_activos](
	[id_clasificacion_ca] [varchar](10) NOT NULL,
	[nombre_clasificacion_ca] [nvarchar](50) NULL,
	[anios_vida_util_ca] [int] NOT NULL,
	[porcentaje_anual_ca] [decimal](3, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_clasificacion_ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_activos]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_activos](
	[id_activo] [varchar](10) NOT NULL,
	[id_clasificacion_ac] [varchar](10) NOT NULL,
	[id_categoria_ac] [varchar](10) NOT NULL,
	[codigo_interno_ac] [varchar](1010) NULL,
	[fecha_registro_ac] [date] NOT NULL,
	[nombre_activo] [nvarchar](100) NOT NULL,
	[fecha_compra_ac] [date] NOT NULL,
	[valor_activo] [decimal](10, 2) NOT NULL,
	[fecha_alta_ac] [date] NULL,
	[id_operario_ac] [varchar](10) NULL,
	[usuario_registro_ac] [varchar](10) NULL,
	[id_ubicacion_ac] [varchar](10) NULL,
	[observaciones_ac] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_activo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_depreciacion_activos]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_depreciacion_activos](
	[id_depreciacion_activo] [varchar](10) NOT NULL,
	[id_activo_da] [varchar](10) NOT NULL,
	[id_clasificacion_da] [varchar](10) NOT NULL,
	[anios_vida_util_da] [int] NOT NULL,
	[porcentaje_anual_da] [decimal](3, 2) NOT NULL,
	[valor_activo_da] [decimal](10, 2) NOT NULL,
	[valor_residual_da] [decimal](10, 2) NOT NULL,
	[id_ubicacion_da] [varchar](10) NOT NULL,
	[anio_compra_da] [int] NOT NULL,
	[ultimo_anio_da] [int] NOT NULL,
	[usuario_registro_da] [nvarchar](15) NOT NULL,
	[estado_da] [tinyint] NOT NULL,
	[fecha_registro_da] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_depreciacion_activo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Depreciacion_Activos]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Depreciacion_Activos] AS
SELECT 
	da.id_depreciacion_activo AS 'ID Depreciación',
	da.fecha_registro_da AS 'Fecha de Registro',
	da.id_activo_da AS 'ID Activo',
	ac.nombre_activo AS 'Nombre del activo',
	cl.nombre_clasificacion_ca AS 'Clasificación',
	da.usuario_registro_da AS 'Registrado por',
	CASE
		WHEN da.estado_da = 1 THEN 'Activo'
		WHEN da.estado_da = 2 THEN 'Depreciado'
		WHEN da.estado_da = 3 THEN 'Obsoleto'
	END As 'Estado del activo'
FROM tb_depreciacion_activos da
INNER JOIN tb_activos ac ON da.id_activo_da = ac.id_activo
INNER JOIN tb_clasificacion_activos cl ON da.id_clasificacion_da = cl.id_clasificacion_ca;
GO
/****** Object:  View [dbo].[V_Clasificaciones_Activos]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_Clasificaciones_Activos] AS
SELECT
	cl.id_clasificacion_ca AS 'ID Clasificación',
	cl.nombre_clasificacion_ca AS 'Nombre de la clasificación',
	cl.anios_vida_util_ca AS 'Años de vida util',
	(cl.porcentaje_anual_ca * 100) AS 'Porcentaje Anual'
FROM tb_clasificacion_activos cl;
GO
/****** Object:  Table [dbo].[tb_roles]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre_rol] [nvarchar](50) NOT NULL,
	[descripcion_rol] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_usuarios]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuarios](
	[id_usuario] [varchar](10) NOT NULL,
	[fecha_registro_us] [date] NOT NULL,
	[nombre_usuario] [nvarchar](50) NOT NULL,
	[apellidos_usuario] [nvarchar](50) NOT NULL,
	[usuario_login] [nvarchar](15) NOT NULL,
	[contrasenia_usuario] [nvarchar](15) NOT NULL,
	[email_usuario] [nvarchar](50) NULL,
	[rol_usuario] [int] NOT NULL,
	[estado_usuario] [bit] NOT NULL,
	[ultima_actualizacion_us] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Usuarios]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Usuarios] AS
SELECT 
	us.id_usuario AS 'ID Usuario',
	us.fecha_registro_us AS 'Fecha Registro',
	us.nombre_usuario AS 'Nombres',
	us.apellidos_usuario AS 'Apellidos',
	us.email_usuario AS 'Email',
	r.nombre_rol As 'Nombre Rol',
		CASE
		WHEN us.estado_usuario = 1 THEN 'Activo'
		WHEN us.estado_usuario = 0 THEN 'Inactivo'
	END As 'Estado'
FROM tb_usuarios us
INNER JOIN tb_roles r ON us.rol_usuario = r.id_rol
GO
/****** Object:  Table [dbo].[tb_categorias_activos]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_categorias_activos](
	[id_categoria_ct] [varchar](10) NOT NULL,
	[id_clasificacion_ct] [varchar](10) NOT NULL,
	[fecha_registro_ct] [date] NOT NULL,
	[nombre_categoria] [nvarchar](50) NOT NULL,
	[usuario_registro] [nvarchar](15) NOT NULL,
	[descripcion_categoria] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria_ct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_empresa]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[fecha_registro_em] [date] NOT NULL,
	[nombre_empresa] [nvarchar](100) NOT NULL,
	[nit_empresa] [varchar](14) NOT NULL,
	[nrc_empresa] [varchar](12) NULL,
	[direccion_empresa] [nvarchar](150) NULL,
	[telefono_empresa] [nvarchar](12) NULL,
	[correo_empresa] [nvarchar](50) NULL,
	[logo_empresa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_operarios]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_operarios](
	[id_operario] [varchar](10) NOT NULL,
	[fecha_registro_op] [date] NOT NULL,
	[nombre_operario] [nvarchar](50) NOT NULL,
	[cargo_operario] [nvarchar](20) NULL,
	[estado_operario] [bit] NOT NULL,
	[descripcion_operario] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_operario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ubicaciones]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ubicaciones](
	[id_ubicacion] [varchar](10) NOT NULL,
	[fecha_registro_ub] [date] NOT NULL,
	[nombre_ubicacion] [nvarchar](100) NOT NULL,
	[estado_ubicacion] [bit] NOT NULL,
	[usuario_registro_ub] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ubicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000001', N'0000000003', N'0000000001', N'Eq - 0001', CAST(N'2024-05-20' AS Date), N'Isuzu Trucks NPR 4.0 Toneladas', CAST(N'2022-03-28' AS Date), CAST(36000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000003', N'Jose03', N'0000000003', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000002', N'0000000003', N'0000000001', N'Eq - 0002', CAST(N'2024-05-20' AS Date), N'Hino 300 Series Duto Express 6.0 Toneladas', CAST(N'2022-03-28' AS Date), CAST(46000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000003', N'Jose03', N'0000000003', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000003', N'0000000003', N'0000000001', N'Eq - 0003', CAST(N'2024-05-20' AS Date), N'Hino 300 Series Duto Pro 2.0 Toneladas', CAST(N'2022-03-28' AS Date), CAST(29500.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000003', N'Jose03', N'0000000003', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000004', N'0000000003', N'0000000001', N'Eq - 0004', CAST(N'2024-05-20' AS Date), N'Hino 300 Series Duto Pack 4.0 Toneladas', CAST(N'2022-03-28' AS Date), CAST(33000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000003', N'Jose03', N'0000000003', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000005', N'0000000003', N'0000000002', N'Eq - 0005', CAST(N'2024-05-20' AS Date), N'Ford Transit Van XL - Oxford White  - 2019', CAST(N'2022-03-28' AS Date), CAST(28000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000003', N'Jose03', N'0000000003', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000006', N'0000000003', N'0000000002', N'Eq - 0006', CAST(N'2024-05-20' AS Date), N'Mercedes-Benz Sprinter Van 2 Toneladas', CAST(N'2022-03-28' AS Date), CAST(25000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000003', N'Jose03', N'0000000003', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000007', N'0000000004', N'0000000003', N'PC - 0001', CAST(N'2024-05-20' AS Date), N'Computador DELL OptiPlex MFF i3-13100T', CAST(N'2022-04-02' AS Date), CAST(500.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000001', N'Jose03', N'0000000002', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000008', N'0000000004', N'0000000003', N'PC - 0002', CAST(N'2024-05-20' AS Date), N'Computador DELL OptiPlex MFF i3-13100T', CAST(N'2022-04-02' AS Date), CAST(500.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000001', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000009', N'0000000004', N'0000000003', N'PC - 0003', CAST(N'2024-05-20' AS Date), N'Computador DELL OptiPlex MFF i3-13100T', CAST(N'2022-04-02' AS Date), CAST(500.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000001', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000010', N'0000000004', N'0000000004', N'LP - 0001', CAST(N'2024-05-20' AS Date), N'Laptop Dell Inspiron 3520 i3-1215U', CAST(N'2022-04-02' AS Date), CAST(650.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000001', N'Jose03', N'0000000002', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000011', N'0000000004', N'0000000004', N'LP - 0002', CAST(N'2024-05-20' AS Date), N'Laptop Dell Inspiron 3520 i3-1215U', CAST(N'2022-04-02' AS Date), CAST(650.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000001', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000012', N'0000000004', N'0000000004', N'LP - 0003', CAST(N'2024-05-20' AS Date), N'Laptop Dell Inspiron 3520 i3-1215U', CAST(N'2022-04-02' AS Date), CAST(650.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000001', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000013', N'0000000004', N'0000000005', N'EC - 0001', CAST(N'2024-05-20' AS Date), N'Escritorio Basico Linea Presidencial - 1101000131', CAST(N'2022-04-02' AS Date), CAST(180.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000014', N'0000000004', N'0000000005', N'EC - 0002', CAST(N'2024-05-20' AS Date), N'Escritorio Basico Linea Presidencial - 1101000131', CAST(N'2022-04-02' AS Date), CAST(180.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000015', N'0000000004', N'0000000005', N'EC - 0003', CAST(N'2024-05-20' AS Date), N'Escritorio Basico Linea Presidencial - 1101000129', CAST(N'2022-04-02' AS Date), CAST(180.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000016', N'0000000004', N'0000000005', N'EC - 0004', CAST(N'2024-05-20' AS Date), N'Escritorio Basico Linea Presidencial - 1101000129', CAST(N'2022-04-02' AS Date), CAST(180.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000017', N'0000000004', N'0000000005', N'EC - 0005', CAST(N'2024-05-20' AS Date), N'Escritorio Personal De Vidrio Negro -  1101000136', CAST(N'2022-04-02' AS Date), CAST(185.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000018', N'0000000004', N'0000000005', N'EC - 0006', CAST(N'2024-05-20' AS Date), N'Escritorio Personal De Vidrio Negro -  1101000136', CAST(N'2022-04-02' AS Date), CAST(185.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000019', N'0000000004', N'0000000005', N'EC - 0007', CAST(N'2024-05-20' AS Date), N'Escritorio Mist Con Gavetas - 1101000103', CAST(N'2022-04-02' AS Date), CAST(200.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000002', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000020', N'0000000004', N'0000000005', N'EC - 0008', CAST(N'2024-05-20' AS Date), N'Escritorio Mist Con Gavetas - 1101000103', CAST(N'2022-04-02' AS Date), CAST(200.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000021', N'0000000004', N'0000000006', N'SL - 0001', CAST(N'2024-05-20' AS Date), N'Silla Secretarial Mesh Bicolor - 1102000088', CAST(N'2022-04-02' AS Date), CAST(150.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000022', N'0000000004', N'0000000006', N'SL - 0002', CAST(N'2024-05-20' AS Date), N'Silla Secretarial Mesh Bicolor - 1102000088', CAST(N'2022-04-02' AS Date), CAST(150.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000002', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000023', N'0000000004', N'0000000006', N'SL - 0003', CAST(N'2024-05-20' AS Date), N'Silla Secretarial Mesh Bicolor - 1102000088', CAST(N'2022-04-02' AS Date), CAST(150.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000024', N'0000000004', N'0000000006', N'SL - 0003', CAST(N'2024-05-20' AS Date), N'Silla Secretarial Mesh Bicolor - 1102000088', CAST(N'2022-04-02' AS Date), CAST(150.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000025', N'0000000004', N'0000000006', N'SL - 0004', CAST(N'2024-05-20' AS Date), N'Silla Secretarial Mesh Bicolor - 1102000088', CAST(N'2022-04-02' AS Date), CAST(150.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000004', N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000026', N'0000000002', N'0000000007', N'MA - 0001', CAST(N'2024-05-20' AS Date), N'Maquina empaquetadora industrial Serie 3003', CAST(N'2022-04-05' AS Date), CAST(5000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000002', N'Jose03', N'0000000002', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000027', N'0000000002', N'0000000007', N'MA - 0002', CAST(N'2024-05-20' AS Date), N'Maquina empaquetadora industrial Serie 3003', CAST(N'2022-04-05' AS Date), CAST(5000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000002', N'Jose03', N'0000000002', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000028', N'0000000002', N'0000000007', N'MA - 0003', CAST(N'2024-05-20' AS Date), N'Maquina empaquetadora industrial Serie 3003', CAST(N'2022-04-05' AS Date), CAST(5000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), N'0000000002', N'Jose03', N'0000000002', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000029', N'0000000001', N'0000000008', N'ED - 0001', CAST(N'2024-05-20' AS Date), N'Edificio Administrativo ', CAST(N'2022-03-12' AS Date), CAST(125000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), NULL, N'Jose03', N'0000000001', N'')
INSERT [dbo].[tb_activos] ([id_activo], [id_clasificacion_ac], [id_categoria_ac], [codigo_interno_ac], [fecha_registro_ac], [nombre_activo], [fecha_compra_ac], [valor_activo], [fecha_alta_ac], [id_operario_ac], [usuario_registro_ac], [id_ubicacion_ac], [observaciones_ac]) VALUES (N'0000000030', N'0000000001', N'0000000008', N'ED - 0002', CAST(N'2024-05-20' AS Date), N'Edificio de Bodega Central', CAST(N'2022-03-12' AS Date), CAST(190000.00 AS Decimal(10, 2)), CAST(N'2024-04-01' AS Date), NULL, N'Jose03', N'0000000002', N'')
GO
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000001', N'0000000003', CAST(N'2024-05-20' AS Date), N'Camiones', N'Jose03', N'Camiones de traslado y reparto')
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000002', N'0000000003', CAST(N'2024-05-20' AS Date), N'Vans', N'Jose03', N'Vehiculos de reparto')
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000003', N'0000000004', CAST(N'2024-05-20' AS Date), N'PC Desktop ', N'Jose03', N'Computadoras de escritorios')
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000004', N'0000000004', CAST(N'2024-05-20' AS Date), N'Laptops', N'Jose03', N'Portatiles')
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000005', N'0000000004', CAST(N'2024-05-20' AS Date), N'Escritorios', N'Jose03', N'Escritorios gerenciales y secretarial')
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000006', N'0000000004', CAST(N'2024-05-20' AS Date), N'Sillas', N'Jose03', N'Sillas gerenciales y secretarial')
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000007', N'0000000002', CAST(N'2024-05-20' AS Date), N'Empaquetadoras', N'Jose03', N'Maquinas empaquetadoras en cajas')
INSERT [dbo].[tb_categorias_activos] ([id_categoria_ct], [id_clasificacion_ct], [fecha_registro_ct], [nombre_categoria], [usuario_registro], [descripcion_categoria]) VALUES (N'0000000008', N'0000000001', CAST(N'2024-05-20' AS Date), N'Edificios', N'Jose03', N'Bienes muebles de la empresa')
GO
INSERT [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca], [nombre_clasificacion_ca], [anios_vida_util_ca], [porcentaje_anual_ca]) VALUES (N'0000000001', N'Edificios', 20, CAST(0.05 AS Decimal(3, 2)))
INSERT [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca], [nombre_clasificacion_ca], [anios_vida_util_ca], [porcentaje_anual_ca]) VALUES (N'0000000002', N'Maquinaria', 5, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca], [nombre_clasificacion_ca], [anios_vida_util_ca], [porcentaje_anual_ca]) VALUES (N'0000000003', N'Vehiculos', 4, CAST(0.25 AS Decimal(3, 2)))
INSERT [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca], [nombre_clasificacion_ca], [anios_vida_util_ca], [porcentaje_anual_ca]) VALUES (N'0000000004', N'Mobilario, equipo y otros bienes', 2, CAST(0.50 AS Decimal(3, 2)))
GO
INSERT [dbo].[tb_depreciacion_activos] ([id_depreciacion_activo], [id_activo_da], [id_clasificacion_da], [anios_vida_util_da], [porcentaje_anual_da], [valor_activo_da], [valor_residual_da], [id_ubicacion_da], [anio_compra_da], [ultimo_anio_da], [usuario_registro_da], [estado_da], [fecha_registro_da]) VALUES (N'0000000001', N'0000000029', N'0000000001', 20, CAST(0.05 AS Decimal(3, 2)), CAST(125000.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'0000000001', 2022, 2042, N'Jose03', 1, CAST(N'2024-05-23' AS Date))
INSERT [dbo].[tb_depreciacion_activos] ([id_depreciacion_activo], [id_activo_da], [id_clasificacion_da], [anios_vida_util_da], [porcentaje_anual_da], [valor_activo_da], [valor_residual_da], [id_ubicacion_da], [anio_compra_da], [ultimo_anio_da], [usuario_registro_da], [estado_da], [fecha_registro_da]) VALUES (N'0000000002', N'0000000030', N'0000000001', 20, CAST(0.05 AS Decimal(3, 2)), CAST(190000.00 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), N'0000000002', 2024, 2044, N'Jose03', 1, CAST(N'2024-05-23' AS Date))
INSERT [dbo].[tb_depreciacion_activos] ([id_depreciacion_activo], [id_activo_da], [id_clasificacion_da], [anios_vida_util_da], [porcentaje_anual_da], [valor_activo_da], [valor_residual_da], [id_ubicacion_da], [anio_compra_da], [ultimo_anio_da], [usuario_registro_da], [estado_da], [fecha_registro_da]) VALUES (N'0000000003', N'0000000005', N'0000000003', 4, CAST(0.25 AS Decimal(3, 2)), CAST(28000.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'0000000003', 2024, 2028, N'Jose03', 1, CAST(N'2024-05-28' AS Date))
GO
INSERT [dbo].[tb_operarios] ([id_operario], [fecha_registro_op], [nombre_operario], [cargo_operario], [estado_operario], [descripcion_operario]) VALUES (N'0000000001', CAST(N'2024-05-29' AS Date), N'Juan Carlos Hernandez', N'Informatica', 1, N'Encargado del equipo de computo del edificio administrativo')
INSERT [dbo].[tb_operarios] ([id_operario], [fecha_registro_op], [nombre_operario], [cargo_operario], [estado_operario], [descripcion_operario]) VALUES (N'0000000002', CAST(N'2024-05-20' AS Date), N'Jorge Flores', N'Supervisor', 1, N'Encargado de la supervición de maquinaria del edificio de bodega')
INSERT [dbo].[tb_operarios] ([id_operario], [fecha_registro_op], [nombre_operario], [cargo_operario], [estado_operario], [descripcion_operario]) VALUES (N'0000000003', CAST(N'2024-05-20' AS Date), N'Roberto Hernandez', N'Supervisor', 1, N'Encargado de la supervición de vehiculos y rutas')
INSERT [dbo].[tb_operarios] ([id_operario], [fecha_registro_op], [nombre_operario], [cargo_operario], [estado_operario], [descripcion_operario]) VALUES (N'0000000004', CAST(N'2024-05-20' AS Date), N'Beatriz Vasquez', N'Logistica', 1, N'Encargada de la supervición del mobiliario del edificio administrativo')
INSERT [dbo].[tb_operarios] ([id_operario], [fecha_registro_op], [nombre_operario], [cargo_operario], [estado_operario], [descripcion_operario]) VALUES (N'0000000005', CAST(N'2024-05-29' AS Date), N'Emmanuel', N'Informatica', 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[tb_roles] ON 

INSERT [dbo].[tb_roles] ([id_rol], [nombre_rol], [descripcion_rol]) VALUES (1, N'Administrador', N'Acceso total al sistema')
INSERT [dbo].[tb_roles] ([id_rol], [nombre_rol], [descripcion_rol]) VALUES (2, N'Operario', N'Acceso a funcionalidades básicas, entrada y consulta de datos')
SET IDENTITY_INSERT [dbo].[tb_roles] OFF
GO
INSERT [dbo].[tb_ubicaciones] ([id_ubicacion], [fecha_registro_ub], [nombre_ubicacion], [estado_ubicacion], [usuario_registro_ub]) VALUES (N'0000000001', CAST(N'2024-05-20' AS Date), N'Departamento de administración', 1, N'Jose03')
INSERT [dbo].[tb_ubicaciones] ([id_ubicacion], [fecha_registro_ub], [nombre_ubicacion], [estado_ubicacion], [usuario_registro_ub]) VALUES (N'0000000002', CAST(N'2024-05-20' AS Date), N'Bodega Central', 1, N'Jose03')
INSERT [dbo].[tb_ubicaciones] ([id_ubicacion], [fecha_registro_ub], [nombre_ubicacion], [estado_ubicacion], [usuario_registro_ub]) VALUES (N'0000000003', CAST(N'2024-05-20' AS Date), N'Despacho en Bodega Central', 1, N'Jose03')
GO
INSERT [dbo].[tb_usuarios] ([id_usuario], [fecha_registro_us], [nombre_usuario], [apellidos_usuario], [usuario_login], [contrasenia_usuario], [email_usuario], [rol_usuario], [estado_usuario], [ultima_actualizacion_us]) VALUES (N'0000000001', CAST(N'2024-05-24' AS Date), N'Jose', N'Alvarado', N'Jose03', N'12345', NULL, 1, 1, NULL)
INSERT [dbo].[tb_usuarios] ([id_usuario], [fecha_registro_us], [nombre_usuario], [apellidos_usuario], [usuario_login], [contrasenia_usuario], [email_usuario], [rol_usuario], [estado_usuario], [ultima_actualizacion_us]) VALUES (N'0000000002', CAST(N'2024-05-24' AS Date), N'admin', N'admin', N'admin', N'12345', NULL, 1, 1, NULL)
INSERT [dbo].[tb_usuarios] ([id_usuario], [fecha_registro_us], [nombre_usuario], [apellidos_usuario], [usuario_login], [contrasenia_usuario], [email_usuario], [rol_usuario], [estado_usuario], [ultima_actualizacion_us]) VALUES (N'0000000003', CAST(N'2024-05-24' AS Date), N'operario', N'operario', N'operario', N'12345', NULL, 2, 1, NULL)
INSERT [dbo].[tb_usuarios] ([id_usuario], [fecha_registro_us], [nombre_usuario], [apellidos_usuario], [usuario_login], [contrasenia_usuario], [email_usuario], [rol_usuario], [estado_usuario], [ultima_actualizacion_us]) VALUES (N'0000000004', CAST(N'2024-05-28' AS Date), N'Emmanuel', N'Espinoza', N'zaldivar16', N'12345', N'', 2, 1, NULL)
INSERT [dbo].[tb_usuarios] ([id_usuario], [fecha_registro_us], [nombre_usuario], [apellidos_usuario], [usuario_login], [contrasenia_usuario], [email_usuario], [rol_usuario], [estado_usuario], [ultima_actualizacion_us]) VALUES (N'0000000005', CAST(N'2024-05-29' AS Date), N'Juan', N'User', N'user', N'2024', N'user@gmail.com', 2, 1, NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tb_activos_id_activo]    Script Date: 31/5/2024 20:30:58 ******/
ALTER TABLE [dbo].[tb_activos] ADD  CONSTRAINT [UQ_tb_activos_id_activo] UNIQUE NONCLUSTERED 
(
	[id_activo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tb_categorias_activos_id_categoria]    Script Date: 31/5/2024 20:30:58 ******/
ALTER TABLE [dbo].[tb_categorias_activos] ADD  CONSTRAINT [UQ_tb_categorias_activos_id_categoria] UNIQUE NONCLUSTERED 
(
	[id_categoria_ct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tb_clasificacion_activos_id_clasificacion]    Script Date: 31/5/2024 20:30:58 ******/
ALTER TABLE [dbo].[tb_clasificacion_activos] ADD  CONSTRAINT [UQ_tb_clasificacion_activos_id_clasificacion] UNIQUE NONCLUSTERED 
(
	[id_clasificacion_ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tb_depreciacion_id_depreciacion]    Script Date: 31/5/2024 20:30:58 ******/
ALTER TABLE [dbo].[tb_depreciacion_activos] ADD  CONSTRAINT [UQ_tb_depreciacion_id_depreciacion] UNIQUE NONCLUSTERED 
(
	[id_depreciacion_activo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tb_operarios_id_operario]    Script Date: 31/5/2024 20:30:58 ******/
ALTER TABLE [dbo].[tb_operarios] ADD  CONSTRAINT [UQ_tb_operarios_id_operario] UNIQUE NONCLUSTERED 
(
	[id_operario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tb_ubicaciones_id_ubicacion]    Script Date: 31/5/2024 20:30:58 ******/
ALTER TABLE [dbo].[tb_ubicaciones] ADD  CONSTRAINT [UQ_tb_ubicaciones_id_ubicacion] UNIQUE NONCLUSTERED 
(
	[id_ubicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_activos]  WITH CHECK ADD FOREIGN KEY([id_categoria_ac])
REFERENCES [dbo].[tb_categorias_activos] ([id_categoria_ct])
GO
ALTER TABLE [dbo].[tb_activos]  WITH CHECK ADD FOREIGN KEY([id_clasificacion_ac])
REFERENCES [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca])
GO
ALTER TABLE [dbo].[tb_activos]  WITH CHECK ADD FOREIGN KEY([id_operario_ac])
REFERENCES [dbo].[tb_operarios] ([id_operario])
GO
ALTER TABLE [dbo].[tb_activos]  WITH CHECK ADD FOREIGN KEY([id_ubicacion_ac])
REFERENCES [dbo].[tb_ubicaciones] ([id_ubicacion])
GO
ALTER TABLE [dbo].[tb_categorias_activos]  WITH CHECK ADD FOREIGN KEY([id_clasificacion_ct])
REFERENCES [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca])
GO
ALTER TABLE [dbo].[tb_depreciacion_activos]  WITH CHECK ADD FOREIGN KEY([id_activo_da])
REFERENCES [dbo].[tb_activos] ([id_activo])
GO
ALTER TABLE [dbo].[tb_depreciacion_activos]  WITH CHECK ADD FOREIGN KEY([id_clasificacion_da])
REFERENCES [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca])
GO
ALTER TABLE [dbo].[tb_depreciacion_activos]  WITH CHECK ADD FOREIGN KEY([id_ubicacion_da])
REFERENCES [dbo].[tb_ubicaciones] ([id_ubicacion])
GO
ALTER TABLE [dbo].[tb_usuarios]  WITH CHECK ADD FOREIGN KEY([rol_usuario])
REFERENCES [dbo].[tb_roles] ([id_rol])
GO
/****** Object:  StoredProcedure [dbo].[STP_BuscarActivoParaDepreciacion]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STP_BuscarActivoParaDepreciacion]
    @IdActivo NVARCHAR(10)
AS
BEGIN
    SELECT 
        ac.nombre_activo,
        ac.id_clasificacion_ac,
        cl.nombre_clasificacion_ca,
        cl.anios_vida_util_ca,
        cl.porcentaje_anual_ca,
        ac.valor_activo,
        ac.id_ubicacion_ac,
        ub.nombre_ubicacion,
        YEAR(ac.fecha_alta_ac) AS 'Anio_alta',
        YEAR(ac.fecha_alta_ac) + cl.anios_vida_util_ca AS 'Ultimo_Anio'
    FROM tb_activos ac
    INNER JOIN tb_clasificacion_activos cl ON ac.id_clasificacion_ac = cl.id_clasificacion_ca
    INNER JOIN tb_ubicaciones ub ON ac.id_ubicacion_ac = ub.id_ubicacion
    WHERE ac.id_activo = @IdActivo;
END;
GO
/****** Object:  StoredProcedure [dbo].[STP_Datos_Usuario]    Script Date: 31/5/2024 20:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STP_Datos_Usuario]
@usuario_login nvarchar(15)
AS
BEGIN
SELECT
	us.nombre_usuario,
	us.apellidos_usuario,
	us.rol_usuario,
	r.nombre_rol
FROM tb_usuarios us
INNER JOIN tb_roles r ON us.rol_usuario = r.id_rol
WHERE us.usuario_login = @usuario_login;
END
GO
