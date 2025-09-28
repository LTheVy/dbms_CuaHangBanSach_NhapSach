--===========================================================--
-------------------------Phần chung----------------------------
--===========================================================--

USE master
GO
CREATE DATABASE CuaHangBanSach
GO
USE CuaHangBanSach
GO

------------------------------------------------------
-- TABLES
------------------------------------------------------

-- 1. Bảng NguoiDung
CREATE TABLE NguoiDung (
    MaNguoiDung INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SDT VARCHAR(15),
    DiaChi NVARCHAR(200),
    TenDangNhap VARCHAR(50) UNIQUE,
    MatKhau VARCHAR(255),
    VaiTro NVARCHAR(50) CHECK (VaiTro IN ('Manager', 'Staff')),
    Luong DECIMAL(18,2),
    NgayTao DATETIME DEFAULT GETDATE(),
    NguoiTao INT,
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động'
);

-- 2. Bảng HoaDon
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLapHD DATE DEFAULT CAST(GETDATE() AS DATE),
    TinhTrangTT NVARCHAR(50) DEFAULT N'Chưa thanh toán',
    TongTien DECIMAL(18,2) DEFAULT 0,
    PhuongThucTT NVARCHAR(50),
    MaNguoiDung INT NOT NULL,
    MaHoiVien INT NULL,
    GhiChu NVARCHAR(500),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- 3. Bảng DonNhap
