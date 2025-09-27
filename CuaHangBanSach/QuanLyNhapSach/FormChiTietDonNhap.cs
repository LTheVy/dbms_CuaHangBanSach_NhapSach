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
        bool isAdding = false;
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
            bL_ChiTietDonNhap = new BL_ChiTietDonNhap();
            DataTable dt;
            if (maSach != "")
            {
                dt = bL_ChiTietDonNhap.laytheoSach(maSach, ref errMessage);
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
                dt = bL_ChiTietDonNhap.laytheoNhaCungCap(maNCC, ref errMessage);
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
                dt = bL_ChiTietDonNhap.laytheoDonNhap(maDN, ref errMessage);
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
                dt = bL_ChiTietDonNhap.layTatCa(ref errMessage);
                if (dt == null)
                {
                    if (errMessage != "")
                        MessageBox.Show(errMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewMain.DataSource = dt;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelMain_LoadDuLieu(
            string maDN = "",
            string maSach = "",
            string maNCC = "",
            decimal soLuong = 1,
            decimal giaNhap = 0,
            decimal thanhTien = 0
            )
        {
            textBoxMaDN.Text = maDN;
            textBoxMaSach.Text = maSach;
            textBoxMaNCC.Text = maNCC;
            numericUpDownSoLuong.Value = soLuong;
            numericUpDownGiaNhap.Value = giaNhap;
            numericUpDownThanhTien.Value = thanhTien;
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
                dataGridViewMain.Rows[currentRow].Cells["MaSach"].Value.ToString(),
                dataGridViewMain.Rows[currentRow].Cells["MaNCC"].Value.ToString(),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["SoLuong"].Value),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["GiaNhap"].Value),
                Convert.ToDecimal(dataGridViewMain.Rows[currentRow].Cells["ThanhTien"].Value)
                );
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (!bL_ChiTietDonNhap.them(
                    textBoxMaDN.Text,
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
                MessageBox.Show("Thêm chi tiết đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isEditing(false);
                buttonTaiLai_Click(sender, e);
                isAdding = false;
            }
            else
            {
                DataGridViewCell currentCell = dataGridViewMain.CurrentCell;
                int currentRow = currentCell.RowIndex;

                string maDNCu = dataGridViewMain.Rows[currentRow].Cells["MaDN"].Value.ToString();
                string maSachCu = dataGridViewMain.Rows[currentRow].Cells["MaSach"].Value.ToString();
                string MaNCCCu = dataGridViewMain.Rows[currentRow].Cells["MaNCC"].Value.ToString();

                if (!bL_ChiTietDonNhap.sua(
                    maDNCu,
                    textBoxMaDN.Text,
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
                MessageBox.Show("Sửa chi tiết đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string errMessage = "";
            if (!bL_ChiTietDonNhap.xoa(
                textBoxMaDN.Text,
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

        private void buttonChonMaDN_Click(object sender, EventArgs e)
        {
            FormChon formChon = new FormChon("DN");
            if (formChon.ShowDialog() == DialogResult.OK)
            {
                textBoxMaDN.Text = formChon.maChon;
            }
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
    }
}
