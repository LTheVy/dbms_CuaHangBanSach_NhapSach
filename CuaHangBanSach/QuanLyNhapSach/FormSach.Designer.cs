namespace QuanLyNhapSach
{
    partial class FormSach
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
            this.labelNguoiDung = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelAnhBia = new System.Windows.Forms.Label();
            this.labelSLTonKho = new System.Windows.Forms.Label();
            this.textBoxAnhBia = new System.Windows.Forms.TextBox();
            this.labelNgayCapNhat = new System.Windows.Forms.Label();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.dateTimePickerNgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownNamXuatBan = new System.Windows.Forms.NumericUpDown();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.textBoxNgonNgu = new System.Windows.Forms.TextBox();
            this.textBoxTrangThai = new System.Windows.Forms.TextBox();
            this.labelNgonNgu = new System.Windows.Forms.Label();
            this.labelMoTa = new System.Windows.Forms.Label();
            this.textBoxTheLoai = new System.Windows.Forms.TextBox();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.labelNamXuatBan = new System.Windows.Forms.Label();
            this.numericUpDownSLTonKho = new System.Windows.Forms.NumericUpDown();
            this.textBoxNhaXuatBan = new System.Windows.Forms.TextBox();
            this.labelNXB = new System.Windows.Forms.Label();
            this.textBoxTacGia = new System.Windows.Forms.TextBox();
            this.labelTacGia = new System.Windows.Forms.Label();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.labelMaSach = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.textBoxMoTa = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.numericUpDownDonGia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSLTonKho)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNguoiDung
            // 
            this.labelNguoiDung.AutoSize = true;
            this.labelNguoiDung.Location = new System.Drawing.Point(12, 9);
            this.labelNguoiDung.Name = "labelNguoiDung";
            this.labelNguoiDung.Size = new System.Drawing.Size(79, 16);
            this.labelNguoiDung.TabIndex = 26;
            this.labelNguoiDung.Text = "Người dùng:";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 221);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(923, 325);
            this.dataGridViewMain.TabIndex = 27;
            this.dataGridViewMain.CurrentCellChanged += new System.EventHandler(this.dataGridViewMain_CurrentCellChanged);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonThem.Location = new System.Drawing.Point(12, 563);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(95, 37);
            this.buttonThem.TabIndex = 28;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSua.Location = new System.Drawing.Point(162, 563);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(95, 37);
            this.buttonSua.TabIndex = 29;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonXoa.Location = new System.Drawing.Point(306, 563);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(95, 37);
            this.buttonXoa.TabIndex = 30;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonTaiLai.Location = new System.Drawing.Point(695, 563);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(95, 37);
            this.buttonTaiLai.TabIndex = 31;
            this.buttonTaiLai.Text = "Tải lại";
            this.buttonTaiLai.UseVisualStyleBackColor = false;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Gray;
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Location = new System.Drawing.Point(840, 563);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(95, 37);
            this.buttonThoat.TabIndex = 32;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelAnhBia
            // 
            this.labelAnhBia.AutoSize = true;
            this.labelAnhBia.Location = new System.Drawing.Point(305, 97);
            this.labelAnhBia.Name = "labelAnhBia";
            this.labelAnhBia.Size = new System.Drawing.Size(55, 16);
            this.labelAnhBia.TabIndex = 18;
            this.labelAnhBia.Text = "Ảnh bìa:";
            // 
            // labelSLTonKho
            // 
            this.labelSLTonKho.AutoSize = true;
            this.labelSLTonKho.Location = new System.Drawing.Point(251, 65);
            this.labelSLTonKho.Name = "labelSLTonKho";
            this.labelSLTonKho.Size = new System.Drawing.Size(109, 16);
            this.labelSLTonKho.TabIndex = 16;
            this.labelSLTonKho.Text = "Số lượng tồn kho:";
            // 
            // textBoxAnhBia
            // 
            this.textBoxAnhBia.Location = new System.Drawing.Point(366, 94);
            this.textBoxAnhBia.Name = "textBoxAnhBia";
            this.textBoxAnhBia.Size = new System.Drawing.Size(100, 22);
            this.textBoxAnhBia.TabIndex = 19;
            // 
            // labelNgayCapNhat
            // 
            this.labelNgayCapNhat.AutoSize = true;
            this.labelNgayCapNhat.Location = new System.Drawing.Point(263, 130);
            this.labelNgayCapNhat.Name = "labelNgayCapNhat";
            this.labelNgayCapNhat.Size = new System.Drawing.Size(97, 16);
            this.labelNgayCapNhat.TabIndex = 20;
            this.labelNgayCapNhat.Text = "Ngày cập nhật:";
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(304, 37);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(56, 16);
            this.labelDonGia.TabIndex = 14;
            this.labelDonGia.Text = "Đơn giá:";
            // 
            // dateTimePickerNgayCapNhat
            // 
            this.dateTimePickerNgayCapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayCapNhat.Location = new System.Drawing.Point(366, 127);
            this.dateTimePickerNgayCapNhat.Name = "dateTimePickerNgayCapNhat";
            this.dateTimePickerNgayCapNhat.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerNgayCapNhat.TabIndex = 21;
            // 
            // numericUpDownNamXuatBan
            // 
            this.numericUpDownNamXuatBan.Location = new System.Drawing.Point(108, 119);
            this.numericUpDownNamXuatBan.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownNamXuatBan.Name = "numericUpDownNamXuatBan";
            this.numericUpDownNamXuatBan.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownNamXuatBan.TabIndex = 9;
            this.numericUpDownNamXuatBan.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Location = new System.Drawing.Point(290, 153);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(70, 16);
            this.labelTrangThai.TabIndex = 22;
            this.labelTrangThai.Text = "Trạng thái:";
            // 
            // textBoxNgonNgu
            // 
            this.textBoxNgonNgu.Location = new System.Drawing.Point(366, 6);
            this.textBoxNgonNgu.Name = "textBoxNgonNgu";
            this.textBoxNgonNgu.Size = new System.Drawing.Size(100, 22);
            this.textBoxNgonNgu.TabIndex = 13;
            // 
            // textBoxTrangThai
            // 
            this.textBoxTrangThai.Location = new System.Drawing.Point(366, 155);
            this.textBoxTrangThai.Name = "textBoxTrangThai";
            this.textBoxTrangThai.Size = new System.Drawing.Size(100, 22);
            this.textBoxTrangThai.TabIndex = 23;
            // 
            // labelNgonNgu
            // 
            this.labelNgonNgu.AutoSize = true;
            this.labelNgonNgu.Location = new System.Drawing.Point(292, 9);
            this.labelNgonNgu.Name = "labelNgonNgu";
            this.labelNgonNgu.Size = new System.Drawing.Size(68, 16);
            this.labelNgonNgu.TabIndex = 12;
            this.labelNgonNgu.Text = "Ngôn ngữ:";
            // 
            // labelMoTa
            // 
            this.labelMoTa.AutoSize = true;
            this.labelMoTa.Location = new System.Drawing.Point(531, 10);
            this.labelMoTa.Name = "labelMoTa";
            this.labelMoTa.Size = new System.Drawing.Size(43, 16);
            this.labelMoTa.TabIndex = 24;
            this.labelMoTa.Text = "Mô tả:";
            // 
            // textBoxTheLoai
            // 
            this.textBoxTheLoai.Location = new System.Drawing.Point(108, 147);
            this.textBoxTheLoai.Name = "textBoxTheLoai";
            this.textBoxTheLoai.Size = new System.Drawing.Size(100, 22);
            this.textBoxTheLoai.TabIndex = 11;
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Location = new System.Drawing.Point(43, 150);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(59, 16);
            this.labelTheLoai.TabIndex = 10;
            this.labelTheLoai.Text = "Thế loại:";
            // 
            // labelNamXuatBan
            // 
            this.labelNamXuatBan.AutoSize = true;
            this.labelNamXuatBan.Location = new System.Drawing.Point(10, 121);
            this.labelNamXuatBan.Name = "labelNamXuatBan";
            this.labelNamXuatBan.Size = new System.Drawing.Size(92, 16);
            this.labelNamXuatBan.TabIndex = 8;
            this.labelNamXuatBan.Text = "Năm xuất bản:";
            // 
            // numericUpDownSLTonKho
            // 
            this.numericUpDownSLTonKho.Location = new System.Drawing.Point(366, 63);
            this.numericUpDownSLTonKho.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSLTonKho.Name = "numericUpDownSLTonKho";
            this.numericUpDownSLTonKho.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownSLTonKho.TabIndex = 17;
            // 
            // textBoxNhaXuatBan
            // 
            this.textBoxNhaXuatBan.Location = new System.Drawing.Point(108, 91);
            this.textBoxNhaXuatBan.Name = "textBoxNhaXuatBan";
            this.textBoxNhaXuatBan.Size = new System.Drawing.Size(100, 22);
            this.textBoxNhaXuatBan.TabIndex = 7;
            // 
            // labelNXB
            // 
            this.labelNXB.AutoSize = true;
            this.labelNXB.Location = new System.Drawing.Point(14, 94);
            this.labelNXB.Name = "labelNXB";
            this.labelNXB.Size = new System.Drawing.Size(88, 16);
            this.labelNXB.TabIndex = 6;
            this.labelNXB.Text = "Nhà xuất bản:";
            // 
            // textBoxTacGia
            // 
            this.textBoxTacGia.Location = new System.Drawing.Point(108, 63);
            this.textBoxTacGia.Name = "textBoxTacGia";
            this.textBoxTacGia.Size = new System.Drawing.Size(100, 22);
            this.textBoxTacGia.TabIndex = 5;
            // 
            // labelTacGia
            // 
            this.labelTacGia.AutoSize = true;
            this.labelTacGia.Location = new System.Drawing.Point(46, 66);
            this.labelTacGia.Name = "labelTacGia";
            this.labelTacGia.Size = new System.Drawing.Size(56, 16);
            this.labelTacGia.TabIndex = 4;
            this.labelTacGia.Text = "Tác giả:";
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Location = new System.Drawing.Point(108, 35);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(100, 22);
            this.textBoxTenSach.TabIndex = 3;
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.Location = new System.Drawing.Point(36, 38);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(66, 16);
            this.labelTenSach.TabIndex = 2;
            this.labelTenSach.Text = "Tên sách:";
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.Location = new System.Drawing.Point(108, 7);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.ReadOnly = true;
            this.textBoxMaSach.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaSach.TabIndex = 1;
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLuu.Location = new System.Drawing.Point(821, 83);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(95, 37);
            this.buttonLuu.TabIndex = 33;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Location = new System.Drawing.Point(41, 10);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(61, 16);
            this.labelMaSach.TabIndex = 0;
            this.labelMaSach.Text = "Mã sách:";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHuy.Location = new System.Drawing.Point(821, 141);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(95, 37);
            this.buttonHuy.TabIndex = 34;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.Location = new System.Drawing.Point(534, 38);
            this.textBoxMoTa.Multiline = true;
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMoTa.Size = new System.Drawing.Size(268, 140);
            this.textBoxMoTa.TabIndex = 25;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.numericUpDownDonGia);
            this.panelMain.Controls.Add(this.textBoxMoTa);
            this.panelMain.Controls.Add(this.buttonHuy);
            this.panelMain.Controls.Add(this.labelMaSach);
            this.panelMain.Controls.Add(this.buttonLuu);
            this.panelMain.Controls.Add(this.textBoxMaSach);
            this.panelMain.Controls.Add(this.labelTenSach);
            this.panelMain.Controls.Add(this.textBoxTenSach);
            this.panelMain.Controls.Add(this.labelTacGia);
            this.panelMain.Controls.Add(this.textBoxTacGia);
            this.panelMain.Controls.Add(this.labelNXB);
            this.panelMain.Controls.Add(this.textBoxNhaXuatBan);
            this.panelMain.Controls.Add(this.numericUpDownSLTonKho);
            this.panelMain.Controls.Add(this.labelNamXuatBan);
            this.panelMain.Controls.Add(this.labelTheLoai);
            this.panelMain.Controls.Add(this.textBoxTheLoai);
            this.panelMain.Controls.Add(this.labelMoTa);
            this.panelMain.Controls.Add(this.labelNgonNgu);
            this.panelMain.Controls.Add(this.textBoxTrangThai);
            this.panelMain.Controls.Add(this.textBoxNgonNgu);
            this.panelMain.Controls.Add(this.labelTrangThai);
            this.panelMain.Controls.Add(this.numericUpDownNamXuatBan);
            this.panelMain.Controls.Add(this.dateTimePickerNgayCapNhat);
            this.panelMain.Controls.Add(this.labelDonGia);
            this.panelMain.Controls.Add(this.labelNgayCapNhat);
            this.panelMain.Controls.Add(this.textBoxAnhBia);
            this.panelMain.Controls.Add(this.labelSLTonKho);
            this.panelMain.Controls.Add(this.labelAnhBia);
            this.panelMain.Location = new System.Drawing.Point(12, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(923, 187);
            this.panelMain.TabIndex = 35;
            // 
            // numericUpDownDonGia
            // 
            this.numericUpDownDonGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDonGia.Location = new System.Drawing.Point(366, 35);
            this.numericUpDownDonGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownDonGia.Name = "numericUpDownDonGia";
            this.numericUpDownDonGia.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownDonGia.TabIndex = 15;
            this.numericUpDownDonGia.ThousandsSeparator = true;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(947, 612);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.labelNguoiDung);
            this.Name = "FormSach";
            this.Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSLTonKho)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNguoiDung;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelAnhBia;
        private System.Windows.Forms.Label labelSLTonKho;
        private System.Windows.Forms.TextBox textBoxAnhBia;
        private System.Windows.Forms.Label labelNgayCapNhat;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayCapNhat;
        private System.Windows.Forms.NumericUpDown numericUpDownNamXuatBan;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.TextBox textBoxNgonNgu;
        private System.Windows.Forms.TextBox textBoxTrangThai;
        private System.Windows.Forms.Label labelNgonNgu;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.TextBox textBoxTheLoai;
        private System.Windows.Forms.Label labelTheLoai;
        private System.Windows.Forms.Label labelNamXuatBan;
        private System.Windows.Forms.NumericUpDown numericUpDownSLTonKho;
        private System.Windows.Forms.TextBox textBoxNhaXuatBan;
        private System.Windows.Forms.Label labelNXB;
        private System.Windows.Forms.TextBox textBoxTacGia;
        private System.Windows.Forms.Label labelTacGia;
        private System.Windows.Forms.TextBox textBoxTenSach;
        private System.Windows.Forms.Label labelTenSach;
        private System.Windows.Forms.TextBox textBoxMaSach;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Label labelMaSach;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.TextBox textBoxMoTa;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.NumericUpDown numericUpDownDonGia;
    }
}