CREATE TABLE DonNhap (
    MaDN INT IDENTITY(1,1) PRIMARY KEY,
    NgayLapDN DATE DEFAULT CAST(GETDATE() AS DATE),
    TongTien DECIMAL(18,2) DEFAULT 0,
    TinhTrangNhap NVARCHAR(50) DEFAULT N'Chờ duyệt',
    MaNguoiDung INT NOT NULL,
    GhiChu NVARCHAR(500),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- 4. Bảng NhaCungCap
CREATE TABLE NhaCungCap (
    MaNCC INT IDENTITY(1,1) PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DienThoai VARCHAR(15),
    DiaChi NVARCHAR(200),
    Website NVARCHAR(200),
    Email NVARCHAR(100)
);

-- 5. Bảng Sach
CREATE TABLE Sach (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(200),
    TacGia NVARCHAR(100),
    NhaXuatBan NVARCHAR(100),
    NamXuatBan INT,
    TheLoai NVARCHAR(100),
    NgonNgu NVARCHAR(50),
    DonGia DECIMAL(18,2),
    SLTonKho INT DEFAULT 0,
    AnhBia NVARCHAR(255),
    NgayCapNhat DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(20) DEFAULT N'Có bán',
    MoTa NVARCHAR(1000)
);

-- 6. Bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL,
    MaSach INT NOT NULL,
    SoLuong INT,
    DonGia DECIMAL(18,2),
    ThanhTien DECIMAL(18,2),
    PRIMARY KEY (MaHD, MaSach),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

-- 7. Bảng ChiTietDonNhap
CREATE TABLE ChiTietDonNhap (
    MaDN INT NOT NULL,
    MaSach INT NOT NULL,
    MaNCC INT NOT NULL,
    SoLuong INT,
    GiaNhap DECIMAL(18,2),
    ThanhTien DECIMAL(18,2),
    PRIMARY KEY (MaDN, MaSach, MaNCC),
    FOREIGN KEY (MaDN) REFERENCES DonNhap(MaDN),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

-- 8. Bảng HoiVien
CREATE TABLE HoiVien (
    MaHoiVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SDT VARCHAR(15),
    DiaChi NVARCHAR(200),
    Email NVARCHAR(100),
    NgayDangKy DATE DEFAULT CAST(GETDATE() AS DATE),
    NgayHetHan DATE,
    LoaiThe NVARCHAR(50) DEFAULT N'Thường',
    DiemTichLuy INT DEFAULT 0,
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động'
);

-- 9. Quan hệ DangKyHoiVien
CREATE TABLE DangKyHoiVien (
    MaNguoiDung INT NOT NULL,
    MaHoiVien INT NOT NULL,
    NgayDangKy DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (MaNguoiDung, MaHoiVien),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaHoiVien) REFERENCES HoiVien(MaHoiVien)
);

-- 10. Bảng LogHoatDong
CREATE TABLE LogHoatDong (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MaNguoiDung INT,
    HanhDong NVARCHAR(100),
    ChiTiet NVARCHAR(500),
    ThoiGian DATETIME DEFAULT GETDATE(),
    IPAddress VARCHAR(45),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- 11. Bảng ThongBao
CREATE TABLE ThongBao (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    NoiDung NVARCHAR(500),
    NgayTao DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) DEFAULT N'Chưa xem',
    MaNguoiDung INT,
    LoaiThongBao NVARCHAR(50) DEFAULT N'Thông tin',
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- 12. Bảng CauHinh (cho hệ thống)
CREATE TABLE CauHinh (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenCauHinh NVARCHAR(100),
    GiaTri NVARCHAR(500),
    MoTa NVARCHAR(200),
    NgayCapNhat DATETIME DEFAULT GETDATE()
);

-- 13. Bảng KhuyenMai
CREATE TABLE KhuyenMai (
    MaKM INT IDENTITY(1,1) PRIMARY KEY,
    TenKM NVARCHAR(100),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    LoaiKM NVARCHAR(50), -- 'Percent' hoặc 'Amount'
    GiaTriKM DECIMAL(18,2),
    DieuKienToiThieu DECIMAL(18,2) DEFAULT 0,
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động',
    MoTa NVARCHAR(500)
);

------------------------------------------------------
-- CONSTRAINTS & INDEXES
------------------------------------------------------

-- Thêm ràng buộc
ALTER TABLE HoaDon ADD CONSTRAINT CK_HoaDon_TongTien CHECK (TongTien >= 0);
ALTER TABLE Sach ADD CONSTRAINT CK_Sach_DonGia CHECK (DonGia >= 0);
ALTER TABLE Sach ADD CONSTRAINT CK_Sach_SLTonKho CHECK (SLTonKho >= 0);
ALTER TABLE ChiTietHoaDon ADD CONSTRAINT CK_ChiTietHoaDon_SoLuong CHECK (SoLuong > 0);
ALTER TABLE HoiVien ADD CONSTRAINT CK_HoiVien_DiemTichLuy CHECK (DiemTichLuy >= 0);
ALTER TABLE NguoiDung ADD CONSTRAINT CK_NguoiDung_Luong CHECK (Luong >= 0);
ALTER TABLE DonNhap ADD CONSTRAINT CK_DonNhap_TongTien CHECK (TongTien >= 0);
ALTER TABLE ChiTietDonNhap ADD CONSTRAINT CK_ChiTietDonNhap_SoLuong CHECK (SoLuong > 0);
ALTER TABLE ChiTietDonNhap ADD CONSTRAINT CK_ChiTietDonNhap_GiaNhap CHECK (GiaNhap >= 0);
ALTER TABLE ChiTietDonNhap ADD CONSTRAINT CK_ChiTietDonNhap_ThanhTien CHECK (ThanhTien >= 0);
ALTER TABLE DonNhap ADD CONSTRAINT CK_DonNhap_TinhTrangNhap CHECK (TinhTrangNhap IN (N'Đã nhập', N'Chưa nhập', N'Hủy đơn'))

-- Thêm khóa ngoại cho HoaDon-HoiVien
ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_HoiVien
FOREIGN KEY (MaHoiVien) REFERENCES HoiVien(MaHoiVien)
ON DELETE SET NULL;

-- Thêm indexes để tối ưu performance
CREATE INDEX IX_HoaDon_NgayLapHD ON HoaDon(NgayLapHD);
CREATE INDEX IX_HoaDon_TinhTrangTT ON HoaDon(TinhTrangTT);
CREATE INDEX IX_Sach_TheLoai ON Sach(TheLoai);
CREATE INDEX IX_Sach_TacGia ON Sach(TacGia);
CREATE INDEX IX_HoiVien_SDT ON HoiVien(SDT);
CREATE INDEX IX_LogHoatDong_ThoiGian ON LogHoatDong(ThoiGian);
CREATE INDEX IX_NguoiDung_VaiTro ON NguoiDung(VaiTro);
CREATE INDEX IX_NguoiDung_TrangThai ON NguoiDung(TrangThai);
CREATE INDEX IX_ChiTietDonNhap_MaDN ON ChiTietDonNhap(MaDN);
CREATE INDEX IX_ChiTietDonNhap_MaSach ON ChiTietDonNhap(MaSach);
CREATE INDEX IX_ChiTietDonNhap_MaNCC ON ChiTietDonNhap(MaNCC);

------------------------------------------------------
-- DATA SAMPLES
------------------------------------------------------

-- Cấu hình hệ thống
INSERT INTO CauHinh (TenCauHinh, GiaTri, MoTa) VALUES
(N'DiemTichLuy_TyLe', N'10000', N'Số tiền để tích 1 điểm'),
(N'TonKho_ToiThieu', N'5', N'Số lượng tồn kho tối thiểu để cảnh báo'),
(N'HoiVien_HanThe', N'365', N'Số ngày hiệu lực thẻ hội viên');

-- Thêm Manager và Staff
INSERT INTO NguoiDung (HoTen, NgaySinh, GioiTinh, SDT, DiaChi, TenDangNhap, MatKhau, VaiTro, Luong) VALUES 
(N'Nguyễn Văn An', '1980-01-01', N'Nam', '0901234567', N'123 Nguyễn Trãi, Q1, TP.HCM', 'manager', 'manager123', 'Manager', 15000000);
INSERT INTO NguoiDung (HoTen, NgaySinh, GioiTinh, SDT, DiaChi, TenDangNhap, MatKhau, VaiTro, Luong, NguoiTao) VALUES 
(N'Trần Thị Bình', '1990-05-15', N'Nữ', '0907654321', N'456 Lê Lợi, Q3, TP.HCM', 'staff1', 'staff123', 'Staff', 8000000, 1),
(N'Lê Văn Cường', '1992-08-20', N'Nam', '0912345678', N'789 Nguyễn Huệ, Q1, TP.HCM', 'staff2', 'staff123', 'Staff', 8500000, 1),
(N'Phạm Văn Đức', '1993-10-10', N'Nam', '0935678901', N'321 Lý Thường Kiệt, Q5, TP.HCM', 'staff3', 'staff123', 'Staff', 8500000,1 );

-- Thêm nhà cung cấp
INSERT INTO NhaCungCap (TenNCC, DienThoai, DiaChi, Website, Email) VALUES 
(N'NXB Kim Đồng', '0283123456', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', 'kimdong.com.vn', 'info@kimdong.com.vn'),
(N'NXB Trẻ', '0283654321', N'161B Lý Chính Thắng, Q3, TP.HCM', 'nxbtre.com.vn', 'info@nxbtre.com.vn'),
(N'NXB Giáo Dục Việt Nam', '0284567890', N'81 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', 'nxbgd.vn', 'contact@nxbgd.vn');

-- Thêm sách đa dạng
INSERT INTO Sach (TenSach, TacGia, NhaXuatBan, NamXuatBan, TheLoai, NgonNgu, DonGia, SLTonKho, MoTa) VALUES 
(N'Doraemon - Tập 45', N'Fujiko F. Fujio', N'Kim Đồng', 2023, N'Truyện tranh', N'Tiếng Việt', 25000, 100, N'Tập truyện mới nhất của Doraemon'),
(N'Thám Tử Lừng Danh Conan - Tập 102', N'Aoyama Gosho', N'Kim Đồng', 2023, N'Truyện tranh', N'Tiếng Việt', 30000, 80, N'Câu chuyện trinh thám hấp dẫn'),
(N'Đắc Nhân Tâm', N'Dale Carnegie', N'NXB Trẻ', 2020, N'Kỹ năng sống', N'Tiếng Việt', 120000, 50, N'Cuốn sách kinh điển về kỹ năng giao tiếp'),
(N'Sapiens - Lược Sử Loài Người', N'Yuval Noah Harari', N'NXB Trẻ', 2022, N'Khoa học', N'Tiếng Việt', 250000, 30, N'Cuốn sách về tiến hóa của loài người'),
(N'Toán Lớp 12', N'Nhóm tác giả', N'NXB Giáo Dục', 2023, N'Giáo khoa', N'Tiếng Việt', 45000, 200, N'Sách giáo khoa Toán lớp 12');

-- Thêm hội viên
INSERT INTO HoiVien (HoTen, NgaySinh, GioiTinh, SDT, DiaChi, Email, LoaiThe) VALUES 
(N'Phạm Thị Lan', '1995-03-20', N'Nữ', '0912345678', N'789 Võ Văn Tần, Q3, TP.HCM', 'lan.pham@email.com', N'VIP'),
(N'Hoàng Minh Tuấn', '1988-12-10', N'Nam', '0923456789', N'123 Điện Biên Phủ, Q1, TP.HCM', 'tuan.hoang@email.com', N'Gold'),
(N'Nguyễn Thị Mai', '1992-07-15', N'Nữ', '0934567890', N'456 Cách Mạng Tháng 8, Q10, TP.HCM', 'mai.nguyen@email.com', N'Thường');

-- Thêm khuyến mãi
INSERT INTO KhuyenMai (TenKM, NgayBatDau, NgayKetThuc, LoaiKM, GiaTriKM, DieuKienToiThieu, MoTa) VALUES 
(N'Giảm giá sách giáo khoa', '2024-08-01', '2024-09-30', N'Percent', 10, 100000, N'Giảm 10% cho sách giáo khoa khi mua từ 100k'),
(N'Ưu đãi hội viên VIP', '2024-01-01', '2024-12-31', N'Percent', 15, 0, N'Giảm 15% cho tất cả hội viên VIP');

-- Thêm hóa đơn
INSERT INTO HoaDon (NgayLapHD, TinhTrangTT, TongTien, PhuongThucTT, MaNguoiDung, MaHoiVien, GhiChu) VALUES
('2024-08-01', N'Đã thanh toán', 445000.00, N'Tiền mặt', 2, 1, N'Khách hàng hội viên VIP'),
('2024-08-02', N'Đã thanh toán', 120000.00, N'Chuyển khoản', 3, NULL, N'Khách mua sách kỹ năng'),
('2024-08-03', N'Chưa thanh toán', 360000.00, N'Tiền mặt', 2, 2, N'Khách hàng hội viên Gold - chờ thanh toán'),
('2024-08-04', N'Đã thanh toán', 45000.00, N'Tiền mặt', 3, 3, N'Mua sách giáo khoa'),
('2024-08-05', N'Đã thanh toán', 545000.00, N'Thẻ tín dụng', 2, 1, N'Khách VIP mua nhiều sách');

-- Thêm dữ liệu vào bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHD, MaSach, SoLuong, DonGia, ThanhTien) VALUES
-- Hóa đơn 1: Khách VIP mua 3 loại sách
(1, 1, 3, 25000, 75000),   -- 3 cuốn Doraemon
(1, 3, 1, 120000, 120000), -- 1 cuốn Đắc Nhân Tâm
(1, 4, 1, 250000, 250000), -- 1 cuốn Sapiens
-- Hóa đơn 2: Khách thường mua sách kỹ năng
(2, 3, 1, 120000, 120000), -- 1 cuốn Đắc Nhân Tâm
-- Hóa đơn 3: Khách Gold mua truyện tranh (chưa thanh toán)
(3, 1, 2, 25000, 50000),   -- 2 cuốn Doraemon
(3, 2, 2, 30000, 60000),   -- 2 cuốn Conan
(3, 4, 1, 250000, 250000), -- 1 cuốn Sapiens
-- Hóa đơn 4: Khách thường mua sách giáo khoa
(4, 5, 1, 45000, 45000),   -- 1 cuốn Toán 12
-- Hóa đơn 5: Khách VIP mua nhiều sách
(5, 1, 5, 25000, 125000),  -- 5 cuốn Doraemon
(5, 2, 3, 30000, 90000),   -- 3 cuốn Conan
(5, 3, 2, 120000, 240000), -- 2 cuốn Đắc Nhân Tâm
(5, 5, 2, 45000, 90000);   -- 2 cuốn Toán 12


-- Tạo login trong master
USE MASTER;
CREATE LOGIN manager WITH PASSWORD = 'manager123';
CREATE LOGIN staff1 WITH PASSWORD = 'staff123';
CREATE LOGIN staff2 WITH PASSWORD = 'staff123';
CREATE LOGIN staff3 WITH PASSWORD = 'staff123';

-- Disable login staff2
ALTER LOGIN staff2 DISABLE;

-- Chuyển sang database CuaHangBanSach
USE CuaHangBanSach;

-- Tạo user cho các login
CREATE USER manager FOR LOGIN manager;
CREATE USER staff1 FOR LOGIN staff1;
CREATE USER staff2 FOR LOGIN staff2;
CREATE USER staff3 FOR LOGIN staff3;

-- Tạo vai trò db_manager và db_staff
CREATE ROLE db_manager;
CREATE ROLE db_staff;

-- Gán user vào vai trò
EXEC sp_addrolemember 'db_manager', 'manager';
EXEC sp_addrolemember 'db_staff', 'staff1';
EXEC sp_addrolemember 'db_staff', 'staff2';
EXEC sp_addrolemember 'db_staff', 'staff3';


-- Cấp quyền cho manager
USE master;
GRANT ALTER ANY LOGIN TO manager;
USE CuaHangBanSach;
GRANT ALTER ANY USER TO manager;
GRANT ALTER ANY ROLE TO manager;

-- Đồng bộ trạng thái staff2 trong NguoiDung
UPDATE NguoiDung
SET TrangThai = N'Ngừng hoạt động'
WHERE TenDangNhap = 'staff2';



--===========================================================--
-------------------------Phần nhập sách------------------------
--===========================================================--

----------------------------------------------
--Dữ liệu
----------------------------------------------



-----------------------------------------------
--Đăng nhập
-----------------------------------------------

USE CuaHangBanSach
GO

-- Procedure: Đăng nhập
GO
CREATE PROCEDURE sp_DangNhap
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @MaNguoiDung INT, @HoTen NVARCHAR(100), @VaiTro NVARCHAR(50), @TrangThai NVARCHAR(20);
    
    SELECT @MaNguoiDung = MaNguoiDung, @HoTen = HoTen, @VaiTro = VaiTro, @TrangThai = TrangThai
    FROM NguoiDung 
    WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau;
    
    IF @MaNguoiDung IS NULL
    BEGIN
        SELECT 0 AS KetQua, N'Tên đăng nhập hoặc mật khẩu không đúng' AS ThongBao;
        RETURN;
    END
    
    IF @TrangThai != N'Hoạt động'
    BEGIN
        SELECT 0 AS KetQua, N'Tài khoản đã bị khóa' AS ThongBao;
        RETURN;
    END
    
    -- Log đăng nhập
    INSERT INTO LogHoatDong (MaNguoiDung, HanhDong, ChiTiet)
    VALUES (@MaNguoiDung, N'ĐĂNG NHẬP', N'Đăng nhập thành công');
    
    -- Trả về thông tin user
    SELECT 
        1 AS KetQua,
        N'Đăng nhập thành công' AS ThongBao,
        @MaNguoiDung AS MaNguoiDung,
		@HoTen AS HoTen,
        @VaiTro AS VaiTro;
END;

----------------------------------------------
--Sách
----------------------------------------------

USE CuaHangBanSach
GO

--View: Lấy danh sách kho sách
GO
CREATE OR ALTER VIEW vw_DanhSachSach AS
SELECT 
    s.MaSach,
    s.TenSach,
    s.TacGia,
    s.TheLoai,
    s.DonGia,
    s.SLTonKho,
    s.SLTonKho * s.DonGia AS GiaTriTonKho,
    CASE
        WHEN s.SLTonKho <= 5 THEN N'Cần nhập'
        WHEN s.SLTonKho <= 20 THEN N'Sắp hết'
        ELSE N'Đủ hàng'
    END AS TinhTrangKho,
    s.NgayCapNhat
FROM Sach s

--View: Lấy danh sách kho sách gốc
GO
CREATE OR ALTER VIEW vw_DanhSachSachGoc AS
SELECT * FROM Sach


--Procedure: Thêm sách
GO
CREATE OR ALTER PROCEDURE sp_ThemSach
    @TenSach NVARCHAR(200),
    @TacGia NVARCHAR(100),
    @NhaXuatBan NVARCHAR(100),
    @NamXuatBan INT,
    @TheLoai NVARCHAR(100),
    @NgonNgu NVARCHAR(50),
    @DonGia DECIMAL(18,2),
    @SLTonKho INT,
    @AnhBia NVARCHAR(255),
    @NgayCapNhat DATETIME = NULL,
    @TrangThai NVARCHAR(20) = NULL,
    @MoTa NVARCHAR(1000),
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
		BEGIN TRANSACTION;
        INSERT INTO Sach (
            TenSach,
            TacGia,
            NhaXuatBan,
            NamXuatBan,
            TheLoai,
            NgonNgu,
            DonGia,
            SLTonKho,
            AnhBia,
            NgayCapNhat,
            TrangThai,
            MoTa
        )
        VALUES (
            @TenSach,
            @TacGia,
            @NhaXuatBan,
            @NamXuatBan,
            @TheLoai,
            @NgonNgu,
            @DonGia,
            @SLTonKho,
            @AnhBia,
            COALESCE(@NgayCapNhat, GETDATE()),
            COALESCE(@TrangThai, N'Có bán'),
            @MoTa
        );

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END;


--Procedure: Sửa sách
GO
CREATE OR ALTER PROCEDURE sp_SuaSach
    @MaSach INT,
    @TenSach NVARCHAR(200),
    @TacGia NVARCHAR(100),
    @NhaXuatBan NVARCHAR(100),
    @NamXuatBan INT,
    @TheLoai NVARCHAR(100),
    @NgonNgu NVARCHAR(50),
    @DonGia DECIMAL(18,2),
    @SLTonKho INT,
    @AnhBia NVARCHAR(255),
    @NgayCapNhat DATETIME = NULL,
    @TrangThai NVARCHAR(20) = NULL,
    @MoTa NVARCHAR(1000),
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;
		-- Kiểm tra MaSach tồn tại
		IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach)
		BEGIN
			THROW 50001, N'Mã sách không tồn tại.', 1;
		END

        UPDATE Sach
        SET
            TenSach = @TenSach,
            TacGia = @TacGia,
            NhaXuatBan = @NhaXuatBan,
            NamXuatBan = @NamXuatBan,
            TheLoai = @TheLoai,
            NgonNgu = @NgonNgu,
            DonGia = @DonGia,
            SLTonKho = @SLTonKho,
            AnhBia = @AnhBia,
            NgayCapNhat = COALESCE(@NgayCapNhat, GETDATE()),
            TrangThai = COALESCE(@TrangThai, N'Có bán'),
            MoTa = @MoTa
        WHERE MaSach = @MaSach;

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END;


--Procedure: Xóa sách
GO
CREATE OR ALTER PROCEDURE sp_XoaSach
    @MaSach INT,
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;

		-- Kiểm tra MaSach tồn tại
		IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach)
		BEGIN
			THROW 50001, N'Mã sách không tồn tại.', 1;
		END

        DELETE FROM Sach
        WHERE MaSach = @MaSach;

        SET @ErrorMessage = N'';
		COMMIT
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END;


