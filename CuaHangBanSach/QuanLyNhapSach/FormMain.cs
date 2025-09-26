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
            EnableFormMain(false);
            tabControlMain.Visible = false;

            //new FormThemDN().ShowDialog();

            loginToolStripMenuItem_Click(sender, e);
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
            DataTable dt = new BL_DonNhap().LayDonNhap(ref errMessage);
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
            DataTable dt = new BL_Sach().layKhoSach(ref errMessage);
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
            DataTable dt = new BL_NhaCungCap().layNhaCungCap(ref errMessage);
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

        private void buttonSachChinhSua_Click(object sender, EventArgs e)
        {
            FormSach formSach = new FormSach();
            formSach.Show();
            loadKhoSach();
        }

        private void buttonSachTaiLai_Click(object sender, EventArgs e)
        {
            loadKhoSach();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNhaCungCap formNhaCungCap = new FormNhaCungCap();
            formNhaCungCap.Show();
            loadNhaCungCap();
        }

        private void buttonNCCTaiLai_Click(object sender, EventArgs e)
        {
            loadNhaCungCap();
        }
    }
}
