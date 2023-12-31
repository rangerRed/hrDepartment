USE [master]
GO
/****** Object:  Database [HR Department]    Script Date: 28.05.2022 14:39:26 ******/
CREATE DATABASE [HR Department]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HR Department', FILENAME = N'C:\Users\yardo\HR Department.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HR Department_log', FILENAME = N'C:\Users\yardo\HR Department_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HR Department] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HR Department].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HR Department] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HR Department] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HR Department] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HR Department] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HR Department] SET ARITHABORT OFF 
GO
ALTER DATABASE [HR Department] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HR Department] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HR Department] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HR Department] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HR Department] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HR Department] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HR Department] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HR Department] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HR Department] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HR Department] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HR Department] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HR Department] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HR Department] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HR Department] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HR Department] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HR Department] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HR Department] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HR Department] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HR Department] SET  MULTI_USER 
GO
ALTER DATABASE [HR Department] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HR Department] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HR Department] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HR Department] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HR Department] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HR Department] SET QUERY_STORE = OFF
GO
USE [HR Department]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [HR Department]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 28.05.2022 14:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[login] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Воинский учетСот]    Script Date: 28.05.2022 14:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Воинский учетСот](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Код сотрудника] [int] NOT NULL,
	[Состав] [nvarchar](50) NULL,
	[Категория годности] [nvarchar](50) NULL,
	[Номер ВУС] [nvarchar](7) NULL,
	[Военно учетная специальность] [nvarchar](100) NULL,
	[Воинское звание] [nvarchar](50) NULL,
	[Категория запаса] [nvarchar](50) NULL,
	[Коммисариат] [nvarchar](50) NULL,
	[Спец учет] [nvarchar](50) NULL,
	[Отметка о снятии] [nvarchar](50) NULL,
	[Общий учет] [nvarchar](50) NULL,
 CONSTRAINT [PK_Воинский учетСот] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[График работы]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[График работы](
	[Код штатной единиц] [int] IDENTITY(1,1) NOT NULL,
	[Код подразделения] [int] NOT NULL,
	[Код должности] [int] NOT NULL,
	[Количество ставок] [int] NOT NULL,
	[Оклад] [float] NOT NULL,
 CONSTRAINT [PK_График работы] PRIMARY KEY CLUSTERED 
(
	[Код штатной единиц] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Должность]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Должность](
	[Код должности] [int] NOT NULL,
	[Название] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Должность] PRIMARY KEY CLUSTERED 
