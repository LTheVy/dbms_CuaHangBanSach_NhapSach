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
            cmd.CommandText = "SELECT * FROM NhaCungCap";
            cmd.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteQuery(cmd, ref errMessage);
            if (ds == null) return null;
            return ds.Tables[0];
        }
    }
}
