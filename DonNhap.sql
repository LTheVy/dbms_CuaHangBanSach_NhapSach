USE CuaHangBanSach
GO


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
	dbo.fn_TongSoLuongDN(dn.MaDN) AS TongSoSach,
	dn.TongTien,
	dn.TinhTrangNhap,
	dn.MaNguoiDung,
	nd.HoTen AS TenNguoiNhap,
	dn.GhiChu
FROM DonNhap dn
JOIN NguoiDung nd ON dn.MaNguoiDung = nd.MaNguoiDung;

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
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
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

        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
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
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaDN tồn tại
    IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
    BEGIN
        SET @ErrorMessage = N'Mã đơn nhập không tồn tại.';
        RETURN 0;
    END

    -- Kiểm tra MaNguoiDung tồn tại
    IF NOT EXISTS (SELECT 1 FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung)
    BEGIN
        SET @ErrorMessage = N'Mã người dùng không tồn tại.';
        RETURN 0;
    END

    BEGIN TRY
        UPDATE DonNhap
        SET
            NgayLapDN = COALESCE(@NgayLapDN, CAST(GETDATE() AS DATE)),
            TongTien = @TongTien,
            TinhTrangNhap = COALESCE(@TinhTrangNhap, N'Chờ duyệt'),
            MaNguoiDung = @MaNguoiDung,
            GhiChu = @GhiChu
        WHERE MaDN = @MaDN;

        SET @ErrorMessage = N'';
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        RETURN 0;
    END CATCH
END


--Procedure: Xóa đơn nhập
GO
CREATE OR ALTER PROCEDURE sp_XoaDonNhap
    @MaDN INT,
    @ErrorMessage NVARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaDN tồn tại
    IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
    BEGIN
        SET @ErrorMessage = N'Mã đơn nhập không tồn tại.';
        RETURN 0;
    END

    BEGIN TRY
        DELETE FROM DonNhap
        WHERE MaDN = @MaDN;

        SET @ErrorMessage = N'';
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        RETURN 0;
    END CATCH
END


--Procedure: Sửa ghi chú
GO
CREATE OR ALTER PROCEDURE sp_SuaGhiChuDonNhap
	@MaDN INT,
	@GhiChu NVARCHAR(500) = N'',
	@ErrorMessage NVARCHAR(500) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	-- Kiểm tra MaDN tồn tại
    IF NOT EXISTS (SELECT 1 FROM DonNhap WHERE MaDN = @MaDN)
    BEGIN
        SET @ErrorMessage = N'Mã đơn nhập không tồn tại.';
        RETURN 0;
    END
	
	BEGIN TRY
        UPDATE DonNhap
        SET
            GhiChu = @GhiChu
        WHERE MaDN = @MaDN;

        SET @ErrorMessage = N'';
        RETURN 1;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        RETURN 0;
    END CATCH
END

GO
ALTER TABLE DonNhap ADD CONSTRAINT CK_DonNhap_TinhTrangNhap CHECK (TinhTrangNhap IN (N'Đã nhập', N'Chưa nhập', N'Hủy đơn'))
