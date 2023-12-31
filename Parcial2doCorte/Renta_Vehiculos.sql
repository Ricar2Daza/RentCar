USE [Renta_Vehiculos]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 29/06/2022 0:30:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Identificacion] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Tipo_Cliente] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registros]    Script Date: 29/06/2022 0:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registros](
	[Placa_FK] [nvarchar](50) NOT NULL,
	[Kilometraje_FK] [int] NOT NULL,
	[Valor_Kilometraje] [int] NOT NULL,
	[Nombre_Propietario_FK] [nvarchar](50) NOT NULL,
	[Fecha] [nvarchar](50) NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_Registros] PRIMARY KEY CLUSTERED 
(
	[Placa_FK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 29/06/2022 0:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[Placa] [nvarchar](50) NOT NULL,
	[Descripcion_Vehiculo] [nvarchar](50) NOT NULL,
	[Kilometraje] [int] NOT NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Registros]  WITH CHECK ADD  CONSTRAINT [fk_fatal_placa] FOREIGN KEY([Placa_FK])
REFERENCES [dbo].[Vehiculos] ([Placa])
GO
ALTER TABLE [dbo].[Registros] CHECK CONSTRAINT [fk_fatal_placa]
GO
