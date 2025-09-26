-- Procedure 1: Đăng nhập
GO
CREATE PROCEDURE sp_DangNhap
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @MaNguoiDung INT, @HoTen NVARCHAR(100), @VaiTro NVARCHAR(50), @TrangThai NVARCHAR(20);
    
    SELECT @MaNguoiDung = MaNguoiDung, @HoTen = HoTen, @VaiTro = VaiTro, @TrangThai = TrangThai
    FROM NguoiDung 
    WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau;
    
    IF @MaNguoiDung IS NULL
    BEGIN
        SELECT 0 AS KetQua, N'Tên đăng nhập hoặc mật khẩu không đúng' AS ThongBao;
        RETURN;
    END
    
    IF @TrangThai != N'Hoạt động'
    BEGIN
        SELECT 0 AS KetQua, N'Tài khoản đã bị khóa' AS ThongBao;
        RETURN;
    END
    
    -- Log đăng nhập
    INSERT INTO LogHoatDong (MaNguoiDung, HanhDong, ChiTiet)
    VALUES (@MaNguoiDung, N'ĐĂNG NHẬP', N'Đăng nhập thành công');
    
    -- Trả về thông tin user
    SELECT 
        1 AS KetQua,
        N'Đăng nhập thành công' AS ThongBao,
        @MaNguoiDung AS MaNguoiDung,
		@HoTen AS HoTen,
        @VaiTro AS VaiTro;
END;