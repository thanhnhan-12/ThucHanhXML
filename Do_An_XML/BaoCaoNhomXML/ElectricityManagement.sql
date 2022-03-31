CREATE DATABASE ElectricityManagement
GO
USE ElectricityManagement
GO	
CREATE TABLE tb_HoTieuThu
(
	makh NVARCHAR(50) PRIMARY KEY NOT NULL,
	hoten NVARCHAR(50) NOT NULL,
	cmt NVARCHAR(50) NOT NULL
		CHECK(cmt LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'), 
	diachi NVARCHAR(50) NOT NULL,	
	gioitinh NVARCHAR(50) ,
	ngaysinh NVARCHAR(50) NOT NULL ,
	sodt NVARCHAR(50) NOT NULL
		CHECK(sodt LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
				 OR sodt LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'), 
	ngaydk NVARCHAR(50) NOT NULL
)			
GO
CREATE TABLE tb_Thang
(
	mathang NVARCHAR(50) NOT NULL PRIMARY KEY,
	tenTHANG NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE tb_ChiSoDien
(
	makh NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES tb_HoTieuThu(makh),
	mathang NVARCHAR(50) NOT NULL,
	chisocu NVARCHAR(50) NOT NULL,
	chisomoi NVARCHAR(50) NOT NULL,
	
)
GO
 CREATE TABLE tb_HoaDon
 (
	mahd NVARCHAR(50) NOT NULL PRIMARY KEY,
	makh NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES tb_HoTieuThu(makh),
	luongdientt NVARCHAR(50) NOT NULL,
	loaidien  NVARCHAR(50) NOT NULL
		CHECK(loaidien IN (N'Sinh hoạt', N'Kinh doanh')),
	thanhtien NVARCHAR(50) NOT NULL 		
 )  
GO
 CREATE TABLE tb_TaiKhoan
 (
	manhanvien NVARCHAR(50) NOT NULL,
	matkhau NVARCHAR(50) NOT NULL,
	quyen NVARCHAR(50) NOT NULL
 )

 Insert into tb_TaiKhoan 
	values('admin', 'admin', 'admin'),
		  ('NV001', '123', 'nhanvien'),
		  ('NV002', '123', 'nhanvien'),
		  ('NV003', '123', 'nhanvien');

