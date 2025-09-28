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