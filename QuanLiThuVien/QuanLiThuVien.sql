CREATE DATABASE dbLibrary
USE dbLibrary

--Thông tin thủ thư
GO
CREATE TABLE TKTHUTHU
(
	MATT VARCHAR(10) NOT NULL,
	MATKHAU VARCHAR(15) NOT NULL,
)

ALTER TABLE TKTHUTHU
ADD  PRIMARY KEY (MATT)

GO
CREATE TABLE THUTHU
(
	MATT VARCHAR(10) NOT NULL,
	HOTEN NVARCHAR(50),
	GIOITINH NVARCHAR(5),
	NGAYSINH DATE,
	SDT INT,
	EMAIL NVARCHAR(50),
	DIACHI NVARCHAR(50)
)

ALTER TABLE THUTHU
ADD  PRIMARY KEY (MATT)

ALTER TABLE THUTHU
ADD  CONSTRAINT FK_THUTHU_TKTHUTHU FOREIGN KEY(MATT)REFERENCES TKTHUTHU(MATT)

--Thông tin đọc giả

GO
CREATE TABLE TKDOCGIA
(
	MADG VARCHAR(10) NOT NULL,
	MATKHAU VARCHAR(15) NOT NULL,
)

ALTER TABLE TKDOCGIA
ADD  PRIMARY KEY (MADG)

GO
CREATE TABLE DOCGIA
(
	MADG VARCHAR(10) NOT NULL,
	TENDG NVARCHAR(50),
	GIOITINH NVARCHAR(5),
	DIACHI NVARCHAR(50),
	NGAYBD DATE NOT NULL,
	NGAYKT DATE NOT NULL,
	PHICOC MONEY
)

ALTER TABLE DOCGIA
ADD  PRIMARY KEY (MADG)

ALTER TABLE DOCGIA
ADD  CONSTRAINT FK_DOCGIA_TKDOCGIA FOREIGN KEY(MADG)REFERENCES TKDOCGIA(MADG)

--Thông tin tác giả

GO
CREATE TABLE TACGIA
(
	MATG VARCHAR(10) NOT NULL,
	TENTG NVARCHAR(50),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(5),
	QUEQUAN NVARCHAR(50)
)

ALTER TABLE TACGIA
ADD  PRIMARY KEY (MATG)

--Thông tin khu vực sách

GO
CREATE TABLE KHUVUC
(
	MAKV VARCHAR(10) NOT NULL,
	LAU NVARCHAR(10)
)

ALTER TABLE KHUVUC
ADD  PRIMARY KEY (MAKV)

--Thông tin khu vực
CREATE TABLE CTKHUVUC
(
	MAKE VARCHAR (10) NOT NULL,	
	MAKV VARCHAR (10) NOT NULL,	
	TENKESACH NVARCHAR(20)
)

ALTER TABLE CTKHUVUC
ADD  PRIMARY KEY (MAKE)

ALTER TABLE CTKHUVUC
ADD  CONSTRAINT FK_KHUVUC_CTKHUVUC FOREIGN KEY(MAKV)REFERENCES KHUVUC(MAKV)

--Thông tin sách

GO
CREATE TABLE SACH
(
	MASH VARCHAR(10) NOT NULL,
	MATG VARCHAR(10) NOT NULL,
	TENSH NVARCHAR(50),
	SOLUONG INT,
	NGAYNHAPSACH DATE,
	THELOAI NVARCHAR(50),
	NXB NVARCHAR(50),
	NAMXB DATE,
	PHIDENBU MONEY,
	MAKE VARCHAR(10)
)

ALTER TABLE SACH
ADD  PRIMARY KEY (MASH)

ALTER TABLE SACH
ADD  CONSTRAINT FK_SACH_TACGIA FOREIGN KEY(MATG)REFERENCES TACGIA(MATG)

ALTER TABLE SACH
ADD  CONSTRAINT FK_SACH_CTKHUVUC FOREIGN KEY(MAKE)REFERENCES CTKHUVUC(MAKE)

