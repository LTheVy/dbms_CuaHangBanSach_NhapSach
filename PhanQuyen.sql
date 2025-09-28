-- Tạo login trong master
CREATE LOGIN manager WITH PASSWORD = 'manager123';
CREATE LOGIN staff1 WITH PASSWORD = 'staff123';
CREATE LOGIN staff2 WITH PASSWORD = 'staff123';
CREATE LOGIN staff3 WITH PASSWORD = 'staff123';

-- Disable login staff2
ALTER LOGIN staff2 DISABLE;

-- Chuyển sang database CuaHangBanSach
USE CuaHangBanSach;

-- Tạo user cho các login
CREATE USER manager FOR LOGIN manager;
CREATE USER staff1 FOR LOGIN staff1;
CREATE USER staff2 FOR LOGIN staff2;
CREATE USER staff3 FOR LOGIN staff3;

-- Tạo vai trò db_manager và db_staff
CREATE ROLE db_manager;
CREATE ROLE db_staff;

-- Gán user vào vai trò
EXEC sp_addrolemember 'db_manager', 'manager';
EXEC sp_addrolemember 'db_staff', 'staff1';
EXEC sp_addrolemember 'db_staff', 'staff2';
EXEC sp_addrolemember 'db_staff', 'staff3';

--========================
-- Phần nhập sách
--========================
-- Cấp quyền trên bảng cho Manager
GRANT SELECT, INSERT, UPDATE, DELETE ON Sach TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON NhaCungCap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietDonNhap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON DonNhap TO db_manager;


-- Cấp quyền thực thi cho Manager
GRANT EXECUTE ON sp_DangNhap TO db_manager;
GRANT EXECUTE ON sp_ThemSach TO db_manager;
GRANT EXECUTE ON sp_SuaSach TO db_manager;
GRANT EXECUTE ON sp_XoaSach TO db_manager;

GRANT EXECUTE ON sp_ThemNhaCungCap TO db_manager;
GRANT EXECUTE ON sp_SuaNhaCungCap TO db_manager;
GRANT EXECUTE ON sp_XoaNhaCungCap TO db_manager;

GRANT EXECUTE ON sp_ThemDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaGhiChuDonNhap TO db_manager;
GRANT EXECUTE ON sp_XoaDonNhap TO db_manager;
GRANT EXECUTE ON sp_XacNhanDonNhap TO db_manager;
GRANT SELECT ON dbo.fn_DonNhap TO db_manager;
GRANT EXECUTE ON dbo.fn_LayTinhTrangNhapDonNhap TO db_staff

GRANT SELECT ON dbo.fn_XemChiTietSach TO db_manager;
GRANT SELECT ON dbo.fn_XemChiTietNhaCungCap TO db_manager;
GRANT SELECT ON dbo.fn_XemChiTietDonNhap TO db_manager;
GRANT EXECUTE ON sp_ThemChiTietDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaChiTietDonNhap TO db_manager;
GRANT EXECUTE ON sp_SuaThongTinNhapHang TO db_manager;
GRANT EXECUTE ON sp_XoaChiTietDonNhap TO db_manager;


-- Cấp quyền xem cho Manager
GRANT SELECT ON vw_DanhSachSach TO db_manager;
GRANT SELECT ON vw_DanhSachSachGoc TO db_manager;

GRANT SELECT ON vw_DanhSachNhaCungCap TO db_manager;
GRANT SELECT ON vw_DanhSachNhaCungCapGoc TO db_manager;

GRANT SELECT ON vw_DanhSachDonNhap TO db_manager;
GRANT SELECT ON vw_DanhSachDonNhapGoc TO db_manager;

GRANT SELECT ON vw_XemChiTiet TO db_manager;

--========================
-- Cấp quyền trên bảng cho Staff
GRANT SELECT, UPDATE ON Sach TO db_manager;
GRANT SELECT, UPDATE ON NhaCungCap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietDonNhap TO db_manager;
GRANT SELECT, INSERT, UPDATE ON DonNhap TO db_manager;


-- Cấp quyền thực thi cho Staff
GRANT EXECUTE ON sp_DangNhap TO db_staff;
REVOKE EXECUTE ON sp_ThemSach FROM db_staff;
REVOKE EXECUTE ON sp_SuaSach FROM db_staff;
REVOKE EXECUTE ON sp_XoaSach FROM db_staff;

REVOKE EXECUTE ON sp_ThemNhaCungCap FROM db_staff;
REVOKE EXECUTE ON sp_SuaNhaCungCap FROM db_staff;
REVOKE EXECUTE ON sp_XoaNhaCungCap FROM db_staff;

GRANT EXECUTE ON sp_ThemDonNhap TO db_staff;
REVOKE EXECUTE ON sp_SuaDonNhap FROM db_staff;
GRANT EXECUTE ON sp_SuaGhiChuDonNhap TO db_staff;
REVOKE EXECUTE ON sp_XoaDonNhap FROM db_staff;
REVOKE EXECUTE ON sp_XacNhanDonNhap FROM db_staff;
GRANT SELECT ON dbo.fn_DonNhap TO db_staff;
GRANT EXECUTE ON dbo.fn_LayTinhTrangNhapDonNhap TO db_staff

GRANT SELECT ON dbo.fn_XemChiTietSach TO db_staff;
GRANT SELECT ON dbo.fn_XemChiTietNhaCungCap TO db_staff;
GRANT SELECT ON dbo.fn_XemChiTietDonNhap TO db_staff;
GRANT EXECUTE ON sp_ThemChiTietDonNhap TO db_staff;
REVOKE EXECUTE ON sp_SuaChiTietDonNhap FROM db_staff;
GRANT EXECUTE ON sp_SuaThongTinNhapHang TO db_staff;
GRANT EXECUTE ON sp_XoaChiTietDonNhap TO db_staff;

GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietDonNhap TO db_staff;
GRANT SELECT, INSERT, UPDATE, DELETE ON DonNhap TO db_staff;

-- Cấp quyền xem cho Staff
GRANT SELECT ON vw_DanhSachSach TO db_staff;
REVOKE SELECT ON vw_DanhSachSachGoc FROM db_staff;

GRANT SELECT ON vw_DanhSachNhaCungCap TO db_staff;
REVOKE SELECT ON vw_DanhSachNhaCungCapGoc FROM db_staff;

GRANT SELECT ON vw_DanhSachDonNhap TO db_staff;
REVOKE SELECT ON vw_DanhSachDonNhapGoc FROM db_staff;

REVOKE SELECT ON vw_XemChiTiet FROM db_staff;
--========================
--Phần nhập sách
--========================
