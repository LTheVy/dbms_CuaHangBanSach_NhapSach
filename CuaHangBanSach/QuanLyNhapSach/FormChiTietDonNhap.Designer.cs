namespace QuanLyNhapSach
{
    partial class FormChiTietDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelGiaNhap = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.labelThanhTien = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelMaDN = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxMaDN = new System.Windows.Forms.TextBox();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.labelNguoiDung = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelMaSach = new System.Windows.Forms.Label();
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.labelMaNCC = new System.Windows.Forms.Label();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.numericUpDownThanhTien = new System.Windows.Forms.NumericUpDown();
            this.buttonChonMaDN = new System.Windows.Forms.Button();
            this.buttonChonMaNCC = new System.Windows.Forms.Button();
            this.buttonChonMaSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThanhTien)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownGiaNhap
            // 
            this.numericUpDownGiaNhap.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGiaNhap.Location = new System.Drawing.Point(456, 35);
            this.numericUpDownGiaNhap.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownGiaNhap.Name = "numericUpDownGiaNhap";
            this.numericUpDownGiaNhap.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownGiaNhap.TabIndex = 19;
            this.numericUpDownGiaNhap.ThousandsSeparator = true;
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(456, 7);
            this.numericUpDownSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownSoLuong.TabIndex = 18;
            this.numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelGiaNhap
            // 
            this.labelGiaNhap.AutoSize = true;
            this.labelGiaNhap.Location = new System.Drawing.Point(385, 38);
            this.labelGiaNhap.Name = "labelGiaNhap";
            this.labelGiaNhap.Size = new System.Drawing.Size(64, 16);
            this.labelGiaNhap.TabIndex = 5;
            this.labelGiaNhap.Text = "Giá nhập:";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(11, 157);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(823, 291);
            this.dataGridViewMain.TabIndex = 53;
            this.dataGridViewMain.CurrentCellChanged += new System.EventHandler(this.dataGridViewMain_CurrentCellChanged);
            // 
            // labelThanhTien
            // 
            this.labelThanhTien.AutoSize = true;
            this.labelThanhTien.Location = new System.Drawing.Point(377, 66);
            this.labelThanhTien.Name = "labelThanhTien";
            this.labelThanhTien.Size = new System.Drawing.Size(72, 16);
            this.labelThanhTien.TabIndex = 35;
            this.labelThanhTien.Text = "Thành tiền:";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.Gray;
            this.buttonHuy.Location = new System.Drawing.Point(725, 63);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(95, 37);
            this.buttonHuy.TabIndex = 34;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // labelMaDN
            // 
            this.labelMaDN.AutoSize = true;
            this.labelMaDN.Location = new System.Drawing.Point(54, 9);
            this.labelMaDN.Name = "labelMaDN";
            this.labelMaDN.Size = new System.Drawing.Size(88, 16);
            this.labelMaDN.TabIndex = 0;
            this.labelMaDN.Text = "Mã đơn nhập:";
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.Gray;
            this.buttonLuu.Location = new System.Drawing.Point(725, 5);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(95, 37);
            this.buttonLuu.TabIndex = 33;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxMaDN
            // 
            this.textBoxMaDN.Location = new System.Drawing.Point(150, 6);
            this.textBoxMaDN.Name = "textBoxMaDN";
            this.textBoxMaDN.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaDN.TabIndex = 1;
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonTaiLai.Location = new System.Drawing.Point(595, 465);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(95, 37);
            this.buttonTaiLai.TabIndex = 57;
            this.buttonTaiLai.Text = "Tải lại";
            this.buttonTaiLai.UseVisualStyleBackColor = false;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonXoa.Location = new System.Drawing.Point(305, 465);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(95, 37);
            this.buttonXoa.TabIndex = 56;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSua.Location = new System.Drawing.Point(161, 465);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(95, 37);
            this.buttonSua.TabIndex = 55;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonThem.Location = new System.Drawing.Point(11, 465);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(95, 37);
            this.buttonThem.TabIndex = 54;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // labelNguoiDung
            // 
            this.labelNguoiDung.AutoSize = true;
            this.labelNguoiDung.Location = new System.Drawing.Point(11, 11);
            this.labelNguoiDung.Name = "labelNguoiDung";
            this.labelNguoiDung.Size = new System.Drawing.Size(79, 16);
            this.labelNguoiDung.TabIndex = 52;
            this.labelNguoiDung.Text = "Người dùng:";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(386, 10);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(63, 16);
            this.labelSoLuong.TabIndex = 4;
            this.labelSoLuong.Text = "Số lượng:";
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Location = new System.Drawing.Point(81, 37);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(61, 16);
            this.labelMaSach.TabIndex = 0;
            this.labelMaSach.Text = "Mã sách:";
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Location = new System.Drawing.Point(150, 62);
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaNCC.TabIndex = 3;
            // 
            // labelMaNCC
            // 
            this.labelMaNCC.AutoSize = true;
            this.labelMaNCC.Location = new System.Drawing.Point(33, 65);
            this.labelMaNCC.Name = "labelMaNCC";
            this.labelMaNCC.Size = new System.Drawing.Size(109, 16);
            this.labelMaNCC.TabIndex = 1;
            this.labelMaNCC.Text = "Mã nhà cung cấp";
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.Location = new System.Drawing.Point(150, 34);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaSach.TabIndex = 2;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThoat.BackColor = System.Drawing.Color.Gray;
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Location = new System.Drawing.Point(740, 465);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(95, 37);
            this.buttonThoat.TabIndex = 58;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.numericUpDownThanhTien);
            this.panelMain.Controls.Add(this.buttonChonMaDN);
            this.panelMain.Controls.Add(this.buttonChonMaNCC);
            this.panelMain.Controls.Add(this.buttonChonMaSach);
            this.panelMain.Controls.Add(this.labelThanhTien);
            this.panelMain.Controls.Add(this.buttonHuy);
            this.panelMain.Controls.Add(this.labelMaDN);
            this.panelMain.Controls.Add(this.numericUpDownGiaNhap);
            this.panelMain.Controls.Add(this.buttonLuu);
            this.panelMain.Controls.Add(this.numericUpDownSoLuong);
            this.panelMain.Controls.Add(this.labelGiaNhap);
            this.panelMain.Controls.Add(this.textBoxMaDN);
            this.panelMain.Controls.Add(this.labelSoLuong);
            this.panelMain.Controls.Add(this.labelMaSach);
            this.panelMain.Controls.Add(this.textBoxMaNCC);
            this.panelMain.Controls.Add(this.labelMaNCC);
            this.panelMain.Controls.Add(this.textBoxMaSach);
            this.panelMain.Location = new System.Drawing.Point(11, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(823, 121);
            this.panelMain.TabIndex = 59;
            // 
            // numericUpDownThanhTien
            // 
            this.numericUpDownThanhTien.Enabled = false;
            this.numericUpDownThanhTien.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownThanhTien.Location = new System.Drawing.Point(456, 64);
            this.numericUpDownThanhTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownThanhTien.Name = "numericUpDownThanhTien";
            this.numericUpDownThanhTien.ReadOnly = true;
            this.numericUpDownThanhTien.Size = new System.Drawing.Size(156, 22);
            this.numericUpDownThanhTien.TabIndex = 42;
            this.numericUpDownThanhTien.ThousandsSeparator = true;
            // 
            // buttonChonMaDN
            // 
            this.buttonChonMaDN.Location = new System.Drawing.Point(313, 6);
            this.buttonChonMaDN.Name = "buttonChonMaDN";
            this.buttonChonMaDN.Size = new System.Drawing.Size(58, 23);
            this.buttonChonMaDN.TabIndex = 41;
            this.buttonChonMaDN.Text = "Chọn";
            this.buttonChonMaDN.UseVisualStyleBackColor = true;
            this.buttonChonMaDN.Click += new System.EventHandler(this.buttonChonMaDN_Click);
            // 
            // buttonChonMaNCC
            // 
            this.buttonChonMaNCC.Location = new System.Drawing.Point(313, 61);
            this.buttonChonMaNCC.Name = "buttonChonMaNCC";
            this.buttonChonMaNCC.Size = new System.Drawing.Size(58, 23);
            this.buttonChonMaNCC.TabIndex = 40;
            this.buttonChonMaNCC.Text = "Chọn";
            this.buttonChonMaNCC.UseVisualStyleBackColor = true;
            this.buttonChonMaNCC.Click += new System.EventHandler(this.buttonChonMaNCC_Click);
            // 
            // buttonChonMaSach
            // 
            this.buttonChonMaSach.Location = new System.Drawing.Point(313, 34);
            this.buttonChonMaSach.Name = "buttonChonMaSach";
            this.buttonChonMaSach.Size = new System.Drawing.Size(58, 23);
            this.buttonChonMaSach.TabIndex = 39;
            this.buttonChonMaSach.Text = "Chọn";
            this.buttonChonMaSach.UseVisualStyleBackColor = true;
            this.buttonChonMaSach.Click += new System.EventHandler(this.buttonChonMaSach_Click);
            // 
            // FormChiTietDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 512);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.labelNguoiDung);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.panelMain);
            this.Name = "FormChiTietDonNhap";
            this.Text = "FormChiTietDonNhap";
            this.Load += new System.EventHandler(this.FormChiTietDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThanhTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownGiaNhap;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.Label labelGiaNhap;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label labelThanhTien;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelMaDN;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxMaDN;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label labelNguoiDung;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelMaSach;
        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.Label labelMaNCC;
        private System.Windows.Forms.TextBox textBoxMaSach;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonChonMaNCC;
        private System.Windows.Forms.Button buttonChonMaSach;
        private System.Windows.Forms.Button buttonChonMaDN;
        private System.Windows.Forms.NumericUpDown numericUpDownThanhTien;
    }
}