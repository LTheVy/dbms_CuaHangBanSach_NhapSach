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
    }
}
