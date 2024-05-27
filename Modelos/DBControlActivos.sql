USE [master]
GO
/****** Object:  Database [DBControlActivos]    Script Date: 24/5/2024 22:34:42 ******/
CREATE DATABASE [DBControlActivos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBControlActivos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBControlActivos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBControlActivos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBControlActivos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBControlActivos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBControlActivos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBControlActivos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBControlActivos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBControlActivos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBControlActivos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBControlActivos] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBControlActivos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBControlActivos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBControlActivos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBControlActivos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBControlActivos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBControlActivos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBControlActivos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBControlActivos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBControlActivos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBControlActivos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBControlActivos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBControlActivos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBControlActivos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBControlActivos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBControlActivos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBControlActivos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBControlActivos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBControlActivos] SET RECOVERY FULL 
GO
ALTER DATABASE [DBControlActivos] SET  MULTI_USER 
GO
ALTER DATABASE [DBControlActivos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBControlActivos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBControlActivos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBControlActivos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBControlActivos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBControlActivos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBControlActivos', N'ON'
GO
ALTER DATABASE [DBControlActivos] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBControlActivos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBControlActivos]
GO
/****** Object:  Table [dbo].[tb_activos]    Script Date: 24/5/2024 22:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_activos](
	[id_activo] [varchar](10) NOT NULL,
	[id_clasificacion_ac] [varchar](10) NOT NULL,
	[codigo_interno_ac] [varchar](1010) NULL,
	[fecha_registro_ac] [date] NOT NULL,
	[nombre_activo] [nvarchar](100) NOT NULL,
	[fecha_compra] [date] NULL,
	[valor_activo] [decimal](10, 2) NOT NULL,
	[fecha_baja_ac] [date] NULL,
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
/****** Object:  Table [dbo].[tb_categorias_activos]    Script Date: 24/5/2024 22:34:42 ******/
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
/****** Object:  Table [dbo].[tb_clasificacion_activos]    Script Date: 24/5/2024 22:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_clasificacion_activos](
	[id_clasificacion_ca] [varchar](10) NOT NULL,
	[nombre_clasificacion_ca] [nvarchar](25) NULL,
	[anios_vida_util_ca] [int] NOT NULL,
	[porcentaje_anual_ca] [decimal](3, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_clasificacion_ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_depreciacion_activos]    Script Date: 24/5/2024 22:34:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[id_depreciacion_activo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_empresa]    Script Date: 24/5/2024 22:34:42 ******/
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
/****** Object:  Table [dbo].[tb_operarios]    Script Date: 24/5/2024 22:34:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[id_operario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_roles]    Script Date: 24/5/2024 22:34:42 ******/
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
/****** Object:  Table [dbo].[tb_ubicaciones]    Script Date: 24/5/2024 22:34:42 ******/
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
/****** Object:  Table [dbo].[tb_usuarios]    Script Date: 24/5/2024 22:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuarios](
	[id_usuario] [varchar](10) NOT NULL,
	[fecha_registro_us] [datetime] NOT NULL,
	[nombre_usuario] [nvarchar](50) NOT NULL,
	[apellidos_usuario] [nvarchar](50) NOT NULL,
	[usuario_login] [nvarchar](15) NOT NULL,
	[contraseña_usuario] [nvarchar](15) NOT NULL,
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
ALTER TABLE [dbo].[tb_activos]  WITH CHECK ADD FOREIGN KEY([id_operario_ac])
REFERENCES [dbo].[tb_operarios] ([id_operario])
GO
ALTER TABLE [dbo].[tb_activos]  WITH CHECK ADD FOREIGN KEY([id_ubicacion_ac])
REFERENCES [dbo].[tb_ubicaciones] ([id_ubicacion])
GO
ALTER TABLE [dbo].[tb_activos]  WITH CHECK ADD FOREIGN KEY([id_clasificacion_ac])
REFERENCES [dbo].[tb_clasificacion_activos] ([id_clasificacion_ca])
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
USE [master]
GO
ALTER DATABASE [DBControlActivos] SET  READ_WRITE 
GO
