USE [master]
GO
/****** Object:  Database [KursovayaRabota]    Script Date: 27.05.2024 18:28:43 ******/
CREATE DATABASE [KursovayaRabota]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KursovayaRabota', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KursovayaRabota.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KursovayaRabota_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KursovayaRabota_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [KursovayaRabota] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KursovayaRabota].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KursovayaRabota] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KursovayaRabota] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KursovayaRabota] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KursovayaRabota] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KursovayaRabota] SET ARITHABORT OFF 
GO
ALTER DATABASE [KursovayaRabota] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KursovayaRabota] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KursovayaRabota] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KursovayaRabota] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KursovayaRabota] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KursovayaRabota] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KursovayaRabota] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KursovayaRabota] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KursovayaRabota] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KursovayaRabota] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KursovayaRabota] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KursovayaRabota] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KursovayaRabota] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KursovayaRabota] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KursovayaRabota] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KursovayaRabota] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KursovayaRabota] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KursovayaRabota] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KursovayaRabota] SET  MULTI_USER 
GO
ALTER DATABASE [KursovayaRabota] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KursovayaRabota] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KursovayaRabota] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KursovayaRabota] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KursovayaRabota] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KursovayaRabota] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [KursovayaRabota] SET QUERY_STORE = OFF
GO
USE [KursovayaRabota]
GO
/****** Object:  Table [dbo].[Должность_Сотрудника]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Должность_Сотрудника](
	[ID_Должности] [int] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Должность_Сотрудника] PRIMARY KEY CLUSTERED 
(
	[ID_Должности] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Заказ]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заказ](
	[ID_Заказа] [int] NOT NULL,
	[ID_Товара] [int] NOT NULL,
	[Цена] [int] NOT NULL,
	[Количество_Товара] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Запрос_Клиента]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Запрос_Клиента](
	[ID_Заказа] [int] IDENTITY(1,1) NOT NULL,
	[ID_Клиента] [int] NULL,
	[ID_Чека] [int] NULL,
 CONSTRAINT [PK_Запрос_Клиента] PRIMARY KEY CLUSTERED 
(
	[ID_Заказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Касса]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Касса](
	[ID_Чека] [int] IDENTITY(1,1) NOT NULL,
	[ID_Сотрудника] [int] NOT NULL,
 CONSTRAINT [PK_Касса] PRIMARY KEY CLUSTERED 
(
	[ID_Чека] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Категории_Товаров]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Категории_Товаров](
	[ID_Категории] [int] IDENTITY(1,1) NOT NULL,
	[Название_Категории] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Категории_Товаров] PRIMARY KEY CLUSTERED 
(
	[ID_Категории] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Клиент]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Клиент](
	[ID_Клиента] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [varchar](50) NOT NULL,
	[Телефон] [int] NULL,
 CONSTRAINT [PK_Клиент] PRIMARY KEY CLUSTERED 
(
	[ID_Клиента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Поставщик]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Поставщик](
	[ID_Поставщика] [int] IDENTITY(1,1) NOT NULL,
	[Название_Компании] [varchar](50) NULL,
 CONSTRAINT [PK_Поставщик] PRIMARY KEY CLUSTERED 
(
	[ID_Поставщика] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Приходной_Документ]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Приходной_Документ](
	[Приходной_Номер] [int] IDENTITY(1,1) NOT NULL,
	[ID_Поставщика] [int] NOT NULL,
	[ID_Сотрудника] [int] NOT NULL,
	[Дата_Оформления] [date] NOT NULL,
	[Количество_Товара] [int] NOT NULL,
	[Цена] [int] NOT NULL,
 CONSTRAINT [PK_Приходной_Документ] PRIMARY KEY CLUSTERED 
(
	[Приходной_Номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Производитель]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Производитель](
	[ID_Производителя] [int] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Производитель] PRIMARY KEY CLUSTERED 
(
	[ID_Производителя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудники]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудники](
	[ID_Сотрудника] [int] IDENTITY(1,1) NOT NULL,
	[ID_Должности] [int] NOT NULL,
	[ФИО] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Сотрудники] PRIMARY KEY CLUSTERED 
(
	[ID_Сотрудника] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Товар]    Script Date: 27.05.2024 18:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Товар](
	[ID_Товара] [int] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NOT NULL,
	[ID_Категории] [int] NOT NULL,
	[Количество] [int] NOT NULL,
	[Цена] [int] NOT NULL,
	[ID_Произодителя] [int] NOT NULL,
 CONSTRAINT [PK_Товар] PRIMARY KEY CLUSTERED 
(
	[ID_Товара] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_Заказ_Запрос_Клиента] FOREIGN KEY([ID_Заказа])
REFERENCES [dbo].[Запрос_Клиента] ([ID_Заказа])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_Заказ_Запрос_Клиента]
GO
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_Заказ_Товар] FOREIGN KEY([ID_Товара])
REFERENCES [dbo].[Товар] ([ID_Товара])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_Заказ_Товар]
GO
ALTER TABLE [dbo].[Запрос_Клиента]  WITH CHECK ADD  CONSTRAINT [FK_Запрос_Клиента_Касса] FOREIGN KEY([ID_Чека])
REFERENCES [dbo].[Касса] ([ID_Чека])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Запрос_Клиента] CHECK CONSTRAINT [FK_Запрос_Клиента_Касса]
GO
ALTER TABLE [dbo].[Запрос_Клиента]  WITH CHECK ADD  CONSTRAINT [FK_Запрос_Клиента_Клиент] FOREIGN KEY([ID_Клиента])
REFERENCES [dbo].[Клиент] ([ID_Клиента])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Запрос_Клиента] CHECK CONSTRAINT [FK_Запрос_Клиента_Клиент]
GO
ALTER TABLE [dbo].[Касса]  WITH CHECK ADD  CONSTRAINT [FK_Касса_Сотрудники] FOREIGN KEY([ID_Сотрудника])
REFERENCES [dbo].[Сотрудники] ([ID_Сотрудника])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Касса] CHECK CONSTRAINT [FK_Касса_Сотрудники]
GO
ALTER TABLE [dbo].[Приходной_Документ]  WITH CHECK ADD  CONSTRAINT [FK_Приходной_Документ_Поставщик] FOREIGN KEY([ID_Поставщика])
REFERENCES [dbo].[Поставщик] ([ID_Поставщика])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Приходной_Документ] CHECK CONSTRAINT [FK_Приходной_Документ_Поставщик]
GO
ALTER TABLE [dbo].[Приходной_Документ]  WITH CHECK ADD  CONSTRAINT [FK_Приходной_Документ_Сотрудники] FOREIGN KEY([ID_Сотрудника])
REFERENCES [dbo].[Сотрудники] ([ID_Сотрудника])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Приходной_Документ] CHECK CONSTRAINT [FK_Приходной_Документ_Сотрудники]
GO
ALTER TABLE [dbo].[Сотрудники]  WITH CHECK ADD  CONSTRAINT [FK_Сотрудники_Должность_Сотрудника] FOREIGN KEY([ID_Должности])
REFERENCES [dbo].[Должность_Сотрудника] ([ID_Должности])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Сотрудники] CHECK CONSTRAINT [FK_Сотрудники_Должность_Сотрудника]
GO
ALTER TABLE [dbo].[Товар]  WITH CHECK ADD  CONSTRAINT [FK_Товар_Категории_Товаров] FOREIGN KEY([ID_Категории])
REFERENCES [dbo].[Категории_Товаров] ([ID_Категории])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Товар] CHECK CONSTRAINT [FK_Товар_Категории_Товаров]
GO
ALTER TABLE [dbo].[Товар]  WITH CHECK ADD  CONSTRAINT [FK_Товар_Производитель] FOREIGN KEY([ID_Произодителя])
REFERENCES [dbo].[Производитель] ([ID_Производителя])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Товар] CHECK CONSTRAINT [FK_Товар_Производитель]
GO
USE [master]
GO
ALTER DATABASE [KursovayaRabota] SET  READ_WRITE 
GO
