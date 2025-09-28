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