--========================
-- Phần nhập sách
--========================
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
GRANT SELECT ON dbo.fn_DonNhap TO db_manager;

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

-- Cấp quyền thực thi cho Staff
GRANT EXECUTE ON sp_DangNhap TO db_staff;

GRANT EXECUTE ON sp_SuaGhiChuDonNhap TO db_staff;
GRANT SELECT ON dbo.fn_DonNhap TO db_staff;

GRANT EXECUTE ON sp_ThemChiTietDonNhap TO db_staff;
REVOKE EXECUTE ON sp_SuaChiTietDonNhap FROM db_staff;
GRANT EXECUTE ON sp_SuaThongTinNhapHang TO db_staff;
GRANT EXECUTE ON sp_XoaChiTietDonNhap TO db_staff;
GRANT SELECT ON dbo.fn_XemChiTietSach TO db_staff;
GRANT SELECT ON dbo.fn_XemChiTietNhaCungCap TO db_staff;
GRANT SELECT ON dbo.fn_XemChiTietDonNhap TO db_staff;

REVOKE EXECUTE ON sp_ThemSach FROM db_staff;
REVOKE EXECUTE ON sp_SuaSach FROM db_staff;
REVOKE EXECUTE ON sp_XoaSach FROM db_staff;

REVOKE EXECUTE ON sp_ThemNhaCungCap FROM db_staff;
REVOKE EXECUTE ON sp_SuaNhaCungCap FROM db_staff;
REVOKE EXECUTE ON sp_XoaNhaCungCap FROM db_staff;

GRANT EXECUTE ON sp_ThemDonNhap TO db_staff;
REVOKE EXECUTE ON sp_SuaDonNhap FROM db_staff;
REVOKE EXECUTE ON sp_XoaDonNhap FROM db_staff;

-- Cấp quyền xem cho Staff
GRANT SELECT ON vw_DanhSachSach TO db_staff;
GRANT SELECT ON vw_DanhSachNhaCungCap TO db_staff;
GRANT SELECT ON vw_DanhSachDonNhap TO db_staff;

REVOKE SELECT ON vw_DanhSachSachGoc FROM db_staff;
REVOKE SELECT ON vw_DanhSachNhaCungCapGoc FROM db_staff;
REVOKE SELECT ON vw_DanhSachDonNhapGoc FROM db_staff;
REVOKE SELECT ON vw_XemChiTiet FROM db_staff;


--========================
--Phần nhập sách
--========================
