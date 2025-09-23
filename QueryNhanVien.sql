USE CuaHangBanSach
GO

------------------------------------------------------
-- FUNCTIONS
------------------------------------------------------

--Function: Lấy thông tin một đơn nhập
GO
CREATE OR ALTER FUNCTION fn_ThongTinDonNhap(@MaDN INT)
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


------------------------------------------------------
-- VIEWS
------------------------------------------------------

--View: Lấy danh sách đơn nhập
GO
CREATE OR ALTER VIEW vw_DanhSachDonNhap AS
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


--View: Lấy danh sách nhà cung cấp (bao gồm tổng số sách, tổng tiền 2 cái)
GO
CREATE OR ALTER VIEW vw_DanhSachNCC AS
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


--View: Lấy danh sách các sách của một nhà cung cấp
GO
--CREATE VIEW vw_SachNCC


--View: Lấy danh sách kho sách cho nhập sách
GO
CREATE OR ALTER VIEW vw_KhoSachNhap AS
SELECT MaSach, TenSach, TacGia, AnhBia, DonGia, SLTonKho as SoLuong, NgayCapNhat, TrangThai
FROM Sach;


