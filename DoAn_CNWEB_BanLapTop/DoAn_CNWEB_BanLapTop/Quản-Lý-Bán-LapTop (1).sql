create database QuanLyBanLapTop
use QuanLyBanLapTop

create table NhaSanXuat
(
	MaNSX int Identity(1,1) not null primary key,
	TenNSX nvarchar(MAX)
)

create table Loai
(
	MaLoai int Identity(1,1) not null primary key,
	TenLoai nvarchar(MAX),
	HinhAnh nvarchar(Max)
)
create table SanPham
(
	MaSanPham int Identity(1,1) not null primary key,
	TenSanPham nvarchar(MAX),
	Gia money,
	AnhBia nvarchar(MAX),
	SoLuongTon int,
	MaNSX int not null,
	MaLoai int not null
)
create table MoTa
(
	MaSanPham int not null primary key,
	CPU nvarchar(100),
	RAM nvarchar(100),
	ManHinh nvarchar(100),
	DoHoa nvarchar(100),
	OCung nvarchar(100),
	HeDieuHanh nvarchar(100),
	TrongLuong float,
	KichThuoc nvarchar(100),
	XuatXu nvarchar(100),
	NamRaMat nvarchar(100)
)
create table HinhAnhSP
(
	MaSanPham int Identity(1,1) not null primary key,
	Hinh1 nvarchar(100),
	Hinh2 nvarchar(100),
	Hinh3 nvarchar(100),
	Hinh4 nvarchar(100)
)
create table KhachHang
(
	MaKhachHang char(10) not null primary key,
	TenKhachHang nvarchar(MAX),
	NgaySinh date,
	GioiTinh nchar(3),
	DienThoai varchar(50),
	MatKhau varChar(50),
	Email varchar(50),
	DiaChi nvarchar(MAX)
)
create table DonHang
(
	MaDonHang int Identity(1,1) not null primary key,
	NgayDat date,
	NgayGiao date,
	TinhTrangThanhToan nvarchar(50),
	MaKhachHang char(10) not null
)
create table CT_DonHang
(
	MaDonHang int not null,
	MaSanPham int not null,
	SoLuong int,
	DonGia money,
)
create table LoaiTinTuc
(
	MaLoaiTin int Identity(1,1) not null primary key,
	TenLoaiTin nvarchar(MAX)
)
create table TinTuc
(
	MaTin int Identity(1,1) not null primary key,
	TieuDe nvarchar(MAX),
	NoiDung nvarchar(MAX),
	AnhBia nvarchar(MAX),
	NgayTao date,
	Cmt int,
	MaLoaiTin int not null
)
create table Admin
(
	TenTaiKhoan char(10) not null,
	MatKhau char(10) not null,
	HoTen nvarchar(MAX),
)
create table LienHe
(
	MaLienHe int Identity(1,1) not null primary key,
	MaKhachHang char(10),
	AnhMoTa nvarchar(max),
	NoiDung nvarchar(max)
)
insert into Admin
values('Dung','123',N'Dũng'), 
('Vi', '123', N'Phạm Thị Vi')

alter table SanPham
add constraint FK_SanPham_NhaSanXuat foreign key (MaNSX) references NhaSanXuat(MaNSX)
alter table SanPham
add constraint FK_SanPham_Loai foreign key (MaLoai) references Loai(MaLoai)
alter table HinhAnhSP
add constraint FK_SanPham_HinhAnhSP foreign key (MaSanPham) references SanPham(MaSanPham)
alter table MoTa
add constraint FK_SanPham_MoTa foreign key (MaSanPham) references SanPham(MaSanPham)
alter table CT_DonHang
add primary key (MaDonHang,MaSanPham)
alter table DonHang
add constraint FK_DonHang_KhachHang foreign key (MaKhachHang) references KhachHang(MaKhachHang)
alter table CT_DonHang
add constraint FK_CT_DonHang_DonHang foreign key (MaDonHang) references DonHang(MaDonHang)
alter table CT_DonHang
add constraint FK_CT_DonHang_SanPham foreign key (MaSanPham) references SanPham(MaSanPham)
alter table TinTuc
add constraint FK_CT_TinTuc_LoaiTin foreign key (MaLoaiTin) references LoaiTinTuc(MaLoaiTin)
alter table LienHe
add constraint FK_LienHe foreign key (MaKhachHang) references KhachHang(MaKhachHang)

