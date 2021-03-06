USE [QLNHAHANG]
GO
/****** Object:  Table [dbo].[BANAN]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANAN](
	[MaB] [int] NOT NULL,
	[SoKhach_ToiDa] [int] NULL,
	[TinhTrang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [int] NOT NULL,
	[TenCV] [nvarchar](30) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHD] [char](5) NOT NULL,
	[MaM] [char](5) NOT NULL,
	[SL_Mon] [int] NULL,
	[TongTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [char](5) NOT NULL,
	[MaNV] [char](5) NULL,
	[MaB] [int] NULL,
	[MaKM] [char](5) NULL,
	[NgayLap] [date] NULL,
	[GioVao] [char](10) NULL,
	[GioRa] [char](10) NULL,
	[SL_Khach] [int] NULL,
	[TongThanhToan] [money] NULL,
	[TienKhachDua] [money] NULL,
	[TienThua] [money] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK__HOADON__2725A6E0EEC28D6C] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [char](5) NOT NULL,
	[HoTenKH] [nvarchar](30) NULL,
	[CMND_KH] [char](15) NULL,
	[SDT_KH] [char](10) NULL,
	[Mail_KH] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUYENMAI]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUYENMAI](
	[MaKM] [char](5) NOT NULL,
	[TenKM] [nvarchar](50) NULL,
	[NgayBD] [date] NULL,
	[NgayKT] [date] NULL,
	[PhanTramKM] [int] NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LUONG]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONG](
	[MaBacLuong] [int] NOT NULL,
	[HeSoLuong] [float] NULL,
	[LuongCoBan] [money] NULL,
 CONSTRAINT [PK_LUONG] PRIMARY KEY CLUSTERED 
(
	[MaBacLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LUONGNV]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONGNV](
	[MaBacLuong] [int] NOT NULL,
	[MaNV] [char](5) NOT NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_LUONGNV] PRIMARY KEY CLUSTERED 
(
	[MaBacLuong] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONAN](
	[MaM] [char](5) NOT NULL,
	[TenM] [nvarchar](30) NULL,
	[Gia] [money] NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](5) NOT NULL,
	[HoTenNV] [nvarchar](30) NULL,
	[CMND_NV] [char](15) NULL,
	[SDT_NV] [char](10) NULL,
	[Mail_NV] [varchar](20) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[HoTen_NguoiLH] [nvarchar](30) NULL,
	[SDT_NguoiLH] [char](10) NULL,
	[MaCV] [int] NULL,
	[MatKhau] [varchar](20) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK__NHANVIEN__2725D70A431EB179] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUDATBAN]    Script Date: 12/16/2020 8:47:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDATBAN](
	[MaPDB] [char](5) NOT NULL,
	[MaB] [int] NULL,
	[MaKH] [char](5) NULL,
	[NgayDat] [date] NULL,
	[GioDat] [char](10) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK__PHIEUDAT__3AE048FDF07FB416] PRIMARY KEY CLUSTERED 
(
	[MaPDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (1, 4, 2)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (2, 4, 2)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (3, 4, 2)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (4, 4, 2)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (5, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (6, 4, 2)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (7, 4, 2)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (8, 4, 2)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (9, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (10, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (11, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (12, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (13, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (14, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (15, 4, 1)
INSERT [dbo].[BANAN] ([MaB], [SoKhach_ToiDa], [TinhTrang]) VALUES (16, 4, 1)
GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (1, N'Admin')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (2, N'Nhân viên')
GO
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD01 ', N'mon1 ', 1, 80000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD01 ', N'mon2 ', 1, 50000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD01 ', N'mon3 ', 1, 90000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD01 ', N'mon4 ', 1, 30000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD02 ', N'mon1 ', 1, 80000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD02 ', N'mon2 ', 1, 50000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD02 ', N'mon3 ', 1, 90000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD02 ', N'mon6 ', 1, 30000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD03 ', N'mon1 ', 1, 80000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD03 ', N'mon2 ', 3, 150000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD03 ', N'mon4 ', 1, 30000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD03 ', N'mon6 ', 1, 30000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD04 ', N'mon2 ', 4, 200000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD05 ', N'mon2 ', 8, 400000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD06 ', N'mon2 ', 4, 200000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'hd07 ', N'mon1 ', 1, 80000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'hd07 ', N'mon3 ', 1, 90000.0000)
INSERT [dbo].[CTHD] ([MaHD], [MaM], [SL_Mon], [TongTien]) VALUES (N'HD8  ', N'mon1 ', 1, 80000.0000)
GO
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD01 ', N'nv03 ', 1, N'KM2  ', CAST(N'2020-09-09' AS Date), N'19:00:00.0', N'21:15:00.0', 3, 220000.0000, 250000.0000, 30000.0000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD02 ', N'nv03 ', 2, N'KM1  ', CAST(N'2020-09-09' AS Date), N'19:00:00.0', N'21:15:00.0', 4, 220000.0000, 250000.0000, 30000.0000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD03 ', N'nv03 ', 3, N'KM1  ', CAST(N'2020-09-09' AS Date), N'19:00:00.0', N'21:15:00.0', 3, 150000.0000, 150000.0000, 0.0000, 1)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD04 ', N'nv03 ', 3, N'KM2  ', CAST(N'2020-09-15' AS Date), N'19:00:00.0', N'21:15:00.0', 2, 200000.0000, 200000.0000, 0.0000, 1)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD05 ', N'nv03 ', 3, N'KM2  ', CAST(N'2020-01-15' AS Date), N'19:00:00.0', N'21:15:00.0', 2, 400000.0000, 200000.0000, 0.0000, 1)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD06 ', N'nv03 ', 3, N'KM2  ', CAST(N'2019-02-27' AS Date), N'19:00:00.0', N'21:15:00.0', 2, 200000.0000, 200000.0000, 0.0000, 1)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'hd07 ', N'nv03 ', 4, N'km2  ', CAST(N'2020-12-16' AS Date), N'00:00:00.0', N'00:00:00.0', 3, 0.0000, 0.0000, 0.0000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD10 ', N'nv03 ', 3, N'KM1  ', CAST(N'2020-12-16' AS Date), N'          ', N'          ', 3, 0.0000, 0.0000, 0.0000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD11 ', N'nv03 ', 8, N'KM1  ', CAST(N'2020-12-16' AS Date), N'          ', N'          ', 1, 0.0000, 0.0000, 0.0000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD8  ', N'nv03 ', 6, N'KM1  ', CAST(N'2020-12-16' AS Date), N'          ', N'          ', 2, 0.0000, 0.0000, 0.0000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaB], [MaKM], [NgayLap], [GioVao], [GioRa], [SL_Khach], [TongThanhToan], [TienKhachDua], [TienThua], [TinhTrang]) VALUES (N'HD9  ', N'nv03 ', 7, N'KM1  ', CAST(N'2020-12-16' AS Date), N'          ', N'          ', 4, 0.0000, 0.0000, 0.0000, 0)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH01 ', N'Trần Thanh A', N'31245454       ', N'0123324323', N'a@gmal.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH02 ', N'Nguyễn Thị B', N'32313233       ', N'0234342343', N'b@gmai.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH03 ', N'Lê Thị C', N'31231232       ', N'0943423638', N'c@gmail.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH04 ', N'Hà Thanh D', N'32435567       ', N'0333243233', N'd@gmail.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH05 ', N'Lý Văn G', N'32323454       ', N'0646343488', N'g@gmail.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH06 ', N'Đoàn Thanh H', N'23344332       ', N'0988454323', N'h@gmail.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH07 ', N'Lê Văn Thanh N', N'23245452       ', N'0898848343', N'n@gmail.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [CMND_KH], [SDT_KH], [Mail_KH]) VALUES (N'KH08 ', N'Hoàng Văn M', N'23245435       ', N'0994882772', N'm@gmail.com')
GO
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [NgayBD], [NgayKT], [PhanTramKM], [TinhTrang]) VALUES (N'KM1  ', N'Không Có', CAST(N'2020-10-10' AS Date), CAST(N'2020-10-11' AS Date), 0, 1)
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [NgayBD], [NgayKT], [PhanTramKM], [TinhTrang]) VALUES (N'KM2  ', N'Quốc Khánh 2-9', CAST(N'2020-01-09' AS Date), CAST(N'2028-01-09' AS Date), 10, 1)
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [NgayBD], [NgayKT], [PhanTramKM], [TinhTrang]) VALUES (N'KM3  ', N'Lễ Noel', CAST(N'2020-01-01' AS Date), CAST(N'2020-09-09' AS Date), 10, 1)
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [NgayBD], [NgayKT], [PhanTramKM], [TinhTrang]) VALUES (N'KM4  ', N'test2', CAST(N'2020-10-10' AS Date), CAST(N'2020-10-11' AS Date), 10, 1)
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [NgayBD], [NgayKT], [PhanTramKM], [TinhTrang]) VALUES (N'KM5  ', N'Tết Âm Lịch', CAST(N'2021-02-11' AS Date), CAST(N'2021-02-16' AS Date), 10, 1)
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [NgayBD], [NgayKT], [PhanTramKM], [TinhTrang]) VALUES (N'KM6  ', N'Tết Dương Lich', CAST(N'2020-12-31' AS Date), CAST(N'2021-01-01' AS Date), 10, 1)
GO
INSERT [dbo].[LUONG] ([MaBacLuong], [HeSoLuong], [LuongCoBan]) VALUES (1, 2.5, 2000000.0000)
INSERT [dbo].[LUONG] ([MaBacLuong], [HeSoLuong], [LuongCoBan]) VALUES (2, 2, 1900000.0000)
INSERT [dbo].[LUONG] ([MaBacLuong], [HeSoLuong], [LuongCoBan]) VALUES (3, 2.75, 2300000.0000)
GO
INSERT [dbo].[LUONGNV] ([MaBacLuong], [MaNV], [TinhTrang]) VALUES (1, N'nv01 ', 1)
INSERT [dbo].[LUONGNV] ([MaBacLuong], [MaNV], [TinhTrang]) VALUES (1, N'nv5  ', 1)
INSERT [dbo].[LUONGNV] ([MaBacLuong], [MaNV], [TinhTrang]) VALUES (2, N'nv03 ', 1)
INSERT [dbo].[LUONGNV] ([MaBacLuong], [MaNV], [TinhTrang]) VALUES (2, N'nv04 ', 1)
INSERT [dbo].[LUONGNV] ([MaBacLuong], [MaNV], [TinhTrang]) VALUES (3, N'nv02 ', 1)
GO
INSERT [dbo].[MONAN] ([MaM], [TenM], [Gia], [TinhTrang]) VALUES (N'mon1 ', N'Mi xao hai san', 80000.0000, 1)
INSERT [dbo].[MONAN] ([MaM], [TenM], [Gia], [TinhTrang]) VALUES (N'mon2 ', N'Xa lach tron', 50000.0000, 1)
INSERT [dbo].[MONAN] ([MaM], [TenM], [Gia], [TinhTrang]) VALUES (N'mon3 ', N'Ga nuong muoi ot', 90000.0000, 1)
INSERT [dbo].[MONAN] ([MaM], [TenM], [Gia], [TinhTrang]) VALUES (N'mon4 ', N'testtesst', 30000.0000, 1)
INSERT [dbo].[MONAN] ([MaM], [TenM], [Gia], [TinhTrang]) VALUES (N'mon5 ', N'testtttt', 30000.0000, 0)
INSERT [dbo].[MONAN] ([MaM], [TenM], [Gia], [TinhTrang]) VALUES (N'mon6 ', N'testtesst333', 30000.0000, 1)
INSERT [dbo].[MONAN] ([MaM], [TenM], [Gia], [TinhTrang]) VALUES (N'mon7 ', N'testtesst44444', 30000.0000, 0)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [CMND_NV], [SDT_NV], [Mail_NV], [NgaySinh], [DiaChi], [HoTen_NguoiLH], [SDT_NguoiLH], [MaCV], [MatKhau], [TinhTrang]) VALUES (N'nv01 ', N'SON', N'301712572      ', N'0987654321', N'mail', CAST(N'2000-01-01' AS Date), N'qqqq', N'qqq', N'0987654123', 1, N'123', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [CMND_NV], [SDT_NV], [Mail_NV], [NgaySinh], [DiaChi], [HoTen_NguoiLH], [SDT_NguoiLH], [MaCV], [MatKhau], [TinhTrang]) VALUES (N'nv02 ', N'Nguyễn Văn Công', N'2222222        ', N'0987654321', N'123', CAST(N'2000-09-09' AS Date), N'Bình an', N'123', N'23        ', 2, N'123', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [CMND_NV], [SDT_NV], [Mail_NV], [NgaySinh], [DiaChi], [HoTen_NguoiLH], [SDT_NguoiLH], [MaCV], [MatKhau], [TinhTrang]) VALUES (N'nv03 ', N'Thai Phi Sơn', N'5555           ', N'123       ', N'123123', CAST(N'2013-12-12' AS Date), N'aaaaaaaaa', N'123123', N'12312     ', 1, N'3', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [CMND_NV], [SDT_NV], [Mail_NV], [NgaySinh], [DiaChi], [HoTen_NguoiLH], [SDT_NguoiLH], [MaCV], [MatKhau], [TinhTrang]) VALUES (N'nv04 ', N'Phi', N'2123           ', N'123       ', N'123123', CAST(N'2014-12-09' AS Date), N'23', N'123123', N'12312     ', 2, N'3', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [CMND_NV], [SDT_NV], [Mail_NV], [NgaySinh], [DiaChi], [HoTen_NguoiLH], [SDT_NguoiLH], [MaCV], [MatKhau], [TinhTrang]) VALUES (N'nv5  ', N'Teayeon', N'09090909       ', N'0123456789', N'mail', CAST(N'2000-09-09' AS Date), N'yyyyy', N'yyyyyy', N'0987654123', 2, N'123', 1)
GO
INSERT [dbo].[PHIEUDATBAN] ([MaPDB], [MaB], [MaKH], [NgayDat], [GioDat], [TinhTrang]) VALUES (N'pdb01', 10, N'KH08 ', CAST(N'2020-12-12' AS Date), N'12:       ', 1)
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK__CTHD__MaHD__48CFD27E] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK__CTHD__MaHD__48CFD27E]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([MaM])
REFERENCES [dbo].[MONAN] ([MaM])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaB__44FF419A] FOREIGN KEY([MaB])
REFERENCES [dbo].[BANAN] ([MaB])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaB__44FF419A]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaKM__45F365D3] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KHUYENMAI] ([MaKM])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaKM__45F365D3]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaNV__440B1D61] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaNV__440B1D61]
GO
ALTER TABLE [dbo].[LUONGNV]  WITH CHECK ADD FOREIGN KEY([MaBacLuong])
REFERENCES [dbo].[LUONG] ([MaBacLuong])
GO
ALTER TABLE [dbo].[LUONGNV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [fk_position_id] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [fk_position_id]
GO
ALTER TABLE [dbo].[PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUDATBA__MaKH__412EB0B6] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUDATBAN] CHECK CONSTRAINT [FK__PHIEUDATBA__MaKH__412EB0B6]
GO
ALTER TABLE [dbo].[PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUDATBAN__MaB__403A8C7D] FOREIGN KEY([MaB])
REFERENCES [dbo].[BANAN] ([MaB])
GO
ALTER TABLE [dbo].[PHIEUDATBAN] CHECK CONSTRAINT [FK__PHIEUDATBAN__MaB__403A8C7D]
GO