----------------------------------------------
--Nhà cung cấp
----------------------------------------------

USE CuaHangBanSach
GO

--Function: Tính tổng số sách đã nhập của một nhà cung cấp
GO
CREATE OR ALTER FUNCTION fn_TongSachNCC(@MaNCC INT)
RETURNS INT
AS
BEGIN
	DECLARE @SoLuong INT;

	SELECT @SoLuong = SUM(ctdn.SoLuong)
	FROM NhaCungCap ncc
	JOIN ChiTietDonNhap ctdn ON ncc.MaNCC = ctdn.MaNCC
	JOIN DonNhap dn ON ctdn.MaDN = dn.MaDN
	WHERE @MaNcc = ncc.MaNCC AND dn.TinhTrangNhap = N'Đã nhập'

	RETURN ISNULL(@SoLuong, 0);
END;


--Function: Tính tổng tiền nhập của một nhà cung cấp
GO
CREATE OR ALTER FUNCTION fn_TongTienNhapNCC(@MaNCC INT)
RETURNS DECIMAL(18,2)
AS
BEGIN
	DECLARE @TongTien DECIMAL(18,2);

	SELECT @TongTien = SUM(ctdn.ThanhTien)
	FROM NhaCungCap ncc
	JOIN ChiTietDonNhap ctdn ON ncc.MaNCC = ctdn.MaNCC
	WHERE ncc.MaNCC = @MaNCC

	RETURN ISNULL(@TongTien, 0);