(
	[Код должности] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[дополнительные поля]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[дополнительные поля](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[характер работы] [nvarchar](50) NULL,
	[режим труда] [nvarchar](50) NULL,
	[продолжительность недели] [nvarchar](50) NULL,
	[график работы] [nvarchar](50) NULL,
	[испытательный срок] [int] NULL,
	[вредные производственные факторы] [nvarchar](50) NULL,
	[основание приема на работу] [nvarchar](50) NULL,
	[разряд] [nvarchar](50) NULL,
	[квалификационная категория] [nvarchar](50) NULL,
	[работник подчиняется] [nvarchar](50) NULL,
	[место нахождение служебного помещения] [nvarchar](50) NULL,
	[обязанности] [nvarchar](50) NULL,
	[длительность отпуска] [nvarchar](50) NULL,
	[алфавит] [nvarchar](1) NULL,
	[код сотрудника] [int] NOT NULL,
 CONSTRAINT [PK_дополнительные поля] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Информация об организации]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Информация об организации](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Краткое название] [nvarchar](100) NULL,
	[Полное наименование] [nvarchar](350) NULL,
	[Город] [nvarchar](50) NULL,
	[Адрес] [nvarchar](100) NULL,
	[ИНН] [nvarchar](13) NULL,
	[КПП] [nvarchar](11) NULL,
	[ОКПО] [nvarchar](7) NULL,
	[Расс. счет] [nvarchar](20) NULL,
	[Корр. счет] [nvarchar](20) NULL,
	[ОГРН] [nvarchar](12) NULL,
	[Рег. номер в ПФР] [nvarchar](12) NULL,
	[Код ТО ПФР] [nvarchar](50) NULL,
	[В банке] [nvarchar](50) NULL,
	[БИК банка] [nvarchar](9) NULL,
	[ФИО Руководителя] [nvarchar](150) NULL,
	[Должность руководителя] [nvarchar](150) NULL,
	[ФИО Главного бухгалтера] [nvarchar](150) NULL,
	[ФИО работника кадровой службы] [nvarchar](150) NULL,
	[Должность работника кадровой службы] [nvarchar](150) NULL,
	[Телефон/факс] [nvarchar](50) NULL,
	[Примечание] [nvarchar](50) NULL,
 CONSTRAINT [PK_Информация об организации] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ОбразовниеСот]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ОбразовниеСот](
	[ID диплома] [int] IDENTITY(1,1) NOT NULL,
	[ВО Наименование документа об образовании] [nvarchar](50) NULL,
	[ВОСерия] [nvarchar](6) NULL,
	[ВОНомер] [nvarchar](7) NULL,
	[ВОТип образования] [nvarchar](50) NULL,
	[ВОНаименование учебного заведения] [nvarchar](50) NULL,
	[ВОСпециальность] [nvarchar](50) NULL,
	[ВОКвалификация] [nvarchar](50) NULL,
	[ВОДата окончания] [date] NULL,
	[Наименование документа об образовании] [nvarchar](50) NULL,
	[Серия] [nvarchar](6) NULL,
	[Номер] [nvarchar](7) NULL,
	[Тип образования] [nvarchar](50) NULL,
	[Наименование учебного заведения] [nvarchar](50) NULL,
	[Специальность] [nvarchar](50) NULL,
	[Квалификация] [nvarchar](50) NULL,
	[Дата окончания] [date] NULL,
	[ПОНаименование] [nvarchar](50) NULL,
	[ПОДокумент№] [nvarchar](15) NULL,
	[[ПОДата выдачи] [date] NULL,
	[[ПОВыдавший орган] [nvarchar](50) NULL,
	[[ПОУченая степень] [nvarchar](50) NULL,
	[ПОНаправление по диплому] [nvarchar](50) NULL,
	[Код сотрудника] [int] NOT NULL,
 CONSTRAINT [PK_ОбразовниеСот] PRIMARY KEY CLUSTERED 
(
	[ID диплома] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Основания увольнения]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Основания увольнения](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Статья ФЗ] [nvarchar](50) NOT NULL,
	[Пункт] [nchar](3) NOT NULL,
	[Основания увольнения] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Основания увольнения] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Отпуска]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Отпуска](
	[№ приказа] [int] IDENTITY(1,1) NOT NULL,
	[Основание] [nvarchar](50) NOT NULL,
	[Дата подписи] [date] NOT NULL,
	[Код сотрудника] [int] NOT NULL,
 CONSTRAINT [PK_Отпуска] PRIMARY KEY CLUSTERED 
(
	[№ приказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Паспортные данныеСот]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Паспортные данныеСот](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Код сотрудника] [int] NULL,
	[Код подразделения] [nvarchar](7) NULL,
	[Серия паспорта] [nvarchar](4) NULL,
	[Номер паспорта] [nvarchar](6) NULL,
	[Кем выдан] [nvarchar](50) NULL,
	[Дата выдачи] [date] NULL,
	[Срок действия] [date] NULL,
	[МРДата регистрации] [date] NULL,
	[МРСрок действия до] [date] NULL,
	[МРСтрана] [nvarchar](50) NULL,
	[МРРегион] [nvarchar](50) NULL,
	[МРПочтовый индекс] [nvarchar](6) NULL,
	[МРГород] [nvarchar](50) NULL,
	[МР Улица] [nvarchar](50) NULL,
	[МРДом] [nvarchar](50) NULL,
	[МРКорпус] [nvarchar](50) NULL,
	[МРКвартира] [nvarchar](5) NULL,
	[ФПДата регистрации] [date] NULL,
	[ФПСрок действия до] [date] NULL,
	[ФПСтрана] [nvarchar](50) NULL,
	[ФПРегион] [nvarchar](50) NULL,
	[ФППочтовый индекс] [nvarchar](6) NULL,
	[ФПГород] [nvarchar](50) NULL,
	[ФП Улица] [nvarchar](50) NULL,
	[ФПДом] [nvarchar](50) NULL,
	[ФПКорпус] [nvarchar](50) NULL,
	[ФПКвартира] [nvarchar](5) NULL,
	[ВУСерия] [nvarchar](4) NULL,
	[ВУНомер] [nvarchar](6) NULL,
	[ВУСрок действия до] [date] NULL,
	[ЗПСерия] [nvarchar](2) NULL,
	[ЗПНомер] [nvarchar](7) NULL,
	[ЗПДата выдачи] [date] NULL,
	[ЗПВыдавший орган] [nvarchar](50) NULL,
	[ЗПСрок действия до] [date] NULL,
 CONSTRAINT [PK_Паспортные данные] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Подразделение]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Подразделение](
	[Код подразделения] [int] NOT NULL,
	[Название] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Подразделение] PRIMARY KEY CLUSTERED 
(
	[Код подразделения] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Приказ о переводе]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Приказ о переводе](
	[№ приакза] [int] IDENTITY(1,1) NOT NULL,
	[Дата утверждения] [date] NOT NULL,
	[Код сотрудника] [int] NOT NULL,
	[Код штатной еденицы] [int] NOT NULL,
	[Основание] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Приказ о переводе] PRIMARY KEY CLUSTERED 
