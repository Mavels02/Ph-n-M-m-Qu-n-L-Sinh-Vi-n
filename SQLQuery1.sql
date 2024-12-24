create database ASM_C#3
go
use ASM_C#3
go
create table Classes(
	MaLop nvarchar(50) primary key,
	TenLop nvarchar(50)
)
go
create table Students(
	MaSV nvarchar(50) primary key,
	HoTen nvarchar(50),
	Email nvarchar(50),
	SoDT varchar(13),
	Gioitinh nvarchar(5),
	DiaChi nvarchar(50),
	Hinh varbinary(max),
	LopHoc nvarchar(50) references Classes(MaLop)
)
go
create table Grade(
	MaSV nvarchar(50) primary key references Students(MaSV),
	TiengAnh float,
	TinHoc float,
	Vovinam float
)
create table Users(
	Username1 varchar(50) primary key,
	Password1 varchar(50),
	Role1 varchar(50)
)
drop table Students
 
