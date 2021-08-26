create database QL_DatDoAn
use QL_DatDoAn
create table QUANLI
(
	MaQL char(10) not null,
	MatKhau char(10) not null
	primary key(MaQL, MatKhau)
)
create table KHACHHANG
(
	MaKH char(10) not null, 
	MatKhau char(10) not null,
	TenKH nvarchar(50),
	DiaChi nvarchar(max),
	NgaySinh date,
	GioiTinh nvarchar(5),
	Gmail nvarchar(max),
	HinhAnh nvarchar(max),
	primary key(MaKH)
)

create table LOAIMON
(
	MaLoaiMon char(10) not null primary key,
	TenLoaiMon nvarchar(50)
)
create table MONAN
(
	MaMon char(10) not null primary key,
	TenMon nvarchar(50),
	MaLoaiMon char(10),
	MaCuaHangMon char(10),
	SoLuongTon int,
	HinhAnhMon nvarchar(max)
)


create table LICHSUGIA
(
	MaMon char(10) not null primary key,
	NgayHL date,
	Gia money
)

create table KHUYENMAI
(
	MaKhuyenMai char(10) not null primary key,
	TenKhuyenMai nvarchar(50),
	DKKhuyenMaiCT nvarchar(50),
	PhanTram money,
	NgayBDKhuyenMai date,
	NgayKTKhuyenMai date,
	HinhAnhKM nvarchar(max),
	DKKhuyenMai money
)




create table CUAHANGMON
(
	MaCuaHangMon char(10) not null primary key,
	TenCuaHang nvarchar(50),
	DiaChi nvarchar(50),
	DanhGia nvarchar(50),
	ThoiGianMoCua nvarchar(50),
	ThoiGianDongCua nvarchar(50),
	HinhAnhCH nvarchar(max),

)

create table DONHANG
(
	MaDonHang char(10) not null,
	MaKH char(10) not null,
	MaCuaHangMon char(10) not null,
	NgayDat date,
	DiaChiGiaoHang nvarchar(50) not null,
	MaKhuyenMai char(10),
	HinhThucThanhToan nvarchar(50),
	GiaShip money,
	TongTien money,
	ThanhToan money,
	TinhTrang nvarchar(max),
	primary key(MaDonHang)
)




create table CHITIETDONHANG
(
	MaDonHang char(10) not null,
	MaMon char(10) not null,
	DonGia money,
	ThanhTien money,
	SoLuong int
	primary key (MaDonHang, MaMon)
)

create table DSDIACHI
(
	MaKH char(10) not null,
	TenDiaChi nvarchar(100) not null,
	DiaChi nvarchar(max),
	primary key (MaKH, TenDiaChi)
)

---------------------------------------------Khoá ngoại--------------------------------------------------------
alter table CHITIETDONHANG
add constraint FK_DONHANG_CHITIETDONHANG foreign key (MaDonHang) references DONHANG(MaDonHang),
	constraint FK_MON_CHITIETDONHANG foreign key (MaMon) references MONAN(MaMon)
alter table MONAN
add	constraint FK_MONAN_CUAHANGMON foreign key (MaCuaHangMon) references CUAHANGMON(MaCuaHangMon),
constraint FK_MALOAI_CUAHANGMON foreign key (MaLoaiMon) references LOAIMON(MaLoaiMon)
alter table LICHSUGIA
add constraint FK_LISHSUGIA_MONAN foreign key (MaMon) references MONAN(MaMon)
alter table DONHANG
add	constraint FK_KHUYENMAI_DONHANG foreign key (MaKhuyenMai) references KHUYENMAI(MaKhuyenMai),
constraint FK_KHACHHANG_DONHANG foreign key (MaKH) references KHACHHANG(MaKH),
constraint FK_CUAHANGMON_DONHANG foreign key (MaCuaHangMon) references CUAHANGMON(MaCuaHangMon)

alter table DSDIACHI
add constraint FK_DSDIACHI_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH)



