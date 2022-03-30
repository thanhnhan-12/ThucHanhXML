Create table student
(
	sCode nvarchar(10),
	sName nvarchar(50),
	Class nvarchar(20),
	address nvarchar(50)
)

Insert into student
			values('S01', N'Bùi Văn Sỹ', 'XML01', N'Quảng Trị'),
				  ('S02', N'Nguyễn Quang Huy', 'XML01', N'Kom Tum'),
				  ('S03', N'Nguyễn Thành Nhân', 'XML02', N'Đà Nẵng'),
				  ('S04', N'Phạm Văn Thiên', 'XML02', N'Quảng Nam')
