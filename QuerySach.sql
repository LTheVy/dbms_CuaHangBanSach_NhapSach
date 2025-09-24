USE CuaHangBanSach
GO

------------------------------------------------------
-- FUNCTIONS
------------------------------------------------------

--Function: Lấy thông tin một đơn nhập
GO
CREATE OR ALTER FUNCTION fn_DonNhapXemChiTiet(@MaDN INT)
RETURNS TABLE
AS
RETURN
(
	SELECT
		dn.MaDN,
		ctdn.MaSach,
		Sach.TenSach,
		ncc.TenNCC,
		ctdn.SoLuong,
		Sach.DonGia AS GiaBan,
		ctdn.GiaNhap,
		ctdn.ThanhTien
	FROM DonNhap dn
	JOIN ChiTietDonNhap ctdn ON dn.MaDN = ctdn.MaDN
	JOIN Sach ON ctdn.MaSach = Sach.MaSach
	JOIN NhaCungCap ncc ON ctdn.MaNCC = ncc.MaNCC
	WHERE dn.MaDN = @MaDN
);


--Function: Tính tổng số lượng của một đơn nhập
GO
CREATE OR ALTER FUNCTION fn_TongSoLuongDN(@MaDN INT)
RETURNS INT
AS
BEGIN
	DECLARE @TongSoLuong INT;

	SELECT @TongSoLuong= SUM(SoLuong)
	FROM DonNhap dn
	JOIN ChiTietDonNhap ctdn ON dn.MaDN = ctdn.MaDN
	WHERE dn.MaDN = @MaDN

	RETURN ISNULL(@TongSoLuong, 0);
END;


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


--Function: Lấy danh sách các sách của một nhà cung cấp
GO
--CREATE VIEW vw_SachNCC
------------------------------------------------------
-- VIEWS
------------------------------------------------------

--View: Lấy danh sách đơn nhập
GO
CREATE OR ALTER VIEW vw_DonNhapDanhSach AS
SELECT
	dn.MaDN,
	dn.NgayLapDN,
	dbo.fn_TongSoLuongDN(dn.MaDN) AS TongSoLuong,
	dn.TongTien,
	dn.TinhTrangNhap,
	dn.MaNguoiDung,
	nd.HoTen AS TenNguoiNhap,
	dn.GhiChu
FROM DonNhap dn
JOIN NguoiDung nd ON dn.MaNguoiDung = nd.MaNguoiDung;

--View: Lấy danh sách đơn nhập gốc
GO
CREATE OR ALTER VIEW vw_DonNhapGoc AS
SELECT * FROM DonNhap


--View: Lấy danh sách nhà cung cấp
GO
CREATE OR ALTER VIEW vw_NhaCungCapDanhSach AS
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
CREATE OR ALTER VIEW vw_NhaCungCapGoc AS
SELECT * FROM NhaCungCap


--View: Lấy danh sách kho sách
GO
CREATE VIEW vw_DanhSachSach AS
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
CREATE OR ALTER VIEW vw_SachGoc AS
SELECT * FROM Sach