--Thông tin mượn trả sách

GO
CREATE TABLE MUONTRA
(
	MAMT VARCHAR(10) NOT NULL,
	MADG VARCHAR(10) NOT NULL,
	MATT VARCHAR(10) NOT NULL,
	MASH VARCHAR(10) NOT NULL,
	NGAYMUON DATE,
	TINHTRANG NVARCHAR(50),
	NGAYTRADUKIEN DATE,
	NGAYTRATHUCTE DATE
)

--Thông tin thu thập từ người dùng
GO
CREATE TABLE THONGTIN
(
	TUOI INT,
	THELOAI NVARCHAR(100)
)

ALTER TABLE MUONTRA
ADD  PRIMARY KEY (MAMT)


ALTER TABLE MUONTRA
ADD  CONSTRAINT FK_MT_SACH FOREIGN KEY(MADG)REFERENCES DOCGIA(MADG)

ALTER TABLE MUONTRA
ADD  CONSTRAINT FK_MT_NV FOREIGN KEY(MATT)REFERENCES THUTHU(MATT)

ALTER TABLE MUONTRA
ADD  CONSTRAINT FK_MT_SH FOREIGN KEY(MASH)REFERENCES SACH(MASH)


SET DATEFORMAT DMY

INSERT INTO TKTHUTHU
VALUES('TT001','THANHTRUNG'),
('TT002','THANHTHANH'),
('TT003','QUANGVU'),
('TT004','HAIDANG')

INSERT INTO THUTHU
VALUES ('TT001',N'NGUYỄN THÀNH TRUNG',N'NAM','10/04/1987','0915481325','NGUYENTHANHTRUNG@GMAIL.COM',N'5 NGUYỄN SÁNG- TÂY THẠNH- TÂN PHÚ'),
('TT002',N'NGUYỄN THANH THANH',N'NỮ','10/03/1975','0354861746','NGUYENTHANHTHANH@GMAIL.COM',N'152 NGUYỄN HUỆ- QUẬN 1'),
('TT003',N'ĐẶNG QUANG VŨ',N'NAM','17/10/1995','034865267','DANGQUANVU@GMAIL.COM',N'364 NGUYỄN CỪ- QUẬN 3'),
('TT004',N'NGUYỄN HẢI ĐĂNG',N'NAM','07/11/1895','034865267','NGUYENHAIDANG@GMAIL.COM',N'5 NGUYỄN SÁNG- QUẬN TÂN PHÚ')


INSERT INTO TKDOCGIA
VALUES('DG001','NGOCDUNG'),
('DG002','VANTHIEN'),
('DG003','PHIDUNG'),
('DG004','THIVI'),
('DG005','LUONGDONG')
  

INSERT INTO DOCGIA
VALUES('DG001',N'PHAN THỊ NGỌC DUNG',N'NỮ',N'65/17 NGUYỄN ĐỖ CUNG,','10/02/2019','10/02/2020',300000),
('DG002',N'NGUYỄN VĂN THIÊN',N'NAM',N'100 CMT8-TÂN PHÚ','15/10/2019','20/08/2020',300000),
('DG003',N'LÝ HOÀNG PHI DŨNG',N'NAM',N'32 NGUYỄN SÁNG-TÂN PHÚ','30/12/2018','17/05/2019',300000),
('DG004',N'PHẠM THỊ VI',N'NỮ',N'25 LÊ LỢI-TÂN BÌNH','19/12/2020','13/05/2021',300000),
('DG005',N'NGUYỄN LƯƠNG ĐÔNG',N'NAM',N'12 NGUYỄN HUỆ-QUẬN 1','26/11/2020','30/07/2021',300000)


