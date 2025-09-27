namespace QuanLyNhapSach
{
    partial class FormNhapHang
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
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonLuuGhiChu = new System.Windows.Forms.Button();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.labelMaDN = new System.Windows.Forms.Label();
            this.textBoxMaDN = new System.Windows.Forms.TextBox();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.textBoxMaNguoiDung = new System.Windows.Forms.TextBox();
            this.labelMaNguoiDung = new System.Windows.Forms.Label();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.buttonChonMaNCC = new System.Windows.Forms.Button();
            this.buttonChonMaSach = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.numericUpDownGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelGiaNhap = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.labelMaNCC = new System.Windows.Forms.Label();
            this.labelMaSach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(11, 230);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(823, 318);
            this.dataGridViewMain.TabIndex = 53;
            this.dataGridViewMain.CurrentCellChanged += new System.EventHandler(this.dataGridViewMain_CurrentCellChanged);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.buttonLuuGhiChu);
            this.panelMain.Controls.Add(this.textBoxGhiChu);
            this.panelMain.Controls.Add(this.labelMaDN);
            this.panelMain.Controls.Add(this.textBoxMaDN);
            this.panelMain.Controls.Add(this.labelGhiChu);
            this.panelMain.Controls.Add(this.textBoxMaNguoiDung);
            this.panelMain.Controls.Add(this.labelMaNguoiDung);
            this.panelMain.Location = new System.Drawing.Point(11, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(823, 100);
            this.panelMain.TabIndex = 59;
            // 
            // buttonLuuGhiChu
            // 
            this.buttonLuuGhiChu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLuuGhiChu.Location = new System.Drawing.Point(725, 10);
            this.buttonLuuGhiChu.Name = "buttonLuuGhiChu";
            this.buttonLuuGhiChu.Size = new System.Drawing.Size(95, 37);
            this.buttonLuuGhiChu.TabIndex = 39;
            this.buttonLuuGhiChu.Text = "Lưu ghi chú";
            this.buttonLuuGhiChu.UseVisualStyleBackColor = false;
            this.buttonLuuGhiChu.Click += new System.EventHandler(this.buttonLuuGhiChu_Click);
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Location = new System.Drawing.Point(438, 10);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGhiChu.Size = new System.Drawing.Size(257, 78);
            this.textBoxGhiChu.TabIndex = 11;
            // 
            // labelMaDN
            // 
            this.labelMaDN.AutoSize = true;
            this.labelMaDN.Location = new System.Drawing.Point(72, 10);
            this.labelMaDN.Name = "labelMaDN";
            this.labelMaDN.Size = new System.Drawing.Size(88, 16);
            this.labelMaDN.TabIndex = 0;
            this.labelMaDN.Text = "Mã đơn nhập:";
            // 
            // textBoxMaDN
            // 
            this.textBoxMaDN.Location = new System.Drawing.Point(168, 7);
            this.textBoxMaDN.Name = "textBoxMaDN";
            this.textBoxMaDN.ReadOnly = true;
            this.textBoxMaDN.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaDN.TabIndex = 1;
            // 
            // labelGhiChu
            // 
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Location = new System.Drawing.Point(378, 10);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(54, 16);
            this.labelGhiChu.TabIndex = 10;
            this.labelGhiChu.Text = "Ghi chú:";
            // 
            // textBoxMaNguoiDung
            // 
            this.textBoxMaNguoiDung.Location = new System.Drawing.Point(168, 35);
            this.textBoxMaNguoiDung.Name = "textBoxMaNguoiDung";
            this.textBoxMaNguoiDung.ReadOnly = true;
            this.textBoxMaNguoiDung.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaNguoiDung.TabIndex = 9;
            // 
            // labelMaNguoiDung
            // 
            this.labelMaNguoiDung.AutoSize = true;
            this.labelMaNguoiDung.Location = new System.Drawing.Point(62, 38);
            this.labelMaNguoiDung.Name = "labelMaNguoiDung";
            this.labelMaNguoiDung.Size = new System.Drawing.Size(98, 16);
            this.labelMaNguoiDung.TabIndex = 8;
            this.labelMaNguoiDung.Text = "Mã người dùng:";
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonTaiLai.Location = new System.Drawing.Point(595, 565);
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
            this.buttonXoa.Location = new System.Drawing.Point(305, 565);
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
            this.buttonSua.Location = new System.Drawing.Point(161, 565);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(95, 37);
            this.buttonSua.TabIndex = 55;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThoat.BackColor = System.Drawing.Color.Gray;
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Location = new System.Drawing.Point(740, 565);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(95, 37);
            this.buttonThoat.TabIndex = 58;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonThem.Location = new System.Drawing.Point(11, 565);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(95, 37);
            this.buttonThem.TabIndex = 54;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelChiTiet.Controls.Add(this.buttonChonMaNCC);
            this.panelChiTiet.Controls.Add(this.buttonChonMaSach);
            this.panelChiTiet.Controls.Add(this.buttonHuy);
            this.panelChiTiet.Controls.Add(this.buttonLuu);
            this.panelChiTiet.Controls.Add(this.numericUpDownGiaNhap);
            this.panelChiTiet.Controls.Add(this.numericUpDownSoLuong);
            this.panelChiTiet.Controls.Add(this.labelGiaNhap);
            this.panelChiTiet.Controls.Add(this.labelSoLuong);
            this.panelChiTiet.Controls.Add(this.textBoxMaNCC);
            this.panelChiTiet.Controls.Add(this.textBoxMaSach);
            this.panelChiTiet.Controls.Add(this.labelMaNCC);
            this.panelChiTiet.Controls.Add(this.labelMaSach);
            this.panelChiTiet.Location = new System.Drawing.Point(11, 136);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(823, 88);
            this.panelChiTiet.TabIndex = 60;
            // 
            // buttonChonMaNCC
            // 
            this.buttonChonMaNCC.Location = new System.Drawing.Point(331, 40);
            this.buttonChonMaNCC.Name = "buttonChonMaNCC";
            this.buttonChonMaNCC.Size = new System.Drawing.Size(58, 23);
            this.buttonChonMaNCC.TabIndex = 38;
            this.buttonChonMaNCC.Text = "Chọn";
            this.buttonChonMaNCC.UseVisualStyleBackColor = true;
            this.buttonChonMaNCC.Click += new System.EventHandler(this.buttonChonMaNCC_Click);
            // 
            // buttonChonMaSach
            // 
            this.buttonChonMaSach.Location = new System.Drawing.Point(331, 13);
            this.buttonChonMaSach.Name = "buttonChonMaSach";
            this.buttonChonMaSach.Size = new System.Drawing.Size(58, 23);
            this.buttonChonMaSach.TabIndex = 37;
            this.buttonChonMaSach.Text = "Chọn";
            this.buttonChonMaSach.UseVisualStyleBackColor = true;
            this.buttonChonMaSach.Click += new System.EventHandler(this.buttonChonMaSach_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHuy.Location = new System.Drawing.Point(725, 47);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(95, 37);
            this.buttonHuy.TabIndex = 36;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLuu.Location = new System.Drawing.Point(725, 3);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(95, 37);
            this.buttonLuu.TabIndex = 35;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // numericUpDownGiaNhap
            // 
            this.numericUpDownGiaNhap.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGiaNhap.Location = new System.Drawing.Point(535, 41);
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
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(535, 13);
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
            this.labelGiaNhap.Location = new System.Drawing.Point(465, 44);
            this.labelGiaNhap.Name = "labelGiaNhap";
            this.labelGiaNhap.Size = new System.Drawing.Size(64, 16);
            this.labelGiaNhap.TabIndex = 5;
            this.labelGiaNhap.Text = "Giá nhập:";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(466, 16);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(63, 16);
            this.labelSoLuong.TabIndex = 4;
            this.labelSoLuong.Text = "Số lượng:";
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Location = new System.Drawing.Point(168, 41);
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaNCC.TabIndex = 3;
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.Location = new System.Drawing.Point(168, 13);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaSach.TabIndex = 2;
            // 
            // labelMaNCC
            // 
            this.labelMaNCC.AutoSize = true;
            this.labelMaNCC.Location = new System.Drawing.Point(51, 44);
            this.labelMaNCC.Name = "labelMaNCC";
            this.labelMaNCC.Size = new System.Drawing.Size(109, 16);
            this.labelMaNCC.TabIndex = 1;
            this.labelMaNCC.Text = "Mã nhà cung cấp";
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Location = new System.Drawing.Point(99, 16);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(61, 16);
            this.labelMaSach.TabIndex = 0;
            this.labelMaSach.Text = "Mã sách:";
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 612);
            this.Controls.Add(this.panelChiTiet);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThem);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelChiTiet.ResumeLayout(false);
            this.panelChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelMaDN;
        private System.Windows.Forms.TextBox textBoxMaDN;
        private System.Windows.Forms.Label labelGhiChu;
        private System.Windows.Forms.TextBox textBoxMaNguoiDung;
        private System.Windows.Forms.Label labelMaNguoiDung;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Panel panelChiTiet;
        private System.Windows.Forms.Label labelMaSach;
        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.TextBox textBoxMaSach;
        private System.Windows.Forms.Label labelMaNCC;
        private System.Windows.Forms.Label labelGiaNhap;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.NumericUpDown numericUpDownGiaNhap;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonChonMaNCC;
        private System.Windows.Forms.Button buttonChonMaSach;
        private System.Windows.Forms.Button buttonLuuGhiChu;
    }
}