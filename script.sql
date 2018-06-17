USE [master]
GO
/****** Object:  Database [ProyectoPedidos]    Script Date: 16/6/2018 18:25:26 ******/
CREATE DATABASE [ProyectoPedidos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoPedidos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DEFAULTSQL\MSSQL\DATA\ProyectoPedidos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProyectoPedidos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DEFAULTSQL\MSSQL\DATA\ProyectoPedidos_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProyectoPedidos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoPedidos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoPedidos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoPedidos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoPedidos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoPedidos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoPedidos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoPedidos] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoPedidos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoPedidos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoPedidos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoPedidos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProyectoPedidos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ProyectoPedidos]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/6/2018 18:25:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Cedula] [nvarchar](15) NOT NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[Apellido1] [nvarchar](15) NOT NULL,
	[Apellido2] [nvarchar](15) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[Contrasenna] [nvarchar](15) NOT NULL,
	[Estado_cliente] [int] NOT NULL,
	[Codigo_postal] [nvarchar](50) NOT NULL,
	[Nombre_usuario] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Configuraciones]    Script Date: 16/6/2018 18:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuraciones](
	[Minutos_max_orden] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalle_orden]    Script Date: 16/6/2018 18:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_orden](
	[Codigo_orden] [int] NOT NULL,
	[Nombre_plato] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio_linea] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Detalle_orden] PRIMARY KEY CLUSTERED 
(
	[Codigo_orden] ASC,
	[Nombre_plato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 16/6/2018 18:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[Codigo_postal] [nvarchar](50) NOT NULL,
	[Provincia] [nvarchar](50) NOT NULL,
	[Canton] [nvarchar](50) NOT NULL,
	[Distrito] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[Codigo_postal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orden]    Script Date: 16/6/2018 18:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden](
	[Codigo_orden] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_pedido] [date] NOT NULL,
	[Cedula] [nvarchar](15) NOT NULL,
	[Estado_pedido] [nvarchar](15) NOT NULL,
	[Costo_total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Orden] PRIMARY KEY CLUSTERED 
(
	[Codigo_orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plato]    Script Date: 16/6/2018 18:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plato](
	[Nombre_plato] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Precio] [decimal](7, 2) NOT NULL,
	[Estado_plato] [nchar](10) NOT NULL,
	[Imagen] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Plato] PRIMARY KEY CLUSTERED 
(
	[Nombre_plato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/6/2018 18:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Identificacion] [nvarchar](15) NOT NULL,
	[Nombre_usuario] [nvarchar](20) NOT NULL,
	[Contrasenna] [nvarchar](15) NOT NULL,
	[Rol] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Direccion] FOREIGN KEY([Codigo_postal])
REFERENCES [dbo].[Direccion] ([Codigo_postal])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Direccion]
GO
ALTER TABLE [dbo].[Detalle_orden]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_orden_Orden] FOREIGN KEY([Codigo_orden])
REFERENCES [dbo].[Orden] ([Codigo_orden])
GO
ALTER TABLE [dbo].[Detalle_orden] CHECK CONSTRAINT [FK_Detalle_orden_Orden]
GO
ALTER TABLE [dbo].[Detalle_orden]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_orden_Plato] FOREIGN KEY([Nombre_plato])
REFERENCES [dbo].[Plato] ([Nombre_plato])
GO
ALTER TABLE [dbo].[Detalle_orden] CHECK CONSTRAINT [FK_Detalle_orden_Plato]
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Orden_Cliente] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Cliente] ([Cedula])
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [FK_Orden_Cliente]
GO
USE [master]
GO
ALTER DATABASE [ProyectoPedidos] SET  READ_WRITE 
GO