END;


--View: Lấy danh sách nhà cung cấp
GO
CREATE OR ALTER VIEW vw_DanhSachNhaCungCap AS
SELECT
	MaNCC,
	TenNCC,
	DienThoai,
	DiaChi,
	Website,
	Email,
	dbo.fn_TongSachNCC(MaNCC) AS TongSachNhap,
	dbo.fn_TongTienNhapNCC(MaNCC) AS TongTienNhap
FROM NhaCungCap ncc;


--View: Lấy danh sách nhà cung cấp gốc
GO
CREATE OR ALTER VIEW vw_DanhSachNhaCungCapGoc AS
SELECT * FROM NhaCungCap


--Procedure: Thêm nhà cung cấp
GO
CREATE PROCEDURE sp_ThemNhaCungCap
    @TenNCC NVARCHAR(100),
    @DienThoai VARCHAR(15),
    @DiaChi NVARCHAR(200),
    @Website NVARCHAR(200),
    @Email NVARCHAR(100),
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
		BEGIN TRANSACTION;
        INSERT INTO NhaCungCap (
            TenNCC,
            DienThoai,
            DiaChi,
            Website,
            Email
        )
        VALUES (
            @TenNCC,
            @DienThoai,
            @DiaChi,
            @Website,
            @Email
        );

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Sửa nhà cung cấp
GO
CREATE PROCEDURE sp_SuaNhaCungCap
    @MaNCC INT,
    @TenNCC NVARCHAR(100),
    @DienThoai VARCHAR(15),
    @DiaChi NVARCHAR(200),
    @Website NVARCHAR(200),
    @Email NVARCHAR(100),
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;
		-- Kiểm tra MaNCC tồn tại
		IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCC)
		BEGIN
			THROW 50001, N'Mã nhà cung cấp không tồn tại.', 1;
		END

        UPDATE NhaCungCap
        SET
            TenNCC = @TenNCC,
            DienThoai = @DienThoai,
            DiaChi = @DiaChi,
            Website = @Website,
            Email = @Email
        WHERE MaNCC = @MaNCC;

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Xóa nhà cung cấp
GO
CREATE PROCEDURE sp_XoaNhaCungCap
    @MaNCC INT,
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;
		-- Kiểm tra MaNCC tồn tại
		IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCC)
		BEGIN
			SET @ErrorMessage = N'Mã nhà cung cấp không tồn tại.';
			RETURN 0;
		END

        DELETE FROM NhaCungCap
        WHERE MaNCC = @MaNCC;

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END

