DROP DATABASE QLCuaHang
go
CREATE DATABASE QLCuaHang
go
USE QLCuaHang
go

CREATE TABLE NhanVien(
	ID int IDENTITY(1,1),
	username varchar(15) PRIMARY KEY,
	matKhau varchar(32),
	email varchar(50),
	hoTen nvarchar(50),
	gioiTinh nvarchar(5),
	namSinh DateTime,
	sdt varchar(15),
	diaChi nvarchar(60),
	chucvu varchar(10),
	trangthai int
)
go
CREATE TABLE SanPham(
	ID int IDENTITY(1,1),
	maSP varchar(5) PRIMARY KEY,
	tenSP nvarchar(30),
	Gia numeric(10),
	photo image,
	loai int,
	trangthai int
)
go
CREATE TABLE PhieuXuat(
	maPhieuXuat int IDENTITY(1,1) PRIMARY KEY,
	username varchar(15),
	tienThu numeric(10),
	tienTra numeric(10),
	uuDai numeric(3),
	thanhToan numeric(10),
	ngayXuat DateTime,
	FOREIGN KEY (username) REFERENCES NhanVien(username),
)
go
CREATE TABLE CTPhieuXuat(
	ID int IDENTITY(1,1) PRIMARY KEY,
	maPhieuXuat int,
	maSP varchar(5),
	soLuong int,
	size int,
	duong int,
	da int,
	FOREIGN KEY (maPhieuXuat) REFERENCES PhieuXuat (maPhieuXuat),
	FOREIGN KEY (maSP) REFERENCES SanPham (maSP)
)
go
CREATE TABLE ChiTietTopping(
	STT int IDENTITY(1,1) PRIMARY KEY,
	ID int,
	maSP varchar(5),
	SL int,
	FOREIGN KEY (ID) REFERENCES CTPhieuXuat(ID),
	FOREIGN KEY (maSP) REFERENCES SanPham (maSP)
)

INSERT INTO NhanVien (username,matKhau,email,hoTen,gioiTinh,namSinh,sdt,diaChi,chucvu,trangthai) VALUES ('admin','21232f297a57a5a743894a0e4a801fc3','admin@gmail.com','Admin','Nam','01/01/2000','0123456789',N'Nhà Hàng Xóm','admin','0')
--password: admin

