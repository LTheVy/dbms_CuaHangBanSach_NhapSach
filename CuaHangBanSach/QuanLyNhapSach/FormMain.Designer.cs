namespace QuanLyNhapSach
{
    partial class FormMain
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
            this.labelTen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMaSo = new System.Windows.Forms.Label();
            this.labelVaiTro = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabSach = new System.Windows.Forms.TabPage();
            this.buttonSachTaiLai = new System.Windows.Forms.Button();
            this.buttonSachXemChiTiet = new System.Windows.Forms.Button();
            this.buttonSachChinhSua = new System.Windows.Forms.Button();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.tabNhaCungCap = new System.Windows.Forms.TabPage();
            this.buttonNCCTaiLai = new System.Windows.Forms.Button();
            this.buttonNCCXemChiTiet = new System.Windows.Forms.Button();
            this.buttonNCCChinhSua = new System.Windows.Forms.Button();
            this.dataGridViewNhaCungCap = new System.Windows.Forms.DataGridView();
            this.tabDonNhap = new System.Windows.Forms.TabPage();
            this.buttonDNTaiLai = new System.Windows.Forms.Button();
            this.buttonDNXemChiTiet = new System.Windows.Forms.Button();
            this.buttonDNChinhSua = new System.Windows.Forms.Button();
            this.dataGridViewDonNhap = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.tabNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).BeginInit();
            this.tabDonNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(12, 37);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(34, 16);
            this.labelTen.TabIndex = 0;
            this.labelTen.Text = "Tên:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.accountToolStripMenuItem.Text = "Tài khoản";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dangNhapToolStripMenuItem.Text = "Đăng nhập";
            this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Enabled = false;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // labelMaSo
            // 
            this.labelMaSo.AutoSize = true;
            this.labelMaSo.Location = new System.Drawing.Point(12, 53);
            this.labelMaSo.Name = "labelMaSo";
            this.labelMaSo.Size = new System.Drawing.Size(47, 16);
            this.labelMaSo.TabIndex = 2;
            this.labelMaSo.Text = "Mã số:";
            this.labelMaSo.Visible = false;
            // 
            // labelVaiTro
            // 
            this.labelVaiTro.AutoSize = true;
            this.labelVaiTro.Location = new System.Drawing.Point(12, 69);
            this.labelVaiTro.Name = "labelVaiTro";
            this.labelVaiTro.Size = new System.Drawing.Size(48, 16);
            this.labelVaiTro.TabIndex = 3;
            this.labelVaiTro.Text = "Vai trò:";
            this.labelVaiTro.Visible = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabSach);
            this.tabControlMain.Controls.Add(this.tabNhaCungCap);
            this.tabControlMain.Controls.Add(this.tabDonNhap);
            this.tabControlMain.Location = new System.Drawing.Point(15, 100);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(922, 465);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabSach
            // 
            this.tabSach.Controls.Add(this.buttonSachTaiLai);
            this.tabSach.Controls.Add(this.buttonSachXemChiTiet);
            this.tabSach.Controls.Add(this.buttonSachChinhSua);
            this.tabSach.Controls.Add(this.dataGridViewSach);
            this.tabSach.Location = new System.Drawing.Point(4, 25);
            this.tabSach.Name = "tabSach";
            this.tabSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabSach.Size = new System.Drawing.Size(914, 436);
            this.tabSach.TabIndex = 1;
            this.tabSach.Text = "Kho sách";
            this.tabSach.UseVisualStyleBackColor = true;
            // 
            // buttonSachTaiLai
            // 
            this.buttonSachTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSachTaiLai.Location = new System.Drawing.Point(815, 393);
            this.buttonSachTaiLai.Name = "buttonSachTaiLai";
            this.buttonSachTaiLai.Size = new System.Drawing.Size(93, 40);
            this.buttonSachTaiLai.TabIndex = 4;
            this.buttonSachTaiLai.Text = "Tải lại";
            this.buttonSachTaiLai.UseVisualStyleBackColor = true;
            this.buttonSachTaiLai.Click += new System.EventHandler(this.buttonSachTaiLai_Click);
            // 
            // buttonSachXemChiTiet
            // 
            this.buttonSachXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSachXemChiTiet.Location = new System.Drawing.Point(125, 393);
            this.buttonSachXemChiTiet.Name = "buttonSachXemChiTiet";
            this.buttonSachXemChiTiet.Size = new System.Drawing.Size(93, 40);
            this.buttonSachXemChiTiet.TabIndex = 3;
            this.buttonSachXemChiTiet.Text = "Xem chi tiết";
            this.buttonSachXemChiTiet.UseVisualStyleBackColor = true;
            this.buttonSachXemChiTiet.Click += new System.EventHandler(this.buttonSachXemChiTiet_Click);
            // 
            // buttonSachChinhSua
            // 
            this.buttonSachChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSachChinhSua.Location = new System.Drawing.Point(6, 393);
            this.buttonSachChinhSua.Name = "buttonSachChinhSua";
            this.buttonSachChinhSua.Size = new System.Drawing.Size(93, 40);
            this.buttonSachChinhSua.TabIndex = 2;
            this.buttonSachChinhSua.Text = "Chỉnh sửa";
            this.buttonSachChinhSua.UseVisualStyleBackColor = true;
            this.buttonSachChinhSua.Click += new System.EventHandler(this.buttonSachChinhSua_Click);
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.AllowUserToOrderColumns = true;
            this.dataGridViewSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.ReadOnly = true;
            this.dataGridViewSach.RowHeadersWidth = 51;
            this.dataGridViewSach.RowTemplate.Height = 24;
            this.dataGridViewSach.Size = new System.Drawing.Size(902, 381);
            this.dataGridViewSach.TabIndex = 1;
            this.dataGridViewSach.VisibleChanged += new System.EventHandler(this.dataGridViewKhoSach_VisibleChanged);
            // 
            // tabNhaCungCap
            // 
            this.tabNhaCungCap.Controls.Add(this.buttonNCCTaiLai);
            this.tabNhaCungCap.Controls.Add(this.buttonNCCXemChiTiet);
            this.tabNhaCungCap.Controls.Add(this.buttonNCCChinhSua);
            this.tabNhaCungCap.Controls.Add(this.dataGridViewNhaCungCap);
            this.tabNhaCungCap.Location = new System.Drawing.Point(4, 25);
            this.tabNhaCungCap.Name = "tabNhaCungCap";
            this.tabNhaCungCap.Size = new System.Drawing.Size(914, 436);
            this.tabNhaCungCap.TabIndex = 2;
            this.tabNhaCungCap.Text = "Nhà cung cấp";
            this.tabNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // buttonNCCTaiLai
            // 
            this.buttonNCCTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNCCTaiLai.Location = new System.Drawing.Point(815, 393);
            this.buttonNCCTaiLai.Name = "buttonNCCTaiLai";
            this.buttonNCCTaiLai.Size = new System.Drawing.Size(93, 40);
            this.buttonNCCTaiLai.TabIndex = 7;
            this.buttonNCCTaiLai.Text = "Tải lại";
            this.buttonNCCTaiLai.UseVisualStyleBackColor = true;
            this.buttonNCCTaiLai.Click += new System.EventHandler(this.buttonNCCTaiLai_Click);
            // 
            // buttonNCCXemChiTiet
            // 
            this.buttonNCCXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNCCXemChiTiet.Location = new System.Drawing.Point(125, 393);
            this.buttonNCCXemChiTiet.Name = "buttonNCCXemChiTiet";
            this.buttonNCCXemChiTiet.Size = new System.Drawing.Size(93, 40);
            this.buttonNCCXemChiTiet.TabIndex = 6;
            this.buttonNCCXemChiTiet.Text = "Xem chi tiết";
            this.buttonNCCXemChiTiet.UseVisualStyleBackColor = true;
            this.buttonNCCXemChiTiet.Click += new System.EventHandler(this.buttonNCCXemChiTiet_Click);
            // 
            // buttonNCCChinhSua
            // 
            this.buttonNCCChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNCCChinhSua.Location = new System.Drawing.Point(6, 393);
            this.buttonNCCChinhSua.Name = "buttonNCCChinhSua";
            this.buttonNCCChinhSua.Size = new System.Drawing.Size(93, 40);
            this.buttonNCCChinhSua.TabIndex = 5;
            this.buttonNCCChinhSua.Text = "Chỉnh sửa";
            this.buttonNCCChinhSua.UseVisualStyleBackColor = true;
            this.buttonNCCChinhSua.Click += new System.EventHandler(this.buttonNCCChinhSua_Click);
            // 
            // dataGridViewNhaCungCap
            // 
            this.dataGridViewNhaCungCap.AllowUserToOrderColumns = true;
            this.dataGridViewNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhaCungCap.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewNhaCungCap.Name = "dataGridViewNhaCungCap";
            this.dataGridViewNhaCungCap.ReadOnly = true;
            this.dataGridViewNhaCungCap.RowHeadersWidth = 51;
            this.dataGridViewNhaCungCap.RowTemplate.Height = 24;
            this.dataGridViewNhaCungCap.Size = new System.Drawing.Size(902, 381);
            this.dataGridViewNhaCungCap.TabIndex = 2;
            this.dataGridViewNhaCungCap.VisibleChanged += new System.EventHandler(this.dataGridViewNhaCungCap_VisibleChanged);
            // 
            // tabDonNhap
            // 
            this.tabDonNhap.Controls.Add(this.buttonDNTaiLai);
            this.tabDonNhap.Controls.Add(this.buttonDNXemChiTiet);
            this.tabDonNhap.Controls.Add(this.buttonDNChinhSua);
            this.tabDonNhap.Controls.Add(this.dataGridViewDonNhap);
            this.tabDonNhap.Location = new System.Drawing.Point(4, 25);
            this.tabDonNhap.Name = "tabDonNhap";
            this.tabDonNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonNhap.Size = new System.Drawing.Size(914, 436);
            this.tabDonNhap.TabIndex = 0;
            this.tabDonNhap.Text = "Đơn nhập sách";
            this.tabDonNhap.UseVisualStyleBackColor = true;
            // 
            // buttonDNTaiLai
            // 
            this.buttonDNTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDNTaiLai.Location = new System.Drawing.Point(815, 393);
            this.buttonDNTaiLai.Name = "buttonDNTaiLai";
            this.buttonDNTaiLai.Size = new System.Drawing.Size(93, 40);
            this.buttonDNTaiLai.TabIndex = 10;
            this.buttonDNTaiLai.Text = "Tải lại";
            this.buttonDNTaiLai.UseVisualStyleBackColor = true;
            this.buttonDNTaiLai.Click += new System.EventHandler(this.buttonDNTaiLai_Click);
            // 
            // buttonDNXemChiTiet
            // 
            this.buttonDNXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDNXemChiTiet.Location = new System.Drawing.Point(125, 393);
            this.buttonDNXemChiTiet.Name = "buttonDNXemChiTiet";
            this.buttonDNXemChiTiet.Size = new System.Drawing.Size(93, 40);
            this.buttonDNXemChiTiet.TabIndex = 9;
            this.buttonDNXemChiTiet.Text = "Xem chi tiết";
            this.buttonDNXemChiTiet.UseVisualStyleBackColor = true;
            this.buttonDNXemChiTiet.Click += new System.EventHandler(this.buttonDNXemChiTiet_Click);
            // 
            // buttonDNChinhSua
            // 
            this.buttonDNChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDNChinhSua.Location = new System.Drawing.Point(6, 393);
            this.buttonDNChinhSua.Name = "buttonDNChinhSua";
            this.buttonDNChinhSua.Size = new System.Drawing.Size(93, 40);
            this.buttonDNChinhSua.TabIndex = 8;
            this.buttonDNChinhSua.Text = "Chỉnh sửa";
            this.buttonDNChinhSua.UseVisualStyleBackColor = true;
            this.buttonDNChinhSua.Click += new System.EventHandler(this.buttonDNChinhSua_Click);
            // 
            // dataGridViewDonNhap
            // 
            this.dataGridViewDonNhap.AllowUserToOrderColumns = true;
            this.dataGridViewDonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonNhap.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDonNhap.Name = "dataGridViewDonNhap";
            this.dataGridViewDonNhap.ReadOnly = true;
            this.dataGridViewDonNhap.RowHeadersWidth = 51;
            this.dataGridViewDonNhap.RowTemplate.Height = 24;
            this.dataGridViewDonNhap.Size = new System.Drawing.Size(902, 381);
            this.dataGridViewDonNhap.TabIndex = 0;
            this.dataGridViewDonNhap.VisibleChanged += new System.EventHandler(this.dataGridViewDonNhap_VisibleChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 577);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelVaiTro);
            this.Controls.Add(this.labelMaSo);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Quản lý nhập sách";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.tabNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).EndInit();
            this.tabDonNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Label labelMaSo;
        private System.Windows.Forms.Label labelVaiTro;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabDonNhap;
        private System.Windows.Forms.TabPage tabSach;
        private System.Windows.Forms.TabPage tabNhaCungCap;
        private System.Windows.Forms.DataGridView dataGridViewDonNhap;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.DataGridView dataGridViewNhaCungCap;
        private System.Windows.Forms.Button buttonSachChinhSua;
        private System.Windows.Forms.Button buttonSachTaiLai;
        private System.Windows.Forms.Button buttonSachXemChiTiet;
        private System.Windows.Forms.Button buttonNCCTaiLai;
        private System.Windows.Forms.Button buttonNCCXemChiTiet;
        private System.Windows.Forms.Button buttonNCCChinhSua;
        private System.Windows.Forms.Button buttonDNTaiLai;
        private System.Windows.Forms.Button buttonDNXemChiTiet;
        private System.Windows.Forms.Button buttonDNChinhSua;
    }
}

