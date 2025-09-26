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