create trigger updateSL
on CT_DonHang
for insert
as
update SanPham
set SoLuongTon = SoLuongton-(select SoLuong from inserted)
where MaSanPham=(select MaSanPham from inserted)
insert into NhaSanXuat(TenNSX)
values(N'Dell'),
(N'Asus'),
(N'HP'),
(N'Macbook')
insert into Loai(TenLoai,HinhAnh)
values(N'Gaming', N'HinhLoaiGame.jpg'),
(N'Học tập - Văn phòng', N'HinhLoaiHocTap.jpg'),
(N'Đồ học - Kỹ thuật', N'HinhLoaiKiThuat.jpg'),
(N'Laptop mỏng nhẹ', N'HinhLoaiMongNhe.jpg')
insert into SanPham(TenSanPham,Gia,AnhBia,SoLuongTon,MaNSX,MaLoai)
values(N'MacBook Pro 16" 2019 Touch Bar 2.3GHz Core i9 1TB',69990000,N'HinhMacBoock1_AnhBia.jpg',10,4,4),
(N'MacBook Pro 13" 2019 Touch Bar 2.4GHz Core i5 512GB',5199000 ,N'HinhMacBoock2_AnhBia.jpg',7,4,2),
(N'MacBook Air 13" 2020 1.1GHz Core i5 512GB',34990000,N'HinhMacBoock3_AnhBia.jpg',5,4,1),
(N'MacBook Air 13" 2020 M1 512GB',11420000,N'HinhMacBoock4_AnhBia.jpg',8,4,2),
(N'MacBook Air 13" 2017 1.8GHz Core i5 128GB',19990000 ,N'HinhMacBoock5_AnhBia.jpg',9,4,4),
(N'MacBook Pro 13" 2020 Touch Bar 1.4GHz Core i5 256GB',34990000 ,N'HinhMacBoock6_AnhBia.jpg',4,4,1),
(N'Laptop HP ENVY 13 ba0046TU i5 1035G4/8GB/512GB SSD/WIN10+Office Home & Student',17490000,N'HinhHP1_AnhBia.jpg',10,3,2),
(N'Laptop HP ENVY 13 aq1022TU i5 10210U/8GB/512GB SSD/WIN10',22390000 ,N'HinhHP2_AnhBia.jpg',9,3,1),
(N'Laptop HP Pavilion Gaming 15 dk1083TX i5 10300H/8GB/512GB/15.6FHD/Win 10 ',22290000  ,N'HinhHP3_AnhBia.jpg',10,3,1),
(N'HP Pavilion x360 14-dh0103TU i3 8145U/4GB/1TB/WIN10',10690000  ,N'HinhHP4_AnhBia.jpg',4,3,2),
(N'HP Pavilion 14-ce1014TU/Core i3-8145U/4GB/500GB/WIN10',9490000  ,N'HinhHP5_AnhBia.jpg',6,3,2),
(N'Laptop HP 348 G7 i5 10210U/8GB/256GB/14.0"FHD/FP/Win 10',14990000  ,N'HinhHP6_AnhBia.jpg',6,3,4),
(N'Laptop Dell XPS 15 9500 i7 10750H/16GB/512GB/GTX 1650 Ti 4GB/Win 10',59990000,N'HinhDell1_AnhBia.jpg',5,1,4),
(N'Laptop Dell Inspiron N3593C i3 1005G1/4GB/256GB/15.6"FHD/Win10',11290000 ,N'HinhDell2_AnhBia.jpg',9,1,4),
(N'Laptop Dell Inspiron N3493 i3 1005G1/4GB/256GB/14.0"FHD/Win 10',10590000  ,N'HinhDell3_AnhBia.jpg',7,1,2),
(N'Laptop Dell Inspiron N5593 i5 1035G1/8Gb/512Gb/Nvidia MX230 2Gb/Win 10',19690000  ,N'HinhDell4_AnhBia.jpg',4,1,1),
(N'Dell Inspiron N3481/Core i3-7020U/4Gb/70190294',12290000  ,N'HinhDell5_AnhBia.jpg',6,1,3),
(N'Laptop Dell Vostro V3405 R5 3500U/4GB/256GB/14"FHD/Win 10',12190000  ,N'HinhDell6_AnhBia.jpg',6,1,3),
(N'Laptop Asus Strix G512 IAL001T i7 10750H/8GB/512G SSD/15.6 FHD/WIN10',29490000  ,N'HinhAsus1_AnhBia.jpg',5,2,1),
(N'Laptop Asus Vivobook X409JA-EK237T i3 1005G1/4GB/Win 10',10290000 ,N'HinhAsus2_AnhBia.jpg',9,2,4),
(N'Laptop Asus Vivobook A412DA EK612T R3 3250U/4GB/512GB SSD/14.0 FHD/Win10',11390000  ,N'HinhAsus3_AnhBia.jpg',7,2,2),
(N'Laptop Asus Zenbook UX334FLC A4096T i5 10210U/8GB/512GB SSD/Win10',23990000  ,N'HinhAsus4_AnhBia.jpg',4,2,1),
(N'Laptop Asus Vivobook E210MA GJ083T/N4020/4GB/128GB eMMC/11.6''/Win10',5990000  ,N'HinhAsus5_AnhBia.jpg',6,2,3),
(N'Laptop Asus TUF FX505DT HN488T R5 3550H/8GB/512GB SSD/Nvidia GTX1650_4G/WIN10',18590000  ,N'HinhAsus6_AnhBia.jpg',6,2,1)

