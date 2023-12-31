USE [master]
GO
/****** Object:  Database [nevsehirDb]    Script Date: 11.05.2023 15:46:32 ******/
CREATE DATABASE [nevsehirDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nevsehirDb', FILENAME = N'C:\Users\talha\nevsehirDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'nevsehirDb_log', FILENAME = N'C:\Users\talha\nevsehirDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [nevsehirDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nevsehirDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nevsehirDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nevsehirDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nevsehirDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nevsehirDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nevsehirDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [nevsehirDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [nevsehirDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nevsehirDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nevsehirDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nevsehirDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nevsehirDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nevsehirDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nevsehirDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nevsehirDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nevsehirDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [nevsehirDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nevsehirDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nevsehirDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nevsehirDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nevsehirDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nevsehirDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [nevsehirDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nevsehirDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [nevsehirDb] SET  MULTI_USER 
GO
ALTER DATABASE [nevsehirDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nevsehirDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nevsehirDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nevsehirDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [nevsehirDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [nevsehirDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [nevsehirDb] SET QUERY_STORE = OFF
GO
USE [nevsehirDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11.05.2023 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sehirTable]    Script Date: 11.05.2023 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sehirTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sehir] [nvarchar](max) NOT NULL,
	[SehirAciklama] [nvarchar](max) NOT NULL,
	[AltBaslik] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_sehirTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sliderEkle]    Script Date: 11.05.2023 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sliderEkle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SliderResim] [nvarchar](max) NOT NULL,
	[SliderBaslik] [nvarchar](max) NOT NULL,
	[SliderAciklama] [nvarchar](max) NOT NULL,
	[sehirId] [int] NOT NULL,
 CONSTRAINT [PK_sliderEkle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230502144131_1', N'6.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230504080223_iki', N'6.0.0')
GO
SET IDENTITY_INSERT [dbo].[sehirTable] ON 

INSERT [dbo].[sehirTable] ([Id], [Sehir], [SehirAciklama], [AltBaslik]) VALUES (1, N'Avanos', N'<p><strong>Avanos</strong>, Nevşehir İline bağlı bir il&ccedil;edir. Nevşehir&#39;in <em>18 km kuzeyinde</em> olan yerleşiminin, Antik Devirdeki adı <em>Venessa</em>, <em>Zuwinasa </em>ya da <em>Ouenasadır</em>. &Ccedil;ok sayıda <strong>&ccedil;anak &ccedil;&ouml;mlek</strong> at&ouml;lyesi bulunan il&ccedil;ede <em>seramik yapım geleneği</em> <strong>Hititlerden </strong>beri s&uuml;regelmektedir.<em>Merkez bucağına bağlı 3</em>, <em>&Ouml;zkonak bucağına bağlı 10</em> ve <em>Topaklı bucağına bağlı 5</em> <strong>k&ouml;y&uuml; </strong>vardır.</p>
', N'Güzel Manzaralı İlçe')
INSERT [dbo].[sehirTable] ([Id], [Sehir], [SehirAciklama], [AltBaslik]) VALUES (2, N'Göreme', N'<p><strong>G&ouml;reme</strong>, Nevşehir ili <em>Merkez il&ccedil;esi</em>ne bağlı bir beldedir. <em>En &ouml;nemli ge&ccedil;im kaynağı turizmdir</em>. G&ouml;reme, G&ouml;reme kasabasının eski isimleri <em>Matiana</em>, <em>Korama</em>, <em>Maccan </em>ve <em>Avcılar</em>&#39;dır. G&ouml;reme ile ilgili <em>6. y&uuml;zyıl</em>a ait bir belgede ilk olarak &quot;<strong>Korama</strong>&quot; adına rastlanıldığından dolayı en eski adının bu&nbsp;olduğu&nbsp;d&uuml;ş&uuml;n&uuml;lmektedir. G&ouml;reme&#39;nin en &uuml;nl&uuml; &ouml;renyeri <em>G&ouml;reme A&ccedil;ıkhava M&uuml;zesi</em> olarak bilinen, kayalara oyulu bir&ccedil;ok kilisenin yer aldığı <em>G&ouml;reme Tarih&icirc; Mill&icirc; Parkı b&ouml;lgesi</em>dir.</p>
', N'Nevşehir İl Merkezine 10km Uzaklıkta')
INSERT [dbo].[sehirTable] ([Id], [Sehir], [SehirAciklama], [AltBaslik]) VALUES (3, N'Hacıbektaş', N'<p><strong>Hacıbektaş</strong>, Nevşehir iline bağlı bir il&ccedil;edir. <em>Kapadokya&#39;nın &ouml;nemli merkezlerinden biridir</em>. <em>Doğuda Avanos</em>, <em>batıda Mucur</em>, <em>g&uuml;neyde G&uuml;lşehir</em>, <em>kuzeyde Kozaklı</em> il&ccedil;eleriyle &ccedil;evrilidir. 13. y&uuml;zyılda T&uuml;rk d&uuml;ş&uuml;n&uuml;r&uuml; <strong>Hacı Bektaş-i Veli</strong>&#39;nin Horasan&#39;ın Nişabur kentinden Anadolu&#39;ya gelmesi ve Suluca Karah&ouml;y&uuml;k&#39;e yerleşmesinden sonra yedi hanelik Hacım K&ouml;y&uuml;&#39;n&uuml;n &ccedil;ehresi değişti. <em>Hacı Bektaş-i Vel&icirc;</em>, burada bir ilim yuvası kurarak d&uuml;ş&uuml;ncelerini yaymış;<em> &ouml;l&uuml;m&uuml;nden sonra da k&ouml;y&uuml;n ismi</em>, adına ve anısına izafeten <em><strong>Hacıbektaş </strong>olarak değiştirilmiştir.</em></p>
', N'Hacı Bektaş-i Veli''nin Selamlarıyla')
INSERT [dbo].[sehirTable] ([Id], [Sehir], [SehirAciklama], [AltBaslik]) VALUES (4, N'Ürgüp', N'<p><strong>&Uuml;rg&uuml;p</strong>, <em>Nevşehir İlinin 20 km doğusunda</em> olan il&ccedil;esidir ve<em> Kapadokya b&ouml;lgesinin &ouml;nemli merkezlerinden birisidir</em>. G&ouml;reme&#39;de olduğu gibi tarihsel s&uuml;re&ccedil; i&ccedil;erisinde &ccedil;ok sayıda isme sahip olmuştur. <em>Bizans d&ouml;neminde Osiana (Assiana)</em>, <em>Hagios Prokopios (Prokopi)</em>; <em>Sel&ccedil;uklu Hanedanı d&ouml;neminde Başhisar</em>; <em>Osmanlılar zamanında Burgut kalesi</em>; <em>Cumhuriyetin ilk yıllarından itibaren de <strong>&Uuml;rg&uuml;p</strong></em><strong> </strong>adıyla anılmıştır.</p>
', N'Birçok Adı Vardır')
SET IDENTITY_INSERT [dbo].[sehirTable] OFF
GO
SET IDENTITY_INSERT [dbo].[sliderEkle] ON 

INSERT [dbo].[sliderEkle] ([Id], [SliderResim], [SliderBaslik], [SliderAciklama], [sehirId]) VALUES (1, N'8e657e7f-22be-4962-947b-f39c75f2c94d avanos1.jpg', N'Avanos 1', N'Avanos', 1)
INSERT [dbo].[sliderEkle] ([Id], [SliderResim], [SliderBaslik], [SliderAciklama], [sehirId]) VALUES (2, N'3b4a7fed-3529-4602-9089-206133200c54 goreme1.png', N'Göreme1', N'Göreme', 2)
INSERT [dbo].[sliderEkle] ([Id], [SliderResim], [SliderBaslik], [SliderAciklama], [sehirId]) VALUES (3, N'5e10300f-2374-4c40-a717-3ffaa141d30e hacibektas1.png', N'Hacıbektaş1', N'Hacıbektaş ', 3)
INSERT [dbo].[sliderEkle] ([Id], [SliderResim], [SliderBaslik], [SliderAciklama], [sehirId]) VALUES (4, N'a9fafd67-e8ca-44a3-9cb6-0a4ceefe48c0 urgup1.jpg', N'Ürgüp1', N'Ürgüp', 1)
SET IDENTITY_INSERT [dbo].[sliderEkle] OFF
GO
ALTER TABLE [dbo].[sliderEkle] ADD  DEFAULT ((0)) FOR [sehirId]
GO
USE [master]
GO
ALTER DATABASE [nevsehirDb] SET  READ_WRITE 
GO
