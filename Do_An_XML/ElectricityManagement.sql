﻿CREATE DATABASE ElectricityManagement
GO
USE ElectricityManagement
GO	

CREATE TABLE tb_HoTieuThu
(
	makh NVARCHAR(50)  NOT NULL,
	hoten NVARCHAR(50) NOT NULL,
	cmt NVARCHAR(50) NOT NULL, 
	diachi NVARCHAR(50) NOT NULL,	
	gioitinh NVARCHAR(50) ,
	ngaysinh NVARCHAR(50) NOT NULL ,
	sodt NVARCHAR(50) NOT NULL, 
	ngaydk NVARCHAR(50) NOT NULL
)			
GO
CREATE TABLE tb_Thang
(
	maTHANG NVARCHAR(50) NOT NULL,
	tenTHANG NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE tb_ChiSoDien
(
	makh NVARCHAR(50) NOT NULL ,
	mathang NVARCHAR(50) NOT NULL,
	chisocu NVARCHAR(50) NOT NULL,
	chisomoi NVARCHAR(50) NOT NULL
)
GO
 CREATE TABLE tb_HoaDon
 (
	mahd NVARCHAR(50) NOT NULL ,
	makh NVARCHAR(50) NOT NULL,
	luongdientt NVARCHAR(50) NOT NULL,
	loaidien  NVARCHAR(50) NOT NULL,
	thanhtien NVARCHAR(50) NOT NULL 		
 )  











