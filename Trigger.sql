--Trigger: Tính thành tiền trong bảng ChiTietDonNhap
GO
CREATE OR ALTER TRIGGER tr_TinhThanhTien_ChiTietDonNhap
ON ChiTietDonNhap
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Cập nhật ThanhTien
        UPDATE ChiTietDonNhap
        SET ThanhTien = inserted.SoLuong * inserted.GiaNhap
        FROM ChiTietDonNhap
        JOIN inserted
			ON ChiTietDonNhap.MaDN = inserted.MaDN
			AND ChiTietDonNhap.MaSach = inserted.MaSach
			AND ChiTietDonNhap.MaNCC = inserted.MaNCC;

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
		THROW
    END CATCH
END


--Trigger: Cập nhật tổng tiền trong DonNhap khi thay đổi CTDN
GO
CREATE OR ALTER TRIGGER tr_CapNhatTongTien_DonNhap
ON ChiTietDonNhap
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE DonNhap
        SET TongTien = (
            SELECT ISNULL(SUM(ThanhTien), 0)
            FROM ChiTietDonNhap ctdn
            WHERE ctdn.MaDN = dn.MaDN
        )
        FROM DonNhap dn
        JOIN (
			SELECT MaDN FROM inserted
			UNION
			SELECT MaDN FROM deleted
		)q ON dn.MaDN = q.MaDN;

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
		THROW
    END CATCH
END

--Chỉnh thứ tự trigger
EXEC sp_settriggerorder 
    @triggername = 'tr_TinhThanhTien_ChiTietDonNhap', 
    @order = 'FIRST', 
    @stmttype = 'INSERT';

EXEC sp_settriggerorder 
    @triggername = 'tr_TinhThanhTien_ChiTietDonNhap', 
    @order = 'FIRST', 
    @stmttype = 'UPDATE';

EXEC sp_settriggerorder 
    @triggername = 'tr_CapNhatTongTien_DonNhap', 
    @order = 'LAST', 
    @stmttype = 'INSERT';

EXEC sp_settriggerorder 
    @triggername = 'tr_CapNhatTongTien_DonNhap', 
    @order = 'LAST', 
    @stmttype = 'UPDATE';
--


--Trigger: Cập nhật SLTonKho khi TinhTrangNhap thay đổi
GO
CREATE OR ALTER TRIGGER tr_CapNhatSLTonKho_DonNhap
ON DonNhap
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF UPDATE(TinhTrangNhap) --Kiểm tra TinhTrangNhap thay đổi
        BEGIN
            --Trường hợp chuyển sang đã nhập
            UPDATE Sach
            SET SLTonKho = Sach.SLTonKho + q.TongSoLuong	--Cộng SLTonKho trong Sach
            FROM Sach
			JOIN
			(
				SELECT ctdn.MaSach, SUM(ctdn.SoLuong) AS TongSoLuong
				FROM ChiTietDonNhap ctdn
				JOIN inserted ins ON ctdn.MaDN = ins.MaDN
				WHERE ins.TinhTrangNhap = N'Đã nhập'	--Lấy dòng được chuyển sang đã nhập
					AND EXISTS
					(
						SELECT 1
						FROM deleted
						WHERE deleted.MaDN = ins.MaDN AND deleted.TinhTrangNhap <> N'Đã nhập'	--Loại ra những dòng trước đó là đã nhập
					)
				GROUP BY ctdn.MaSach
			)q ON q.MaSach = Sach.MaSach;

            --Chuyển từ Đã nhập sang cái khác
            UPDATE Sach
            SET SLTonKho = Sach.SLTonKho - q.TongSoLuong	--Trừ SLTonKho trong Sach
            FROM Sach
			JOIN
			(
				SELECT ctdn.MaSach, SUM(ctdn.SoLuong) AS TongSoLuong
				FROM ChiTietDonNhap ctdn
				JOIN inserted ins ON ctdn.MaDN = ins.MaDN
				WHERE ins.TinhTrangNhap IN (N'Chưa nhập', N'Hủy đơn')	--Lấy dòng chuyển sang cái khác
					AND EXISTS
					(
						SELECT 1
						FROM deleted
						WHERE deleted.MaDN = ins.MaDN
							AND deleted.TinhTrangNhap = N'Đã nhập'	--Những dòng trước đó phải là đã nhập
					)
				GROUP BY ctdn.MaSach
			)q ON q.MaSach = Sach.MaSach

        END
        COMMIT;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(500) = ERROR_MESSAGE();
        IF @@TRANCOUNT > 0
            ROLLBACK;
        RAISERROR (@ErrorMessage, 16, 1);
    END CATCH
END