USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QuanLyThuVien')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QuanLyThuVien') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QuanLyThuVien]
END
GO


USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 6/10/2018 10:23:54 PM ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [tblChiTietPhieuMuon]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblChiTietPhieuMuon](
	[machitietphieumuon] [nvarchar](8) NOT NULL,
	[maphieumuonsach] [nvarchar](8) NOT NULL,
	[masach] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[machitietphieumuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblChiTietPhieuTra]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblChiTietPhieuTra](
	[machitietphieutra] [nvarchar](8) NOT NULL,
	[masach] [nvarchar](8) NOT NULL,
	[maphieutrasach] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuTra] PRIMARY KEY CLUSTERED 
(
	[machitietphieutra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblDocGia]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [tblDocGia](
	[madocgia] [nvarchar](8) NOT NULL,
	[hotendocgia] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](30) NOT NULL,
	[ngaylapthe] [datetime] NOT NULL,
	[maloaidocgia] [char](1) NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [tblLoaiDocGia]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [tblLoaiDocGia](
	[maloaidocgia] [char](1) NOT NULL,
	[tenloaidocgia] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [tblNhaXuatBan]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblNhaXuatBan](
	[manhaxuatban] [nvarchar](8) NOT NULL,
	[tennhanxuatban] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblPhieuMuonSach]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblPhieuMuonSach](
	[maphieumuonsach] [nvarchar](8) NOT NULL,
	[ngaymuon] [datetime] NOT NULL,
	[madocgia] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblPhieuTraSach]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblPhieuTraSach](
	[maphieutrasach] [nvarchar](8) NOT NULL,
	[ngaytra] [datetime] NOT NULL,
	[madocgia] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieutrasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblSach]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblSach](
	[masach] [nvarchar](8) NOT NULL,
	[tensach] [nvarchar](50) NOT NULL,
	[namxuatban] [datetime] NOT NULL,
	[manhaxuatban] [nvarchar](8) NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[trigia] [money] NOT NULL,
	[matacgia] [nvarchar](8) NOT NULL,
	[matheloai] [nvarchar](8) NOT NULL,
	[matrangthai] [int] NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblTacGia]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblTacGia](
	[matacgia] [nvarchar](8) NOT NULL,
	[tentacgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblThamSo]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblThamSo](
	[tuoitoithieu] [smallint] NOT NULL,
	[tuoitoida] [smallint] NOT NULL,
	[hansudung] [smallint] NOT NULL,
	[namxuatbantoithieu] [datetime] NOT NULL,
	[soluongsachmuontoida] [smallint] NOT NULL,
	[thoigianmuontoida] [smallint] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [tblTheLoai]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblTheLoai](
	[matheloai] [nvarchar](8) NOT NULL,
	[tentheloai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTheLoai] PRIMARY KEY CLUSTERED 
(
	[matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tblTrangThai]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblTrangThai](
	[matrangthai] [int] NOT NULL,
	[tentrangthai] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblTrangThai] PRIMARY KEY CLUSTERED 
(
	[matrangthai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [tblChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuMuon_tblPhieuMuonSach] FOREIGN KEY([maphieumuonsach])
REFERENCES [tblPhieuMuonSach] ([maphieumuonsach])
GO
ALTER TABLE [tblChiTietPhieuMuon] CHECK CONSTRAINT [FK_tblChiTietPhieuMuon_tblPhieuMuonSach]
GO
ALTER TABLE [tblChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuTraSach] FOREIGN KEY([maphieutrasach])
REFERENCES [tblPhieuTraSach] ([maphieutrasach])
GO
ALTER TABLE [tblChiTietPhieuTra] CHECK CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuTraSach]
GO
ALTER TABLE [tblPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuonSach_tblDocGia] FOREIGN KEY([madocgia])
REFERENCES [tblDocGia] ([madocgia])
GO
ALTER TABLE [tblPhieuMuonSach] CHECK CONSTRAINT [FK_tblPhieuMuonSach_tblDocGia]
GO
ALTER TABLE [tblPhieuTraSach]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuTraSach_tblDocGia] FOREIGN KEY([madocgia])
REFERENCES [tblDocGia] ([madocgia])
GO
ALTER TABLE [tblPhieuTraSach] CHECK CONSTRAINT [FK_tblPhieuTraSach_tblDocGia]
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
