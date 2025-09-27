using QuanLyNhapSach.Database_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapSach.Business_Layer
{

    internal class BL_ChiTietDonNhap
    {
        DBMain db = null;

        public BL_ChiTietDonNhap()
        {
            db = new DBMain();
        }

        public DataTable laytheoSach(string maSach, ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM dbo.fn_XemChiTietSach(@MaSach)";
            cmd.CommandType = CommandType.Text;
            if (!int.TryParse(maSach, out int maSachInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return null;
            }
            cmd.Parameters.AddWithValue("@MaSach", maSachInt);
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public DataTable laytheoNhaCungCap(string maNCC, ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM dbo.fn_XemChiTietNhaCungCap(@MaNCC)";
            cmd.CommandType = CommandType.Text;
            if (!int.TryParse(maNCC, out int maNCCInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return null;
            }
            cmd.Parameters.AddWithValue("@MaNCC", maNCCInt);
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public DataTable laytheoDonNhap(string maDN, ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM dbo.fn_XemChiTietDonNhap(@MaDN)";
            cmd.CommandType = CommandType.Text;
            if (!int.TryParse(maDN, out int maDNInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return null;
            }
            cmd.Parameters.AddWithValue("@MaDN", maDNInt);
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public DataTable layTatCa(ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_XemChiTiet";
            cmd.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public bool them(
            string maDN,
            string maSach,
            string maNCC,
            decimal soLuong,
            decimal giaNhap,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ThemChiTietDonNhap";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maDN, out int maDNInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaDN", maDNInt);

            if (!int.TryParse(maSach, out int maSachInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaSach", maSachInt);

            if (!int.TryParse(maNCC, out int maNCCInt))
            {
                errMessage = "Mã nhà cung cấp không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCC", maNCCInt);

            cmd.Parameters.AddWithValue("@SoLuong", (int)soLuong);
            cmd.Parameters.AddWithValue("@GiaNhap", giaNhap);

            // OUTPUT
            SqlParameter errorParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 500)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(errorParam);

            // RETURN
            SqlParameter returnParam = new SqlParameter
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(returnParam);

            if (!db.MyExecuteNonQuery(cmd, ref errMessage))
            {
                return false;
            }

            errMessage = (string)errorParam.Value;
            int returnValue = (int)returnParam.Value;
            return returnValue != 0;
        }

        // Sửa chi tiết đơn nhập (gồm cả maDN)
        public bool sua(
            string maDNCu,
            string maDNMoi,
            string maSachCu,
            string maSachMoi,
            string maNCCCu,
            string maNCCMoi,
            decimal soLuong,
            decimal giaNhap,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SuaChiTietDonNhap";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maDNCu, out int maDNCuInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaDNCu", maDNCuInt);

            if (!int.TryParse(maDNMoi, out int maDNMoiInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaDNMoi", maDNMoiInt);

            if (!int.TryParse(maSachCu, out int maSachCuInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaSachCu", maSachCuInt);

            if (!int.TryParse(maSachMoi, out int maSachMoiInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaSachMoi", maSachMoiInt);

            if (!int.TryParse(maNCCCu, out int maNCCCuInt))
            {
                errMessage = "Mã nhà cung cấp không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCCCu", maNCCCuInt);

            if (!int.TryParse(maNCCMoi, out int maNCCMoiInt))
            {
                errMessage = "Mã nhà cung cấp không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCCMoi", maNCCMoiInt);

            cmd.Parameters.AddWithValue("@SoLuong", (int)soLuong);
            cmd.Parameters.AddWithValue("@giaNhap", giaNhap);

            // OUTPUT
            SqlParameter errorParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 500)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(errorParam);

            // RETURN
            SqlParameter returnParam = new SqlParameter
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(returnParam);

            if (!db.MyExecuteNonQuery(cmd, ref errMessage))
            {
                return false;
            }

            errMessage = (string)errorParam.Value;
            int returnValue = (int)returnParam.Value;
            return returnValue != 0;
        }

        // Sửa thông tin nhập hàng
        public bool sua(
            string maDN,
            string maSachCu,
            string maSachMoi,
            string maNCCCu,
            string maNCCMoi,
            decimal soLuong,
            decimal giaNhap,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SuaThongTinNhapHang";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maDN, out int maDNInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaDN", maDNInt);

            if (!int.TryParse(maSachCu, out int maSachCuInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaSachCu", maSachCuInt);

            if (!int.TryParse(maSachMoi, out int maSachMoiInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaSachMoi", maSachMoiInt);

            if (!int.TryParse(maNCCCu, out int maNCCCuInt))
            {
                errMessage = "Mã nhà cung cấp không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCCCu", maNCCCuInt);

            if (!int.TryParse(maNCCMoi, out int maNCCMoiInt))
            {
                errMessage = "Mã nhà cung cấp không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCCMoi", maNCCMoiInt);

            cmd.Parameters.AddWithValue("@SoLuong", (int)soLuong);
            cmd.Parameters.AddWithValue("@giaNhap", giaNhap);

            // OUTPUT
            SqlParameter errorParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 500)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(errorParam);

            // RETURN
            SqlParameter returnParam = new SqlParameter
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(returnParam);

            if (!db.MyExecuteNonQuery(cmd, ref errMessage))
            {
                return false;
            }

            errMessage = (string)errorParam.Value;
            int returnValue = (int)returnParam.Value;
            return returnValue != 0;
        }

        public bool xoa(
            string maDN,
            string maSach,
            string maNCC,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XoaChiTietDonNhap";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maDN, out int maDNInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaDN", maDNInt);

            if (!int.TryParse(maSach, out int maSachInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaSach", maSachInt);

            if (!int.TryParse(maNCC, out int maNCCInt))
            {
                errMessage = "Mã nhà cung cấp không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCC", maNCCInt);

            // OUTPUT
            SqlParameter errorParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 500)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(errorParam);

            // RETURN
            SqlParameter returnParam = new SqlParameter
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(returnParam);

            if (!db.MyExecuteNonQuery(cmd, ref errMessage))
            {
                return false;
            }

            errMessage = (string)errorParam.Value;
            int returnValue = (int)returnParam.Value;
            return returnValue != 0;
        }
    }
}
