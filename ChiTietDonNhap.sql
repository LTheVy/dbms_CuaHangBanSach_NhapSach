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
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra MaDN tồn tại
        IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
        BEGIN
            SET @ErrorMessage = N'Mã đơn nhập không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaSach tồn tại
        IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach)
        BEGIN
            SET @ErrorMessage = N'Mã sách không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaNCC tồn tại
        IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCC)
        BEGIN
            SET @ErrorMessage = N'Mã nhà cung cấp không tồn tại.';
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
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra bản ghi ChiTietDonNhap tồn tại
        IF NOT EXISTS (SELECT 1 FROM ChiTietDonNhap WHERE MaDN = @MaDNCu AND MaSach = @MaSachCu AND MaNCC = @MaNCCCu)
        BEGIN
            SET @ErrorMessage = N'Bản ghi chi tiết đơn nhập không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaDN tồn tại
        IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDNMoi)
        BEGIN
            SET @ErrorMessage = N'Mã đơn nhập không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaSach tồn tại
        IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSachMoi)
        BEGIN
            SET @ErrorMessage = N'Mã sách không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaNCC tồn tại
        IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCCMoi)
        BEGIN
            SET @ErrorMessage = N'Mã nhà cung cấp không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Cập nhật ChiTietDonNhap
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
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra bản ghi ChiTietDonNhap tồn tại
        IF NOT EXISTS (SELECT 1 FROM ChiTietDonNhap WHERE MaDN = @MaDN AND MaSach = @MaSach AND MaNCC = @MaNCC)
        BEGIN
            SET @ErrorMessage = N'Bản ghi chi tiết đơn nhập không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Xóa bản ghi trong ChiTietDonNhap
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
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra bản ghi ChiTietDonNhap tồn tại
        IF NOT EXISTS (SELECT 1 FROM ChiTietDonNhap WHERE MaDN = @MaDN AND MaSach = @MaSachCu AND MaNCC = @MaNCCCu)
        BEGIN
            SET @ErrorMessage = N'Bản ghi chi tiết đơn nhập không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaDN tồn tại
        IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
        BEGIN
            SET @ErrorMessage = N'Mã đơn nhập không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaSach tồn tại
        IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSachMoi)
        BEGIN
            SET @ErrorMessage = N'Mã sách không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Kiểm tra MaNCC tồn tại
        IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC = @MaNCCMoi)
        BEGIN
            SET @ErrorMessage = N'Mã nhà cung cấp không tồn tại.';
            ROLLBACK;
            RETURN 0;
        END

        -- Cập nhật ChiTietDonNhap
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