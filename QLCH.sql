
use master;

go

ALTER DATABASE QLCH SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE  QLCH;

go
CREATE DATABASE QLCH

GO

USE QLCH

GO

CREATE TABLE nhanvien 
(
  manv int PRIMARY KEY IDENTITY (1, 1),
  tennv nvarchar(100),
  giottinh nvarchar(50),
  sdt nvarchar(20),
  email nvarchar(50),
  diachi nvarchar(100),
  cmnd nvarchar(12),
  passwword nvarchar(100),
  quyenhan int,
  trangthai int
)

CREATE TABLE khachhang 
(
  makh int PRIMARY KEY IDENTITY (1, 1),
  tenkh nvarchar(100),
  gioitinh nvarchar(50),
  diachi nvarchar(200),
  sdt nvarchar(20),
)

CREATE TABLE dondathang 
(
  maddh int PRIMARY KEY IDENTITY (1, 1),
  manv int FOREIGN KEY REFERENCES nhanvien (manv),
  makh int FOREIGN KEY REFERENCES khachhang (makh),
  ngaydathang datetime,
  trangthai int,
  ghichu nvarchar(300)
)

CREATE TABLE nhacungcap 
(
  mancc int PRIMARY KEY IDENTITY (1, 1),
  tenncc nvarchar(200),
  sdt nvarchar(20),
  diachi nvarchar(200),
  email nvarchar(200)
)

CREATE TABLE loaihang 
(
  maloai int PRIMARY KEY IDENTITY (1, 1),
  tenloai nvarchar(100)
)

CREATE TABLE hang 
(
  mahang int PRIMARY KEY IDENTITY (1, 1),
  tenhang nvarchar(100),
  maloai int FOREIGN KEY REFERENCES loaihang (maloai)
)


CREATE TABLE sanpham 
(
  masp int PRIMARY KEY IDENTITY (1, 1),
  tensp nvarchar(100),
  mahang int FOREIGN KEY REFERENCES hang (mahang), 
  anh varbinary(max),
  mota nvarchar(300)
)

CREATE TABLE ct_sanpham
(
  mactsp int PRIMARY KEY IDENTITY (1, 1),
  tinhtrang int,
  soluong int,
  masp int FOREIGN KEY REFERENCES sanpham (masp),
  giaban bigint,
  giasale bigint,
  thoigianbh int,
)

CREATE TABLE ct_dondathang 
(
  mactddh int PRIMARY KEY IDENTITY (1, 1),
  maddh int FOREIGN KEY REFERENCES dondathang (maddh),
 mactsp int FOREIGN KEY REFERENCES ct_sanpham(mactsp),
  tensp nvarchar(100),
  soluong int,
  giaban bigint,
  thoigianbatdau datetime,
  thoigianketthuc datetime,
  tinhtrang int,
  soserial nvarchar(500) NOT NULL
)

CREATE TABLE ct_baohanh 
(
  mactbh int PRIMARY KEY IDENTITY (1, 1),
  mactddh int FOREIGN KEY REFERENCES ct_dondathang (mactddh),
  manv int FOREIGN KEY REFERENCES nhanvien (manv),
  ngaynhanmay datetime,
  ngaytradukien datetime,
  soserial nvarchar(500) NOT NULL,
  ngaytrathucte datetime,
  tinhtrang int
)

CREATE TABLE donhangnhap (
  madhn int PRIMARY KEY IDENTITY (1, 1),
  manv int FOREIGN KEY REFERENCES nhanvien (manv),
  mancc int FOREIGN KEY REFERENCES nhacungcap (mancc),
  ngaynhaphang datetime,
  trangthai int,
  
  ghichu nvarchar(200)
)

CREATE TABLE ct_donhangnhap (
  mactdhn int PRIMARY KEY IDENTITY (1, 1),
  madhn int FOREIGN KEY REFERENCES donhangnhap (madhn),
  mactsp int FOREIGN KEY REFERENCES ct_sanpham(mactsp),
  giamua bigint,
  soluongmua int,
  tongtien bigint,
)

CREATE TABLE thongsokythuat (
  matskt int PRIMARY KEY IDENTITY (1, 1),
  ten nvarchar(100),
  thongsokythuat nvarchar(200),
  masp int FOREIGN KEY REFERENCES sanpham (masp),
  sothutu int,
  idparent int default 0,
  isdefault int default 0
)

CREATE TABLE loaithongso (
  malts int PRIMARY KEY IDENTITY (1, 1),
  title nvarchar(200),
  id_parent int,
  stt int,
)

CREATE TABLE fillter_thong_so (
  id int PRIMARY KEY IDENTITY (1, 1),
  matskt int FOREIGN KEY REFERENCES thongsokythuat (matskt),
  malts int FOREIGN KEY REFERENCES loaithongso (malts)
)

GO
SET IDENTITY_INSERT [dbo].[loaihang] ON 

INSERT [dbo].[loaihang] ([maloai], [tenloai]) VALUES (1, N'Android')
INSERT [dbo].[loaihang] ([maloai], [tenloai]) VALUES (2, N'iPhone (IOS)')
INSERT [dbo].[loaihang] ([maloai], [tenloai]) VALUES (3, N'Điện thoại phổ thông')
SET IDENTITY_INSERT [dbo].[loaihang] OFF
SET IDENTITY_INSERT [dbo].[hang] ON 

INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (1, N'SAMSUNG', 1)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (2, N'OPPO', 1)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (3, N'VIVO', 1)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (4, N'XIAOMI', 1)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (5, N'realme', 1)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (6, N'VSMART', 1)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (7, N'HUAWEI', 1)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (8, N'iPhone', 2)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (9, N'NOKIA', 3)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (10, N'mobell', 3)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (11, N'itel', 3)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (12, N'Masstel', 3)
INSERT [dbo].[hang] ([mahang], [tenhang], [maloai]) VALUES (13, N'Energizer', 3)
SET IDENTITY_INSERT [dbo].[hang] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([manv], [tennv], [giottinh], [sdt], [email], [diachi], [cmnd], [passwword], [quyenhan], [trangthai]) VALUES (1, N'Lieu', N'nu', N'0967345765', N'maithulieu@gmail.com', N'Hanoi', N'0987654345', N'25d55ad283aa400af464c76d713c07ad', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [tennv], [giottinh], [sdt], [email], [diachi], [cmnd], [passwword], [quyenhan], [trangthai]) VALUES (2, N'Nam', N'nu', N'0967345965', N'Nguyennam@gmail.com', N'Hanoi', N'0987654343', N'4428c6c474502e61151877825bb41961', 2, 1)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
SET IDENTITY_INSERT [dbo].[thongsokythuat] ON 

INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (1, N'Màn hình', NULL, NULL, 1, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (2, N'Camera sau', NULL, NULL, 2, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (3, N'Camera trước', NULL, NULL, 3, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (4, N'Hệ điều hành & CPU', NULL, NULL, 4, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (5, N'Bộ nhớ & Lưu trữ', NULL, NULL, 5, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (6, N'Kết nối', NULL, NULL, 6, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (7, N'Pin & Sạc', NULL, NULL, 7, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (8, N'Tiện ích', NULL, NULL, 8, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (9, N'Thông tin chung', NULL, NULL, 9, 0, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (10, N'Công nghệ màn hình', NULL, NULL, 1, 1, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (11, N'Độ phân giải', NULL, NULL, 2, 1, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (12, N'Kích thước màn hình', NULL, NULL, 3, 1, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (13, N'Mặt kính cảm ứng', NULL, NULL, 4, 1, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (14, N'Độ phân giải', NULL, NULL, 1, 2, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (15, N'Quay phim', NULL, NULL, 2, 2, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (16, N'Đèn Flash', NULL, NULL, 3, 2, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (17, N'Tính năng', NULL, NULL, 4, 2, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (18, N'Độ phân giải', NULL, NULL, 1, 3, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (19, N'Tính năng', NULL, NULL, 2, 3, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (20, N'Hệ điều hành', NULL, NULL, 1, 4, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (21, N'Chip xử lý (CPU)', NULL, NULL, 2, 4, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (22, N'Tốc độ CPU', NULL, NULL, 3, 4, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (23, N'Chip đồ họa (GPU)', NULL, NULL, 4, 4, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (24, N'RAM', NULL, NULL, 1, 5, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (25, N'Bộ nhớ trong', NULL, NULL, 2, 5, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (26, N'Bộ nhớ còn lại (khả dụng) khoảng', NULL, NULL, 3, 5, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (27, N'Thẻ nhớ', NULL, NULL, 4, 5, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (28, N'Mạng di động', NULL, NULL, 1, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (29, N'SIM', NULL, NULL, 2, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (30, N'Wifi', NULL, NULL, 3, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (31, N'GPS', NULL, NULL, 4, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (32, N'Bluetooth', NULL, NULL, 5, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (33, N'Cổng kết nối/sạc', NULL, NULL, 6, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (34, N'Jack tai nghe', NULL, NULL, 7, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (35, N'Kết nối khác', NULL, NULL, 8, 6, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (36, N'Loại pin', NULL, NULL, 1, 7, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (37, N'Dung lượng pin', NULL, NULL, 2, 7, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (38, N'Công nghệ pin', NULL, NULL, 3, 7, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (39, N'Bảo mật nâng cao', NULL, NULL, 1, 8, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (40, N'Tính năng đặc biệt', NULL, NULL, 2, 8, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (41, N'Ghi âm', NULL, NULL, 3, 8, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (42, N'Radio', NULL, NULL, 4, 8, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (43, N'Xem phim', NULL, NULL, 5, 8, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (44, N'Nghe nhạc', NULL, NULL, 6, 8, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (45, N'Thiết kế', NULL, NULL, 1, 9, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (46, N'Chất liệu', NULL, NULL, 2, 9, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (47, N'Kích thước', NULL, NULL, 3, 9, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (48, N'Khối lượng', NULL, NULL, 4, 9, 1)
INSERT [dbo].[thongsokythuat] ([matskt], [ten], [thongsokythuat], [masp], [sothutu], [idparent], [isdefault]) VALUES (49, N'Thời điểm ra mắt', NULL, NULL, 5, 9, 1)
SET IDENTITY_INSERT [dbo].[thongsokythuat] OFF
