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
    public partial class FormDangNhap : Form
    {
        BL_DangNhap bL_DangNhap;
        int id;
        string name;
        string role;
        string message = "";
        string errMessage = "";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            bL_DangNhap = new BL_DangNhap();
        }

        private void buttonLoginCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonLoginConfirm_Click(object sender, EventArgs e)
        {
            string username = textBoxTenDangNhap.Text;
            string password = textBoxMatKhau.Text;
            if (bL_DangNhap.UserLogin(username, password, ref id, ref name, ref role, ref message, ref errMessage))
            {
                FormMain.id = id;
                FormMain.name = name;
                FormMain.role = role;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            else
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
