using QuanLyNhapSach.Database_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyNhapSach.Business_Layer
{
    internal class BL_DonNhap
    {
        DBMain db = null;

        public BL_DonNhap()
        {
            db = new DBMain();
        }

        public DataTable LayDonNhap(ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_DanhSachDonNhap";
            cmd.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public DataTable layDonNhapGoc(ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_DanhSachDonNhapGoc";
            cmd.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public bool themDonNhap(
            DateTime ngayLapDN,
            decimal tongTien,
            string tinhTrangNhap,
            string maNguoiDung,
            string ghiChu,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ThemDonNhap";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NgayLapDN", ngayLapDN);
            cmd.Parameters.AddWithValue("@TongTien", tongTien);
            cmd.Parameters.AddWithValue("@TinhTrangNhap", tinhTrangNhap);
            if (!int.TryParse(maNguoiDung, out int maNguoiDungInt))
            {
                errMessage = "Mã người dùng không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDungInt);
            cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

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

        public bool suaDonNhap(
            string maDN,
            DateTime ngayLapDN,
            decimal tongTien,
            string tinhTrangNhap,
            string maNguoiDung,
            string ghiChu,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SuaDonNhap";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maDN, out int maDNInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaDN", maDNInt);
            cmd.Parameters.AddWithValue("@NgayLapDN", ngayLapDN);
            cmd.Parameters.AddWithValue("@TongTien", tongTien);
            cmd.Parameters.AddWithValue("@TinhTrangNhap", tinhTrangNhap);
            if (!int.TryParse(maNguoiDung, out int maNguoiDungInt))
            {
                errMessage = "Mã người dùng không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDungInt);
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

        public bool xoaDonNhap(string maDN, ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XoaDonNhap";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maDN, out int maDNInt))
            {
                errMessage = "Mã đơn nhập không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCC", maDNInt);

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