----------------------------------------------
--Đơn nhập
----------------------------------------------

USE CuaHangBanSach
GO

--Function: Tính tổng số lượng của một đơn nhập
GO
CREATE OR ALTER FUNCTION fn_TongSoLuongDN(@MaDN INT)
RETURNS INT
AS
BEGIN
	DECLARE @TongSoLuong INT;

	SELECT @TongSoLuong = SUM(SoLuong)
	FROM DonNhap dn
	JOIN ChiTietDonNhap ctdn ON dn.MaDN = ctdn.MaDN
	WHERE dn.MaDN = @MaDN

	RETURN ISNULL(@TongSoLuong, 0);
END;


--Function: Lấy TinhTrangNhap một DonNhap
GO
CREATE OR ALTER FUNCTION fn_LayTinhTrangNhapDonNhap(@MaDN INT)
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @TinhTrangNhap NVARCHAR(50) = N'';

	SELECT @TinhTrangNhap = TinhTrangNhap
	FROM DonNhap
	WHERE MaDN = @MaDN

	RETURN @TinhTrangNhap
END;


--View: Lấy danh sách đơn nhập
GO
CREATE OR ALTER VIEW vw_DanhSachDonNhap AS
SELECT
	dn.MaDN,
	dn.NgayLapDN,
	dbo.fn_TongSoLuongDN(dn.MaDN) AS TongSoSach,
	dn.TongTien,
	dn.TinhTrangNhap,
	dn.MaNguoiDung,
	nd.HoTen AS TenNguoiNhap,
	dn.GhiChu
FROM DonNhap dn
JOIN NguoiDung nd ON dn.MaNguoiDung = nd.MaNguoiDung
WHERE TinhTrangNhap <> N'Hủy đơn'

--View: Lấy danh sách đơn nhập gốc
GO
CREATE OR ALTER VIEW vw_DanhSachDonNhapGoc AS
SELECT * FROM DonNhap


--Function: Lấy một đơn nhập
GO
CREATE OR ALTER FUNCTION fn_DonNhap(@MaDN INT)
RETURNS TABLE
AS
RETURN(
	SELECT *
	FROM DonNhap
	WHERE MaDN = @MaDN
);


--Procedure: Thêm đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_ThemDonNhap
    @NgayLapDN DATE = NULL,
    @TongTien DECIMAL(18,2) = 0,
    @TinhTrangNhap NVARCHAR(50) = N'Chưa nhập',
    @MaNguoiDung INT,
    @GhiChu NVARCHAR(500) = NULL,
    @ErrorMessage NVARCHAR(500) OUTPUT,
	@MaDN INT OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
		BEGIN TRANSACTION;

        INSERT INTO DonNhap (
            NgayLapDN,
            TongTien,
            TinhTrangNhap,
            MaNguoiDung,
            GhiChu
        )
        VALUES (
            COALESCE(@NgayLapDN, CAST(GETDATE() AS DATE)),
            @TongTien,
            COALESCE(@TinhTrangNhap, N'Chờ duyệt'),
            @MaNguoiDung,
            @GhiChu
        );

		SET @MaDN = SCOPE_IDENTITY();
        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Sửa đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_SuaDonNhap
    @MaDN INT,
    @NgayLapDN DATE = NULL,
    @TongTien DECIMAL(18,2) = 0,
    @TinhTrangNhap NVARCHAR(50) = NULL,
    @MaNguoiDung INT,
    @GhiChu NVARCHAR(500),
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

	BEGIN TRY
		BEGIN TRANSACTION;
		-- Kiểm tra MaDN tồn tại
		IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
		BEGIN
			SET @ErrorMessage = N'Mã đơn nhập không tồn tại.';
			RETURN 0;
		END

		-- Kiểm tra MaNguoiDung tồn tại
		IF NOT EXISTS (SELECT 1 FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung)
		BEGIN
			THROW 5001, N'Mã người dùng không tồn tại.', 1;
		END

        UPDATE DonNhap
        SET
            NgayLapDN = COALESCE(@NgayLapDN, CAST(GETDATE() AS DATE)),
            TongTien = @TongTien,
            TinhTrangNhap = COALESCE(@TinhTrangNhap, N'Chờ duyệt'),
            MaNguoiDung = @MaNguoiDung,
            GhiChu = @GhiChu
        WHERE MaDN = @MaDN;

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Xóa đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_XoaDonNhap
    @MaDN INT,
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

	BEGIN TRY
		BEGIN TRANSACTION;
		-- Kiểm tra MaDN tồn tại
		IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
		BEGIN
			THROW 50001, N'Mã đơn nhập không tồn tại.', 1;
		END

        DELETE FROM DonNhap
        WHERE MaDN = @MaDN;

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Sửa ghi chú
GO
CREATE OR ALTER PROCEDURE sp_SuaGhiChuDonNhap
	@MaDN INT,
	@GhiChu NVARCHAR(500) = N'',
	@ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;
		-- Kiểm tra MaDN tồn tại
		IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
		BEGIN
			THROW 50001, N'Mã đơn nhập không tồn tại.', 1;
		END
	
        UPDATE DonNhap
        SET
            GhiChu = @GhiChu
        WHERE MaDN = @MaDN;

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Xác nhận đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_XacNhanDonNhap
	@MaDN INT,
	@ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;
		-- Kiểm tra MaDN tồn tại
		IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
		BEGIN
			THROW 50001, N'Mã đơn nhập không tồn tại.', 1;
		END
	
        UPDATE DonNhap
        SET
            TinhTrangNhap = N'Đã nhập'
        WHERE MaDN = @MaDN;

        SET @ErrorMessage = N'';
		COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END

