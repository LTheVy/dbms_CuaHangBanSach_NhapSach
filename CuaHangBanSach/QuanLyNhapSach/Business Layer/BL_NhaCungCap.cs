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
    internal class BL_NhaCungCap
    {
        DBMain db = null;

        public BL_NhaCungCap()
        {
            db = new DBMain();
        }

        public DataTable layNhaCungCap(ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_DanhSachNhaCungCap";
            cmd.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public DataTable layNhaCungCapGoc(ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_DanhSachNhaCungCapGoc";
            cmd.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }

        public bool themNhaCungCap(
            string tenNCC,
            string dienThoai,
            string diaChi,
            string website,
            string email,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ThemNhaCungCap";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
            cmd.Parameters.AddWithValue("@DienThoai", dienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            cmd.Parameters.AddWithValue("@Website", website);
            cmd.Parameters.AddWithValue("@Email", email);

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

        public bool suaNhaCungCap(
            string maNCC,
            string tenNCC,
            string dienThoai,
            string diaChi,
            string website,
            string email,
            ref string errMessage
            )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SuaNhaCungCap";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maNCC, out int maNCCInt))
            {
                errMessage = "Mã sách không hợp lệ.";
                return false;
            }
            cmd.Parameters.AddWithValue("@MaNCC", maNCCInt);
            cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
            cmd.Parameters.AddWithValue("@DienThoai", dienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            cmd.Parameters.AddWithValue("@Website", website);
            cmd.Parameters.AddWithValue("@Email", email);

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

        public bool xoaNhaCungCap(string maNCC, ref string errMessage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XoaNhaCungCap";
            cmd.CommandType = CommandType.StoredProcedure;

            if (!int.TryParse(maNCC, out int maNCCInt))
            {
                errMessage = "Mã sách không hợp lệ.";
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