INSERT INTO TACGIA
VALUES('TG001',N'A.ĐÔIARENCÔ','',N'Nam',N'Gia Lai'),
('TG002',N'HỘI KHKT LÂM NGHIỆP VIỆT NAM','',N'Nam',N'TP HCM'),
('TG003',N'ĐẶNG VĂN HẢO','',N'Nam',N'Hà Nội'),
('TG004',N'NUYỄN XUÂN THÀNH','',N'Nam',N'Đà Nẵng'),
('TG005',N'JEFFERY DEAVER','',N'Nam',N'Mỹ'),
('TG006',N'LẠI VĂN LONG','',N'Nam',N'Phú Yên'),
('TG007',N'TRẦN THUỲ MAI','',N'Nữ',N'Hà Nội'),
('TG008',N'CIEL','',N'Nữ',N'Nga'),
('TG009',N'Dorie Clacrk','',N'Nam',N'Pháp'),
('TG010',N'Paul Kalanithi','',N'Nam',N'Pháp')

INSERT INTO KHUVUC
VALUES('KV01', N'Lầu 1'),
('KV02', N'Lầu 2'),
('KV03', N'Lầu 3')

INSERT INTO CTKHUVUC
VALUES('MK01', 'KV01', N'Sách văn học'),
('MK02', 'KV02', N'Khoa học tự nhiên'),
('MK03', 'KV03', N'Công nghệ'),
('MK04', 'KV02', N'Kinh tế'),
('MK05', 'KV01', N'Tiểu Sử Hồi Ký')

INSERT INTO SACH
VALUES('SH001','TG001',N'CHẾ TẠO ROBOT',15,'16/02/2016',N'KHOA HỌC',N'BÁCH KHOA HÀ NỘI','2010',50000,'MK01'),
('SH002','TG002',N'NÔNG HỌC VUI',25,'13/09/2015',N'KHOA HỌC',N'THANH NIÊN','2013',100000,'MK01'),
('SH003','TG003',N'ENLIGH',34,'23/11/2017',N'GIÁO KHOA',N'GIÁO DỤC VÀ ĐÀO TẠO','2012',58000,'MK02'),
('SH004','TG004',N'CHÚ VOI BIẾT NÓI',26,'13/10/1999',N'TRUYỆN TRANH',N'GIÁO DỤC VÀ ĐÀO TẠO','2014',132000,'MK03'),
('SH005','TG005',N'KIM CƯƠNG ĐOẠT MẠNG',5,'1/10/2020',N'VĂN HỌC',N'LAO ĐỘNG','2020',162000,'MK01'),
('SH006','TG005',N'NGANG QUA THẾ GIỚI CỦA EM',10,'11/11/2020',N'VĂN HỌC',N'HÀ NỘI','2020',103000,'MK01'),
('SH007','TG006',N'KẺ SÁT NHÂN LƯƠNG THIỆN',10,'11/11/2020',N'VĂN HỌC',N'HỘI NHÀ VĂN','2020',78000,'MK01'),
('SH008','TG007',N'NHỚ THƯƠNG HOÀNG LAN',7,'8/8/2020',N'VĂN HỌC',N'PHỤ NỮ','2019',200000,'MK01'),
('SH009','TG008',N'GIẤC CHIÊM BAO MÙA HẠ',15,'7/9/2020',N'VĂN HỌC',N'THẾ GIỚI','2019',75000,'MK01'),
('SH010','TG008',N'Trong Khi Chờ Đợi Godot',5,'7/9/2020',N'VĂN HỌC',N'VĂN HỌC','2019',85000,'MK01'),
('SH011','TG005',N'Từ Tốt Đến Vĩ Đại - Jim Collins',5,'7/9/2019',N'KINH TẾ',N'TRẺ','2019',100000,'MK04'),
('SH012','TG009',N'Khởi Nghiệp 4.0',12,'7/7/2019',N'KINH TẾ',N'LAO ĐỘNG','2019',85000,'MK04'),
('SH013','TG009',N'Good to great',12,'4/7/2020',N'KINH TẾ',N'Harper Collins','2020',400000,'MK04'),
('SH014','TG010',N'Khi Hơi Thở Hóa Thinh Không',7,'9/7/2020',N'HỒI KÍ',N'LAO ĐỘNG','2020',87000,'MK05'),
('SH015','TG010',N'Châu Phi Nghìn Trùng',22,'9/10/2020',N'HỒI KÍ',N'TRẺ','2020',100000,'MK05')

