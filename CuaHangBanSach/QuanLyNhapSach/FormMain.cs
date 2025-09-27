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
        FormChiTietDonNhap formChiTietDonNhap;

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

                panelChucNangNV.Visible = true;
            }
            else
            {
                labelTen.Text = "Chưa đăng nhập";
                labelMaSo.Visible = false;
                labelVaiTro.Visible = false;
                tabControlMain.Visible = false;

                panelChucNangNV.Visible = false;
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
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != this)
                    Application.OpenForms[i].Close();
            }
            MessageBox.Show("Đã đăng xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadDonNhap()
        {
            DataTable dt = new BL_DonNhap().layDuLieu(ref errMessage);
            if (dt == null)
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewDonNhap.DataSource = dt;
            dataGridViewDonNhap.ClearSelection();
            dataGridViewDonNhap.CurrentCell = null;
        }

        private void loadSach()
        {
            DataTable dt = new BL_Sach().layDuLieu(ref errMessage);
            if (dt == null)
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewSach.DataSource = dt;
            dataGridViewSach.ClearSelection();
            dataGridViewSach.CurrentCell = null;
        }

        private void loadNhaCungCap()
        {
            DataTable dt = new BL_NhaCungCap().layDuLieu(ref errMessage);
            if (dt == null)
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewNhaCungCap.DataSource = dt;
            dataGridViewNhaCungCap.ClearSelection();
            dataGridViewNhaCungCap.CurrentCell = null;
        }

        private void dataGridViewDonNhap_VisibleChanged(object sender, EventArgs e)
        {
            if (isLogin) loadDonNhap();
        }

        private void dataGridViewKhoSach_VisibleChanged(object sender, EventArgs e)
        {
            if (isLogin) loadSach();
        }

        private void dataGridViewNhaCungCap_VisibleChanged(object sender, EventArgs e)
        {
            if (isLogin) loadNhaCungCap();
        }

        private void buttonSachChinhSua_Click(object sender, EventArgs e)
        {
            FormSach formSach = new FormSach();
            formSach.Show();
            loadSach();
        }

        private void buttonSachTaiLai_Click(object sender, EventArgs e)
        {
            loadSach();
        }

        private void buttonSachXemChiTiet_Click(object sender, EventArgs e)
        {
            string maSach = "";
            if (dataGridViewSach.CurrentRow != null)
            {
                maSach = dataGridViewSach.CurrentRow.Cells["MaSach"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            formChiTietDonNhap = new FormChiTietDonNhap(maSach, "", "");
            formChiTietDonNhap.Show();
        }
        private void buttonNCCChinhSua_Click(object sender, EventArgs e)
        {
            FormNhaCungCap formNhaCungCap = new FormNhaCungCap();
            formNhaCungCap.Show();
            loadNhaCungCap();
        }

        private void buttonNCCTaiLai_Click(object sender, EventArgs e)
        {
            loadNhaCungCap();
        }
        private void buttonNCCXemChiTiet_Click(object sender, EventArgs e)
        {
            string maNCC = "";
            if (dataGridViewNhaCungCap.CurrentRow != null)
            {
                maNCC = dataGridViewNhaCungCap.CurrentRow.Cells["MaNCC"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            formChiTietDonNhap = new FormChiTietDonNhap("", maNCC, "");
            formChiTietDonNhap.Show();
        }

        private void buttonDNChinhSua_Click(object sender, EventArgs e)
        {
            FormDonNhap formDonNhap = new FormDonNhap();
            formDonNhap.Show();
            loadDonNhap();
        }

        private void buttonDNTaiLai_Click(object sender, EventArgs e)
        {
            loadDonNhap();
        }

        private void buttonDNXemChiTiet_Click(object sender, EventArgs e)
        {
            string maDN = "";
            if (dataGridViewDonNhap.CurrentRow != null)
            {
                maDN = dataGridViewDonNhap.CurrentRow.Cells["MaDN"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn nhập để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            formChiTietDonNhap = new FormChiTietDonNhap("", "", maDN);
            formChiTietDonNhap.Show();
        }

        private void buttonNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang formNhapHang = new FormNhapHang();
            formNhapHang.Show();
        }

        private void buttonChinhDN_Click(object sender, EventArgs e)
        {
            FormNhapHang formNhapHang = new FormNhapHang(textBoxMaDN.Text);
            formNhapHang.Show();
        }

        private void dataGridViewDonNhap_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = dataGridViewDonNhap.CurrentCell;
            if (currentCell == null)
            {
                textBoxMaDN.Text = "";
                return;
            }
            int currentRow = currentCell.RowIndex;
            textBoxMaDN.Text = dataGridViewDonNhap.Rows[currentRow].Cells["MaDN"].Value.ToString();
        }
    }
}
