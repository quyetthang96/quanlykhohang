USE [master]
GO
/****** Object:  Database [quanlykho]    Script Date: 3/9/2017 8:16:45 AM ******/
CREATE DATABASE [quanlykho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlykho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\quanlykho.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlykho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\quanlykho_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlykho] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlykho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlykho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlykho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlykho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlykho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlykho] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlykho] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quanlykho] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [quanlykho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlykho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlykho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlykho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlykho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlykho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlykho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlykho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlykho] SET  DISABLE_BROKER 
GO
ALTER DATABASE [quanlykho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlykho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlykho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlykho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlykho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlykho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlykho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlykho] SET RECOVERY FULL 
GO
ALTER DATABASE [quanlykho] SET  MULTI_USER 
GO
ALTER DATABASE [quanlykho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlykho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlykho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlykho] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'quanlykho', N'ON'
GO
USE [quanlykho]
GO
/****** Object:  Table [dbo].[chitietphieunhap]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieunhap](
	[so_pn] [nvarchar](10) NOT NULL,
	[ma_hh] [nvarchar](10) NOT NULL,
	[ma_kho] [nvarchar](10) NULL,
	[soluong] [nchar](10) NULL,
	[dongia] [nchar](10) NULL,
 CONSTRAINT [PK_phieunhap] PRIMARY KEY CLUSTERED 
(
	[so_pn] ASC,
	[ma_hh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTphieuxuat]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTphieuxuat](
	[so_px] [nvarchar](10) NOT NULL,
	[ma_hh] [nvarchar](10) NOT NULL,
	[ma_kho] [nvarchar](10) NULL,
	[soluong] [nchar](10) NULL,
	[dongia] [nchar](10) NULL,
 CONSTRAINT [PK_CTphieuxuat] PRIMARY KEY CLUSTERED 
(
	[so_px] ASC,
	[ma_hh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hanghoa]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanghoa](
	[ma_hh] [nvarchar](10) NOT NULL,
	[ten_hh] [nchar](100) NULL,
	[ma_nhom] [nchar](10) NULL,
	[dvt] [nchar](10) NULL,
 CONSTRAINT [PK_hanghoa] PRIMARY KEY CLUSTERED 
(
	[ma_hh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[ma_khach] [nvarchar](10) NOT NULL,
	[tenkhachhang] [nchar](100) NULL,
	[diachi] [nchar](10) NULL,
	[ghichu] [nchar](10) NULL,
	[sodienthoai] [nchar](10) NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[ma_khach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kho]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kho](
	[ma_kho] [nvarchar](10) NOT NULL,
	[tenkho] [nchar](100) NULL,
	[sdt] [nchar](10) NULL,
	[diachi] [nchar](10) NULL,
 CONSTRAINT [PK_kho] PRIMARY KEY CLUSTERED 
(
	[ma_kho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[ma_ncc] [nvarchar](10) NOT NULL,
	[ten_ncc] [nchar](100)NULL,
	[diachi] [nchar](10) NULL,
	[sodienthoai] [nchar](10) NULL,
	[ghichu] [nchar](10) NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[ma_ncc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieunhap1]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieunhap1](
	[so_pn] [nvarchar](10) NOT NULL,
	[ngaynhap] [datetime] NULL,
	[ma_ncc] [nvarchar](10) NULL,
	[nguoigiao] [nchar](10) NULL,
	[noidung] [nchar](10) NULL,
	[taikhoan] [nchar](10) NULL,
	[ma_kho] [nvarchar](10) NULL,
 CONSTRAINT [PK_phieunhap1] PRIMARY KEY CLUSTERED 
(
	[so_pn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieuxuat]    Script Date: 3/9/2017 8:16:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuxuat](
	[so_px] [nvarchar](10) NOT NULL,
	[ngayxuat] [datetime] NULL,
	[ma_kho] [nvarchar](10) NULL,
	[nguoinhan] [nchar](10) NULL,
	[ghichu] [nchar](10) NULL,
	[taikhoanno] [nchar](10) NULL,
	[ma_khach] [nvarchar](10) NULL,
 CONSTRAINT [PK_phieuxuat_1] PRIMARY KEY CLUSTERED 
(
	[so_px] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieunhap_hanghoa] FOREIGN KEY([ma_hh])
REFERENCES [dbo].[hanghoa] ([ma_hh])
GO
ALTER TABLE [dbo].[chitietphieunhap] CHECK CONSTRAINT [FK_chitietphieunhap_hanghoa]
GO
ALTER TABLE [dbo].[chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieunhap_phieunhap1] FOREIGN KEY([so_pn])
REFERENCES [dbo].[phieunhap1] ([so_pn])
GO
ALTER TABLE [dbo].[chitietphieunhap] CHECK CONSTRAINT [FK_chitietphieunhap_phieunhap1]
GO
ALTER TABLE [dbo].[CTphieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_CTphieuxuat_hanghoa] FOREIGN KEY([ma_hh])
REFERENCES [dbo].[hanghoa] ([ma_hh])
GO
ALTER TABLE [dbo].[CTphieuxuat] CHECK CONSTRAINT [FK_CTphieuxuat_hanghoa]
GO
ALTER TABLE [dbo].[CTphieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_CTphieuxuat_phieuxuat] FOREIGN KEY([so_px])
REFERENCES [dbo].[phieuxuat] ([so_px])
GO
ALTER TABLE [dbo].[CTphieuxuat] CHECK CONSTRAINT [FK_CTphieuxuat_phieuxuat]
GO
ALTER TABLE [dbo].[phieunhap1]  WITH CHECK ADD  CONSTRAINT [FK_phieunhap1_kho] FOREIGN KEY([ma_kho])
REFERENCES [dbo].[kho] ([ma_kho])
GO
ALTER TABLE [dbo].[phieunhap1] CHECK CONSTRAINT [FK_phieunhap1_kho]
GO
ALTER TABLE [dbo].[phieunhap1]  WITH CHECK ADD  CONSTRAINT [FK_phieunhap1_nhacungcap] FOREIGN KEY([ma_ncc])
REFERENCES [dbo].[nhacungcap] ([ma_ncc])
GO
ALTER TABLE [dbo].[phieunhap1] CHECK CONSTRAINT [FK_phieunhap1_nhacungcap]
GO
ALTER TABLE [dbo].[phieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_phieuxuat_khachhang] FOREIGN KEY([ma_khach])
REFERENCES [dbo].[khachhang] ([ma_khach])
GO
ALTER TABLE [dbo].[phieuxuat] CHECK CONSTRAINT [FK_phieuxuat_khachhang]
GO
ALTER TABLE [dbo].[phieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_phieuxuat_kho] FOREIGN KEY([ma_kho])
REFERENCES [dbo].[kho] ([ma_kho])
GO
ALTER TABLE [dbo].[phieuxuat] CHECK CONSTRAINT [FK_phieuxuat_kho]
GO
USE [master]
GO
ALTER DATABASE [quanlykho] SET  READ_WRITE 
GO