INSERT INTO MUONTRA
VALUES('MT001','DG002','TT002','SH001','10/05/2019',N'ĐANG MƯỢN','11/06/2019','12/06/2019'),
('MT002','DG001','TT002','SH001','25/07/2019',N'ĐANG MƯỢN','5/01/2020','15/01/2020'),
('MT003','DG002','TT001','SH002','1/05/2020',N'ĐANG MƯỢN','21/05/2020','21/05/2020'),
('MT004','DG004','TT002','SH003','18/01/2018',N'ĐANG MƯỢN','30/05/2019','05/06/2019'),
('MT005','DG003','TT001','SH003','12/1/2020',N'ĐANG MƯỢN','25/07/2020','20/07/2020')

INSERT INTO THONGTIN
VALUES(10,N'Truyện Cổ Tích'),
(15,N'Khoa Học'),
(16,N'Giáo Dục Giới Tính'),
(20,N'Tình Yêu'),
(22,N'Tình Yêu'),
(25,N'Khởi Nghiệp'),
(8,N'Truyện Dân Gian'),
(30,N'Kinh Doanh'),
(45,N'Kinh Doanh'),
(19,N'Hồi Kí'),
(22,N'Hồi Kí'),
(33,N'Hồi Kí'),
(19,N'Viễn Tưởng'),
(23,N'Viễn Tưởng'),
(15,N'Viễn Tưởng'),
(26,N'Viễn Tưởng'),
(19,N'Tử Vi'),
(16,N'Tử Vi'),
(28,N'Tử Vi'),
(30,N'Tử Vi'),
(19,N'Tử Vi')

SELECT*FROM THUTHU
SELECT*FROM SACH
SELECT*FROM MUONTRA
SELECT*FROM DOCGIA

----TUỔI THỦ THƯ TỪ 18 TRỞ LÊN

--create trigger KT_TUOI
--on THUTHU
--after insert
--as
-- begin
-- declare @tuoi_tt int
-- set @tuoi_tt = ( select year(getdate())-year(NGAYSINH) from inserted)
-- if (@tuoi_tt < 18)
--     begin 
--            PRINT N'CHƯA ĐỦ 18 TUỔI'
--     end
--end
--go

----KIỂM TRA SINH VIÊN ĐÃ ĐĂNG KÝ THẺ CHƯA

--create trigger TG_NGAYBD_NGAYMT
--on MUONTRA
--after insert
--as
-- begin
-- if (SELECT NGAYMUON FROM INSERTED) < (SELECT NGAYBD FROM DOCGIA WHERE MADG =(SELECT MADG FROM INSERTED))
--     begin 
--            PRINT N'PHẢI ĐĂNG KÝ TRƯỚC KHI MƯỢN'
--     end
--end
--go

-- trigger update tình trạng sách -- 
--create trigger update_tinhtrang
--on MUONTRA
--for insert, update
--as
--begin
--	if(select ngaytrathucte from muontra)=null
--	begin
--		update MUONTRA
--		set TINHTRANG=N'ĐANG MƯỢN'
--		where (select MASH from inserted)=MUONTRA.MASH
--	end
--	else
--	begin
--		update MUONTRA
--		set TINHTRANG=N'KHÔNG MƯỢN'
--		where (select MASH from inserted)=MUONTRA.MASH
--	end
--end

-- Tống số đọc giả --
create proc tongsodocgia
with recompile
as
begin
	select count(MADG) from docgia
end

-- trigger update phí cọc --
--create trigger update_phicoc
--on docgia
--for insert, update
--as
--begin
--	if(select phicoc from inserted)=null
--	begin
--		update DOCGIA
--		set PHICOC= 300000
--		where docgia.MADG=(select madg from inserted)
--	end
--end

