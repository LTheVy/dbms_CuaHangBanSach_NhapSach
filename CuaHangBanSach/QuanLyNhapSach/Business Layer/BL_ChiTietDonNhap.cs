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

        public DataTable LaytheoSach(string maSach, ref string errMessage)
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

        public DataTable LaytheoNhaCungCap(string maNCC, ref string errMessage)
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

        public DataTable LaytheoDonNhap(string maDN, ref string errMessage)
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

    }
}