insert into MoTa
values(1,N'Intel Core i9-9th-gen', N'16 GB DDR4 2666 MHz',N'16.0", 3072 x 1920 Pixel, IPS, Đang cập nhật, Đang cập nhật, IPS LCD LED Backlit, True Tone', N'AMD Radeon Pro 5500M 4 GB', N'SSD 1 TB', N'Mac OS',2.0 , N'357.9 x 24.59 x 16.2', N'Trung Quốc', N'2019'),
(2,N'Intel Core i5-8th-gen', N'8 GB LPDDR3 2133 MHz', N'13.3", 2560 x 1600 Pixel, IPS, Đang cập nhật, Đang cập nhật, IPS LCD LED Backlit, True Tone', N'Intel Iris Plus Graphics 655', N'SSD 512 GB', N'Mac OS',1.37 , N'304.1 x 212.4 x 14.9', N'Trung Quốc', N'	2019'),
(3,N'Intel Core i5-10th-gen', N'8 GB LPDDR4 3733 MHz', N'	13.3", 2560 x 1600 Pixel, IPS, Đang cập nhật, Đang cập nhật, IPS LCD LED Backlit, True Tone', N'Intel Iris Plus Graphics', N'	SSD 512 GB', N'Mac OS',1.29, N'304.1 x 212.4 x 4.1 ~ 16.1', N'Trung Quốc', N'2020'),
(4,N'Apple M1', N'8 GB Đang cập nhật Đang cập nhật', N'8 GB Đang cập nhật Đang cập nhật', N'Đang cập nhật', N'SSD 512 GB', N'Mac OS',1.29 , N'304.1 x 212.4 x 4.1 ~ 16.1', N'	Trung Quốc', N'2020'),
(5,N'Intel Core i5-5th-gen', N'8 GB LPDDR3 1600 MHz', N'13.3", 1440 x 900 Pixel, Đang cập nhật, Đang cập nhật, Đang cập nhật, LED-backlit', N'Intel HD Graphics 6000', N'SSD 128 GB', N'Mac OS',1.35 , N'Đang cập nhật x Đang cập nhật x Đang cập nhật', N'Trung Quốc', N'2017'),
(6,N'Intel Core i5-8th-gen', N'8 GB LPDDR3 2133 MHz', N'	13.3", 2560 x 1600 Pixel, IPS, Đang cập nhật, Đang cập nhật, IPS LCD LED Backlit, True Tone', N'Intel Iris Plus Graphics 645', N'SSD 256 GB', N'Mac OS', 1.4, N'304.1 x 212.4 x 15.6', N'Trung Quốc', N'2020'),
(7,N'Intel Core i5-1035G4', N'8 GB DDR4 3200 MHz', N'13.3", 1920 x 1080 Pixel, IPS, 60 Hz, 300 nits, Micro-edge WLED-backlit', N'Intel Iris Plus Graphics', N'SSD 512 GB', N'Windows 10',1.3 , N'306.5 x 194.6 x 16.9', N'Trung Quốc', N'2020'),
(8,N'Intel Core i5-10210U', N'	8 GB DDR4 2400 MHz', N'13.3", 1920 x 1080 Pixel, IPS, 60 Hz, 300 nits, BrightView Micro-edge WLED-backlit', N'	Intel UHD Graphics', N'	SSD 512 GB', N'	Windows 10',1.17 , N'307 x 211.5 x 14.7', N'Trung Quốc', N'Đang cập nhật'),
(9,N'	Intel Core i5-10300H', N'	8 GB DDR4 3200 MHz', N'5.6", 1920 x 1080 Pixel, IPS, 144 Hz, 250 nits, Anti-glare WLED-backlit', N'	NVIDIA GeForce GTX 1650 4 GB', N'	SSD 512 GB', N'Windows 10',2.3 , N'360 x 230 x 23.4', N'	Trung Quốc', N'	2020'),
(10,N'Intel Core i3-8145U', N'	4 GB DDR4 2666 MHz', N'	14.0", 1920 x 1080 Pixel, Đang cập nhật, Đang cập nhật, Đang cập nhật, LED-backlit', N'	Intel UHD Graphics 620', N'	HDD 1000 GB', N'	Windows 10',1.629 , N'324 x 222.9 x 19.7', N'Trung Quốc', N'Đang cập nhật'),
(11,N'Intel Core i3-8145U', N'4 GB DDR4 2400 MHz', N'	14.0", 1920 x 1080 Pixel, Đang cập nhật, 60 Hz, Đang cập nhật, LED-backlit', N'Intel UHD Graphics 620', N'	HDD 500 GB', N'Windows 10',1.53 , N'Đang cập nhật x Đang cập nhật x Đang cập nhật', N'	Trung Quốc', N'2018'),
(12,N'	Intel Core i5-10210U', N'	8 GB DDR4 2666 MHz', N'	14.0", 1920 x 1080 Pixel, Đang cập nhật, 60 Hz, 220 nits, WLED-backlit', N'	Intel UHD Graphics', N'	SSD 256 GB', N'	SSD 256 GB',	1.42 , N'324 x 225 x 19.9', N'	Trung Quốc', N'	2020'),
(13,N'	Intel Core i7-10750H', N'	16 GB DDR4 2933 MHz', N'	15.6", 3840 x 2400 Pixel, WVA, 60 Hz, 500 nits, Anti-glare LED-backlit', N'	NVIDIA GeForce GTX 1650Ti 4 GB', N'	SSD 512 GB', N'Windows 10', 2.05, N'	343 x 230 x 18', N'	Trung Quốc', N'	2020'),
(14,N'	Intel Core i3-1005G1', N'	4 GB DDR4 2666 MHz', N'	15.6", 1920 x 1080 Pixel, TN, 60 Hz, 220 nits, Anti-glare LED-backlit', N'Intel UHD Graphics', N'	SSD 256 GB', N'	Windows 10', 2, N'380 x 258 x 19.89 ~ 19.90', N'	Trung Quốc', N'	2020'),
(15,N'	Intel Core i3-1005G1', N'	4 GB DDR4 2666 MHz', N'14.0", 1920 x 1080 Pixel, Đang cập nhật, Đang cập nhật, Đang cập nhật, LED-backlit', N'	Intel UHD Graphics', N'SSD 256 GB', N'	Windows 10', 1.724, N'Đang cập nhật x Đang cập nhật x Đang cập nhật', N'Trung Quốc', N'	2020'),
(16,N'	Intel Core i5-1035G1', N'	8 GB DDR4 2666 MHz', N'	15.6", 1920 x 1080 Pixel, IPS, 60 Hz, 220 nits, LED-backlit', N'NVIDIA GeForce MX230 2 GB', N'SSD 512 GB', N'Windows 10',1.8 , N'Đang cập nhật x Đang cập nhật x Đang cập nhật', N'Trung Quốc', N'2019'),
(17,N'Intel Core i3-7020U', N'4 GB DDR4 2666 MHz', N'14.0", 1366 x 768 Pixel, TN, 60 Hz, Đang cập nhật, LED-backlit', N'AMD Radeon 530 2 GB', N'Đang cập nhật', N'Windows 10',1.79 , N'Đang cập nhật x Đang cập nhật x Đang cập nhật', N'Trung Quốc', N'Đang cập nhật'),
(18,N'AMD Ryzen 7-3700U', N'8 GB DDR4 2400 MHz', N'14.0", 1920 x 1080 Pixel, WVA, 60 Hz, 220 nits, Anti-glare LED-backlit', N'Intel UHD Graphics', N'SSD 512 GB', N'Windows 10',1.7 , N'328 x 230 x 19.9', N'Trung Quốc', N'2020'),
(19,N'Intel Core i7-10750H', N'8 GB DDR4 2933 MHz', N'15.6", 1920 x 1080 Pixels, IPS, 144 Hz, 250 nits, IPS FHD', N'NVIDIA GeForce GTX 1650Ti 4 GB', N'SSD 512 GB', N'Windows 10 Home', 2.3, N'360 x 275 x 21.7', N'Trung Quốc', N'2020'),
(20,N'	Intel Core i3-1005G1', N'4 GB DDR4 2400 MHz', N'14.0", 1920 x 1080 Pixel, TN, 60 Hz, 220 nits, Nano Edge', N'Intel HD Graphics 520', N'SSD 256 GB', N'Windows 10', 1.6, N'325 x 216 x 23.1', N'Trung Quốc', N'2020'),
(21,N'AMD Ryzen 3-3250U', N'4 GB DDR4 2400 MHz', N'14.0", 1920 x 1080 Pixel, TN, 60 Hz, 200 nits, Anti-glare LED-backlit', N'AMD Radeon Graphics Vega 3', N'SSD 512 GB', N'Windows 10', 1.5, N'322 x 212 x 19.89 ~ 19.90', N'Trung Quốc', N'2016'),
(22,N'Intel Core i5-10210U', N'8 GB LPDDR3 2133 MHz', N'13.3", 1920 x 1080 Pixel, IPS, 60 Hz, 250 nits, Anti-glare LED-backlit', N'NVIDIA GeForce MX250 2 GB', N'SSD 512 GB', N'Windows 10', 1.22, N'302 x 189 x 17.9', N'Trung Quốc', N'2020'),
(23,N'Intel Celeron N4020', N'4 GB DDR4 2400 MHz', N'11.6", 1366 x 768 Pixel, TN, 60 Hz, 200 nits, BrightView LED Backlit', N'Intel HD Graphics 610', N'eMMC 128GB', N'Windows 10', 1.1, N'280.5 x 189 x 16.9', N'Trung Quốc', N'2020'),
(24,N'AMD Ryzen 5-3550H', N'8 GB DDR4 2400 MHz', N'15.6", 1920 x 1080 Pixel, IPS, 144 Hz, Đang cập nhật, LED Backlit', N'NVIDIA GeForce GTX 1650 4 GB', N'SSD 512 GB', N'Windows 10', 2.14, N'360 x 262 x 26.8', N'Trung Quốc', N'2019')