-------------------------------------------Nhập liệu-----------------------------------------------------------
insert into QUANLI
values('AD01','0611'),
('AD02','0405'),
('AD03','1003'),
('AD04','0204')

insert into LOAIMON
values('LM01',N'Cơm'),
('LM02',N'Bún/Phở'),
('LM03',N'Trà Sữa/Cafe'),
('LM04',N'Đặc Sản'),
('LM05',N'Đồ Ăn Nhanh'),
('LM06',N'Ăn Vặt'),
('LM07',N'Healthy'),
('LM08',N'Tráng Miệng')

insert into CUAHANGMON
values('CH01',N'Cơm gà Xối Mỡ Anh Ba',N'79 Phan Huy Ích, P.12, Q.Gò Vấp',N'4.4',N'9:00 AM',N'22:00 PM',N'CH_ComGaXoiMoAnhBa.jpg'),
('CH02',N'Cơm gà Xối Mỡ Thạch Lam',N'142 Phan Huy Ích, P.12, Q.Gò Vấp',N'5.0',N'8:30 AM',N'21:00 PM',N'CH_ComGaThachLam.jpg'),
('CH03',N'3 Râu',N'222 Phan Huy Ích, P.14, Q.Gò Vấp',N'5.0',N'6:00 AM',N'22:00 PM',N'CH_3Rau.jpg'),
('CH04',N'Checken plus',N'86 Lê Đức Thọ, P.16, Q.Gò Vấp',N'4.3',N'8:00 AM',N'22:00 PM',N'CH_ChickenPlus.jpeg'),
('CH05',N'Bún bò Huế Hạnh',N'162 Lê Trọng Tấn, P.14, Q.Tân Phú',N'5.0',N'7:00 AM',N'22:00 PM',N'CH_BunBoHueHanh.jpg'),
('CH06',N'Phở Thìn',N'54 Nguyễn Tư Giãn, P.12, Q.Gò Vấp',N'4.6',N'7:00 AM',N'22:00 PM',N'CH_PhoThin.jpg'),
('CH07',N'Đặc sản Miền Trung',N'441 Phan Huy Ích, P.12, Q.Gò Vấp',N'5.0',N'8:30 AM',N'22:00 PM',N'CH_DacSanMienTrung.jpg'),
('CH08',N'Miền Tây Food',N'426 Phan Huy Ích, P.12, Q.Gò Vấp',N'5.0',N'9:00 AM',N'22:00 PM',N'CH_MienTayFood.jpg'),
('CH09',N'Trà Sữa Tocotoco',N'79 Lê Trọng Tấn, P.14, Q.Tân Phú',N'5.0',N'9:00 AM',N'23:00 PM',N'CH_TraSuaToco.jpg'),
('CH010',N'Phúc Long',N'493a Trường Trinh, P.14, Q.Tân Bình',N'5.0',N'7:00 AM',N'23:00 PM',N'CH_PhucLong.jpg'),
('CH011',N'Healthy Food',N'43 Trường Trinh, P.14, Q.Tân Bình',N'5.0',N'8:00 AM',N'22:00 PM',N'CH_HealthyFood.png')


