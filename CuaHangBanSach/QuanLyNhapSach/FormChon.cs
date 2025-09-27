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
    public partial class FormChon : Form
    {
        string errMessage = "";
        public string maChon = "";
        string bang = "";
        public FormChon(string bang)
        {
            InitializeComponent();
            this.bang = bang;
            
        }

        private void FormChon_Load(object sender, EventArgs e)
        {
            if (bang == "Sach")
            {
                BL_Sach bL_Sach = new BL_Sach();
                DataTable dt = bL_Sach.layDuLieu(ref errMessage);
                if (dt == null)
                {
                    if (errMessage != "")
                        MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Text = "Chọn Sách";
                dataGridViewMain_Load(dt);
            }
            else if (bang == "NCC")
            {
                BL_NhaCungCap bL_NhaCungCap = new BL_NhaCungCap();
                DataTable dt = bL_NhaCungCap.layDuLieu(ref errMessage);
                if (dt == null)
                {
                    if (errMessage != "")
                        MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Text = "Chọn Nhà Cung Cấp";
                dataGridViewMain_Load(dt);
            }
            else if (bang == "DN")
            {
                BL_DonNhap bL_DonNhap = new BL_DonNhap();
                DataTable dt = bL_DonNhap.layDuLieu(ref errMessage);
                if (dt == null)
                {
                    if (errMessage != "")
                        MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Text = "Chọn Đơn Nhập";
                dataGridViewMain_Load(dt);
            }
            else
            {
                MessageBox.Show("Bảng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridViewMain_Load(DataTable dt)
        {
            dataGridViewMain.DataSource = dt;
            dataGridViewMain.ClearSelection();
            dataGridViewMain.CurrentCell = null;
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dataGridViewMain_CurrentCellChanged(object sender, EventArgs e)
        {
            buttonChon.Enabled = dataGridViewMain.CurrentCell != null;
            if (dataGridViewMain.CurrentCell != null)
            {
                int rowIndex = dataGridViewMain.CurrentCell.RowIndex;
                maChon = dataGridViewMain.Rows[rowIndex].Cells["ma" + bang].Value.ToString();
            }
            else
                maChon = "";
        }
    }
}
