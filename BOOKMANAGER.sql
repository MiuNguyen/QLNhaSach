CREATE DATABASE QLNS
USE QLNS

CREATE TABLE SACH
(
	MASACH char(4) PRIMARY KEY,
	TENSACH varchar(40),
	THELOAI varchar(40),
	TACGIA varchar(40),
	GIA money,
	SOLUONG int,
	NGAYNHAP smalldatetime
)

CREATE TABLE HOADON
(
	MAHD char(4) PRIMARY KEY,
	MAKH char(4),
	NGAYLAP smalldatetime
)

CREATE TABLE KHACHHANG
(
	MAKH char(4) PRIMARY KEY,
	TENKH varchar(40),
	DIACHI varchar(40),
	SDT int,
	TIENNO money
)

CREATE TABLE CTHD
(
	MAHD char(4) FOREIGN KEY REFERENCES HOADON(MAHD),
	MASACH char(4) FOREIGN KEY REFERENCES SACH(MASACH),
	SL int,
	DONGIA money,
	THANHTIEN money
	CONSTRAINT PK_CTHD PRIMARY KEY (MAHD, MASACH)
)

ALTER TABLE HOADON ADD CONSTRAINT FK_MAKH FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)