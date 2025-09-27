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
    public partial class FormDonNhap : Form
    {
        BL_DonNhap bL_DonNhap;

        string errMessage = "";
        bool isAdding = false;
        public FormDonNhap()
        {
            InitializeComponent();
        }

        private void FormDonNhap_Load(object sender, EventArgs e)
        {
            bL_DonNhap = new BL_DonNhap();
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

                panelMain.Enabled = true;
            }
            else
            {
                buttonLuu.Enabled = false;
                buttonHuy.Enabled = false;

                buttonThem.Enabled = true;
                buttonSua.Enabled = true;

                buttonXoa.Enabled = true;
                buttonTaiLai.Enabled = true;

                panelMain.Enabled = false;
            }
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            DataTable dt = bL_DonNhap.layDuLieuGoc(ref errMessage);
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
            string maDN = "",
            DateTime ngayLapDN = default(DateTime),
            decimal tongTien = 0,
            string tinhTrangNhap = "Chưa nhập",
            string maNguoiDung = "",
            string ghiChu = ""
            )
        {
            textBoxMaDN.Text = maDN;
            dateTimePickerNgayLapDN.Value = ngayLapDN == default(DateTime) ? DateTime.Now : ngayLapDN;
            numericUpDownTongTien.Value = tongTien;
            comboBoxTinhTrangNhap.Text = tinhTrangNhap;
            textBoxMaNguoiDung.Text = maNguoiDung;
            textBoxGhiChu.Text = ghiChu;
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
                dataGridViewMain.Rows[currentRow].Cells["MaDN"].Value.ToString(),
                (DateTime)dataGridViewMain.Rows[currentRow].Cells["NgayLapDN"].Value,
                (decimal)dataGridViewMain.Rows[currentRow].Cells["TongTien"].Value,
                dataGridViewMain.Rows[currentRow].Cells["TinhTrangNhap"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["MaNguoiDung"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["GhiChu"].Value.ToString()
                );
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (!bL_DonNhap.them(
                    dateTimePickerNgayLapDN.Value,
                    numericUpDownTongTien.Value,
                    comboBoxTinhTrangNhap.Text,
                    textBoxMaNguoiDung.Text,
                    textBoxGhiChu.Text,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isEditing(false);
                buttonTaiLai_Click(sender, e);
                isAdding = false;
            }
            else
            {
                if (!bL_DonNhap.sua(
                    textBoxMaDN.Text,
                    dateTimePickerNgayLapDN.Value,
                    numericUpDownTongTien.Value,
                    comboBoxTinhTrangNhap.Text,
                    textBoxMaNguoiDung.Text,
                    textBoxGhiChu.Text,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Sửa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn nhập này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string errMessage = "";
            string maNCC = dataGridViewMain.Rows[dataGridViewMain.CurrentCell.RowIndex].Cells["MaNCC"].Value.ToString();
            if (!bL_DonNhap.xoa(maNCC, ref errMessage))
            {
                MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonTaiLai_Click(sender, e);
        }
    }
}