----------------------------------------------
--Chi tiết đơn nhập
----------------------------------------------

USE CuaHangBanSach
GO

--Function: Lấy thông tin một đơn nhập
GO
CREATE OR ALTER FUNCTION fn_XemChiTietDonNhap(@MaDN INT)
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM vw_XemChiTiet
	WHERE MaDN = @MaDN
);


--Function: Lấy thông tin một nhà cung cấp
GO
CREATE OR ALTER FUNCTION fn_XemChiTietNhaCungCap(@MaNCC INT)
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM vw_XemChiTiet
	WHERE MaNCC = @MaNCC
);


--Function: Lấy thông tin một sách
GO
CREATE OR ALTER FUNCTION fn_XemChiTietSach(@MaSach INT)
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM vw_XemChiTiet
	WHERE MaSach = @MaSach
);


--View: Xem chi tiết
GO
CREATE OR ALTER VIEW vw_XemChiTiet AS
SELECT
	ctdn.MaDN,
	ctdn.MaSach,
	Sach.TenSach,
	ctdn.MaNCC,
	ncc.TenNCC,
	ctdn.SoLuong,
	ctdn.GiaNhap,
	ctdn.ThanhTien
FROM ChiTietDonNhap ctdn
JOIN DonNhap dn ON dn.MaDN = ctdn.MaDN
JOIN Sach ON Sach.MaSach = ctdn.MaSach
JOIN NhaCungCap ncc ON ncc.MaNCC = ctdn.MaNCC;


--Procedure: Thêm chi tiết đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_ThemChiTietDonNhap
    @MaDN INT,
    @MaSach INT,
    @MaNCC INT,
    @SoLuong INT,
    @GiaNhap DECIMAL(18,2),
	@ThanhTien DECIMAL(18,2) = 0,
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra MaDN tồn tại
        IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
        BEGIN
            THROW 50001, N'Mã đơn nhập không tồn tại.', 1;
        END

        -- Kiểm tra MaSach tồn tại
        IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach)
        BEGIN
            THROW 50001, N'Mã sách không tồn tại.', 1;
        END

        -- Kiểm tra MaNCC tồn tại
        IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCC)
        BEGIN
            THROW 50001, N'Mã nhà cung cấp không tồn tại.', 1;
        END

		--Kiểm tra DonNhap có bị hủy
		IF dbo.fn_LayTinhTrangNhapDonNhap(@MaDN) = N'Hủy đơn'
		BEGIN
            SET @ErrorMessage = N'Đơn đã bị hủy';
            ROLLBACK;
            RETURN 0;
        END

        INSERT INTO ChiTietDonNhap (MaDN, MaSach, MaNCC, SoLuong, GiaNhap, ThanhTien)
        VALUES (@MaDN, @MaSach, @MaNCC, @SoLuong, @GiaNhap, @ThanhTien);

        SET @ErrorMessage = N'';
        COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Sửa chi tiết đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_SuaChiTietDonNhap
    @MaDNCu INT,
	@MaDNMoi INT,
    @MaSachCu INT,
	@MaSachMoi INT,
    @MaNCCCu INT,
	@MaNCCMoi INT,
    @SoLuong INT,
    @GiaNhap DECIMAL(18,2),
	@ThanhTien DECIMAL(18,2) = 0,
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra bản ghi ChiTietDonNhap tồn tại
        IF NOT EXISTS (SELECT 1 FROM ChiTietDonNhap WHERE MaDN = @MaDNCu AND MaSach = @MaSachCu AND MaNCC = @MaNCCCu)
        BEGIN
            THROW 50001, N'Bản ghi chi tiết đơn nhập không tồn tại.', 1;
        END

        -- Kiểm tra MaDN tồn tại
        IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDNMoi)
        BEGIN
            THROW 50001, N'Mã đơn nhập không tồn tại.', 1;
        END

        -- Kiểm tra MaSach tồn tại
        IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSachMoi)
        BEGIN
            THROW 50001, N'Mã sách không tồn tại.', 1;
        END

        -- Kiểm tra MaNCC tồn tại
        IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCCMoi)
        BEGIN
            THROW 50001, N'Mã nhà cung cấp không tồn tại.', 1;
        END

		--Kiểm tra DonNhap có bị hủy
		IF dbo.fn_LayTinhTrangNhapDonNhap(@MaDNCu) = N'Hủy đơn' OR dbo.fn_LayTinhTrangNhapDonNhap(@MaDNMoi) = N'Hủy đơn'
		BEGIN
            THROW 50001, N'Đơn đã bị hủy', 1;
        END

        UPDATE ChiTietDonNhap
        SET	MaDN = @MaDNMoi,
			MaSach = @MaSachMoi,
			MaNCC = @MaNCCMoi,
			SoLuong = @SoLuong,
            GiaNhap = @GiaNhap,
            ThanhTien = @ThanhTien
        WHERE MaDN = @MaDNCu AND MaSach = @MaSachCu AND MaNCC = @MaNCCCu;

        SET @ErrorMessage = N'';
        COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END



--Procedure: Xóa chi tiết đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_XoaChiTietDonNhap
    @MaDN INT,
    @MaSach INT,
    @MaNCC INT,
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra bản ghi ChiTietDonNhap tồn tại
        IF NOT EXISTS (SELECT 1 FROM ChiTietDonNhap WHERE MaDN = @MaDN AND MaSach = @MaSach AND MaNCC = @MaNCC)
        BEGIN
            THROW 50001, N'Bản ghi chi tiết đơn nhập không tồn tại.', 1;
        END

		--Kiểm tra DonNhap có bị hủy
		IF dbo.fn_LayTinhTrangNhapDonNhap(@MaDN) = N'Hủy đơn'
		BEGIN
            THROW 50001, N'Đơn đã bị hủy', 1;
        END

        DELETE FROM ChiTietDonNhap
        WHERE MaDN = @MaDN AND MaSach = @MaSach AND MaNCC = @MaNCC;

        SET @ErrorMessage = N'';
        COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END


