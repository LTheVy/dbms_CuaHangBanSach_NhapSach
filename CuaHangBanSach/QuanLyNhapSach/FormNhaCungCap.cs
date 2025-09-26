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
    public partial class FormNhaCungCap : Form
    {
        BL_NhaCungCap bL_NhaCungCap;

        string errMessage = "";
        bool isAdding = false;
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            bL_NhaCungCap = new BL_NhaCungCap();
            labelNguoiDung.Text = "Người dùng: " + FormMain.name + " (" + FormMain.role + ")";
            isEditing(false);
            buttonTaiLai_Click(sender, e);
        }

        private void isEditing(bool isEditing)
        {
            if (isEditing)
            {
                buttonLuu.Enabled = true;
                buttonHuy.Enabled = true;

                buttonThem.Enabled = false;
                buttonSua.Enabled = false;

                buttonXoa.Enabled = false;
                buttonTaiLai.Enabled = false;
            }
            else
            {
                buttonLuu.Enabled = false;
                buttonHuy.Enabled = false;

                buttonThem.Enabled = true;
                buttonSua.Enabled = true;

                buttonXoa.Enabled = true;
                buttonTaiLai.Enabled = true;
            }
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            DataTable dt = bL_NhaCungCap.layNhaCungCapGoc(ref errMessage);
            if (dt == null)
            {
                if (errMessage != "")
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewMain.DataSource = dt;
            dataGridViewMain.ClearSelection();
            dataGridViewMain.CurrentCell = null;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelMain_LoadDuLieu(
            string MaNCC = "",
            string TenNCC = "",
            string DienThoai = "",
            string DiaChi = "",
            string Website = "",
            string Email = ""
            )
        {
            textBoxMaNCC.Text = MaNCC;
            textBoxTenNCC.Text = TenNCC;
            textBoxDienThoai.Text = DienThoai;
            textBoxDiaChi.Text = DiaChi;
            textBoxWebsite.Text = Website;
            textBoxEmail.Text = Email;
        }

        private void dataGridViewMain_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = dataGridViewMain.CurrentCell;
            if (currentCell == null)
            {
                panelMain_LoadDuLieu();
                return;
            }
            int currentRow = currentCell.RowIndex;
            panelMain_LoadDuLieu(
                dataGridViewMain.Rows[currentRow].Cells["MaNCC"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["TenNCC"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["DienThoai"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["DiaChi"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["Website"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["Email"].Value.ToString()
                );
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (!bL_NhaCungCap.themNhaCungCap(
                    textBoxTenNCC.Text,
                    textBoxDienThoai.Text,
                    textBoxDiaChi.Text,
                    textBoxWebsite.Text,
                    textBoxEmail.Text,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isEditing(false);
                buttonTaiLai_Click(sender, e);
                isAdding = false;
            }
            else
            {
                if (dataGridViewMain.CurrentCell == null)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!bL_NhaCungCap.suaNhaCungCap(
                    textBoxMaNCC.Text,
                    textBoxTenNCC.Text,
                    textBoxDienThoai.Text,
                    textBoxDiaChi.Text,
                    textBoxWebsite.Text,
                    textBoxEmail.Text,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isEditing(false);
                buttonTaiLai_Click(sender, e);
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            isEditing(false);
            if (isAdding)
            {
                dataGridViewMain.ClearSelection();
                dataGridViewMain.CurrentCell = null;
                isAdding = false;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.ClearSelection();
            dataGridViewMain.CurrentCell = null;
            panelMain_LoadDuLieu();
            isEditing(true);
            isAdding = true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isEditing(true);
            isAdding = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string errMessage = "";
            string maNCC = dataGridViewMain.Rows[dataGridViewMain.CurrentCell.RowIndex].Cells["MaNCC"].Value.ToString();
            if (!bL_NhaCungCap.xoaNhaCungCap(maNCC, ref errMessage))
            {
                MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonTaiLai_Click(sender, e);
        }
    }
}
