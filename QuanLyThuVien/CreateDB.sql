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

set dateformat dmy

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

insert into [tblChiTietPhieuMuon] values ('CTPM0001', 'PMS00001', 'S0000004')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0002', 'PMS00001', 'S0000010')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0003', 'PMS00002', 'S0000007')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0004', 'PMS00002', 'S0000011')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0005', 'PMS00002', 'S0000002')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0006', 'PMS00002', 'S0000005')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0007', 'PMS00003', 'S0000010')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0008', 'PMS00004', 'S0000008')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0009', 'PMS00004', 'S0000012')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0010', 'PMS00004', 'S0000013')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0011', 'PMS00005', 'S0000001')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0012', 'PMS00006', 'S0000003')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0013', 'PMS00007', 'S0000009')
GO
insert into [tblChiTietPhieuMuon] values ('CTPM0014', 'PMS00007', 'S0000012')
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

insert into [tblChiTietPhieuTra] values ('CTPT0001', 'S0000010', 'PTS00001')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0002', 'S0000010', 'PTS00002')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0003', 'S0000008', 'PTS00003')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0004', 'S0000012', 'PTS00003')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0005', 'S0000005', 'PTS00004')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0006', 'S0000007', 'PTS00004')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0007', 'S0000002', 'PTS00004')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0008', 'S0000011', 'PTS00005')
GO
insert into [tblChiTietPhieuTra] values ('CTPT0009', 'S0000004', 'PTS00006')
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

insert into [tblDocGia] values ('DG000001', N'Phan Thanh Tùng', '31/01/1998', N'Linh Trung, Thủ Đức, HCM', 'thanhtunga1lqd@gmail.com', '24/06/2017', '1')
GO
insert into [tblDocGia] values ('DG000002', N'Nguyễn Thành Luân', '01/01/1998', N'Linh Trung, Thủ Đức, HCM', 'thanhluana2lqd@gmail.com', '24/06/2017', '2')
GO
insert into [tblDocGia] values ('DG000003', N'Nguyễn Văn A', '01/05/1997', N'Linh Trung, Thủ Đức, HCM', 'nva@gmail.com', '24/06/2017', '2')
GO
insert into [tblDocGia] values ('DG000004', N'Trần Thị B', '31/10/1998', N'Linh Trung, Thủ Đức, HCM', 'ttb@gmail.com', '23/06/2017', '1')
GO
insert into [tblDocGia] values ('DG000005', N'Trần Thị Bưởi', '18/01/1998', N'Linh Trung, Thủ Đức, HCM', 'tbuoi@gmail.com', '22/06/2017', '1')
GO
insert into [tblDocGia] values ('DG000006', N'Vương Giả', '23/12/1995', N'Phường 10, Phú Nhuận, HCM', 'vuonggia@gmail.com', '23/06/2017', '2')
GO
insert into [tblDocGia] values ('DG000007', N'Lưu Bị', '01/02/1990', N'Phường 5, Quận 3, HCM', 'luubi@gmail.com', '20/05/2017', '1')
GO
insert into [tblDocGia] values ('DG000008', N'Tào Tháo', '03/03/1998', N'Bén Nghé, Quận 1, HCM', 'taothao@gmail.com', '23/05/2017', '1')
GO
insert into [tblDocGia] values ('DG000009', N'Lữ Bố', '12/12/1988', N'Phường 26, Bình Thạnh, HCM', 'lubo@gmail.com', '01/04/2017', '2')
GO
insert into [tblDocGia] values ('DG000010', N'Tôn Sách', '10/06/1980', N'Đakao, Quận 1, HCM', 'tonsach@gmail.com', '03/05/2017', '2')
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

insert into [tblLoaiDocGia] values ('1', 'X')
GO
insert into [tblLoaiDocGia] values ('2', 'Y')
GO

