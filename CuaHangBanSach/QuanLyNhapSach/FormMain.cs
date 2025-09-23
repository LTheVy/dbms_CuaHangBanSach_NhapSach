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
    public partial class FormMain : Form
    {
        BL_DonNhap bL_DonNhap;
        BL_KhoSach bL_KhoSach;
        BL_NhaCungCap bL_NhaCungCap;

        public static int id = -1;
        public static string name = "";
        public static string role = "";
        string errMessage = "";
        bool isLogin = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            bL_DonNhap = new BL_DonNhap();
            bL_KhoSach = new BL_KhoSach();
            bL_NhaCungCap = new BL_NhaCungCap();

            EnableFormMain(false);
            tabControlMain.Visible = false;

            new FormThemDN().ShowDialog();
        }

        private void EnableFormMain(bool enable)
        {
            if (enable)
            {
                labelTen.Text = "Tên:" + name;
                labelMaSo.Text = "Mã số:" + id;
                labelMaSo.Visible = true;
                labelVaiTro.Text = "Vai trò:" + role;
                labelVaiTro.Visible = true;
                tabControlMain.Visible = true;
            }
            else
            {
                labelTen.Text = "Chưa đăng nhập";
                labelMaSo.Visible = false;
                labelVaiTro.Visible = false;
                tabControlMain.Visible = false;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap formLogin = new FormDangNhap();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                isLogin = true;
                dangNhapToolStripMenuItem.Enabled = false;
                dangXuatToolStripMenuItem.Enabled = true;
                EnableFormMain(true);
            }
            else
            {
                isLogin = false;
                EnableFormMain(false);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogin = false;
            id = -1;
            name = "";
            role = "";
            dangNhapToolStripMenuItem.Enabled = true;
            dangXuatToolStripMenuItem.Enabled = false;
            EnableFormMain(false);
            MessageBox.Show("Đã đăng xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadDonNhap()
        {
            DataTable dt = bL_DonNhap.LayDonNhap(ref errMessage);
            if (dt == null)
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewDonNhap.DataSource = dt;
        }

        private void loadKhoSach()
        {
            DataTable dt = bL_KhoSach.LayKhoSach(ref errMessage);
            if (dt == null)
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewKhoSach.DataSource = dt;
        }

        private void loadNhaCungCap()
        {
            DataTable dt = bL_NhaCungCap.layNhaCungCap(ref errMessage);
            if (dt == null)
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewNhaCungCap.DataSource = dt;
        }

        private void dataGridViewDonNhap_VisibleChanged(object sender, EventArgs e)
        {
            if (isLogin) loadDonNhap();
        }

        private void dataGridViewKhoSach_VisibleChanged(object sender, EventArgs e)
        {
            if (isLogin) loadKhoSach();
        }

        private void dataGridViewNhaCungCap_VisibleChanged(object sender, EventArgs e)
        {
            if (isLogin) loadNhaCungCap();
        }
    }
}