insert into HinhAnhSP(Hinh1,Hinh2,Hinh3,Hinh4)
values(N'HinhMacBoock1_Anh1.jpg', N'HinhMacBoock1_Anh2.jpg', N'HinhMacBoock1_Anh3.jpg', N'HinhMacBoock1_Anh4.jpg'),
(N'HinhMacBoock2_Anh1.jpg', N'HinhMacBoock2_Anh2.jpg', N'HinhMacBoock2_Anh3.jpg', N'HinhMacBoock2_Anh4.jpg'),
(N'HinhMacBoock3_Anh1.jpg', N'HinhMacBoock3_Anh2.jpg', N'HinhMacBoock3_Anh3.jpg', N'HinhMacBoock3_Anh4.jpg'),
(N'HinhMacBoock4_Anh1.jpg', N'HinhMacBoock4_Anh2.jpg', N'HinhMacBoock4_Anh3.jpg', N'HinhMacBoock4_Anh4.jpg'),
(N'HinhMacBoock5_Anh1.jpg', N'HinhMacBoock5_Anh2.jpg', N'HinhMacBoock5_Anh3.jpg', N'HinhMacBoock5_Anh4.jpg'),
(N'HinhMacBoock6_Anh1.jpg', N'HinhMacBoock6_Anh2.jpg', N'HinhMacBoock6_Anh3.jpg', N'HinhMacBoock6_Anh4.jpg')
insert into HinhAnhSP(Hinh1,Hinh2,Hinh3,Hinh4)
values(N'HinhHP1_Anh1.jpg', N'HinhHP1_Anh2.jpg', N'HinhHP1_Anh3.jpg', N'HinhHP1_Anh4.jpg'),
(N'HinhHP2_Anh1.jpg', N'HinhHP2_Anh2.jpg', N'HinhHP2_Anh3.jpg', N'HinhHP2_Anh4.jpg'),
(N'HinhHP3_Anh1.jpg', N'HinhHP3_Anh2.jpg', N'HinhHP3_Anh3.jpg', N'HinhHP3_Anh4.jpg'),
(N'HinhHP4_Anh1.jpg', N'HinhHP4_Anh2.jpg', N'HinhHP4_Anh3.jpg', N'HinhHP5_Anh4.jpg'),
(N'HinhHP5_Anh1.jpg', N'HinhHP5_Anh2.jpg', N'HinhHP5_Anh3.jpg', N'HinhHP5_Anh4.jpg'),
(N'HinhHP6_Anh1.jpg', N'HinhHP6_Anh2.jpg', N'HinhHP6_Anh3.jpg', N'HinhHP6_Anh4.jpg')
insert into HinhAnhSP(Hinh1,Hinh2,Hinh3,Hinh4)
values(N'HinhDell1_Anh1.jpg', N'HinhDell1_Anh2.jpg', N'HinhDell1_Anh3.jpg', N'HinhDell1_Anh4.jpg'),
(N'HinhDell2_Anh1.jpg', N'HinhDell2_Anh2.jpg', N'HinhDell2_Anh3.jpg', N'HinhDell2_Anh4.jpg'),
(N'HinhDell3_Anh1.jpg', N'HinhDell3_Anh2.jpg', N'HinhDell3_Anh3.jpg', N'HinhDell1_Anh4.jpg'),
(N'HinhDell4_Anh1.jpg', N'HinhDell4_Anh2.jpg', N'HinhDell4_Anh3.jpg', N'HinhDell1_Anh4.jpg'),
(N'HinhDell5_Anh1.jpg', N'HinhDell5_Anh2.jpg', N'HinhDell5_Anh3.jpg', N'HinhDell1_Anh4.jpg'),
(N'HinhDell6_Anh1.jpg', N'HinhDell6_Anh2.jpg', N'HinhDell1_Anh3.jpg', N'HinhDell1_Anh4.jpg')
insert into HinhAnhSP(Hinh1,Hinh2,Hinh3,Hinh4)
values(N'HinhAsus1_Anh1.jpg', N'HinhAsus1_Anh3.jpg', N'HinhAsus1_Anh3.jpg', N'HinhAsus1_Anh4.jpg'),
(N'HinhAsus2_Anh1.jpg', N'HinhAsus2_Anh3.jpg', N'HinhAsus2_Anh3.jpg', N'HinhAsus2_Anh4.jpg'),
(N'HinhAsus3_Anh1.jpg', N'HinhAsus3_Anh3.jpg', N'HinhAsus3_Anh3.jpg', N'HinhAsus3_Anh4.jpg'),
(N'HinhAsus4_Anh1.jpg', N'HinhAsus4_Anh3.jpg', N'HinhAsus4_Anh3.jpg', N'HinhAsus4_Anh4.jpg'),
(N'HinhAsus5_Anh1.jpg', N'HinhAsus5_Anh3.jpg', N'HinhAsus5_Anh3.jpg', N'HinhAsus5_Anh4.jpg'),
(N'HinhAsus6_Anh1.jpg', N'HinhAsus6_Anh3.jpg', N'HinhAsus6_Anh3.jpg', N'HinhAsus6_Anh4.jpg')