--Procedure: Sửa thông tin đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_SuaThongTinNhapHang
    @MaDN INT,
    @MaSachCu INT,
	@MaSachMoi INT,
    @MaNCCCu INT,
	@MaNCCMoi INT,
    @SoLuong INT,
    @GiaNhap DECIMAL(18,2),
	@ThanhTien DECIMAL(18,2) = 0,
    @ErrorMessage NVARCHAR(500) OUTPUT
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra bản ghi ChiTietDonNhap tồn tại
        IF NOT EXISTS (SELECT 1 FROM ChiTietDonNhap WHERE MaDN = @MaDN AND MaSach = @MaSachCu AND MaNCC = @MaNCCCu)
        BEGIN
            THROW 50001, N'Bản ghi chi tiết đơn nhập không tồn tại.', 1;
        END

        -- Kiểm tra MaDN tồn tại
        IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
        BEGIN
            THROW 50001, N'Mã đơn nhập không tồn tại.', 1;
        END

        -- Kiểm tra MaSach tồn tại
        IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSachMoi)
        BEGIN
            THROW 50001, N'Mã sách không tồn tại.', 1;
        END

        -- Kiểm tra MaNCC tồn tại
        IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCCMoi)
        BEGIN
            THROW 50001, N'Mã nhà cung cấp không tồn tại.', 1;
        END

		--Kiểm tra DonNhap có bị hủy
		IF dbo.fn_LayTinhTrangNhapDonNhap(@MaDN) = N'Hủy đơn'
		BEGIN
            THROW 50001, N'Đơn đã bị hủy', 1;
        END

        UPDATE ChiTietDonNhap
        SET MaSach = @MaSachMoi,
			MaNCC = @MaNCCMoi,
			SoLuong = @SoLuong,
            GiaNhap = @GiaNhap,
            ThanhTien = @ThanhTien
        WHERE MaDN = @MaDN AND MaSach = @MaSachCu AND MaNCC = @MaNCCCu;

        SET @ErrorMessage = N'';
        COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RETURN 0;
    END CATCH
END

----------------------------------------------
--Trigger
----------------------------------------------

USE CuaHangBanSach
GO

--Trigger: Tính thành tiền trong bảng ChiTietDonNhap
GO
CREATE OR ALTER TRIGGER tr_TinhThanhTien_ChiTietDonNhap
ON ChiTietDonNhap
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE ChiTietDonNhap
        SET ThanhTien = inserted.SoLuong * inserted.GiaNhap
        FROM ChiTietDonNhap
        JOIN inserted
			ON ChiTietDonNhap.MaDN = inserted.MaDN
			AND ChiTietDonNhap.MaSach = inserted.MaSach
			AND ChiTietDonNhap.MaNCC = inserted.MaNCC;
    END TRY
    BEGIN CATCH
		THROW
    END CATCH
END


--Trigger: Cập nhật tổng tiền trong DonNhap khi thay đổi CTDN
GO
CREATE OR ALTER TRIGGER tr_CapNhatTongTien_DonNhap
ON ChiTietDonNhap
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE DonNhap
        SET TongTien = (
            SELECT ISNULL(SUM(ThanhTien), 0)
            FROM ChiTietDonNhap ctdn
            WHERE ctdn.MaDN = dn.MaDN
        )
        FROM DonNhap dn
        JOIN (
			SELECT MaDN FROM inserted
			UNION
			SELECT MaDN FROM deleted
		)q ON dn.MaDN = q.MaDN;
    END TRY
    BEGIN CATCH
		THROW
    END CATCH
END

--Chỉnh thứ tự trigger
EXEC sp_settriggerorder 
    @triggername = 'tr_TinhThanhTien_ChiTietDonNhap', 
    @order = 'FIRST', 
    @stmttype = 'INSERT';

EXEC sp_settriggerorder 
    @triggername = 'tr_TinhThanhTien_ChiTietDonNhap', 
    @order = 'FIRST', 
    @stmttype = 'UPDATE';

EXEC sp_settriggerorder 
    @triggername = 'tr_CapNhatTongTien_DonNhap', 
    @order = 'LAST', 
    @stmttype = 'INSERT';

EXEC sp_settriggerorder 
    @triggername = 'tr_CapNhatTongTien_DonNhap', 
    @order = 'LAST', 
    @stmttype = 'UPDATE';
--


--Trigger: Cập nhật SLTonKho khi TinhTrangNhap thay đổi
GO
CREATE OR ALTER TRIGGER tr_CapNhatSLTonKho_DonNhap
ON DonNhap
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF UPDATE(TinhTrangNhap) --Kiểm tra TinhTrangNhap thay đổi
        BEGIN
            --Trường hợp chuyển sang đã nhập
            UPDATE Sach
            SET SLTonKho = Sach.SLTonKho + q.TongSoLuong	--Cộng SLTonKho trong Sach
            FROM Sach
			JOIN
			(
				SELECT ctdn.MaSach, SUM(ctdn.SoLuong) AS TongSoLuong
				FROM ChiTietDonNhap ctdn
				JOIN inserted ins ON ctdn.MaDN = ins.MaDN
				WHERE ins.TinhTrangNhap = N'Đã nhập'	--Lấy dòng được chuyển sang đã nhập
					AND EXISTS
					(
						SELECT 1
						FROM deleted
						WHERE deleted.MaDN = ins.MaDN AND deleted.TinhTrangNhap <> N'Đã nhập'	--Loại ra những dòng trước đó là đã nhập
					)
				GROUP BY ctdn.MaSach
			)q ON q.MaSach = Sach.MaSach;

            --Chuyển từ Đã nhập sang cái khác
            UPDATE Sach
            SET SLTonKho = Sach.SLTonKho - q.TongSoLuong	--Trừ SLTonKho trong Sach
            FROM Sach
			JOIN
			(
				SELECT ctdn.MaSach, SUM(ctdn.SoLuong) AS TongSoLuong
				FROM ChiTietDonNhap ctdn
				JOIN inserted ins ON ctdn.MaDN = ins.MaDN
				WHERE ins.TinhTrangNhap IN (N'Chưa nhập', N'Hủy đơn')	--Lấy dòng chuyển sang cái khác
					AND EXISTS
					(
						SELECT 1
						FROM deleted
						WHERE deleted.MaDN = ins.MaDN
							AND deleted.TinhTrangNhap = N'Đã nhập'	--Những dòng trước đó phải là đã nhập
					)
				GROUP BY ctdn.MaSach
			)q ON q.MaSach = Sach.MaSach
        END
    END TRY
    BEGIN CATCH
		THROW
    END CATCH