(
	[№ приакза] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Приказ о приеме]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Приказ о приеме](
	[№ приказа] [int] IDENTITY(1,1) NOT NULL,
	[Дата подписи] [date] NOT NULL,
	[Код сотрудника] [int] NOT NULL,
	[Код штатной единицы] [int] NOT NULL,
	[Количество ставок] [int] NOT NULL,
 CONSTRAINT [PK_Приказ о приеме] PRIMARY KEY CLUSTERED 
(
	[№ приказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Приказ об увольнении]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Приказ об увольнении](
	[№ приказа] [int] IDENTITY(1,1) NOT NULL,
	[Дата увольнения] [date] NOT NULL,
	[Основание увольнения] [nvarchar](250) NOT NULL,
	[Статья] [nvarchar](50) NOT NULL,
	[Пункт] [nvarchar](3) NOT NULL,
	[Номер приказа на увольнение] [nvarchar](50) NOT NULL,
	[Дата приказа на увольнение] [date] NOT NULL,
	[Код сотрудника] [int] NOT NULL,
	[IDОснование] [int] NOT NULL,
 CONSTRAINT [PK_Приказ об увольнении] PRIMARY KEY CLUSTERED 
(
	[№ приказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудник]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудник](
	[Табельный номер] [int] NOT NULL,
	[Дата приема на работу] [date] NULL,
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
	[Отчество] [nvarchar](50) NULL,
	[Дата рождения] [date] NULL,
	[Пол] [nvarchar](10) NULL,
	[Семейное положение] [nvarchar](70) NULL,
	[Телефон домашний] [nvarchar](11) NULL,
	[Телефон рабочий] [nvarchar](11) NULL,
	[Телефон мобильный] [nvarchar](11) NULL,
	[Должность] [nvarchar](50) NULL,
	[Отдел] [nvarchar](50) NULL,
	[Кабинет] [nvarchar](5) NULL,
	[ИНН] [nvarchar](12) NULL,
	[СНИЛС] [nvarchar](11) NULL,
	[№ мед полиса] [nvarchar](16) NULL,
	[E-mail] [nvarchar](70) NULL,
	[Национальность] [nvarchar](50) NULL,
	[Гражданство] [nvarchar](100) NULL,
	[Место рождения] [nvarchar](100) NULL,
	[название фото] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Сотрудник] PRIMARY KEY CLUSTERED 
(
	[Табельный номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Трудовая деятельность]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Трудовая деятельность](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Код сотрудника] [int] NOT NULL,
	[Дата приема на работу] [date] NULL,
	[Должность] [nvarchar](50) NULL,
	[№ договора] [nvarchar](20) NULL,
	[Дата договора] [date] NULL,
	[№ приказа] [nvarchar](20) NULL,
	[Дата приказа] [date] NULL,
	[Срок договора] [date] NULL,
	[Тип места работы] [nvarchar](50) NOT NULL,
	[Стаж работы общий] [nvarchar](50) NULL,
	[Стаж работы страховой] [nvarchar](50) NULL,
	[Стаж работы на предприятии] [nvarchar](50) NULL,
	[Состоит в профсюзе] [bit] NULL,
	[Оклад] [float] NULL,
	[Надбавка] [float] NULL,
	[Всего рублей] [float] NULL,
	[Оклад с надбавкой] [float] NULL,
	[КТУ] [float] NULL,
	[Ставка] [float] NULL,
	[Чето рубли какието ваще хз] [float] NULL,
 CONSTRAINT [PK_Трудовая деятельность] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Трудовая книжка]    Script Date: 28.05.2022 14:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Трудовая книжка](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Код сотрудника] [int] NOT NULL,
	[№пп] [int] NOT NULL,
	[Дата] [date] NULL,
	[Сведения о приеме переводах и увольнении] [nvarchar](200) NULL,
	[ОснованиеНаименование] [nvarchar](50) NULL,
	[ОснованиеДата] [date] NULL,
	[ОснованиеНомер] [nvarchar](20) NULL,
	[ОснованиеСерия] [nvarchar](20) NULL,
	[Вид кадрового мероприятия] [nvarchar](50) NULL,
	[Статья ФЗ причины при увольнении] [nvarchar](150) NULL,
	[Пункт ФЗ причины при увольнении] [nvarchar](3) NULL,
	[выполняемая функция(при наличии)] [nvarchar](500) NULL,
	[С даты] [date] NULL,
	[по дату] [date] NULL,
	[признак отмены записи] [bit] NULL,
	[дата отмены записи] [date] NULL,
	[совместитель] [bit] NULL,
	[должность] [nvarchar](50) NULL,
	[отдел] [nvarchar](50) NULL,
	[работа в районах крайнего севера] [nvarchar](150) NULL,
	[UUID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Трудовая книжка] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Login] ([login], [password]) VALUES (N'123', N'123')
GO
SET IDENTITY_INSERT [dbo].[Воинский учетСот] ON 

INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (2, 0, N'состав1', N'1категория годности', N'432', N'ВУС123', N'воинское звание1', N'категория запаса1', N'комиссариат1', N'спец учет1', N'отметка о снятии1', N'общий учет1')
INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (6003, 1, N'состав1', N'1категория годности', N'432', N'ВУС123', N'воинское звание1', N'категория запаса1', N'комиссариат1', N'спец учет1', N'отметка о снятии1', N'общий учет1')
INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (6004, 2, N'состав1', N'1категория годности', N'432', N'ВУС123', N'воинское звание1', N'категория запаса1', N'комиссариат1', N'спец учет1', N'отметка о снятии1', N'общий учет1')
INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (6005, 3, N'состав1', N'1категория годности', N'432', N'ВУС123', N'воинское звание1', N'категория запаса1', N'комиссариат1', N'спец учет1', N'отметка о снятии1', N'общий учет1')
INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (6006, 4, N'состав1', N'1категория годности', N'432', N'ВУС123', N'воинское звание1', N'категория запаса1', N'комиссариат1', N'спец учет1', N'отметка о снятии1', N'общий учет1')
INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (6007, 51, N'Призывник', N'Б', N'37', N'Водитель транспортных средств категории ВС', N'Рядовой', N'3 разряд', N'Красноармейский', N'', N'Есть', N'847939438')
INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (9007, 54, N'Состав', N'Категория годности', N'37', N'Водитель ', N'Рядовой', N'Категория запаса', N'Комиссариат', N'Спец учет', N'Отметка о снятии', N'Общий учет')
INSERT [dbo].[Воинский учетСот] ([id], [Код сотрудника], [Состав], [Категория годности], [Номер ВУС], [Военно учетная специальность], [Воинское звание], [Категория запаса], [Коммисариат], [Спец учет], [Отметка о снятии], [Общий учет]) VALUES (10007, 57, N'Состав', N'Б3', N'374', N'ВУС', N'Звание', N'Категория', N'Слободской', N'Спец учет', N'2387492', N'Общий учет')
SET IDENTITY_INSERT [dbo].[Воинский учетСот] OFF
GO
INSERT [dbo].[Должность] ([Код должности], [Название]) VALUES (1, N'Генеральный директор')
INSERT [dbo].[Должность] ([Код должности], [Название]) VALUES (2, N'Главный механик')
INSERT [dbo].[Должность] ([Код должности], [Название]) VALUES (3, N'Электрик')
GO
SET IDENTITY_INSERT [dbo].[дополнительные поля] ON 

INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (1, NULL, NULL, NULL, N'', 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (2, NULL, NULL, NULL, NULL, 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (3, NULL, NULL, NULL, NULL, 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (4, NULL, NULL, NULL, NULL, 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (5, NULL, NULL, NULL, NULL, 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4)
INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (5007, N'Постоянно', N'полное рабочее время', N'5 дней', N'5 на 2', 30, N'', N'приказ', N'', N'вторая', N'Директор', N'МБОУ СОШ №5 каб. 14', N'по должностной инструкци', N'28', N'Б', 51)
INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (8007, N'Характер работы', N'Режим труда', N'5 дней', N'5 на 2', 30, N'', N'приказ', N'', N'категория', N'диектор', N'КОГПОБУ СКПиСО каб. 17', N'обязанности', N'28', N'П', 54)
INSERT [dbo].[дополнительные поля] ([id], [характер работы], [режим труда], [продолжительность недели], [график работы], [испытательный срок], [вредные производственные факторы], [основание приема на работу], [разряд], [квалификационная категория], [работник подчиняется], [место нахождение служебного помещения], [обязанности], [длительность отпуска], [алфавит], [код сотрудника]) VALUES (9007, N'Характер работы', N'Режим труда', N'5 дней', N'5 на 2', 30, N'', N'Приказ', N'3 разряд', N'КатегорияК', N'Директор', N'СКПиСО каб. 4', N'По должностной инструкции', N'28', N'К', 57)
SET IDENTITY_INSERT [dbo].[дополнительные поля] OFF
GO
SET IDENTITY_INSERT [dbo].[Информация об организации] ON 

INSERT [dbo].[Информация об организации] ([id], [Краткое название], [Полное наименование], [Город], [Адрес], [ИНН], [КПП], [ОКПО], [Расс. счет], [Корр. счет], [ОГРН], [Рег. номер в ПФР], [Код ТО ПФР], [В банке], [БИК банка], [ФИО Руководителя], [Должность руководителя], [ФИО Главного бухгалтера], [ФИО работника кадровой службы], [Должность работника кадровой службы], [Телефон/факс], [Примечание]) VALUES (1, N'МБОУ СОШ №5', N'Муниципальное бютжетное общеобразовательное учреждение средняя школа №5', N'Слободской', N'ул. Гоголя, 97, Слободской, Кировская обл.', N'4343004262', N'432901001', N'1095746', N'1', N'1', N'102430107816', N'1', N'1', N'1', N'1', N'Комаровских Марина Валерьевна', N'Директор', N'Комкина Татьяна Сергеевна', N'Иванов Иван Иванович', N'Инспектор по кадрам', N'88336241729-88336250639', N'1')
SET IDENTITY_INSERT [dbo].[Информация об организации] OFF
GO
SET IDENTITY_INSERT [dbo].[ОбразовниеСот] ON 

INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (1003, N'наименование1', N'123123', N'1231212', N'1тип образования', N'наименование1', N'специальность1', N'квалификация1', CAST(N'2001-06-07' AS Date), N'документ1', N'123123', N'1231231', N'тип образования1', N'наименование1', N'специальность1', N'1квалификация', CAST(N'2001-06-07' AS Date), N'наименование1', N'11', CAST(N'2001-06-07' AS Date), N'орган1', N'1ученая степень', N'направление1', 0)
INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (7004, N'наименование1', N'123123', N'1231212', N'1тип образования', N'наименование1', N'специальность1', N'квалификация1', CAST(N'2001-06-07' AS Date), N'документ1', N'123123', N'1231231', N'тип образования1', N'наименование1', N'специальность1', N'1квалификация', CAST(N'2001-06-07' AS Date), N'наименование1', N'11', CAST(N'2001-06-07' AS Date), N'орган1', N'1ученая степень', N'направление1', 1)
INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (7005, N'наименование1', N'123123', N'1231212', N'1тип образования', N'наименование1', N'специальность1', N'квалификация1', CAST(N'2001-06-07' AS Date), N'документ1', N'123123', N'1231231', N'тип образования1', N'наименование1', N'специальность1', N'1квалификация', CAST(N'2001-06-07' AS Date), N'наименование1', N'11', CAST(N'2001-06-07' AS Date), N'орган1', N'1ученая степень', N'направление1', 2)
INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (7006, N'наименование1', N'123123', N'1231212', N'1тип образования', N'наименование1', N'специальность1', N'квалификация1', CAST(N'2001-06-07' AS Date), N'документ1', N'123123', N'1231231', N'тип образования1', N'наименование1', N'специальность1', N'1квалификация', CAST(N'2001-06-07' AS Date), N'наименование1', N'11', CAST(N'2001-06-07' AS Date), N'орган1', N'1ученая степень', N'направление1', 3)
INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (7007, N'наименование1', N'123123', N'1231212', N'1тип образования', N'наименование1', N'специальность1', N'квалификация1', CAST(N'2001-06-07' AS Date), N'документ1', N'123123', N'1231231', N'тип образования1', N'наименование1', N'специальность1', N'1квалификация', CAST(N'2001-06-07' AS Date), N'наименование1', N'11', CAST(N'2001-06-07' AS Date), N'орган1', N'1ученая степень', N'направление1', 4)
INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (12010, N'', N'', N'', N'', N'', N'', N'', CAST(N'0001-01-01' AS Date), N'Аттестат', N'888888', N'8888888', N'Среднее профессиональное обраование', N'ВЖТ', N'Проводник', N'Проводник', CAST(N'1999-06-29' AS Date), N'Докторантура', N'9348754', CAST(N'2008-06-29' AS Date), N'РАН', N'Доктор наук', N'Теология', 51)
INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (15010, N'документ об образовании', N'182368', N'2372839', N'Тип образования', N'Наименование', N'Специальность', N'Квалификация', CAST(N'2022-05-20' AS Date), N'Аттестат', N'384756', N'3485773', N'Среднее специальное образование', N'КОГПОБУ СКПиСО', N'Информационные системы и программирование', N'Программист', CAST(N'2022-06-30' AS Date), N'Диплом', N'27346283', CAST(N'2022-06-30' AS Date), N'РАН', N'Докторская степень', N'Теолог', 54)
INSERT [dbo].[ОбразовниеСот] ([ID диплома], [ВО Наименование документа об образовании], [ВОСерия], [ВОНомер], [ВОТип образования], [ВОНаименование учебного заведения], [ВОСпециальность], [ВОКвалификация], [ВОДата окончания], [Наименование документа об образовании], [Серия], [Номер], [Тип образования], [Наименование учебного заведения], [Специальность], [Квалификация], [Дата окончания], [ПОНаименование], [ПОДокумент№], [[ПОДата выдачи], [[ПОВыдавший орган], [[ПОУченая степень], [ПОНаправление по диплому], [Код сотрудника]) VALUES (16010, N'Диплом', N'563845', N'6837563', N'Высшее образование', N'МГУ', N'01.43.43', N'Математика', CAST(N'2022-07-05' AS Date), N'Аттестат', N'347854', N'0098098', N'Среднее специальное образование', N'СКПиСО', N'09.02.07', N'Программирование', CAST(N'2022-07-01' AS Date), N'Диплом', N'24723984', CAST(N'2022-07-05' AS Date), N'РАН', N'Магистратура', N'Теология', 57)
SET IDENTITY_INSERT [dbo].[ОбразовниеСот] OFF
GO
SET IDENTITY_INSERT [dbo].[Основания увольнения] ON 

INSERT [dbo].[Основания увольнения] ([ID], [Статья ФЗ], [Пункт], [Основания увольнения]) VALUES (1, N'77 часть один', N'3  ', N'расторжение трудового договора по инициативе работника')
INSERT [dbo].[Основания увольнения] ([ID], [Статья ФЗ], [Пункт], [Основания увольнения]) VALUES (2, N'77 часть один', N'2  ', N'расторжение трудового договора по истечение срока трудового договора')
SET IDENTITY_INSERT [dbo].[Основания увольнения] OFF
GO
SET IDENTITY_INSERT [dbo].[Паспортные данныеСот] ON 

INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (2, 0, N'8768768', N'0988', N'098890', N'кем выдан1', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'789798', N'город1', N'улица1', N'11', N'11', N'11', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'987987', N'1город', N'улица1', N'11', N'11', N'11', N'8767', N'876876', CAST(N'2022-05-17' AS Date), N'12', N'1231233', CAST(N'2022-05-17' AS Date), N'выдавший', CAST(N'2022-05-17' AS Date))
INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (6009, 1, N'8768768', N'0988', N'098890', N'кем выдан1', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'789798', N'город1', N'улица1', N'11', N'11', N'11', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'987987', N'1город', N'улица1', N'11', N'11', N'11', N'8767', N'876876', CAST(N'2022-05-17' AS Date), N'12', N'1231233', CAST(N'2022-05-17' AS Date), N'выдавший', CAST(N'2022-05-17' AS Date))
INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (6010, 2, N'8768768', N'0988', N'098890', N'кем выдан1', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'789798', N'город1', N'улица1', N'11', N'11', N'11', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'987987', N'1город', N'улица1', N'11', N'11', N'11', N'8767', N'876876', CAST(N'2022-05-17' AS Date), N'12', N'1231233', CAST(N'2022-05-17' AS Date), N'выдавший', CAST(N'2022-05-17' AS Date))
INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (6011, 3, N'8768768', N'0988', N'098890', N'кем выдан1', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'789798', N'город1', N'улица1', N'11', N'11', N'11', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'987987', N'1город', N'улица1', N'11', N'11', N'11', N'8767', N'876876', CAST(N'2022-05-17' AS Date), N'12', N'1231233', CAST(N'2022-05-17' AS Date), N'выдавший', CAST(N'2022-05-17' AS Date))
INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (6012, 4, N'8768768', N'0988', N'098890', N'кем выдан1', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'789798', N'город1', N'улица1', N'11', N'11', N'11', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'страна1', N'регион1', N'987987', N'1город', N'улица1', N'11', N'11', N'11', N'8767', N'876876', CAST(N'2022-05-17' AS Date), N'12', N'1231233', CAST(N'2022-05-17' AS Date), N'выдавший', CAST(N'2022-05-17' AS Date))
INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (11005, 51, N'430-030', N'1111', N'222223', N'УМВД по Кировской обл.', CAST(N'2000-11-11' AS Date), CAST(N'2025-11-11' AS Date), CAST(N'2010-11-11' AS Date), CAST(N'2025-11-11' AS Date), N'РФ', N'Кировская обл.', N'613150', N'Слободской', N'Рождественая', N'66', N'1', N'54', CAST(N'2010-11-11' AS Date), CAST(N'2025-11-11' AS Date), N'РФ', N'Кировская обл.', N'613150', N'Слободской', N'Рождественая', N'66', N'1', N'54', N'1111', N'222222', CAST(N'2025-11-11' AS Date), N'11', N'2222222', CAST(N'2015-11-11' AS Date), N'МВД России', CAST(N'2025-11-11' AS Date))
INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (14005, 54, N'430-040', N'1231', N'123123', N'УМВД по Кировской обл.', CAST(N'2016-02-03' AS Date), CAST(N'2023-02-03' AS Date), CAST(N'2015-07-10' AS Date), CAST(N'2025-07-11' AS Date), N'РФ', N'Кировская обл.', N'613150', N'Слободской', N'Гоголя', N'89', N'1', N'24', CAST(N'2015-07-10' AS Date), CAST(N'2025-07-11' AS Date), N'РФ', N'Кировская обл.', N'613150', N'Слободской', N'Гоголя', N'89', N'1', N'24', N'1232', N'123213', CAST(N'2029-07-06' AS Date), N'42', N'2342342', CAST(N'2020-02-03' AS Date), N'МВД России', CAST(N'2030-02-03' AS Date))
INSERT [dbo].[Паспортные данныеСот] ([id], [Код сотрудника], [Код подразделения], [Серия паспорта], [Номер паспорта], [Кем выдан], [Дата выдачи], [Срок действия], [МРДата регистрации], [МРСрок действия до], [МРСтрана], [МРРегион], [МРПочтовый индекс], [МРГород], [МР Улица], [МРДом], [МРКорпус], [МРКвартира], [ФПДата регистрации], [ФПСрок действия до], [ФПСтрана], [ФПРегион], [ФППочтовый индекс], [ФПГород], [ФП Улица], [ФПДом], [ФПКорпус], [ФПКвартира], [ВУСерия], [ВУНомер], [ВУСрок действия до], [ЗПСерия], [ЗПНомер], [ЗПДата выдачи], [ЗПВыдавший орган], [ЗПСрок действия до]) VALUES (15005, 57, N'345-345', N'8457', N'934857', N'УМВД по Кировской обл.', CAST(N'2016-07-05' AS Date), CAST(N'2022-07-05' AS Date), CAST(N'2019-07-05' AS Date), CAST(N'2019-07-06' AS Date), N'РФ', N'Кировская обл.', N'348579', N'Белая холуница', N'Речная', N'71', N'', N'', CAST(N'2019-07-05' AS Date), CAST(N'2022-07-05' AS Date), N'РФ', N'Кировская обл.', N'613150', N'Слободской', N'Никольская', N'8', N'', N'54', N'1231', N'586858', CAST(N'2025-07-05' AS Date), N'74', N'8954984', CAST(N'2019-07-05' AS Date), N'МВД России', CAST(N'2029-07-05' AS Date))
SET IDENTITY_INSERT [dbo].[Паспортные данныеСот] OFF
GO
INSERT [dbo].[Подразделение] ([Код подразделения], [Название]) VALUES (1, N'Бухгалтерия')
INSERT [dbo].[Подразделение] ([Код подразделения], [Название]) VALUES (2, N'Плановый отдел')
GO
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (0, CAST(N'2022-05-03' AS Date), N'Фамилия12', N'Имя12', N'12Отчество', CAST(N'2001-06-07' AS Date), N'Мужской', N'семейное положение1', N'73458937459', N'34985734957', N'78935748395', N'Должность1', N'Отдел1', N'11', N'573895739475', N'94537459384', N'3495873495837945', N'почта1', N'национальность1', N'гражданство1', N'место рождения1', N'1256397.png')
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (1, CAST(N'2010-08-08' AS Date), N'Тагиев', N'Артём', N'Сергеевич', CAST(N'2001-06-07' AS Date), N'Мужской', N'Не в браке', N'89195265405', N'88007890202', N'85446788888', N'1', N'1', N'2', N'23749283479', N'29384729387', N'23984729', N'word1@mail.ru', N'Русский', N'РФ', N'пгт. Первомайский г. Слободского Кировская обл.', NULL)
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (2, CAST(N'2011-11-11' AS Date), N'Иванов', N'Иван', N'Иванович', CAST(N'2002-09-09' AS Date), N'Мужской', N'В браке', N'89076872332', N'89345783948', N'89456378474', N'2', N'2', N'14', N'48763485767', N'28374672837', N'82364827', N'word2@mail.ru', N'Грузин', N'РФ', N'пгт. Первомайский г. Слободского Кировская обл.', NULL)
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (3, CAST(N'2019-03-03' AS Date), N'Петрова', N'Юлия', N'Михайловна', CAST(N'1999-10-10' AS Date), N'Женский', N'В браке', N'89767634733', N'89475638877', N'89345763477', N'3', N'2', N'14', N'89347753867', N'65234768858', N'43287499', N'word3@mail.ru', N'Русский', N'РФ', N'пгт. Первомайский г. Слободского Кировская обл.', NULL)
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (4, CAST(N'2017-06-06' AS Date), N'Кораблева', N'Татьяна', N'Анатольевна', CAST(N'1990-04-04' AS Date), N'Женский', N'В браке', N'80949357394', N'89746573843', N'89005436787', N'1', N'1', N'17', N'74829374299', N'46786538478', N'74563784', N'word4@mail.ru', N'Русский', N'РФ', N'пгт. Первомайский г. Слободского Кировская обл.', NULL)
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (51, CAST(N'2010-11-11' AS Date), N'Иванов', N'Иван', N'Иванович', CAST(N'1980-02-06' AS Date), N'Мужской', N'В браке, 2 ребенка', N'27569', N'87495876495', N'49856749587', N'Бухгалтер', N'Бухгалтерия', N'14', N'393847539485', N'43985739485', N'3498573495739453', N'Ivan@mail.ru', N'Русский', N'РФ', N'г. Киров Кировская обл.', N'jv5l3v9svse-1-kopiya.jpg')
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (54, CAST(N'2010-02-03' AS Date), N'Маслов', N'Дмитрий', N'Игоревич', CAST(N'2002-04-08' AS Date), N'Мужской', N'Не в браке', N'22523', N'76859475694', N'39485738943', N'Программист', N'IT', N'17', N'394857489385', N'39485738493', N'9438573849538457', N'dimon@mail.ru', N'Русский', N'РФ', N'г. Слободской Кировская обл.', N'startup-3267505_1920.jpg')
INSERT [dbo].[Сотрудник] ([Табельный номер], [Дата приема на работу], [Фамилия], [Имя], [Отчество], [Дата рождения], [Пол], [Семейное положение], [Телефон домашний], [Телефон рабочий], [Телефон мобильный], [Должность], [Отдел], [Кабинет], [ИНН], [СНИЛС], [№ мед полиса], [E-mail], [Национальность], [Гражданство], [Место рождения], [название фото]) VALUES (57, CAST(N'2019-07-05' AS Date), N'Едигарев', N'Иван', N'Дмитриевич', CAST(N'2002-07-05' AS Date), N'Мужской', N'Не в браке', N'29898', N'94728394283', N'98457389453', N'Кадровик', N'Кадровый отдел', N'4', N'293847283942', N'34958304583', N'4305984580890099', N'john159@scam.ru', N'Русский', N'РФ', N'г. Слободской Кировская обл.', N'1200px-Visual_Studio_2017_Logo.svg.png')
GO
SET IDENTITY_INSERT [dbo].[Трудовая деятельность] ON 

INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (7, 2, CAST(N'2022-05-16' AS Date), N'должность', N'ТД-2', CAST(N'2022-05-16' AS Date), N'2', CAST(N'2022-05-16' AS Date), CAST(N'2022-05-16' AS Date), N'тип', N'0 лет 0 месяцев 0 дней', N'0 лет 0 месяцев 0 дней', N'0 лет 0 месяцев 0 дней', 1, 100, 100, 100, 100, 100, 100, 1000)
INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (8, 0, CAST(N'2001-06-07' AS Date), N'должность1', N'ТД-0', CAST(N'2001-06-07' AS Date), N'1', CAST(N'2001-06-07' AS Date), CAST(N'2001-06-07' AS Date), N'тип места1', N'1 лет 0 месяцев 12 дней', N'1 лет 0 месяцев 12 дней', N'0 лет 0 месяцев 0 дней', 1, 100, 100, 100, 100, 100, 100, 100)
INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (6009, 1, CAST(N'2022-05-16' AS Date), N'должность', N'ТД-1', CAST(N'2022-05-16' AS Date), N'2', CAST(N'2022-05-16' AS Date), CAST(N'2022-05-16' AS Date), N'тип', N'0 лет 0 месяцев 0 дней', N'0 лет 0 месяцев 0 дней', N'0 лет 0 месяцев 0 дней', 1, 100, 100, 100, 100, 100, 100, 1000)
INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (6010, 3, CAST(N'2001-06-07' AS Date), N'должность1', N'ТД-3', CAST(N'2001-06-07' AS Date), N'1', CAST(N'2001-06-07' AS Date), CAST(N'2001-06-07' AS Date), N'тип места1', N'1 лет 0 месяцев 12 дней', N'1 лет 0 месяцев 12 дней', N'0 лет 0 месяцев 0 дней', 1, 100, 100, 100, 100, 100, 100, 100)
INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (6011, 4, CAST(N'2022-05-16' AS Date), N'должность', N'ТД-4', CAST(N'2022-05-16' AS Date), N'2', CAST(N'2022-05-16' AS Date), CAST(N'2022-05-16' AS Date), N'тип', N'0 лет 0 месяцев 0 дней', N'0 лет 0 месяцев 0 дней', N'0 лет 0 месяцев 0 дней', 1, 100, 100, 100, 100, 100, 100, 1000)
INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (10015, 51, CAST(N'2010-11-11' AS Date), N'Бухгалтер', N'ТД-15', CAST(N'2010-11-11' AS Date), N'15-к', CAST(N'2010-11-11' AS Date), CAST(N'2025-11-11' AS Date), N'Основная', N'22 лет 4 месяцев 19 дней', N'21 лет 11 месяцев 15 дней', N'11 лет 6 месяцев 18 дней', 1, 13000, 5, 650, 13650, 1000, 1, NULL)
INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (13015, 54, CAST(N'2010-02-03' AS Date), N'Программист', N'ТД-17', CAST(N'2010-02-03' AS Date), N'17-к', CAST(N'2010-02-03' AS Date), CAST(N'2030-02-03' AS Date), N'Основная', N'12 лет 2 месяцев 26 дней', N'12 лет 2 месяцев 26 дней', N'12 лет 2 месяцев 26 дней', 1, 13000, 5, 650, 13650, 1000, 1, NULL)
INSERT [dbo].[Трудовая деятельность] ([id], [Код сотрудника], [Дата приема на работу], [Должность], [№ договора], [Дата договора], [№ приказа], [Дата приказа], [Срок договора], [Тип места работы], [Стаж работы общий], [Стаж работы страховой], [Стаж работы на предприятии], [Состоит в профсюзе], [Оклад], [Надбавка], [Всего рублей], [Оклад с надбавкой], [КТУ], [Ставка], [Чето рубли какието ваще хз]) VALUES (14015, 57, CAST(N'2019-07-05' AS Date), N'Кадровик', N'ТД-77', CAST(N'2019-07-05' AS Date), N'90-к', CAST(N'2019-07-05' AS Date), CAST(N'2029-07-05' AS Date), N'Основная', N'0 лет 0 месяцев 23 дней', N'0 лет 0 месяцев 23 дней', N'0 лет 0 месяцев 23 дней', 0, 14000, 8.112, 1135.68, 15135.68, 1000, 1, NULL)
SET IDENTITY_INSERT [dbo].[Трудовая деятельность] OFF
GO
SET IDENTITY_INSERT [dbo].[Трудовая книжка] ON 

INSERT [dbo].[Трудовая книжка] ([ID], [Код сотрудника], [№пп], [Дата], [Сведения о приеме переводах и увольнении], [ОснованиеНаименование], [ОснованиеДата], [ОснованиеНомер], [ОснованиеСерия], [Вид кадрового мероприятия], [Статья ФЗ причины при увольнении], [Пункт ФЗ причины при увольнении], [выполняемая функция(при наличии)], [С даты], [по дату], [признак отмены записи], [дата отмены записи], [совместитель], [должность], [отдел], [работа в районах крайнего севера], [UUID]) VALUES (4009, 51, 18, CAST(N'2022-05-26' AS Date), N'Зачисление в отдел Бухгалтерия на должность Бухгалтер', N'Приказ', CAST(N'2022-05-26' AS Date), N'18-к', N'', N'Прием', N'', N'', N'', CAST(N'0001-01-01' AS Date), CAST(N'0001-01-01' AS Date), 0, CAST(N'0001-01-01' AS Date), 0, N'Бухгалтер', N'Бухгалтерия', N'', N'')
INSERT [dbo].[Трудовая книжка] ([ID], [Код сотрудника], [№пп], [Дата], [Сведения о приеме переводах и увольнении], [ОснованиеНаименование], [ОснованиеДата], [ОснованиеНомер], [ОснованиеСерия], [Вид кадрового мероприятия], [Статья ФЗ причины при увольнении], [Пункт ФЗ причины при увольнении], [выполняемая функция(при наличии)], [С даты], [по дату], [признак отмены записи], [дата отмены записи], [совместитель], [должность], [отдел], [работа в районах крайнего севера], [UUID]) VALUES (6009, 57, 23, CAST(N'2022-05-27' AS Date), N'Зачисление в отдел Кадровый отдел на должность Кадровик', N'Приказ', CAST(N'2022-05-27' AS Date), N'23-к', N'', N'Прием', N'', N'', N'', CAST(N'0001-01-01' AS Date), CAST(N'0001-01-01' AS Date), 0, CAST(N'0001-01-01' AS Date), 0, N'Кадровик', N'Кадровый отдел', N'', N'')
SET IDENTITY_INSERT [dbo].[Трудовая книжка] OFF
GO
ALTER TABLE [dbo].[Воинский учетСот]  WITH CHECK ADD  CONSTRAINT [FK_Воинский учетСот_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Воинский учетСот] CHECK CONSTRAINT [FK_Воинский учетСот_Сотрудник]
GO
ALTER TABLE [dbo].[График работы]  WITH CHECK ADD  CONSTRAINT [FK_График работы_Должность] FOREIGN KEY([Код должности])
REFERENCES [dbo].[Должность] ([Код должности])
GO
ALTER TABLE [dbo].[График работы] CHECK CONSTRAINT [FK_График работы_Должность]
GO
ALTER TABLE [dbo].[График работы]  WITH CHECK ADD  CONSTRAINT [FK_График работы_Подразделение] FOREIGN KEY([Код подразделения])
REFERENCES [dbo].[Подразделение] ([Код подразделения])
GO
ALTER TABLE [dbo].[График работы] CHECK CONSTRAINT [FK_График работы_Подразделение]
GO
ALTER TABLE [dbo].[дополнительные поля]  WITH CHECK ADD  CONSTRAINT [FK_дополнительные поля_Сотрудник] FOREIGN KEY([код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[дополнительные поля] CHECK CONSTRAINT [FK_дополнительные поля_Сотрудник]
GO
ALTER TABLE [dbo].[ОбразовниеСот]  WITH CHECK ADD  CONSTRAINT [FK_ОбразовниеСот_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ОбразовниеСот] CHECK CONSTRAINT [FK_ОбразовниеСот_Сотрудник]
GO
ALTER TABLE [dbo].[Отпуска]  WITH CHECK ADD  CONSTRAINT [FK_Отпуска_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
GO
ALTER TABLE [dbo].[Отпуска] CHECK CONSTRAINT [FK_Отпуска_Сотрудник]
GO
ALTER TABLE [dbo].[Паспортные данныеСот]  WITH CHECK ADD  CONSTRAINT [FK_Паспортные данныеСот_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Паспортные данныеСот] CHECK CONSTRAINT [FK_Паспортные данныеСот_Сотрудник]
GO
ALTER TABLE [dbo].[Приказ о переводе]  WITH CHECK ADD  CONSTRAINT [FK_Приказ о переводе_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
GO
ALTER TABLE [dbo].[Приказ о переводе] CHECK CONSTRAINT [FK_Приказ о переводе_Сотрудник]
GO
ALTER TABLE [dbo].[Приказ о приеме]  WITH CHECK ADD  CONSTRAINT [FK_Приказ о приеме_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
GO
ALTER TABLE [dbo].[Приказ о приеме] CHECK CONSTRAINT [FK_Приказ о приеме_Сотрудник]
GO
ALTER TABLE [dbo].[Приказ об увольнении]  WITH CHECK ADD  CONSTRAINT [FK_Приказ об увольнении_Основания увольнения] FOREIGN KEY([IDОснование])
REFERENCES [dbo].[Основания увольнения] ([ID])
GO
ALTER TABLE [dbo].[Приказ об увольнении] CHECK CONSTRAINT [FK_Приказ об увольнении_Основания увольнения]
GO
ALTER TABLE [dbo].[Трудовая деятельность]  WITH CHECK ADD  CONSTRAINT [FK_Трудовая деятельность_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Трудовая деятельность] CHECK CONSTRAINT [FK_Трудовая деятельность_Сотрудник]
GO
ALTER TABLE [dbo].[Трудовая книжка]  WITH CHECK ADD  CONSTRAINT [FK_Трудовая книжка_Сотрудник] FOREIGN KEY([Код сотрудника])
REFERENCES [dbo].[Сотрудник] ([Табельный номер])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Трудовая книжка] CHECK CONSTRAINT [FK_Трудовая книжка_Сотрудник]
GO
USE [master]
GO
ALTER DATABASE [HR Department] SET  READ_WRITE 
GO
