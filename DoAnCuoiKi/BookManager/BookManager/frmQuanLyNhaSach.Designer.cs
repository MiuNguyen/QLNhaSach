namespace BookManager
{
    partial class frmQuanLyNhaSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhaSach));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuyDinhPQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThayDoiQDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GTPMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLToolStripMenuItem,
            this.TCToolStripMenuItem,
            this.QPToolStripMenuItem,
            this.GTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(680, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QLToolStripMenuItem
            // 
            this.QLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SachToolStripMenuItem,
            this.KHToolStripMenuItem,
            this.HoaDonToolStripMenuItem});
            this.QLToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLToolStripMenuItem.Name = "QLToolStripMenuItem";
            this.QLToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.QLToolStripMenuItem.Text = "Quản lý";
            // 
            // SachToolStripMenuItem
            // 
            this.SachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemSToolStripMenuItem,
            this.qlSachToolStripMenuItem});
            this.SachToolStripMenuItem.Name = "SachToolStripMenuItem";
            this.SachToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.SachToolStripMenuItem.Text = "Sách";
            // 
            // ThemSToolStripMenuItem
            // 
            this.ThemSToolStripMenuItem.Name = "ThemSToolStripMenuItem";
            this.ThemSToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.ThemSToolStripMenuItem.Text = "Thêm sách";
            this.ThemSToolStripMenuItem.Click += new System.EventHandler(this.ThemSToolStripMenuItem_Click);
            // 
            // qlSachToolStripMenuItem
            // 
            this.qlSachToolStripMenuItem.Name = "qlSachToolStripMenuItem";
            this.qlSachToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.qlSachToolStripMenuItem.Text = "Quản lý sách";
            this.qlSachToolStripMenuItem.Click += new System.EventHandler(this.qlSachToolStripMenuItem_Click);
            // 
            // KHToolStripMenuItem
            // 
            this.KHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemKhachHangToolStripMenuItem,
            this.qlKhachHangToolStripMenuItem});
            this.KHToolStripMenuItem.Name = "KHToolStripMenuItem";
            this.KHToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.KHToolStripMenuItem.Text = "Khách hàng";
            // 
            // ThemKhachHangToolStripMenuItem
            // 
            this.ThemKhachHangToolStripMenuItem.Name = "ThemKhachHangToolStripMenuItem";
            this.ThemKhachHangToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.ThemKhachHangToolStripMenuItem.Text = "Thêm khách hàng";
            this.ThemKhachHangToolStripMenuItem.Click += new System.EventHandler(this.ThemKhachHangToolStripMenuItem_Click);
            // 
            // qlKhachHangToolStripMenuItem
            // 
            this.qlKhachHangToolStripMenuItem.Name = "qlKhachHangToolStripMenuItem";
            this.qlKhachHangToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.qlKhachHangToolStripMenuItem.Text = "Quản lý khách hàng";
            this.qlKhachHangToolStripMenuItem.Click += new System.EventHandler(this.qlKhachHangToolStripMenuItem_Click);
            // 
            // HoaDonToolStripMenuItem
            // 
            this.HoaDonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemHoaDonToolStripMenuItem,
            this.qlHoaDonToolStripMenuItem});
            this.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem";
            this.HoaDonToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.HoaDonToolStripMenuItem.Text = "Hóa đơn";
            // 
            // ThemHoaDonToolStripMenuItem
            // 
            this.ThemHoaDonToolStripMenuItem.Name = "ThemHoaDonToolStripMenuItem";
            this.ThemHoaDonToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.ThemHoaDonToolStripMenuItem.Text = "Thêm hóa đơn";
            this.ThemHoaDonToolStripMenuItem.Click += new System.EventHandler(this.ThemHoaDonToolStripMenuItem_Click);
            // 
            // qlHoaDonToolStripMenuItem
            // 
            this.qlHoaDonToolStripMenuItem.Name = "qlHoaDonToolStripMenuItem";
            this.qlHoaDonToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.qlHoaDonToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.qlHoaDonToolStripMenuItem.Click += new System.EventHandler(this.qlHoaDonToolStripMenuItem_Click);
            // 
            // TCToolStripMenuItem
            // 
            this.TCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcSachToolStripMenuItem,
            this.tcKHToolStripMenuItem,
            this.tcHDToolStripMenuItem});
            this.TCToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCToolStripMenuItem.Name = "TCToolStripMenuItem";
            this.TCToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.TCToolStripMenuItem.Text = "Tra cứu";
            // 
            // tcSachToolStripMenuItem
            // 
            this.tcSachToolStripMenuItem.Name = "tcSachToolStripMenuItem";
            this.tcSachToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.tcSachToolStripMenuItem.Text = "Tra cứu sách";
            this.tcSachToolStripMenuItem.Click += new System.EventHandler(this.tcSachToolStripMenuItem_Click);
            // 
            // tcKHToolStripMenuItem
            // 
            this.tcKHToolStripMenuItem.Name = "tcKHToolStripMenuItem";
            this.tcKHToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.tcKHToolStripMenuItem.Text = "Tra cứu khách hàng";
            this.tcKHToolStripMenuItem.Click += new System.EventHandler(this.tcKHToolStripMenuItem_Click);
            // 
            // tcHDToolStripMenuItem
            // 
            this.tcHDToolStripMenuItem.Name = "tcHDToolStripMenuItem";
            this.tcHDToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.tcHDToolStripMenuItem.Text = "Tra cứu hóa đơn";
            this.tcHDToolStripMenuItem.Click += new System.EventHandler(this.tcHDToolStripMenuItem_Click);
            // 
            // QPToolStripMenuItem
            // 
            this.QPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuyDinhPQToolStripMenuItem,
            this.ThayDoiQDToolStripMenuItem});
            this.QPToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QPToolStripMenuItem.Name = "QPToolStripMenuItem";
            this.QPToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.QPToolStripMenuItem.Text = "Phân quyền";
            // 
            // QuyDinhPQToolStripMenuItem
            // 
            this.QuyDinhPQToolStripMenuItem.Name = "QuyDinhPQToolStripMenuItem";
            this.QuyDinhPQToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.QuyDinhPQToolStripMenuItem.Text = "Quy định";
            this.QuyDinhPQToolStripMenuItem.Click += new System.EventHandler(this.QuyDinhPQToolStripMenuItem_Click);
            // 
            // ThayDoiQDToolStripMenuItem
            // 
            this.ThayDoiQDToolStripMenuItem.Name = "ThayDoiQDToolStripMenuItem";
            this.ThayDoiQDToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.ThayDoiQDToolStripMenuItem.Text = "Thay đổi quy định";
            this.ThayDoiQDToolStripMenuItem.Click += new System.EventHandler(this.ThayDoiQDToolStripMenuItem_Click);
            // 
            // GTToolStripMenuItem
            // 
            this.GTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GTPMToolStripMenuItem});
            this.GTToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTToolStripMenuItem.Name = "GTToolStripMenuItem";
            this.GTToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.GTToolStripMenuItem.Text = "Giới thiệu";
            // 
            // GTPMToolStripMenuItem
            // 
            this.GTPMToolStripMenuItem.Name = "GTPMToolStripMenuItem";
            this.GTPMToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.GTPMToolStripMenuItem.Text = "Giới thiệu phần mềm";
            this.GTPMToolStripMenuItem.Click += new System.EventHandler(this.GTPMToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(21, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 182);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MASACH";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TENSACH";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "THELOAI";
            this.Column3.HeaderText = "Thể loại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TACGIA";
            this.Column4.HeaderText = "Tác giả";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "SOLUONG";
            this.Column5.HeaderText = "Số lượng tồn";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "GIA";
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(214, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHÀ SÁCH";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(570, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLyNhaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 346);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyNhaSach";
            this.Text = "Quản Lý Nhà Sách";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStripMenuItem QLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tcSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tcKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tcHDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuyDinhPQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThayDoiQDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GTPMToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}