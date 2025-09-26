USE CuaHangBanSach
GO


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

--View: Lấy danh sách đơn nhập gốc
GO
CREATE OR ALTER VIEW vw_DonNhapGoc AS
SELECT * FROM DonNhap



--ALTER TABLE DonNhap ADD CONSTRAINT CK_DonNhap_TinhTrangNhap CHECK (TinhTrangNhap IN (N'Đã nhập', N'Chưa nhập', N'Hủy đơn'))