insert into MONAN
values('MA01',N'Cơm gà ta','LM01','CH01',10,N'ComGaTa.jpg'),
('MA02',N'Cơm gà xối mỡ','LM01','CH01',15,N'ComGaXoiMo.jpg'),
('MA03',N'Cơm chiên dương châu','LM01','CH02',7,N'ComChienDuongChau1.jpg'),
('MA04',N'Cơm chiên dương châu','LM01','CH02',9,N'ComChienDuongChau2.jpg'),
('MA05',N'Cơm bò lúc lắc','LM01','CH01',10,N'ComBoLucLac.jpg'),
('MA06',N'Cơm gà ta','LM01','CH02',8,N'ComGaTa2.jpg'),
('MA07',N'Bún bò Đông Ba','LM02','CH05',5,N'BunBoDongBa.jpg'),
('MA08',N'Bún bò huế','LM02','CH05',14,N'BunBoHue.jpg'),
('MA09',N'Phở bò','LM02','CH06',10,N'PhoBo.jpg'),
('MA010',N'Hủ tiếu & bò kho','LM02','CH06',11,N'HuTieuBoKho.jpg'),
('MA011',N'Trà sữa Tocotoco','LM03','CH09',12,N'TraSuaTocco.jpg'),
('MA012',N'Trà sữa Huy','LM03','CH010',20,N'TraSuaHuy.jpg'),
('MA013',N'Trà sữa Khoai Môn','LM03','CH010',9,N'TraSuaKhoaiMon.jpg'),
('MA014',N'Sữa tươi đường hổ ','LM03','CH09',7,N'TraSuaDuongHo.jpg'),
('MA015',N'Trà sữa trân châu hoàng kim','LM03','CH010',10,N'TraSuaHoangKim.jpeg'),
('MA016',N'Bánh canh mực','LM04','CH07',12,N'BanhCanhMuc.jpg'),
('MA017',N'Bánh bèo','LM04','CH07',22,N'BanhBeo.jpg'),
('MA018',N'Nem nướng và bún thịt nướng','LM04','CH07',13,N'NemNuongBunThitNuong.jpeg'),
('MA019',N'Bánh ướt lòng gà','LM04','CH08',8,N'BanhUotLongGa.jpeg'),
('MA020',N'Xôi hạnh','LM04','CH08',12,N'XoiHanh.jpeg'),
('MA021',N'Gà chiên Chicken plus','LM01','CH04',9,N'GaChickenPlus.jpeg'),
('MA022',N'3 Râu','LM05','CH03',10,N'GaRan3Rau.jpeg'),
('MA023',N'Gà Rán Popeyes','LM05','CH04',12,N'GaRanPopeyes.jpeg'),
('MA024',N'Texas Chicken','LM05','CH03',21,N'TexasChicken.jpg'),
('MA025',N'Hamburger','LM05','CH04',12,N'Hamburger.jpg'),
('MA026',N'Cơm chay Vạn Duyên','LM07','CH011',11,N'ComChayVanDuyen.jpg'),
('MA027',N'Nước ép trái cây','LM07','CH011',5,N'NuocEpTraiCay.jpg'),
('MA028',N'Sữa hạt Nhé','LM07','CH011',3,N'SuaHatNhe.jpg'),
('MA029',N'Thực dưỡng sạch','LM07','CH011',9,N'ThucDuongSach.jpg'),
('MA030',N'Bánh mì thịt xông khói','LM08','CH03',9,N'BanhMi.jpg'),
('MA031',N'Chả chiên - chả bò','LM08','CH08',9,N'ChaChien.jpg')


set dateformat dmy
insert into LICHSUGIA
values('MA01','12/8/2021',32000),
('MA02','19/8/2021',24000),
('MA03','20/8/2021',35000),
('MA04','18/8/2021',40000),
('MA05','15/8/2021',42000),
('MA06','10/8/2021',38000),
('MA07','10/8/2021',28000),
('MA08','10/8/2021',88000),
('MA09','10/8/2021',18000),
('MA010','10/8/2021',58000),
('MA011','10/8/2021',31000),
('MA012','10/8/2021',36000),
('MA013','10/8/2021',32000),
('MA014','10/8/2021',18000),
('MA015','10/8/2021',36000),
('MA016','10/8/2021',80000),
('MA017','10/8/2021',8000),
('MA018','10/8/2021',31000),
('MA019','10/8/2021',30000),
('MA020','10/8/2021',76000),
('MA021','10/8/2021',28000),
('MA022','10/8/2021',90000),
('MA023','10/8/2021',68000),
('MA024','10/8/2021',18000),
('MA025','10/8/2021',30000),
('MA026','10/8/2021',48000),
('MA027','10/8/2021',98000),
('MA028','10/8/2021',99000),
('MA029','10/8/2021',14000),
('MA030','10/8/2021',18000),
('MA031','10/8/2021',48000)

