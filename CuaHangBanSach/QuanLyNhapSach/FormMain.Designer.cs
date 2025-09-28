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
            this.tabDonNhap = new System.Windows.Forms.TabPage();
            this.buttonHuyDon = new System.Windows.Forms.Button();
            this.buttonXacNhanDon = new System.Windows.Forms.Button();
            this.buttonDNTaiLai = new System.Windows.Forms.Button();
            this.buttonDNXemChiTiet = new System.Windows.Forms.Button();
            this.buttonDNChinhSua = new System.Windows.Forms.Button();
            this.dataGridViewDonNhap = new System.Windows.Forms.DataGridView();
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
            this.buttonNhapHang = new System.Windows.Forms.Button();
            this.buttonChinhDN = new System.Windows.Forms.Button();
            this.labelMaDN = new System.Windows.Forms.Label();
            this.textBoxMaDN = new System.Windows.Forms.TextBox();
            this.panelChucNangNV = new System.Windows.Forms.Panel();
            this.tabChiTietDonNhap = new System.Windows.Forms.TabPage();
            this.buttonCTDNTaiLai = new System.Windows.Forms.Button();
            this.buttonCTDNChinhSua = new System.Windows.Forms.Button();
            this.dataGridViewChiTietDonNhap = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabDonNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhap)).BeginInit();
            this.tabSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.tabNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).BeginInit();
            this.panelChucNangNV.SuspendLayout();
            this.tabChiTietDonNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDonNhap)).BeginInit();
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
            this.tabControlMain.Controls.Add(this.tabDonNhap);
            this.tabControlMain.Controls.Add(this.tabSach);
            this.tabControlMain.Controls.Add(this.tabNhaCungCap);
            this.tabControlMain.Controls.Add(this.tabChiTietDonNhap);
            this.tabControlMain.Location = new System.Drawing.Point(15, 137);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(922, 428);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabDonNhap
            // 
            this.tabDonNhap.Controls.Add(this.buttonHuyDon);
            this.tabDonNhap.Controls.Add(this.buttonXacNhanDon);
            this.tabDonNhap.Controls.Add(this.buttonDNTaiLai);
            this.tabDonNhap.Controls.Add(this.buttonDNXemChiTiet);
            this.tabDonNhap.Controls.Add(this.buttonDNChinhSua);
            this.tabDonNhap.Controls.Add(this.dataGridViewDonNhap);
            this.tabDonNhap.Location = new System.Drawing.Point(4, 25);
            this.tabDonNhap.Name = "tabDonNhap";
            this.tabDonNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonNhap.Size = new System.Drawing.Size(914, 399);
            this.tabDonNhap.TabIndex = 0;
            this.tabDonNhap.Text = "Đơn nhập sách";
            this.tabDonNhap.UseVisualStyleBackColor = true;
            // 
            // buttonHuyDon
            // 
            this.buttonHuyDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHuyDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonHuyDon.Location = new System.Drawing.Point(537, 353);
            this.buttonHuyDon.Name = "buttonHuyDon";
            this.buttonHuyDon.Size = new System.Drawing.Size(93, 40);
            this.buttonHuyDon.TabIndex = 12;
            this.buttonHuyDon.Text = "Hủy đơn";
            this.buttonHuyDon.UseVisualStyleBackColor = false;
            this.buttonHuyDon.Click += new System.EventHandler(this.buttonHuyDon_Click);
            // 
            // buttonXacNhanDon
            // 
            this.buttonXacNhanDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonXacNhanDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonXacNhanDon.Location = new System.Drawing.Point(387, 353);
            this.buttonXacNhanDon.Name = "buttonXacNhanDon";
            this.buttonXacNhanDon.Size = new System.Drawing.Size(115, 40);
            this.buttonXacNhanDon.TabIndex = 11;
            this.buttonXacNhanDon.Text = "Xác nhận đơn";
            this.buttonXacNhanDon.UseVisualStyleBackColor = false;
            this.buttonXacNhanDon.Click += new System.EventHandler(this.buttonXacNhanDon_Click);
            // 
            // buttonDNTaiLai
            // 
            this.buttonDNTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDNTaiLai.Location = new System.Drawing.Point(815, 356);
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
            this.buttonDNXemChiTiet.Location = new System.Drawing.Point(125, 356);
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
            this.buttonDNChinhSua.Location = new System.Drawing.Point(6, 356);
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
            this.dataGridViewDonNhap.MultiSelect = false;
            this.dataGridViewDonNhap.Name = "dataGridViewDonNhap";
            this.dataGridViewDonNhap.ReadOnly = true;
            this.dataGridViewDonNhap.RowHeadersWidth = 51;
            this.dataGridViewDonNhap.RowTemplate.Height = 24;
            this.dataGridViewDonNhap.Size = new System.Drawing.Size(902, 344);
            this.dataGridViewDonNhap.TabIndex = 0;
            this.dataGridViewDonNhap.CurrentCellChanged += new System.EventHandler(this.dataGridViewDonNhap_CurrentCellChanged);
            this.dataGridViewDonNhap.VisibleChanged += new System.EventHandler(this.dataGridViewDonNhap_VisibleChanged);
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
            this.tabSach.Size = new System.Drawing.Size(914, 399);
            this.tabSach.TabIndex = 1;
            this.tabSach.Text = "Kho sách";
            this.tabSach.UseVisualStyleBackColor = true;
            // 
            // buttonSachTaiLai
            // 
            this.buttonSachTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSachTaiLai.Location = new System.Drawing.Point(815, 356);
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
            this.buttonSachXemChiTiet.Location = new System.Drawing.Point(125, 356);
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
            this.buttonSachChinhSua.Location = new System.Drawing.Point(6, 356);
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
            this.dataGridViewSach.MultiSelect = false;
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.ReadOnly = true;
            this.dataGridViewSach.RowHeadersWidth = 51;
            this.dataGridViewSach.RowTemplate.Height = 24;
            this.dataGridViewSach.Size = new System.Drawing.Size(902, 344);
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
            this.tabNhaCungCap.Size = new System.Drawing.Size(914, 399);
            this.tabNhaCungCap.TabIndex = 2;
            this.tabNhaCungCap.Text = "Nhà cung cấp";
            this.tabNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // buttonNCCTaiLai
            // 
            this.buttonNCCTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNCCTaiLai.Location = new System.Drawing.Point(815, 356);
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
            this.buttonNCCXemChiTiet.Location = new System.Drawing.Point(125, 356);
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
            this.buttonNCCChinhSua.Location = new System.Drawing.Point(6, 356);
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
            this.dataGridViewNhaCungCap.MultiSelect = false;
            this.dataGridViewNhaCungCap.Name = "dataGridViewNhaCungCap";
            this.dataGridViewNhaCungCap.ReadOnly = true;
            this.dataGridViewNhaCungCap.RowHeadersWidth = 51;
            this.dataGridViewNhaCungCap.RowTemplate.Height = 24;
            this.dataGridViewNhaCungCap.Size = new System.Drawing.Size(902, 344);
            this.dataGridViewNhaCungCap.TabIndex = 2;
            this.dataGridViewNhaCungCap.VisibleChanged += new System.EventHandler(this.dataGridViewNhaCungCap_VisibleChanged);
            // 
            // buttonNhapHang
            // 
            this.buttonNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNhapHang.Location = new System.Drawing.Point(168, 3);
            this.buttonNhapHang.Name = "buttonNhapHang";
            this.buttonNhapHang.Size = new System.Drawing.Size(118, 41);
            this.buttonNhapHang.TabIndex = 5;
            this.buttonNhapHang.Text = "Nhập đơn mới";
            this.buttonNhapHang.UseVisualStyleBackColor = false;
            this.buttonNhapHang.Click += new System.EventHandler(this.buttonNhapHang_Click);
            // 
            // buttonChinhDN
            // 
            this.buttonChinhDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonChinhDN.Location = new System.Drawing.Point(27, 62);
            this.buttonChinhDN.Name = "buttonChinhDN";
            this.buttonChinhDN.Size = new System.Drawing.Size(118, 41);
            this.buttonChinhDN.TabIndex = 6;
            this.buttonChinhDN.Text = "Chỉnh đơn";
            this.buttonChinhDN.UseVisualStyleBackColor = false;
            this.buttonChinhDN.Click += new System.EventHandler(this.buttonChinhDN_Click);
            // 
            // labelMaDN
            // 
            this.labelMaDN.AutoSize = true;
            this.labelMaDN.Location = new System.Drawing.Point(151, 74);
            this.labelMaDN.Name = "labelMaDN";
            this.labelMaDN.Size = new System.Drawing.Size(29, 16);
            this.labelMaDN.TabIndex = 7;
            this.labelMaDN.Text = "Mã:";
            // 
            // textBoxMaDN
            // 
            this.textBoxMaDN.Location = new System.Drawing.Point(186, 71);
            this.textBoxMaDN.Name = "textBoxMaDN";
            this.textBoxMaDN.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaDN.TabIndex = 8;
            // 
            // panelChucNangNV
            // 
            this.panelChucNangNV.BackColor = System.Drawing.Color.Transparent;
            this.panelChucNangNV.Controls.Add(this.buttonNhapHang);
            this.panelChucNangNV.Controls.Add(this.textBoxMaDN);
            this.panelChucNangNV.Controls.Add(this.buttonChinhDN);
            this.panelChucNangNV.Controls.Add(this.labelMaDN);
            this.panelChucNangNV.Location = new System.Drawing.Point(644, 31);
            this.panelChucNangNV.Name = "panelChucNangNV";
            this.panelChucNangNV.Size = new System.Drawing.Size(289, 125);
            this.panelChucNangNV.TabIndex = 9;
            // 
            // tabChiTietDonNhap
            // 
            this.tabChiTietDonNhap.Controls.Add(this.buttonCTDNTaiLai);
            this.tabChiTietDonNhap.Controls.Add(this.buttonCTDNChinhSua);
            this.tabChiTietDonNhap.Controls.Add(this.dataGridViewChiTietDonNhap);
            this.tabChiTietDonNhap.Location = new System.Drawing.Point(4, 25);
            this.tabChiTietDonNhap.Name = "tabChiTietDonNhap";
            this.tabChiTietDonNhap.Size = new System.Drawing.Size(914, 399);
            this.tabChiTietDonNhap.TabIndex = 4;
            this.tabChiTietDonNhap.Text = "Chi tiết đơn nhập";
            this.tabChiTietDonNhap.UseVisualStyleBackColor = true;
            // 
            // buttonCTDNTaiLai
            // 
            this.buttonCTDNTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCTDNTaiLai.Location = new System.Drawing.Point(815, 356);
            this.buttonCTDNTaiLai.Name = "buttonCTDNTaiLai";
            this.buttonCTDNTaiLai.Size = new System.Drawing.Size(93, 40);
            this.buttonCTDNTaiLai.TabIndex = 7;
            this.buttonCTDNTaiLai.Text = "Tải lại";
            this.buttonCTDNTaiLai.UseVisualStyleBackColor = true;
            this.buttonCTDNTaiLai.Click += new System.EventHandler(this.buttonCTDNTaiLai_Click);
            // 
            // buttonCTDNChinhSua
            // 
            this.buttonCTDNChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCTDNChinhSua.Location = new System.Drawing.Point(6, 356);
            this.buttonCTDNChinhSua.Name = "buttonCTDNChinhSua";
            this.buttonCTDNChinhSua.Size = new System.Drawing.Size(93, 40);
            this.buttonCTDNChinhSua.TabIndex = 5;
            this.buttonCTDNChinhSua.Text = "Chỉnh sửa";
            this.buttonCTDNChinhSua.UseVisualStyleBackColor = true;
            this.buttonCTDNChinhSua.Click += new System.EventHandler(this.buttonCTDNChinhSua_Click);
            // 
            // dataGridViewChiTietDonNhap
            // 
            this.dataGridViewChiTietDonNhap.AllowUserToOrderColumns = true;
            this.dataGridViewChiTietDonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChiTietDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewChiTietDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietDonNhap.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewChiTietDonNhap.MultiSelect = false;
            this.dataGridViewChiTietDonNhap.Name = "dataGridViewChiTietDonNhap";
            this.dataGridViewChiTietDonNhap.ReadOnly = true;
            this.dataGridViewChiTietDonNhap.RowHeadersWidth = 51;
            this.dataGridViewChiTietDonNhap.RowTemplate.Height = 24;
            this.dataGridViewChiTietDonNhap.Size = new System.Drawing.Size(902, 344);
            this.dataGridViewChiTietDonNhap.TabIndex = 2;
            this.dataGridViewChiTietDonNhap.VisibleChanged += new System.EventHandler(this.dataGridViewChiTietDonNhap_VisibleChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 577);
            this.Controls.Add(this.panelChucNangNV);
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
            this.tabDonNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhap)).EndInit();
            this.tabSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.tabNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).EndInit();
            this.panelChucNangNV.ResumeLayout(false);
            this.panelChucNangNV.PerformLayout();
            this.tabChiTietDonNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDonNhap)).EndInit();
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
        private System.Windows.Forms.Button buttonNhapHang;
        private System.Windows.Forms.Button buttonChinhDN;
        private System.Windows.Forms.Label labelMaDN;
        private System.Windows.Forms.TextBox textBoxMaDN;
        private System.Windows.Forms.Panel panelChucNangNV;
        private System.Windows.Forms.Button buttonXacNhanDon;
        private System.Windows.Forms.Button buttonHuyDon;
        private System.Windows.Forms.TabPage tabChiTietDonNhap;
        private System.Windows.Forms.Button buttonCTDNTaiLai;
        private System.Windows.Forms.Button buttonCTDNChinhSua;
        private System.Windows.Forms.DataGridView dataGridViewChiTietDonNhap;
    }
}