/****** Object:  Table [tblNhaXuatBan]    Script Date: 6/10/2018 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblNhaXuatBan](
	[manhaxuatban] [nvarchar](8) NOT NULL,
	[tennhaxuatban] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblNhaXuatBan] values ('NXB00001', N'NXB Trẻ')
GO
insert into [tblNhaXuatBan] values ('NXB00002', N'NXB Già')
GO
insert into [tblNhaXuatBan] values ('NXB00003', N'NXB Kim Đồng')
GO
insert into [tblNhaXuatBan] values ('NXB00004', N'NXB Giáo Dục')
GO
insert into [tblNhaXuatBan] values ('NXB00005', N'NXB Thanh Niên')
GO
insert into [tblNhaXuatBan] values ('NXB00006', N'NXB Thiếu Niên')
GO
insert into [tblNhaXuatBan] values ('NXB00007', N'NXB Ngô Quốc')
GO
insert into [tblNhaXuatBan] values ('NXB00008', N'NXB Nguỵ Quốc')
GO
insert into [tblNhaXuatBan] values ('NXB00009', N'NXB Thục Quốc')
GO
insert into [tblNhaXuatBan] values ('NXB00010', N'NXB Nhã Nam')
GO
insert into [tblNhaXuatBan] values ('NXB00011', N'NXB Thái Hà')
GO
insert into [tblNhaXuatBan] values ('NXB00012', N'NXB Thanh Tùng')
GO
insert into [tblNhaXuatBan] values ('NXB00013', N'NXB Phương Nam')
GO
insert into [tblNhaXuatBan] values ('NXB00014', N'NXB Đông A')
GO
insert into [tblNhaXuatBan] values ('NXB00015', N'NXB Alpha Books')
GO
insert into [tblNhaXuatBan] values ('NXB00016', N'NXB First News')
GO
insert into [tblNhaXuatBan] values ('NXB00017', N'NXB Đông Tây')
GO
insert into [tblNhaXuatBan] values ('NXB00018', N'NXB Đại học Quốc Gia Tp. Hồ Chí Minh')
GO
insert into [tblNhaXuatBan] values ('NXB00019', N'NXB Sư Phạm')
GO
insert into [tblNhaXuatBan] values ('NXB00020', N'NXB Thành Luân')
GO

/****** Object:  Table [dbo].[tblPhieuMuonSach]    Script Date: 6/25/2018 8:12:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuMuonSach](
	[maphieumuonsach] [nvarchar](8) NOT NULL,
	[ngaymuon] [datetime] NOT NULL,
	[madocgia] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblPhieuMuonSach] values ('PMS00001', '20/06/2018', 'DG000003')
GO
insert into [tblPhieuMuonSach] values ('PMS00002', '22/06/2018', 'DG000010')
GO
insert into [tblPhieuMuonSach] values ('PMS00003', '22/06/2018', 'DG000001')
GO
insert into [tblPhieuMuonSach] values ('PMS00004', '23/06/2018', 'DG000005')
GO
insert into [tblPhieuMuonSach] values ('PMS00005', '24/06/2018', 'DG000001')
GO
insert into [tblPhieuMuonSach] values ('PMS00006', '26/06/2018', 'DG000004')
GO
insert into [tblPhieuMuonSach] values ('PMS00007', '26/06/2018', 'DG000002')
GO

/****** Object:  Table [dbo].[tblPhieuTraSach]    Script Date: 6/25/2018 8:15:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuTraSach](
	[maphieutrasach] [nvarchar](8) NOT NULL,
	[ngaytra] [datetime] NOT NULL,
	[madocgia] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieutrasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblPhieuTraSach] values ('PTS00001', '22/06/2018', 'DG000003')
GO
insert into [tblPhieuTraSach] values ('PTS00002', '24/06/2018', 'DG000001')
GO
insert into [tblPhieuTraSach] values ('PTS00003', '24/06/2018', 'DG000005')
GO
insert into [tblPhieuTraSach] values ('PTS00004', '24/06/2018', 'DG000010')
GO
insert into [tblPhieuTraSach] values ('PTS00005', '25/06/2018', 'DG000010')
GO
insert into [tblPhieuTraSach] values ('PTS00006', '26/06/2018', 'DG000003')
GO

/****** Object:  Table [dbo].[tblSach]    Script Date: 6/25/2018 8:15:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSach](
	[masach] [nvarchar](8) NOT NULL,
	[tensach] [nvarchar](50) NOT NULL,
	[manhaxuatban] [nvarchar](8) NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[matrangthai] [int] NOT NULL,
	[namxuatban] [int] NOT NULL,
	[trigia] [int] NOT NULL,
	[madocgiamuon] [nvarchar](8)
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblSach] values ('S0000001', N'Sách 1', 'NXB00006', '01/01/2016', 2, 2012, 100000, 'DG000001')
GO
insert into [tblSach] values ('S0000002', N'Sách 2', 'NXB00002', '01/01/2016', 1, 2012, 52000, '')
GO
insert into [tblSach] values ('S0000003', N'Tam Quốc Diễn Nghĩa 1', 'NXB00008', '01/01/2016', 1, 2011, 500000, '')
GO
insert into [tblSach] values ('S0000004', N'Tây Du Ký', 'NXB00001', '01/01/2016', 2, 2010, 450000, 'DG000004')
GO
insert into [tblSach] values ('S0000005', N'Harry Potter 1', 'NXB00006', '01/01/2016', 1, 2012, 2000000, '')
GO
insert into [tblSach] values ('S0000006', N'Harry Potter 2', 'NXB00006', '01/01/2016', 1, 2012, 200000, '')
GO
insert into [tblSach] values ('S0000007', N'Harry Potter 3', 'NXB00006', '01/01/2016', 1, 2012, 200000, '')
GO
insert into [tblSach] values ('S0000008', N'Harry Potter 4', 'NXB00006', '01/01/2016', 1, 2012, 200000, '')
GO
insert into [tblSach] values ('S0000009', N'Harry Potter 5', 'NXB00006', '01/01/2016', 2, 2012, 200000, 'DG000002')
GO
insert into [tblSach] values ('S0000010', N'Harry Potter 6', 'NXB00006', '01/01/2016', 1, 2012, 200000, '')
GO
insert into [tblSach] values ('S0000011', N'Harry Potter 7', 'NXB00006', '01/01/2016', 1, 2012, 200000, '')
GO
insert into [tblSach] values ('S0000012', N'Tam Quốc Diễn Nghĩa 1', 'NXB00008', '01/01/2016', 2, 2011, 500000, 'DG000002')
GO
insert into [tblSach] values ('S0000013', N'Tam Quốc Diễn Nghĩa 2', 'NXB00008', '01/01/2016', 2, 2011, 500000, 'DG000005')
GO
insert into [tblSach] values ('S0000014', N'Tam Quốc Diễn Nghĩa 3', 'NXB00008', '01/01/2016', 1, 2011, 500000, '')
GO
insert into [tblSach] values ('S0000015', N'Sherlock Holmes 1', 'NXB00019', '01/01/2016', 1, 2010, 780000, '')
GO
insert into [tblSach] values ('S0000016', N'Sherlock Holmes 2', 'NXB00019', '01/01/2016', 1, 2010, 780000, '')
GO
insert into [tblSach] values ('S0000017', N'Sherlock Holmes 3', 'NXB00019', '01/01/2016', 1, 2010, 780000, '')
GO

/****** Object:  Table [dbo].[tblTacGia]    Script Date: 6/25/2018 8:16:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [nvarchar](8) NOT NULL,
	[tentacgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblTacGia] values ('TG001', N'Phan Thanh Tùng')
GO
insert into [tblTacGia] values ('TG002', N'Nguyễn Thành Luân') 
GO
insert into [tblTacGia] values ('TG003', N'Nguyễn Văn A')
GO
insert into [tblTacGia] values ('TG004', N'Lại Thi Lại')
GO
insert into [tblTacGia] values ('TG005', N'Nguyễn Nhật Ánh')
GO
insert into [tblTacGia] values ('TG006', N'Trang Hạ')
GO
insert into [tblTacGia] values ('TG007', N'Nguyễn Phong Việt')
GO
insert into [tblTacGia] values ('TG008', N'Sơn Tùng')
GO
insert into [tblTacGia] values ('TG009', N'Anh Khang')
GO
insert into [tblTacGia] values ('TG010', N'Sơn Paris')
GO
insert into [tblTacGia] values ('TG011', N'Gào')
GO
insert into [tblTacGia] values ('TG012', N'Thét')
GO
insert into [tblTacGia] values ('TG013', N'Phan Thanh Tuấn')
GO
insert into [tblTacGia] values ('TG014', N'Phan Quân')
GO
insert into [tblTacGia] values ('TG015', N'Phan Hải')
GO
insert into [tblTacGia] values ('TG016', N'Phan Thị')
GO
insert into [tblTacGia] values ('TG017', N'Phan Phong Trào')
GO
insert into [tblTacGia] values ('TG018', N'Phan Xuân Quang')
GO
insert into [tblTacGia] values ('TG019', N'Lê Xuân Trường')
GO
insert into [tblTacGia] values ('TG020', N'Hà Nội')
GO
insert into [tblTacGia] values ('TG021', N'Hồ Chí Minh')
GO
insert into [tblTacGia] values ('TG022', N'Đà Nẵng')
GO
insert into [tblTacGia] values ('TG023', N'Phan Cuồng')
GO
insert into [tblTacGia] values ('TG024', N'Phan Thành')
GO
insert into [tblTacGia] values ('TG025', N'Nguyễn Ngọc Thạch')
GO
insert into [tblTacGia] values ('TG026', N'Đỗ Nhật Nam')
GO
insert into [tblTacGia] values ('TG027', N'Hamlet Trương')
GO
insert into [tblTacGia] values ('TG028', N'Iris Cao')
GO
insert into [tblTacGia] values ('TG029', N'Adam Lalana')
GO
insert into [tblTacGia] values ('TG030', N'Ronaldo')
GO
insert into [tblTacGia] values ('TG031', N'Wayne Bruce')
GO
insert into [tblTacGia] values ('TG032', N'Clark Kent')
GO
insert into [tblTacGia] values ('TG033', N'Diana Prince')
GO
insert into [tblTacGia] values ('TG034', N'Iron Man')
GO
insert into [tblTacGia] values ('TG035', N'Tony Stark')
GO
insert into [tblTacGia] values ('TG036', N'Bruce Banner')
GO
insert into [tblTacGia] values ('TG037', N'Steve Roger')
GO
insert into [tblTacGia] values ('TG038', N'Thor')
GO
insert into [tblTacGia] values ('TG039', N'Hawkeye')
GO
insert into [tblTacGia] values ('TG040', N'Natasha')
GO
insert into [tblTacGia] values ('TG041', N'Vision')
GO
insert into [tblTacGia] values ('TG042', N'Xuân Diệu')
GO
insert into [tblTacGia] values ('TG043', N'Xuân Quỳnh')
GO
insert into [tblTacGia] values ('TG044', N'Tú Xương')
GO
insert into [tblTacGia] values ('TG045', N'Tú Mỡ')
GO
insert into [tblTacGia] values ('TG046', N'Đỗ Trọng Phụng')
GO
insert into [tblTacGia] values ('TG047', N'Hồ Xuân Hương')
GO
insert into [tblTacGia] values ('TG048', N'Bà Huyện Thanh Quan')
GO
insert into [tblTacGia] values ('TG049', N'Nguyễn Du')
GO
insert into [tblTacGia] values ('TG050', N'Đỗ Phủ')
GO
insert into [tblTacGia] values ('TG051', N'Nguyễn Bỉnh Khiêm')
GO
insert into [tblTacGia] values ('TG052', N'Chế Lan Viên')
GO
insert into [tblTacGia] values ('TG053', N'Lê Đạt')
GO
insert into [tblTacGia] values ('TG054', N'Lê Đỗ')
GO
insert into [tblTacGia] values ('TG055', N'Lê Rớt')
GO
insert into [tblTacGia] values ('TG056', N'Lê Tạch')
GO
insert into [tblTacGia] values ('TG057', N'Nguyễn Trãi')
GO
insert into [tblTacGia] values ('TG058', N'Tản Đà')
GO
insert into [tblTacGia] values ('TG059', N'Cao Bá Quát')
GO
insert into [tblTacGia] values ('TG060', N'Hàn Mạc Tử')
GO
insert into [tblTacGia] values ('TG061', N'Nguyễn Duy')
GO
insert into [tblTacGia] values ('TG062', N'Tố Hữu')
GO
insert into [tblTacGia] values ('TG063', N'Nguyễn Bính')
GO
insert into [tblTacGia] values ('TG064', N'Nguyễn Khuyến')
GO
insert into [tblTacGia] values ('TG065', N'Huy Cận')
GO
insert into [tblTacGia] values ('TG066', N'Luân Cận')
GO
insert into [tblTacGia] values ('TG067', N'Phan Bội Châu')
GO
insert into [tblTacGia] values ('TG068', N'Phan Chu Trinh')
GO
insert into [tblTacGia] values ('TG069', N'Lưu Quang Vũ')
GO
insert into [tblTacGia] values ('TG070', N'Bằng Việt')
GO
insert into [tblTacGia] values ('TG071', N'Quách Gia')
GO
insert into [tblTacGia] values ('TG072', N'Thu Bồn')
GO
insert into [tblTacGia] values ('TG073', N'Trần Đăng Khoa')
GO
insert into [tblTacGia] values ('TG074', N'Nguyễn Khoa Điềm')
GO
insert into [tblTacGia] values ('TG075', N'Nguyễn Đình Chiểu')
GO
insert into [tblTacGia] values ('TG076', N'Nguyễn Công Trứ')
GO
insert into [tblTacGia] values ('TG077', N'Lưu Trọng Lư')
GO
insert into [tblTacGia] values ('TG078', N'Đỗ Trung Quân')
GO
insert into [tblTacGia] values ('TG079', N'Lý Bạch')
GO
insert into [tblTacGia] values ('TG080', N'Bạch Cư Dị')
GO
insert into [tblTacGia] values ('TG081', N'Vương Duy')
GO
insert into [tblTacGia] values ('TG082', N'Khổng Tử')
GO
insert into [tblTacGia] values ('TG083', N'Đỗ Mục')
GO
insert into [tblTacGia] values ('TG084', N'Gia Cát Lượng')
GO
insert into [tblTacGia] values ('TG085', N'Tào Tháo')
GO
insert into [tblTacGia] values ('TG086', N'Tào Thực')
GO
insert into [tblTacGia] values ('TG087', N'Lục Tốn')
GO
insert into [tblTacGia] values ('TG088', N'Chu Du')
GO
insert into [tblTacGia] values ('TG089', N'Tuân Úc')
GO
insert into [tblTacGia] values ('TG090', N'Trương Cáp')
GO
insert into [tblTacGia] values ('TG091', N'Bàng Thống')
GO
insert into [tblTacGia] values ('TG092', N'Đồng Hoa')
GO
insert into [tblTacGia] values ('TG093', N'Đinh Diện')
GO
insert into [tblTacGia] values ('TG094', N'Đinh Mặc')
GO
insert into [tblTacGia] values ('TG095', N'Ngô Thừa Ân')
GO
insert into [tblTacGia] values ('TG096', N'J.K.Rowling')
GO
insert into [tblTacGia] values ('TG097', N'William Shakespeare')
GO
insert into [tblTacGia] values ('TG098', N'Lev Tolstoy')
GO
insert into [tblTacGia] values ('TG099', N'Victor Hugo')
GO
insert into [tblTacGia] values ('TG100', N'Puskin')
GO

/****** Object:  Table [dbo].[tblTacGiaSach]    Script Date: 6/25/2018 8:16:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTacGiaSach](
	[matacgiasach] [nvarchar](8) NOT NULL,
	[masach] [nvarchar](8) NULL,
	[matacgia] [nvarchar](8) NULL,
 CONSTRAINT [PK_tblTacGiaSach] PRIMARY KEY CLUSTERED 
(
	[matacgiasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblTacGiaSach] values ('TGS00001', 'S0000001', 'TG020')
insert into [tblTacGiaSach] values ('TGS00002', 'S0000002', 'TG018')
insert into [tblTacGiaSach] values ('TGS00003', 'S0000005', 'TG006')
insert into [tblTacGiaSach] values ('TGS00004', 'S0000002', 'TG018')
insert into [tblTacGiaSach] values ('TGS00005', 'S0000016', 'TG001')
insert into [tblTacGiaSach] values ('TGS00006', 'S0000008', 'TG019')
insert into [tblTacGiaSach] values ('TGS00007', 'S0000010', 'TG098')
insert into [tblTacGiaSach] values ('TGS00008', 'S0000006', 'TG031')
insert into [tblTacGiaSach] values ('TGS00009', 'S0000004', 'TG001')
insert into [tblTacGiaSach] values ('TGS00010', 'S0000017', 'TG019')
insert into [tblTacGiaSach] values ('TGS00011', 'S0000007', 'TG098')
insert into [tblTacGiaSach] values ('TGS00012', 'S0000003', 'TG010')
insert into [tblTacGiaSach] values ('TGS00013', 'S0000009', 'TG020')
insert into [tblTacGiaSach] values ('TGS00014', 'S0000011', 'TG030')
insert into [tblTacGiaSach] values ('TGS00015', 'S0000012', 'TG022')
insert into [tblTacGiaSach] values ('TGS00016', 'S0000013', 'TG033')
insert into [tblTacGiaSach] values ('TGS00017', 'S0000014', 'TG044')

/****** Object:  Table [dbo].[tblThamSo]    Script Date: 6/25/2018 8:16:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblThamSo](
	[tuoitoithieu] [smallint] NOT NULL,
	[tuoitoida] [smallint] NOT NULL,
	[hansudung] [smallint] NOT NULL,
	[namxuatbantoithieu] [smallint] NOT NULL,
	[soluongsachmuontoida] [smallint] NOT NULL,
	[thoigianmuontoida] [smallint] NOT NULL
) ON [PRIMARY]

GO

insert into [tblThamSo] values (18, 55, 6, 8, 5, 4)

/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 6/25/2018 8:18:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTheLoai](
	[matheloai] [nvarchar](8) NOT NULL,
	[tentheloai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTheLoai] PRIMARY KEY CLUSTERED 
(
	[matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblTheLoai] values ('TL1', 'A')
GO
insert into [tblTheLoai] values ('TL2', 'B')
GO
insert into [tblTheLoai] values ('TL3', 'C')
GO

/****** Object:  Table [dbo].[tblTheLoaiSach]    Script Date: 6/25/2018 8:19:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTheLoaiSach](
	[matheloaisach] [nvarchar](8) NULL,
	[masach] [nvarchar](8) NULL,
	[matheloai] [nvarchar](8) NULL
) ON [PRIMARY]

GO

insert into [tblTheLoaiSach] values ('TLS00001', 'S0000001', 'TL1')
insert into [tblTheLoaiSach] values ('TLS00002', 'S0000002', 'TL2')
insert into [tblTheLoaiSach] values ('TLS00003', 'S0000003', 'TL2')
insert into [tblTheLoaiSach] values ('TLS00004', 'S0000004', 'TL3')
insert into [tblTheLoaiSach] values ('TLS00005', 'S0000005', 'TL3')
insert into [tblTheLoaiSach] values ('TLS00006', 'S0000006', 'TL1')
insert into [tblTheLoaiSach] values ('TLS00007', 'S0000007', 'TL3')
insert into [tblTheLoaiSach] values ('TLS00008', 'S0000008', 'TL1')
insert into [tblTheLoaiSach] values ('TLS00009', 'S0000009', 'TL2')
insert into [tblTheLoaiSach] values ('TLS00010', 'S0000010', 'TL1')
insert into [tblTheLoaiSach] values ('TLS00011', 'S0000011', 'TL2')
insert into [tblTheLoaiSach] values ('TLS00012', 'S0000012', 'TL2')
insert into [tblTheLoaiSach] values ('TLS00013', 'S0000013', 'TL3')
insert into [tblTheLoaiSach] values ('TLS00014', 'S0000014', 'TL1')
insert into [tblTheLoaiSach] values ('TLS00015', 'S0000015', 'TL3')
insert into [tblTheLoaiSach] values ('TLS00016', 'S0000016', 'TL3')
insert into [tblTheLoaiSach] values ('TLS00017', 'S0000017', 'TL1')

/****** Object:  Table [dbo].[tblTrangThai]    Script Date: 6/25/2018 8:19:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTrangThai](
	[matrangthai] [int] NOT NULL,
	[tentrangthai] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblTrangThai] PRIMARY KEY CLUSTERED 
(
	[matrangthai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into [tblTrangThai] values (1, N'Còn sách')
GO
insert into [tblTrangThai] values (2, N'Đã mượn')
GO

SELECT dg.[hotendocgia], dg.[ngaylapthe], ctpm.[masach] 
FROM [tblDocGia] dg, [tblPhieuMuonSach] pms, [tblChiTietPhieuMuon] ctpm
WHERE 
pms.[madocgia] = dg.[madocgia]
AND ctpm.[maphieumuonsach] = pms.[maphieumuonsach]
AND dg.[madocgia] = 'DG000001'
GROUP BY dg.[hotendocgia], dg.[ngaylapthe], ctpm.[masach] 