insert into  KHUYENMAI
values('KM01',N'Giảm 70k cho 200k',N'Giảm 75k cho đơn hàng 200k không bao gồm phí ship',75000,'13/05/2021','13/07/2021',N'Deal70K.jpeg', 200000),
('KM02',N'FreeShip 15k',N'Free ship cho đơn 0đ',28000,'13/05/2021','13/07/2021',N'FreeShip.jpeg', 0),
('KM03',N'Giảm 50k cho 90k',N'Giảm 50k cho đơn hàng 200k không bao gồm phí ship',50000,'13/05/2021','13/07/2021',N'Deal50K.jpeg', 90000),
('KM04',N'Giảm 40k cho 150k',N'Giảm 60k cho đơn hàng 200k không bao gồm phí ship',60000,'13/05/2021','13/07/2021',N'Deal40.jpeg', 200000),
('KM05',N'Giảm 40k cho đơn đầu tiên',N'Giảm 40k cho đơn hàng 200k không bao gồm phí ship',40000,'13/05/2021','13/07/2021',N'Giam40KDonDau.png', 200000)

insert into KHACHHANG
values('0832110611','0611',N'Đỗ Thanh Tùng',N'80/26 Huỳnh Văn Nghệ','06/11/2000',N'Nam',N'dothanhtung.06112000@gmail.com', 'Tung.jpg'),
('0376437459','0405',N'Phạm Thị Vi',N'1 Bùi Xuân Phái','04/05/2000',N'Nữ',N'phamthivi459@gmail.com', 'ViHeo.jpg'),
('0816044584','0204',N'Lý Hoàng Phi Dũng',N'32 Nguyễn Sáng','02/04/2000',N'Nam',N'lyhoangdung@gmail.com', 'Dungpro.jpg'),
('0378287287','1003',N'Phan Thị Ngọc Dung',N'46 Nguyễn Đỗ Cung','10/03/1999',N'Nữ',N'phanngocdung@gmail.com', 'Dung.jpg')

insert into DSDIACHI
values('0376437459',N'Nhà của Vi', N'Hẻm 1 Bùi Xuân phái'),
('0376437459',N'Nhà cũ', N'Hẻm 29/7 Phạm Ngọc Thảo')

insert into DONHANG(MaDonHang,MaKH,MaCuaHangMon,NgayDat,DiaChiGiaoHang,MaKhuyenMai,HinhThucThanhToan,GiaShip, TinhTrang)
values('DH01','0832110611','CH01','14/05/2021',N'416 Phan Huy Ích','KM01',N'Tiền mặt',15000,N'Đã giao')
--Thành tiền của CTTDONHANG
--Create trigger upDateThanhTien on CHITIETDONHANG for insert,UPDATE
--as
--update CHITIETDONHANG
--set ThanhTien = DonGia*SoLuong  
--where MaMon=(select MaMon from inserted) and MaDonHang=(select MaDonHang from inserted)
----Thành tiền DonHang
--Create trigger upDonHang on CHITIETDONHANG for insert,UPDATE
--as
--update DONHANG
--set TongTien = (select SUM(ThanhTien) from  CHITIETDONHANG where  MaDonHang = (select MaDonHang from inserted)) + GiaShip
--where MaDonHang=(select MaDonHang from inserted)


insert into DONHANG(MaDonHang,MaKH,MaCuaHangMon,NgayDat,DiaChiGiaoHang,MaKhuyenMai,HinhThucThanhToan,GiaShip, TinhTrang)
values('DH02','0376437459','CH02','15/05/2021',N'140 Lê Trọng Tấn','KM02',N'Tiền mặt',15000,N'Đơn hủy')

insert into DONHANG(MaDonHang,MaKH,MaCuaHangMon,NgayDat,DiaChiGiaoHang,MaKhuyenMai,HinhThucThanhToan,GiaShip, TinhTrang)
values('DH03','0816044584','CH05','14/05/2021',N'1 Nguyễn Sáng','KM02',N'Tiền mặt',15000,N'Đã giao')

