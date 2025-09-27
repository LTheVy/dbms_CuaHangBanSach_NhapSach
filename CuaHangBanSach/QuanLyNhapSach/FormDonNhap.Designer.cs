namespace QuanLyNhapSach
{
    partial class FormDonNhap
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.labelNguoiDung = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.comboBoxTinhTrangNhap = new System.Windows.Forms.ComboBox();
            this.numericUpDownTongTien = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerNgayLapDN = new System.Windows.Forms.DateTimePicker();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelMaDN = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxMaDN = new System.Windows.Forms.TextBox();
            this.labelNgayLapDN = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.textBoxMaNguoiDung = new System.Windows.Forms.TextBox();
            this.labelMaNguoiDung = new System.Windows.Forms.Label();
            this.labelTinhTrangNhap = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThoat.BackColor = System.Drawing.Color.Gray;
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Location = new System.Drawing.Point(740, 565);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(95, 37);
            this.buttonThoat.TabIndex = 50;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonTaiLai.Location = new System.Drawing.Point(595, 565);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(95, 37);
            this.buttonTaiLai.TabIndex = 49;
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
            this.buttonXoa.TabIndex = 48;
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
            this.buttonSua.TabIndex = 47;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonThem.Location = new System.Drawing.Point(11, 565);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(95, 37);
            this.buttonThem.TabIndex = 46;
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
            this.labelNguoiDung.TabIndex = 44;
            this.labelNguoiDung.Text = "Người dùng:";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.comboBoxTinhTrangNhap);
            this.panelMain.Controls.Add(this.numericUpDownTongTien);
            this.panelMain.Controls.Add(this.dateTimePickerNgayLapDN);
            this.panelMain.Controls.Add(this.textBoxGhiChu);
            this.panelMain.Controls.Add(this.buttonHuy);
            this.panelMain.Controls.Add(this.labelMaDN);
            this.panelMain.Controls.Add(this.buttonLuu);
            this.panelMain.Controls.Add(this.textBoxMaDN);
            this.panelMain.Controls.Add(this.labelNgayLapDN);
            this.panelMain.Controls.Add(this.labelTongTien);
            this.panelMain.Controls.Add(this.labelGhiChu);
            this.panelMain.Controls.Add(this.textBoxMaNguoiDung);
            this.panelMain.Controls.Add(this.labelMaNguoiDung);
            this.panelMain.Controls.Add(this.labelTinhTrangNhap);
            this.panelMain.Location = new System.Drawing.Point(11, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(823, 187);
            this.panelMain.TabIndex = 51;
            // 
            // comboBoxTinhTrangNhap
            // 
            this.comboBoxTinhTrangNhap.FormattingEnabled = true;
            this.comboBoxTinhTrangNhap.Items.AddRange(new object[] {
            "Chưa nhập",
            "Đã nhập",
            "Hủy đơn"});
            this.comboBoxTinhTrangNhap.Location = new System.Drawing.Point(166, 91);
            this.comboBoxTinhTrangNhap.Name = "comboBoxTinhTrangNhap";
            this.comboBoxTinhTrangNhap.Size = new System.Drawing.Size(159, 24);
            this.comboBoxTinhTrangNhap.TabIndex = 7;
            // 
            // numericUpDownTongTien
            // 
            this.numericUpDownTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownTongTien.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTongTien.Location = new System.Drawing.Point(166, 64);
            this.numericUpDownTongTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownTongTien.Name = "numericUpDownTongTien";
            this.numericUpDownTongTien.ReadOnly = true;
            this.numericUpDownTongTien.Size = new System.Drawing.Size(159, 22);
            this.numericUpDownTongTien.TabIndex = 5;
            this.numericUpDownTongTien.ThousandsSeparator = true;
            // 
            // dateTimePickerNgayLapDN
            // 
            this.dateTimePickerNgayLapDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayLapDN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayLapDN.Location = new System.Drawing.Point(168, 35);
            this.dateTimePickerNgayLapDN.Name = "dateTimePickerNgayLapDN";
            this.dateTimePickerNgayLapDN.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerNgayLapDN.TabIndex = 3;
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Location = new System.Drawing.Point(435, 43);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGhiChu.Size = new System.Drawing.Size(257, 78);
            this.textBoxGhiChu.TabIndex = 11;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHuy.Location = new System.Drawing.Point(721, 142);
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
            this.labelMaDN.Location = new System.Drawing.Point(72, 10);
            this.labelMaDN.Name = "labelMaDN";
            this.labelMaDN.Size = new System.Drawing.Size(88, 16);
            this.labelMaDN.TabIndex = 0;
            this.labelMaDN.Text = "Mã đơn nhập:";
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLuu.Location = new System.Drawing.Point(721, 84);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(95, 37);
            this.buttonLuu.TabIndex = 33;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxMaDN
            // 
            this.textBoxMaDN.Location = new System.Drawing.Point(168, 7);
            this.textBoxMaDN.Name = "textBoxMaDN";
            this.textBoxMaDN.ReadOnly = true;
            this.textBoxMaDN.Size = new System.Drawing.Size(157, 22);
            this.textBoxMaDN.TabIndex = 1;
            // 
            // labelNgayLapDN
            // 
            this.labelNgayLapDN.AutoSize = true;
            this.labelNgayLapDN.Location = new System.Drawing.Point(36, 38);
            this.labelNgayLapDN.Name = "labelNgayLapDN";
            this.labelNgayLapDN.Size = new System.Drawing.Size(124, 16);
            this.labelNgayLapDN.TabIndex = 2;
            this.labelNgayLapDN.Text = "Ngày lập đơn nhập:";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(94, 66);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(66, 16);
            this.labelTongTien.TabIndex = 4;
            this.labelTongTien.Text = "Tổng tiền:";
            // 
            // labelGhiChu
            // 
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Location = new System.Drawing.Point(375, 38);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(54, 16);
            this.labelGhiChu.TabIndex = 10;
            this.labelGhiChu.Text = "Ghi chú:";
            // 
            // textBoxMaNguoiDung
            // 
            this.textBoxMaNguoiDung.Location = new System.Drawing.Point(479, 3);
            this.textBoxMaNguoiDung.Name = "textBoxMaNguoiDung";
            this.textBoxMaNguoiDung.ReadOnly = true;
            this.textBoxMaNguoiDung.Size = new System.Drawing.Size(213, 22);
            this.textBoxMaNguoiDung.TabIndex = 9;
            // 
            // labelMaNguoiDung
            // 
            this.labelMaNguoiDung.AutoSize = true;
            this.labelMaNguoiDung.Location = new System.Drawing.Point(375, 7);
            this.labelMaNguoiDung.Name = "labelMaNguoiDung";
            this.labelMaNguoiDung.Size = new System.Drawing.Size(98, 16);
            this.labelMaNguoiDung.TabIndex = 8;
            this.labelMaNguoiDung.Text = "Mã người dùng:";
            // 
            // labelTinhTrangNhap
            // 
            this.labelTinhTrangNhap.AutoSize = true;
            this.labelTinhTrangNhap.Location = new System.Drawing.Point(58, 94);
            this.labelTinhTrangNhap.Name = "labelTinhTrangNhap";
            this.labelTinhTrangNhap.Size = new System.Drawing.Size(102, 16);
            this.labelTinhTrangNhap.TabIndex = 6;
            this.labelTinhTrangNhap.Text = "Tình trạng nhập:";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(11, 223);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(823, 325);
            this.dataGridViewMain.TabIndex = 45;
            this.dataGridViewMain.CurrentCellChanged += new System.EventHandler(this.dataGridViewMain_CurrentCellChanged);
            // 
            // FormDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 612);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.labelNguoiDung);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "FormDonNhap";
            this.Text = "FormDonNhap";
            this.Load += new System.EventHandler(this.FormDonNhap_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label labelNguoiDung;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelMaDN;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxMaDN;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ComboBox comboBoxTinhTrangNhap;
        private System.Windows.Forms.NumericUpDown numericUpDownTongTien;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLapDN;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Label labelNgayLapDN;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label labelGhiChu;
        private System.Windows.Forms.TextBox textBoxMaNguoiDung;
        private System.Windows.Forms.Label labelMaNguoiDung;
        private System.Windows.Forms.Label labelTinhTrangNhap;
    }
}