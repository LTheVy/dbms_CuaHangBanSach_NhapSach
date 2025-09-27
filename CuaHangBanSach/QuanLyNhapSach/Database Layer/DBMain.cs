using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapSach.Database_Layer
{
    internal class DBMain
    {
        public static string user_id = "";
        public static string user_password = "";

        //string ConnString = "Data Source=LUNHELE;Initial Catalog=CuaHangBanSach;User ID=sa;Password=1234;TrustServerCertificate=True";

        string ConnString = "Data Source=LUNHELE;Initial Catalog=CuaHangBanSach;" +
            "User ID=" + user_id + ";Password=" + user_password + 
            ";TrustServerCertificate=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(ConnString);
        }

        public DataSet ExecuteQuery(SqlCommand cmd, ref string errMessage)
        {
            DataSet ds = new DataSet();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Connection = conn;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                errMessage = ex.Message;
                ds = null;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public bool MyExecuteNonQuery(SqlCommand cmd, ref string errMessage)
        {
            // Có lỗi kết nối mới trả về false
            bool result = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                errMessage = ex.Message;
                result = false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
