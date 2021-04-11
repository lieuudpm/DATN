
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
  trangthai nvarchar(50),
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
  anh varbinary(50),
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
  thoigianbatdau nvarchar(50),
  thoigianketthuc nvarchar(50),
  tinhtrang nvarchar(100),
  soserial nvarchar(500) NOT NULL
)

CREATE TABLE ct_baohanh 
(
  mactbh int PRIMARY KEY IDENTITY (1, 1),
  mactddh int FOREIGN KEY REFERENCES ct_dondathang (mactddh),
  manv int FOREIGN KEY REFERENCES nhanvien (manv),
  ngaynhanmay date,
  ngaytradukien date,
  soserial nvarchar(500) NOT NULL,
  ngaytrathucte date,
  tinhtrang nvarchar(50)
)

CREATE TABLE donhangnhap (
  madhn int PRIMARY KEY IDENTITY (1, 1),
  manv int FOREIGN KEY REFERENCES nhanvien (manv),
  mancc int FOREIGN KEY REFERENCES nhacungcap (mancc),
  ngaynhaphang date,
  trangthai nvarchar(100),
  ghichu nvarchar(200)
)

CREATE TABLE ct_donhangnhap (
  mactdhn int PRIMARY KEY IDENTITY (1, 1),
  madhn int FOREIGN KEY REFERENCES donhangnhap (madhn),
mactsp int FOREIGN KEY REFERENCES ct_sanpham(mactsp),
  giamua bigint,
  soluongmua int
)

CREATE TABLE loaithongso (
  malts int PRIMARY KEY IDENTITY (1, 1),
  tents nvarchar(200),
  stt int,
)

CREATE TABLE thongsokythuat (
  matskt int PRIMARY KEY IDENTITY (1, 1),
  ten nvarchar(100),
  thongsokythuat nvarchar(200),
  masp int FOREIGN KEY REFERENCES sanpham (masp),
  sothutu int,
  malts int FOREIGN KEY REFERENCES loaithongso (malts),
  idparent int default 0,
  isdefault int default 0
)


insert into nhanvien values ('Lieu','nu','0967345765','maithulieu@gmail.com','Hanoi','0987654345','25d55ad283aa400af464c76d713c07ad','1','1')
insert into nhanvien values ('Nam','nu','0967345965','Nguyennam@gmail.com','Hanoi','0987654343','4428c6c474502e61151877825bb41961','2','1')