-- Tổng số sách --
go
create proc tongsosach
with recompile
as
begin
	select count(*)
	from SACH
end

exec tongsosach 

-- Tổng Phiếu mượn --
go
create proc tongsophieumuon
with recompile
as
begin
	select count(*)
	from MUONTRA
end

 --Tổng số sách đang mượn --
go
create proc tongsosachdangmuon 
with recompile
as
begin
	select count(*)
	from MUONTRA
	where TINHTRANG = N'ĐANG MƯỢN'
end

---- Tổng số sách còn lại --
--go 
--create proc tongsosachconlai @so int output
--with recompile
--as
--begin
--	select @so=count(*)
--	from sach
--	where TINHTRANG=N'KHÔNG MƯỢN'
--end

-- Tổng số phiếu quá hạn --
create proc tongsophieuquahan
with recompile
as
begin
	select count(*)
	from MUONTRA
	where NGAYTRATHUCTE IS NULL
end

---- tim kiem gan dung doc gia
--create proc timkiemDG @dg nvarchar(50) 
--as
--	select * from DOCGIA where MADG  like N'%'+ @dg + '%' OR TENDG  like N'%'+ @dg + '%'

--exec timkiemDG 'THI'

---- tim kiem gan dung thu thu
--create proc timkiemTT @tt nvarchar(50) 
--as
--	select * from THUTHU where MATT  like N'%'+ @tt + '%' OR HOTEN  like N'%'+ @tt + '%'

--exec timkiemTT 'THI'

---- tim kiem gan dung sách
--create proc timkiemSH @sh nvarchar(50) 
--as
--	select * from SACH where MASH  like N'%'+ @sh + '%' OR TENSH  like N'%'+ @sh + '%'

--exec timkiemSH 'SH'

---- tim kiem gan dung mượn trả
--create proc timkiemMT @mt nvarchar(50) 
--as
--	select * from MUONTRA where MAMT  like N'%'+ @mt + '%' OR MADG  like N'%'+ @mt + '%' OR MATT  like N'%'+ @mt + '%'

--exec timkiemMT 'THI'

--create proc xoaDG @dg nvarchar(50) 
--as
--	declare @kq nvarchar(50)
--	set @kq = (select MADG from MUONTRA where MADG=@dg)
--	if(@kq='NULL')
--		print N'Đọc Giả đang mượn sách không thể xóa'
--	else
--		delete from DOCGIA where MADG=@dg 

--exec xoaDG 'DG001'

--select * from DOCGIA

--select * from MUONTRA

----Viết thủ tục truyền vào tham số mã đọc giả trả về số lượng sách mà đọc giả đang mượn,
----nếu không có sách nào đang mượn thì trả về 0
--create procedure insSoLuongSach @madg char(10) , @soluongsach int output
--as
--SET @soluongsach = (SELECT COUNT(MASH) FROM MUONTRA WHERE MADG=@madg)
--DECLARE @soluongsach int
--exec insSoLuongSach'DG002', @soluongsach output
--SELECT @soluongsach AS SoLuongSach



----Dùng Cursor kết hợp với thủ tục cập nhật phí đền bù 
--CREATE PROC CN_PHIDENBU
--AS
--DECLARE CS_PHIDENBU CURSOR
--DYNAMIC
--FOR SELECT MADG,MASH FROM MUONTRA
--OPEN CS_PHIDENBU
--DECLARE @madg char(10),@mash char(10)
--FETCH NEXT FROM CS_PHIDENBU INTO @madg, @mash
--WHILE(@@FETCH_STATUS=0)
--  

--FETCH NEXT FROM CS_PHIDENBU INTO @madg,@mash
--END
--CLOSE CS_PHIDENBU
--DEALLOCATE CS_PHIDENBU

--EXEC CN_PHIDENBU

--SELECT * FROM MUONTRA

----Sao lưu dữ liệu 
