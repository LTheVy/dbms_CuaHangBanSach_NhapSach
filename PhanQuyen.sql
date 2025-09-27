-- Tạo login trong master
CREATE LOGIN manager WITH PASSWORD = 'manager123';
CREATE LOGIN staff WITH PASSWORD = 'staff123';
CREATE LOGIN staff1 WITH PASSWORD = 'staff123';
CREATE LOGIN staff2 WITH PASSWORD = 'staff123';
CREATE LOGIN staff3 WITH PASSWORD = 'staff123';

-- Disable login staff2
ALTER LOGIN staff2 DISABLE;

USE CuaHangBanSach;
-- Tạo user cho các login
CREATE USER manager FOR LOGIN manager;
CREATE USER staff1 FOR LOGIN staff;
CREATE USER staff2 FOR LOGIN staff;
CREATE USER staff3 FOR LOGIN staff;

-- Tạo vai trò db_manager và db_staff
CREATE ROLE db_manager;
CREATE ROLE db_staff;

-- Gán user vào vai trò
EXEC sp_addrolemember 'db_manager', 'manager';
EXEC sp_addrolemember 'db_staff', 'staff1';
EXEC sp_addrolemember 'db_staff', 'staff2';
EXEC sp_addrolemember 'db_staff', 'staff3';

-- Cấp quyền cho db_manager
GRANT SELECT, INSERT, UPDATE, DELETE ON NguoiDung TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON HoaDon TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON DonNhap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON NhaCungCap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON Sach TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietHoaDon TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON ChiTietDonNhap TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON HoiVien TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON DangKyHoiVien TO db_manager;
GRANT SELECT, INSERT ON LogHoatDong TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON ThongBao TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON CauHinh TO db_manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON KhuyenMai TO db_manager;
GRANT EXECUTE ON sp_CapNhatNhanVien TO db_manager;
GRANT EXECUTE ON sp_XoaNhanVien TO db_manager;

-- Cấp quyền cho db_staff
GRANT SELECT, INSERT, UPDATE ON HoaDon TO db_staff;
GRANT SELECT, INSERT, UPDATE ON ChiTietHoaDon TO db_staff;
GRANT SELECT ON Sach TO db_staff;
GRANT SELECT ON NhaCungCap TO db_staff;
GRANT SELECT ON HoiVien TO db_staff;
GRANT SELECT ON KhuyenMai TO db_staff;
GRANT INSERT ON LogHoatDong TO db_staff;
GRANT SELECT, INSERT, UPDATE ON ThongBao TO db_staff;

-- Cấp quyền cho manager
USE master;
GRANT ALTER ANY LOGIN TO manager;
USE CuaHangBanSach;
GRANT ALTER ANY USER TO manager;
GRANT ALTER ANY ROLE TO manager;



UPDATE NguoiDung
SET TrangThai = N'Ngừng hoạt động'
WHERE TenDangNhap = 'staff2';