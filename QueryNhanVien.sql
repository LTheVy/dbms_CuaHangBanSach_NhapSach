--View: Lấy danh sách đơn nhập
GO
CREATE VIEW vw_DanhSachDonNhap AS
SELECT
	dn.MaDN,
	dn.NgayLapDN,
	dn.TongTien,
	dn.TinhTrangNhap,
	dn.MaNguoiDung,
	nd.HoTen AS TenNguoiNhap,
	dn.GhiChu
FROM DonNhap dn
JOIN NguoiDung nd ON dn.MaNguoiDung = nd.MaNguoiDung

--View: Lấy thông tin một đơn nhập
GO
CREATE VIEW vw_ThongTinDonNhap AS
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

--Function: Tính tổng số sách đã nhập của một nhà cung cấp
GO
CREATE FUNCTION fn_TongSachNCC(@MaNCC INT)
RETURNS INT
AS
BEGIN
	DECLARE @SoLuong INT;

	SELECT @SoLuong = SUM(ctdn.SoLuong)
		
	FROM NhaCungCap ncc
	JOIN ChiTietDonNhap ctdn ON ncc.MaNCC = ctdn.MaNCC
	JOIN DonNhap dn ON ctdn.MaDN = dn.MaDN
	WHERE @MaNcc = ncc.MaNCC AND 

	RETURN @SoLuong;
END

--View: Lấy danh sách kho sách cho nhập sách'
--GO
--CREATE VIEW vw_KhoSachNhap AS
--SELECT
	
--FROM Sach