END


--Trigger: Xóa đơn chuyển thành hủy đơn
GO
CREATE OR ALTER TRIGGER tr_HuyDonNhap
ON DonNhap
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Kiểm tra bản ghi tồn tại
        IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN IN (SELECT MaDN FROM deleted))
        BEGIN
            THROW 50001, N'Mã đơn nhập không tồn tại.', 1;
        END

        -- Cập nhật TinhTrangNhap thành N'Hủy đơn'
        UPDATE DonNhap
        SET TinhTrangNhap = N'Hủy đơn'
        FROM DonNhap
        JOIN deleted ON DonNhap.MaDN = deleted.MaDN;
    END TRY
    BEGIN CATCH
		THROW;
    END CATCH
END


----------------------------------------------
--Phân quyền
----------------------------------------------

-- Cấp quyền trên bảng cho Manager
GRANT SELECT, INSERT, UPDATE, DELETE ON Sach TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON NhaCungCap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietDonNhap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON DonNhap TO db_manager;


-- Cấp quyền thực thi cho Manager
GRANT EXECUTE ON sp_DangNhap TO db_manager;
GRANT EXECUTE ON sp_ThemSach TO db_manager;
GRANT EXECUTE ON sp_SuaSach TO db_manager;
GRANT EXECUTE ON sp_XoaSach TO db_manager;

GRANT EXECUTE ON sp_ThemNhaCungCap TO db_manager;
GRANT EXECUTE ON sp_SuaNhaCungCap TO db_manager;
GRANT EXECUTE ON sp_XoaNhaCungCap TO db_manager;

GRANT EXECUTE ON sp_ThemDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaGhiChuDonNhap TO db_manager;
GRANT EXECUTE ON sp_XoaDonNhap TO db_manager;
GRANT EXECUTE ON sp_XacNhanDonNhap TO db_manager;
GRANT SELECT ON dbo.fn_DonNhap TO db_manager;
GRANT EXECUTE ON dbo.fn_LayTinhTrangNhapDonNhap TO db_staff

GRANT SELECT ON dbo.fn_XemChiTietSach TO db_manager;
GRANT SELECT ON dbo.fn_XemChiTietNhaCungCap TO db_manager;
GRANT SELECT ON dbo.fn_XemChiTietDonNhap TO db_manager;
GRANT EXECUTE ON sp_ThemChiTietDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaChiTietDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaThongTinNhapHang TO db_manager;
GRANT EXECUTE ON sp_XoaChiTietDonNhap TO db_manager;


-- Cấp quyền xem cho Manager
GRANT SELECT ON vw_DanhSachSach TO db_manager;
GRANT SELECT ON vw_DanhSachSachGoc TO db_manager;

GRANT SELECT ON vw_DanhSachNhaCungCap TO db_manager;
GRANT SELECT ON vw_DanhSachNhaCungCapGoc TO db_manager;

GRANT SELECT ON vw_DanhSachDonNhap TO db_manager;
GRANT SELECT ON vw_DanhSachDonNhapGoc TO db_manager;

GRANT SELECT ON vw_XemChiTiet TO db_manager;

--========================
-- Cấp quyền trên bảng cho Staff
GRANT SELECT, UPDATE ON Sach TO db_manager;
GRANT SELECT, UPDATE ON NhaCungCap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietDonNhap TO db_manager;
GRANT SELECT, INSERT, UPDATE ON DonNhap TO db_manager;


-- Cấp quyền thực thi cho Staff
GRANT EXECUTE ON sp_DangNhap TO db_staff;
REVOKE EXECUTE ON sp_ThemSach FROM db_staff;
REVOKE EXECUTE ON sp_SuaSach FROM db_staff;
REVOKE EXECUTE ON sp_XoaSach FROM db_staff;

REVOKE EXECUTE ON sp_ThemNhaCungCap FROM db_staff;
REVOKE EXECUTE ON sp_SuaNhaCungCap FROM db_staff;
REVOKE EXECUTE ON sp_XoaNhaCungCap FROM db_staff;

GRANT EXECUTE ON sp_ThemDonNhap TO db_staff;
REVOKE EXECUTE ON sp_SuaDonNhap FROM db_staff;
GRANT EXECUTE ON sp_SuaGhiChuDonNhap TO db_staff;
REVOKE EXECUTE ON sp_XoaDonNhap FROM db_staff;
REVOKE EXECUTE ON sp_XacNhanDonNhap FROM db_staff;
GRANT SELECT ON dbo.fn_DonNhap TO db_staff;
GRANT EXECUTE ON dbo.fn_LayTinhTrangNhapDonNhap TO db_staff

GRANT SELECT ON dbo.fn_XemChiTietSach TO db_staff;
GRANT SELECT ON dbo.fn_XemChiTietNhaCungCap TO db_staff;
GRANT SELECT ON dbo.fn_XemChiTietDonNhap TO db_staff;
GRANT EXECUTE ON sp_ThemChiTietDonNhap TO db_staff;
REVOKE EXECUTE ON sp_SuaChiTietDonNhap FROM db_staff;
GRANT EXECUTE ON sp_SuaThongTinNhapHang TO db_staff;
GRANT EXECUTE ON sp_XoaChiTietDonNhap TO db_staff;

GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietDonNhap TO db_staff;
GRANT SELECT, INSERT, UPDATE, DELETE ON DonNhap TO db_staff;

-- Cấp quyền xem cho Staff
GRANT SELECT ON vw_DanhSachSach TO db_staff;
REVOKE SELECT ON vw_DanhSachSachGoc FROM db_staff;

GRANT SELECT ON vw_DanhSachNhaCungCap TO db_staff;
REVOKE SELECT ON vw_DanhSachNhaCungCapGoc FROM db_staff;

GRANT SELECT ON vw_DanhSachDonNhap TO db_staff;
REVOKE SELECT ON vw_DanhSachDonNhapGoc FROM db_staff;

REVOKE SELECT ON vw_XemChiTiet FROM db_staff;