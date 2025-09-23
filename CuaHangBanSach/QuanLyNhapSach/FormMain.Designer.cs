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
            this.dataGridViewDonNhap = new System.Windows.Forms.DataGridView();
            this.tabKhoSach = new System.Windows.Forms.TabPage();
            this.dataGridViewKhoSach = new System.Windows.Forms.DataGridView();
            this.tabNhaCungCap = new System.Windows.Forms.TabPage();
            this.dataGridViewNhaCungCap = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabDonNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhap)).BeginInit();
            this.tabKhoSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoSach)).BeginInit();
            this.tabNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).BeginInit();
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
            this.labelVaiTro.Size = new System.Drawing.Size(45, 16);
            this.labelVaiTro.TabIndex = 3;
            this.labelVaiTro.Text = "Vai trò";
            this.labelVaiTro.Visible = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabKhoSach);
            this.tabControlMain.Controls.Add(this.tabNhaCungCap);
            this.tabControlMain.Controls.Add(this.tabDonNhap);
            this.tabControlMain.Location = new System.Drawing.Point(15, 100);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(922, 465);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabDonNhap
            // 
            this.tabDonNhap.Controls.Add(this.dataGridViewDonNhap);
            this.tabDonNhap.Location = new System.Drawing.Point(4, 25);
            this.tabDonNhap.Name = "tabDonNhap";
            this.tabDonNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonNhap.Size = new System.Drawing.Size(914, 436);
            this.tabDonNhap.TabIndex = 0;
            this.tabDonNhap.Text = "Đơn nhập sách";
            this.tabDonNhap.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDonNhap
            // 
            this.dataGridViewDonNhap.AllowUserToOrderColumns = true;
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
            // tabKhoSach
            // 
            this.tabKhoSach.Controls.Add(this.dataGridViewKhoSach);
            this.tabKhoSach.Location = new System.Drawing.Point(4, 25);
            this.tabKhoSach.Name = "tabKhoSach";
            this.tabKhoSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoSach.Size = new System.Drawing.Size(914, 436);
            this.tabKhoSach.TabIndex = 1;
            this.tabKhoSach.Text = "Kho sách";
            this.tabKhoSach.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKhoSach
            // 
            this.dataGridViewKhoSach.AllowUserToOrderColumns = true;
            this.dataGridViewKhoSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKhoSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoSach.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewKhoSach.Name = "dataGridViewKhoSach";
            this.dataGridViewKhoSach.ReadOnly = true;
            this.dataGridViewKhoSach.RowHeadersWidth = 51;
            this.dataGridViewKhoSach.RowTemplate.Height = 24;
            this.dataGridViewKhoSach.Size = new System.Drawing.Size(902, 381);
            this.dataGridViewKhoSach.TabIndex = 1;
            this.dataGridViewKhoSach.VisibleChanged += new System.EventHandler(this.dataGridViewKhoSach_VisibleChanged);
            // 
            // tabNhaCungCap
            // 
            this.tabNhaCungCap.Controls.Add(this.dataGridViewNhaCungCap);
            this.tabNhaCungCap.Location = new System.Drawing.Point(4, 25);
            this.tabNhaCungCap.Name = "tabNhaCungCap";
            this.tabNhaCungCap.Size = new System.Drawing.Size(914, 436);
            this.tabNhaCungCap.TabIndex = 2;
            this.tabNhaCungCap.Text = "Nhà cung cấp";
            this.tabNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNhaCungCap
            // 
            this.dataGridViewNhaCungCap.AllowUserToOrderColumns = true;
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
            this.tabDonNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhap)).EndInit();
            this.tabKhoSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoSach)).EndInit();
            this.tabNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).EndInit();
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
        private System.Windows.Forms.TabPage tabKhoSach;
        private System.Windows.Forms.TabPage tabNhaCungCap;
        private System.Windows.Forms.DataGridView dataGridViewDonNhap;
        private System.Windows.Forms.DataGridView dataGridViewKhoSach;
        private System.Windows.Forms.DataGridView dataGridViewNhaCungCap;
    }
}

