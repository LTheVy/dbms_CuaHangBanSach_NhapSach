using QuanLyNhapSach.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhapSach
{
    public partial class FormChiTietDonNhap : Form
    {
        BL_ChiTietDonNhap bL_ChiTietDonNhap;
        private string maSach = "";
        private string maNCC = "";
        private string maDN = "";
        string errMessage = "";
        public FormChiTietDonNhap(string maSach = "", string maNCC = "", string maDN = "")
        {
            InitializeComponent();
            this.maSach = maSach;
            this.maNCC = maNCC;
            this.maDN = maDN;
        }

        private void FormChiTietDonNhap_Load(object sender, EventArgs e)
        {
            bL_ChiTietDonNhap = new BL_ChiTietDonNhap();
            DataTable dt;
            if (maSach != "")
            {
                dt = bL_ChiTietDonNhap.LaytheoSach(maSach, ref errMessage);
                if (dt == null)
                {
                    if (errMessage != "")
                        MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewMain.DataSource = dt;
            }
            else if (maNCC != "")
            {
                dt = bL_ChiTietDonNhap.LaytheoNhaCungCap(maNCC, ref errMessage);
                if (dt == null)
                {
                    if (errMessage != "")
                        MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewMain.DataSource = dt;
            }
            else if (maDN != "")
            {
                dt = bL_ChiTietDonNhap.LaytheoDonNhap(maDN, ref errMessage);
                if (dt == null)
                {
                    if (errMessage != "")
                        MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewMain.DataSource = dt;
            }
            else
            {

            }
        }
    }
}