set dateformat dmy
insert into KhachHang
values('KH01',N'Đỗ Thanh Tùng','06/11/2000','Nam','0832110611','123','dothanhtung@gmail.com',N'80/26 Huỳnh Văn Nghệ'),
('KH02',N'Phạm Thị Vi','05/04/2000','Nu','094982212','12345','phamvi@gmail.com',N'3 Bùi Xuân Phái'),
('KH03',N'Phan Thị Ngọc Dung','04/03/2000','Nu','0987787678','999','dungphan@gmail.com',N'67 Nguyễn Đỗ Cung'),
('KH04',N'Lý Hoàng Phi Dũng','02/04/2000','Nam','0988764321','555','dungly@gmail.com',N'8 Nguyễn Đỗ Cung')

insert into DonHang(NgayDat, NgayGiao, TinhTrangThanhToan, MaKhachHang)
values('12/03/2020','15/03/2020',N'Đã Thanh Toán','KH01'),
('05/04/2020','06/04/2020',N'Đã Thanh Toán','KH03'),
('10/05/2020','15/05/2020',N'Đã Thanh Toán','KH02'),
('10/03/2020','11/03/2020',N'Đã Thanh Toán','KH04'),
('09/06/2020','10/06/2020',N'Đã Thanh Toán','KH01'),
('23/07/2020','24/07/2020',N'Đã Thanh Toán','KH02'),
('25/08/2020','26/08/2020',N'Đã Thanh Toán','KH03')

insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(1,1,1,0)

insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(2,2,1,0)
insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(3,3,2,0)
insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(4,4,2,0)
insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(5,5,1,0)
insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(6,6,1,0)
insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(7,7,1,0)
insert into LoaiTinTuc(TenLoaiTin)
values(N'Tin Mới'),
(N'Khuyến Mãi'),
(N'Thủ Thuật'),
(N'App & Game'),
(N'For Game')
select * from TinTuc

insert into TinTuc(TieuDe,NoiDung,AnhBia,NgayTao,Cmt,MaLoaiTin)
values(N'ASUS Zenbook 13 & 14: hiệu năng, tiện dụng đỉnh cao trong thân hình mỏng nhẹ bậc nhất thế giới'
,N'Nối tiếp sự thành công về tính di động của người tiền nhiệm, Zenbook 13 và Zenbook 14 phiên bản mới vượt lên và tạo một đỉnh cao mới của sự mỏng nhẹ, tiện dụng.
 Cả hai chiếc máy đều đạt đến độ mỏng "khó có thể mỏng hơn", chỉ 13,9 mm. Asus đã khiến giới công nghệ bất ngờ, khi có thể trang bị bộ khung hợp kim nhôm cao cấp, chắc chắn mà vẫn có thể giữ cho bộ đôi Zenbook 13 và Zenbook 14 số đo về trọng lượng rất nhẹ. Gây ấn tượng nhất là chiếc Zenbook 13 với trọng lượng chỉ 1,11 kg.
  Với thân hình "mi nhon" như thế, bộ đôi Zenbook sẽ dễ dàng trở thành người bạn đồng hành với chúng ta tới bất kì đâu, sẵn sàng trợ giúp chúng ta trong mọi hoàn cảnh. 
Đặc biệt, với viên pin có thể hoạt động lên đến 21 giờ chỉ với 1 lần sạc, cùng khả năng sạc nhanh thông qua cổng USB Type C, bạn sẽ hạn chế phải mang theo sạc trong những lần ngồi cafe làm việc hay trong những chuyến đi chơi ngắn ngày. 
ZenBook 13 và ZenBook 14 sở hữu sức mạnh đến từ vi xử lý Intel® Core™ thế hệ 11 mới nhất với tốc độ nhanh hơn, hoạt động mượt mà hơn và phản hồi tốt hơn so với thế hệ tiền nhiệm. Máy còn được trang bị đồ họa thế hệ mới Intel® Iris® Xe cho trải nghiệm đồ họa toàn diện, kết hợp cùng RAM lên đến 16GB giúp người dùng dễ dàng giải quyết mọi tác vụ thường ngày.
Không chỉ gây ấn tượng về sức mạnh, bộ đôi Zenbook mới còn rất tinh tế khi làm việc, khi được trang bị chế độ Whisper giúp tản nhiệt không tiếng ồn, rất hữu ích mỗi khi cần sự tập trung cao độ hay làm việc vào ban đêm.
Về lưu trữ, ổ SSD PCIe® 3.0 x2 dung lượng 512GB giúp máy đọc chép dữ liệu nhanh và cho thời gian tải các ứng dụng gần như ngay lập tức. Với kết nối không dây WiFi 6 (802.11ax), người dùng có thể tận hưởng tốc độ nhanh gấp 3 lần so với chuẩn WiFi cũ. Chất lượng kết nối không dây được tăng cường nhờ ASUS WiFi Smart Connect tự động chọn nguồn WiFi tốt nhất để kết nối.','tin1.jpg','25/11/2020',5,'2'),

(N'Trải nghiệm Lenovo ThinkPad X13: Cảm hứng từ X1 Carbon với mức giá dễ chịu hơn',N'Là thế hệ tiếp nối mẫu X390 trước đây, ThinkPad X13 có đủ đặc trưng và sức mạnh để là lựa chọn đáng cân nhắc về mẫu laptop doanh nhân ở phân khúc cao cấp.
Đối với cái tên ThinkPad, con số kích thước màn hình 13 inch thường gợi nhớ đến dòng flagship X1 Carbon vốn luôn có giá bán rất cao. Với nhiều người đề cao tính di động, con số 13 inch vẫn được coi là tỷ lệ vàng. Và việc Lenovo tung ra ThinkPad X390 trước đây và hiện tại là ThinkPad X13 đang đến lựa chọn dễ tiếp cận hơn với nhiều người dùng và doanh nghiệp tại Việt Nam.
 Sở hữu màn hình kích thước 13 inch cùng mức cân nặng xấp xỉ 1,3 kg, ThinkPad X13 hướng đến đối tượng người dùng thường xuyên di chuyển. Vẫn khoác lên tông đen đặc trưng nhìn là biết ngay ThinkPad nhưng cũng vì thế mẫu laptop này khá dễ bám bẩn, dấu vân tay in lên phần nắp máy. Hành trang trong hộp sản phẩm bao gồm củ sạc 65W qua cổng USB-C và một đầu chuyển sang cổng RJ45. Phần logo ThinkPad có dấu tròn đỏ tích hợp đèn báo LED từ lâu đã thành đặc trưng rất riêng khi nhắc về dòng sản phẩm nổi tiếng của Lenovo.
 Chính ngoại hình "đen nguyên cây" cùng logo chấm đỏ phát sáng như vậy tạo nên vẻ "đẹp lạ" cho ThinkPad X13 nói riêng và laptop Thinkpad nói chung khi người chung quanh nhìn vào. Cạnh phải bao gồm khe tản nhiệt, cổng USB-A và khóa Kensington. Cạnh trái có tương đối nhiều cổng so với thân hình nhỏ nhẹ của máy bao gồm 2 cổng USB-C thunderbolt 3, 1 USB-A, 1 HDMI và cổng âm thanh 3,5mm.','tin2.jpg','29/12/2020',12,'2'),
 (N'Acer ra mắt Aspire 5 mới, trang bị vi xử lý Intel Core i thế hệ thứ 11',N'Acer Việt Nam ra mắt Aspire 5 mới, dòng laptop siêu mỏng nhẹ dành cho mọi đối tượng. Với việc được trang bị vi xử lý Intel Core i thế hệ 11 mới nhất, thiết kế trẻ trung, thanh lịch hơn với nhiều màu sắc cá tính, Aspire 5 là sự lựa chọn hoàn hảo cho những người cần một hiệu năng mạnh mẽ nhưng vẫn đề cao tính thời trang tinh tế. Acer Aspire 5 mới sẽ có ngoại hình mỏng nhẹ hơn, sexy hơn. Máy giờ đây sẽ sở hữu ngôn ngữ thiết kế trẻ trung, thanh lịch với chất liệu kim loại sang trọng. Aspire 5 có "số đo" lý tưởng, nhẹ chỉ 1.46kg và độ mỏng đạt 17.95mm, kết hợp với đa màu sắc cá tính giúp chủ nhân của nó thể hiện được cái tôi ở bất kỳ môi trường làm việc nào.
Là một trong những chiếc laptop đầu tiên được trang bị vi xử lý Intel® Core™ i thế hệ 11 mới nhất, Acer Aspire 5 sở hữu sức mạnh vượt trội hơn 20% so với thế hệ trước. Người dùng có thể thoải mái làm việc trên các tác vụ văn phòng từ đơn giản đến phức tạp, thậm chí có thể giải trí, chơi game dễ dàng ở độ phân giải Full HD. Tuy mang lại hiệu năng cao hơn nhưng lại tiết kiệm điện hơn, Aspire 5 cho thời lượng pin sử dụng liên tục từ 7 – 11 tiếng, giúp người dùng có thể làm việc trong suốt một ngày dài mà không phải lo lắng mình có mang theo sạc hay không.
 Với kết nối Wifi 6 mới nhất, Acer Aspire 5 thừa hưởng tốc độ kết nối không dây siêu nhanh, hơn gấp bốn lần so với thế hệ cũ. Máy cũng sẽ được trang bị tới hai ăng-ten ở trên nắp máy giúp tăng khả năng bắt sóng, giúp người dùng dễ dàng kết nối mọi lúc mọi nơi.
Máy vẫn được đầy đủ các cổng kết nối thông dụng mang lại sự tiện lợi cao nhất, bao gồm cổng USB Type-C, hai cổng USB 3.1, cổng USB 2.0, cổng HDMI hỗ trợ HDCP, cổng âm thanh 3.5 mm (hỗ trợ tai nghe có microphone tích hợp), cổng Ethernet và cổng nguồn. Chiếc laptop này cũng hỗ trợ kết nối Bluetooth 5.0. Acer Aspire 5 sử dụng vi xử lý Intel® Core™ i thế hệ 11 mới nhất có giá bán lẻ từ 13,49 triệu đến 17,69 triệu. Khi mua Aspire 5 từ nay cho đến hết ngày 30/11, người dùng nhận được một ly giữ nhiệt Predator.','tin3.jpg','22/12/2020',11,'1'),
(N' Laptop Dell Precision M4800 cho nhà thiết kế 3D thời trang chuyên nghiệp',N'Thiết kế vuông vức, mạnh mẽ là dòng máy trạm di động Dell Precision M4800 đạt chuẩn quân đội MIL-STD 810G nên cực kỳ bền, khả năng chống chịu với điều kiện khắc nghiệt rất tốt.Dell Precision M4800 được thiết kế tối ưu dành cho những phần mềm đồ họa chuyên nghiệp, trong đó có các phần mềm thiết kế thời trang. Nếu bạn làm trong môi trường thiết kế thời trang chuyên nghiệp thì không thể bỏ qua laptop này. Với cấu hình mạnh mẽ năng cấp dễ dàng rất nhiều công ty thời trang đã chọn laptop này.','tin4.jpg','10/03/2020',26,'3'),
(N' Laptop Hp Zbook 15 G3 một gợi ý cho nhà thiết kế thời trang 3D',N'Đánh giá thiết kế: Laptop Hp Zbook 15 thiết kế thời trang. Nếu bạn là nhà thiết kế thời trang sử dụng phần mềm 3D cực nặng, cần một laptop có vẻ ngoài tinh tế thì không thể bỏ qua Hp Zbook 15 G3. Là laptop đồ họa có thiết kế các cạnh bo tròn, máy mỏng và nhẹ. Chất liệu nhôm-magie bền chắc. Phần nắp phía xung quanh được bọc lớp cao su mềm. Hp Zbook 15 G3 thỏa mãn các tiêu chuẩn độ bền quân đội MIL-STD 810G.Hp Zbook 15 G3 có hiệu năng xử lý tuyệt vời. Card NVIDIA Quadro tương thích với mọi phần mềm đồ họa, trong đó có các phần mềm thiết kế thời trang (VSTITCHER, TUKA3D, Gerber Accumark...). Nếu là dân thiết kế thời trang chuyên nghiệp, bạn không thể bỏ qua mẫu laptop này. Gần như nếu dùng thiết kế thời trang thì mình không có điểm gì để chê cả.','tin5.jpg','10/12/2019',24,'3'),
(N'Acer Nitro 5 - laptop gaming đáng tiền trong phân khúc dưới 30 triệu',N'Sự cải tiến được lòng nhiều game thủ nhất có lẻ ở phần bàn phím của Nitro 5. Bàn phím trên máy được trang bị hệ thống đèn LED RGB bốn vùng thay vì chỉ đỏ đơn sắc như trước đây. Đặc biệt, game thủ hoàn toàn có thể điều chỉnh hiệu ứng chuyển màu sắc thông qua phần mềm NitroSense đi kèm.Màn hình chất lượng tốt nhất trong tầm giá.Màn hình Nitro 5 có kích thước lớn lên đến 15.6 inches, độ phân giải FullHD cùng tấm nền IPS tiên tiến, mang đến những hình ảnh vô cùng rõ nét và sống động. Thêm vào đó, màn hình này còn được Acer trang bị công nghệ chống chói ComfyView, giúp người dùng vẫn có thể nhìn rõ trong môi trường có ánh sáng lớn. Màn hình Nitro 5 còn gây ấn tượng khi cho khả năng đạt chuẩn 72% gam màu NTSC, độ sáng 270 nits và độ sai lệch màu thấp. Viền màn hình của Nitro 5 được Acer cắt đi khá mỏng chỉ còn 6.3mm mang đến khả năng trải nghiệm thị giác vô cùng tuyệt vời.','PC1.jpg','22/12/2020',11,'1'),

(N'ASUS ra mắt bội đôi laptop ZenBook Flip màn hình OLED, giá từ 25,99 triệu đồng',N'Nổi trội nhất của dòng ZenBook Flip mới là màn hình cảm ứng OLED kích thước 13,3 inch Full HD (ZenBook Flip 13 UX363). Màn hình cảm ứng OLED này đạt chuẩn PANTONE, dải màu chuẩn điện ảnh 100% DCI-P3, chứng nhận VESA DisplayHDR 500 True Black cho màu đen sâu và độ tương phản cao hơn.
ZenBook Flip S UX371 được trang bị màn hình cảm ứng 4K UHD OLED viền siêu mỏng NanoEdge, kích thước 13,3 inch, tỷ lệ 16:9, được trang bị vi xử lý Intel Core i7 thế hệ thứ 11 chuẩn EVO cùng card đồ họa tích hợp Iris Xe, kết hợp với RAM lên đến 16GB và 1 TB PCIe 3.0 x4 SSD.
Flip S UX371 dùng vi xử lý Intel Core i7-1165G7 có TPU 15W, đồ họa Intel Iris Xe, bộ nhớ RAM 16GB LPDDR4x, ổ cứ SSD 1TB PCIe. Máy tích hợp camera hồng ngoại (IR) trên màn hình có 2 cổng Thunderbolt 4, một cổng HDMI và bàn phím số NumberPad 2.0 (khu vực touchpad).','PC3.jpg','17/12/2020',13,'4'),

(N'Xu hướng chọn laptop sinh viên, văn phòng dịp cuối năm',N'Thị trường laptop cuối năm càng sôi động hơn với rất nhiều khuyến mại, giảm giá đến từ các nhà bán lẻ, nhiều sản phẩm mới ra đời giúp người dùng có thêm sự lựa chọn. Tuy nhiên việc có quá nhiều sản phẩm cũng làm người dùng băn khoăn.
Những trăn trở của sinh viên, văn phòng khi chọn mua laptop
Mức giá hợp lý
Phần lớn sinh viên, người dùng văn phòng hầu bao không quá rủng rỉnh luôn quan tâm đến mức giá. Trong đó, phân khúc 10 triệu đến dưới 20 triệu được quan tâm nhiều nhất.
Mạnh mẽ - bền bỉ
Pin dai cho cả ngày dài
Không phải giảng đường chỗ nào cũng có sẵn ổ cắm điện, các bạn dân văn phòng đôi khi cần mang máy đi họp, đi công tác hay gặp khách hàng. Vì thế ai cũng cần một laptop có thời lượng pin cả ngày.
Thiết kế thời trang
Sau tất cả, thiết kế là một yếu tố được các bạn sinh viên, dân văn phòng đặc biệt quan tâm. Không ít bạn còn coi laptop như một phụ kiện thời trang để mang đi cà phê, đi học, đi gặp bạn bè...','PC4.jpg','10/12/2020',10,'1')
select *from LienHe
select *from CT_DonHang
insert into CT_DonHang(MaDonHang, MaSanPham, SoLuong, DonGia)
values(2,6,1,0)
