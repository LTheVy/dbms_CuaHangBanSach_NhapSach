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
    public partial class FormNhapHang : Form
    {
        BL_DonNhap bL_DonNhap;
        BL_ChiTietDonNhap bL_ChiTietDonNhap;

        string maNguoiDung = "";
        string maDN = "";
        string errMessage = "";
        bool isAdding = false;

        public FormNhapHang()
        {
            InitializeComponent();
            bL_DonNhap = new BL_DonNhap();
            bL_ChiTietDonNhap = new BL_ChiTietDonNhap();

            maNguoiDung = FormMain.id.ToString();

            if (!bL_DonNhap.themTrong(maNguoiDung, ref maDN, ref errMessage))
            {
                MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public FormNhapHang(string maDN)
        {
            InitializeComponent();
            bL_DonNhap = new BL_DonNhap();
            bL_ChiTietDonNhap = new BL_ChiTietDonNhap();

            DataTable dt = bL_DonNhap.layDonNhap(maDN, ref errMessage);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            this.maDN = maDN;
            maNguoiDung = dt.Rows[0]["MaNguoiDung"].ToString();
            textBoxGhiChu.Text = dt.Rows[0]["GhiChu"].ToString();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            textBoxMaDN.Text = maDN;
            textBoxMaNguoiDung.Text = maNguoiDung;
            isEditing(false);
            isAdding = false;
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

                panelChiTiet.Enabled = true;
            }
            else
            {
                buttonLuu.Enabled = false;
                buttonHuy.Enabled = false;

                buttonThem.Enabled = true;
                buttonSua.Enabled = true;

                buttonXoa.Enabled = true;
                buttonTaiLai.Enabled = true;

                panelChiTiet.Enabled = false;
            }
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            DataTable dt = bL_ChiTietDonNhap.laytheoDonNhap(maDN, ref errMessage);
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

        private void panelChiTiet_LoadDuLieu(
            string maSach = "",
            string maNCC = "",
            decimal soLuong = 1,
            decimal giaNhap = 0
            )
        {
            textBoxMaSach.Text = maSach;
            textBoxMaNCC.Text = maNCC;
            numericUpDownSoLuong.Value = soLuong;
            numericUpDownGiaNhap.Value = giaNhap;
        }

        private void dataGridViewMain_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = dataGridViewMain.CurrentCell;
            if (currentCell == null)
            {
                panelChiTiet_LoadDuLieu();
                return;
            }
            int currentRow = currentCell.RowIndex;
            panelChiTiet_LoadDuLieu(
                dataGridViewMain.Rows[currentRow].Cells["MaSach"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["MaNCC"].Value.ToString(),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["SoLuong"].Value),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["GiaNhap"].Value)
                );
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (!bL_ChiTietDonNhap.them(
                    maDN,
                    textBoxMaSach.Text,
                    textBoxMaNCC.Text,
                    numericUpDownSoLuong.Value,
                    numericUpDownGiaNhap.Value,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                buttonTaiLai_Click(sender, e);
                isEditing(false);
                isAdding = false;
            }
            else
            {
                DataGridViewCell currentCell = dataGridViewMain.CurrentCell;
                int currentRow = currentCell.RowIndex;

                string maSachCu = dataGridViewMain.Rows[currentRow].Cells["MaSach"].Value.ToString();
                string MaNCCCu = dataGridViewMain.Rows[currentRow].Cells["MaNCC"].Value.ToString();

                if (!bL_ChiTietDonNhap.sua(
                    maDN,
                    maSachCu,
                    textBoxMaSach.Text,
                    MaNCCCu,
                    textBoxMaNCC.Text,
                    numericUpDownSoLuong.Value,
                    numericUpDownGiaNhap.Value,
                    ref errMessage
                    ))
                {
                    MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                buttonTaiLai_Click(sender, e);
                isEditing(false);
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
            panelChiTiet_LoadDuLieu();
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string errMessage = "";
            if (!bL_ChiTietDonNhap.xoa(
                maDN,
                textBoxMaSach.Text,
                textBoxMaNCC.Text,
                ref errMessage
                ))
            {
                MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            buttonTaiLai_Click(sender, e);
        }

        private void buttonChonMaSach_Click(object sender, EventArgs e)
        {
            FormChon formChon = new FormChon("Sach");
            if (formChon.ShowDialog() == DialogResult.OK)
            {
                textBoxMaSach.Text = formChon.maChon;
            }
        }

        private void buttonChonMaNCC_Click(object sender, EventArgs e)
        {
            FormChon formChon = new FormChon("NCC");
            if (formChon.ShowDialog() == DialogResult.OK)
            {
                textBoxMaNCC.Text = formChon.maChon;
            }
        }

        private void buttonLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!bL_DonNhap.suaGhiChu(maDN, textBoxGhiChu.Text, ref errMessage))
            {
                MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Lưu ghi chú thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonTaiLai_Click(sender, e);
        }
    }
}