insert into DONHANG(MaDonHang,MaKH,MaCuaHangMon,NgayDat,DiaChiGiaoHang,MaKhuyenMai,HinhThucThanhToan,GiaShip, TinhTrang)
values('DH04','0378287287','CH03','18/05/2021',N'416 Phan Huy Ích','KM01',N'Tiền mặt',15000,N'Đã giao')

insert into CHITIETDONHANG
values('DH01','MA01',30000,null,1)
insert into CHITIETDONHANG
values('DH01','MA06',32000,null,1)
insert into CHITIETDONHANG
values('DH01','MA07',28000,null,1)
insert into CHITIETDONHANG
values('DH02','MA011',24000,null,1)



select TenMon, HinhAnhMon, DanhGia from MONAN, CUAHANGMON, LOAIMON where MONAN.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and MONAN.MaLoaiMon = LOAIMON.MaLoaiMon and LOAIMON.MaLoaiMon = 'LM01'
select TenMon, Gia
from MONAN, LICHSUGIA
where MONAN.MaMon = LICHSUGIA.MaMon
select TenMon, HinhAnhMon, DanhGia from MONAN, CUAHANGMON where MONAN.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and TenMon like N'%Bánh mì%'
select TenMon, HinhAnhMon, DanhGia from MONAN, CUAHANGMON, LOAIMON where MONAN.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and CUAHANGMON.MaCuaHangMon = 'CH03'

--
select MaDonHang, TenCuaHang, NgayDat, TinhTrang, CUAHANGMON.DiaChi, TongTien, HinhThucThanhToan
from DONHANG, CUAHANGMON, KHACHHANG
where DONHANG.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and KHACHHANG.MaKH = DONHANG.MaKH and KHACHHANG.MaKH = '0376437459'

select MaMon
from DONHANG, CHITIETDONHANG
where CHITIETDONHANG.MaDonHang = DONHANG.MaDonHang and DONHANG.MaDonHang = 'DH02'


select MaDonHang, TenCuaHang, NgayDat, TinhTrang, DiaChiGiaoHang, TongTien, HinhThucThanhToan from DONHANG, CUAHANGMON, KHACHHANG where DONHANG.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and KHACHHANG.MaKH = DONHANG.MaKH and KHACHHANG.MaKH = '0376437459'
select *from KHUYENMAI where NgayBDKhuyenMai < GETDATE() and NgayKTKhuyenMai > GETDATE()
select *from DSDIACHI where MaKH = '0376437459'
select DISTINCT TenMon,  HinhAnhMon,DiaChi, TenCuaHang,  DanhGia, Gia, HinhAnhCH
 from MONAN, CUAHANGMON, LOAIMON, LICHSUGIA 
where MONAN.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and CUAHANGMON.MaCuaHangMon = 'CH01' and GETDATE() < NgayHL and LICHSUGIA.MaMon = MONAN.MaMon

select *from KHUYENMAI where TenKhuyenMai = N'Giảm 70k cho 200k' and DKKhuyenMai <= 40000.0000
select MaDonHang, TenCuaHang, NgayDat, TinhTrang, DiaChiGiaoHang, TongTien, HinhThucThanhToan from DONHANG, CUAHANGMON, KHACHHANG where DONHANG.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and KHACHHANG.MaKH = DONHANG.MaKH and KHACHHANG.MaKH = '0376437459'
select MaDonHang, TenCuaHang, NgayDat, TinhTrang, DiaChiGiaoHang, TongTien, HinhThucThanhToan from DONHANG, CUAHANGMON, KHACHHANG where DONHANG.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and KHACHHANG.MaKH = DONHANG.MaKH and KHACHHANG.MaKH = '0376437459'

--TonSoLuong của CTTDONHANG
Create trigger upDateSoLuongTon on CHITIETDONHANG for insert,UPDATE
as
update MONAN
set SoLuongTon = SoLuongTon - (select SoLuong from inserted where inserted.MaMon = MONAN.MaMon) 
where MaMon=(select MaMon from inserted)
