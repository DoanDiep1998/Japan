Create database HieuDesigner
GO
USE HieuDesigner
go
create Table DanhMuc(
 Id int Primary key identity,
 Name NvarChar(500),
 Content NvarChar(500),
 Img NvarChar(500)
)
create Table DanhMucCon(
 Id int Primary key identity,
 Name NvarChar(500),
 ID_DanhMucCha int , 
 FOREIGN KEY (ID_DanhMucCha) REFERENCES DanhMuc(Id)
)
go
create Table Item(
 Id int Primary key identity,
 Tile NvarChar(500),
 Contents NvarChar(Max),
 CreateDate Datetime,
 Images NvarChar(Max),
 ID_DanhMucCon int , 
 FOREIGN KEY (ID_DanhMucCon) REFERENCES DanhMucCon(Id)
) 

Create table Baner (
id int Primary key identity,
name NvarChar(500),
Images Nvarchar(max)
)
create Table BaoGia(
 Id int Primary key identity,
 HotenKH NvarChar(500),
 Email NvarChar(Max),
 SoDienThoai  NvarChar(Max),
 Images NvarChar(Max),
 itemID Int,
  FOREIGN KEY (itemID) REFERENCES Item(Id)
) 