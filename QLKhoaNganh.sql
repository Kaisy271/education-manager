create database QLKhoaNganh;
use QLKhoaNganh;

CREATE TABLE Khoa (
    MaKhoa INT IDENTITY(1,1) PRIMARY KEY,
    TenKhoa NVARCHAR(255) 
);


CREATE TABLE Nganh (
    MaNganh INT IDENTITY(1,1) PRIMARY KEY,
    TenNganh NVARCHAR(255),
	ThoiGianDaoTao int,
	MaKhoa int not null references Khoa(MaKhoa)
);
