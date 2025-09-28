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
