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
    public partial class FormSach : Form
    {
        BL_Sach bL_Sach;

        string errMessage = "";
        bool isAdding = false;
        public FormSach()
        {
            InitializeComponent();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            bL_Sach = new BL_Sach();
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
            DataTable dt = bL_Sach.layDuLieuGoc(ref errMessage);
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
            string MaSach = "",
            string TenSach = "",
            string TacGia = "",
            string NhaXuatBan = "",
            decimal NamXuatBan = 0,
            string TheLoai = "",
            string NgonNgu = "",
            decimal DonGia = 0,
            decimal SoLuong = 0,
            string AnhBia = "",
            DateTime NgayCapNhat = default(DateTime),
            string TrangThai = "",
            string MoTa = ""
            )
        {
            textBoxMaSach.Text = MaSach;
            textBoxTenSach.Text = TenSach;
            textBoxTacGia.Text = TacGia;
            textBoxNhaXuatBan.Text = NhaXuatBan;
            textBoxTheLoai.Text = TheLoai;
            textBoxNgonNgu.Text = NgonNgu;
            numericUpDownDonGia.Value = DonGia;
            numericUpDownSLTonKho.Value = SoLuong;
            textBoxAnhBia.Text = AnhBia;
            dateTimePickerNgayCapNhat.Value = NgayCapNhat == default(DateTime) ? DateTime.Now : NgayCapNhat;
            textBoxTrangThai.Text = TrangThai;
            textBoxMoTa.Text = MoTa;
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
                dataGridViewMain.Rows[currentRow].Cells["MaSach"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["TenSach"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["TacGia"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["NhaXuatBan"].Value.ToString(),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["NamXuatBan"].Value),
                dataGridViewMain.Rows[currentRow].Cells["TheLoai"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["NgonNgu"].Value.ToString(),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["DonGia"].Value),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["SLTonKho"].Value),
                dataGridViewMain.Rows[currentRow].Cells["AnhBia"].Value.ToString(),
                Convert.ToDateTime(dataGridViewMain.Rows[currentRow].Cells["NgayCapNhat"].Value),
                dataGridViewMain.Rows[currentRow].Cells["TrangThai"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["MoTa"].Value.ToString()
                );
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if(!bL_Sach.them(
                    textBoxTenSach.Text,
                    textBoxTacGia.Text,
                    textBoxNhaXuatBan.Text,
                    numericUpDownNamXuatBan.Value,
                    textBoxTheLoai.Text,
                    textBoxNgonNgu.Text,
                    numericUpDownDonGia.Value,
                    numericUpDownSLTonKho.Value,
                    textBoxAnhBia.Text,
                    dateTimePickerNgayCapNhat.Value,
                    textBoxTrangThai.Text,
                    textBoxMoTa.Text,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!bL_Sach.sua(
                    textBoxMaSach.Text,
                    textBoxTenSach.Text,
                    textBoxTacGia.Text,
                    textBoxNhaXuatBan.Text,
                    numericUpDownNamXuatBan.Value,
                    textBoxTheLoai.Text,
                    textBoxNgonNgu.Text,
                    numericUpDownDonGia.Value,
                    numericUpDownSLTonKho.Value,
                    textBoxAnhBia.Text,
                    dateTimePickerNgayCapNhat.Value,
                    textBoxTrangThai.Text,
                    textBoxMoTa.Text,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Sửa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string errMessage = "";
            string maSach = dataGridViewMain.Rows[dataGridViewMain.CurrentCell.RowIndex].Cells["MaSach"].Value.ToString();
            if (!bL_Sach.xoa(maSach, ref errMessage))
            {
                MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonTaiLai_Click(sender, e);
        }
    }
}
