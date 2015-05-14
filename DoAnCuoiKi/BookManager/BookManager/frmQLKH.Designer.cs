namespace BookManager
{
    partial class frmQLKH
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
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaKH_Xoa = new System.Windows.Forms.TextBox();
            this.view_XoaKH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox15.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_XoaKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txtTienNo);
            this.groupBox15.Controls.Add(this.label3);
            this.groupBox15.Controls.Add(this.btnCapNhat);
            this.groupBox15.Controls.Add(this.txtSDT);
            this.groupBox15.Controls.Add(this.txtDC);
            this.groupBox15.Controls.Add(this.txtTenKH);
            this.groupBox15.Controls.Add(this.label33);
            this.groupBox15.Controls.Add(this.label32);
            this.groupBox15.Controls.Add(this.label31);
            this.groupBox15.Location = new System.Drawing.Point(20, 102);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(506, 138);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Sửa thông tin khách hàng";
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(323, 70);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Size = new System.Drawing.Size(169, 26);
            this.txtTienNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tiền nợ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(384, 112);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 26);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(323, 25);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 26);
            this.txtSDT.TabIndex = 4;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(71, 70);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(169, 26);
            this.txtDC.TabIndex = 3;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(71, 25);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(169, 26);
            this.txtTenKH.TabIndex = 2;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(264, 28);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 19);
            this.label33.TabIndex = 3;
            this.label33.Text = "SDT";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 73);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 19);
            this.label32.TabIndex = 2;
            this.label32.Text = "Địa chỉ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 32);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 19);
            this.label31.TabIndex = 1;
            this.label31.Text = "Tên KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(208, 58);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(178, 26);
            this.txtMaKH.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(30, 58);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(172, 19);
            this.label30.TabIndex = 0;
            this.label30.Text = "Nhập mã KH cần cập nhật";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label1);
            this.groupBox17.Controls.Add(this.btnXoa);
            this.groupBox17.Controls.Add(this.txtMaKH_Xoa);
            this.groupBox17.Location = new System.Drawing.Point(20, 246);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(506, 66);
            this.groupBox17.TabIndex = 4;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Xóa khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập mã khách hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(398, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 26);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaKH_Xoa
            // 
            this.txtMaKH_Xoa.Location = new System.Drawing.Point(188, 28);
            this.txtMaKH_Xoa.Name = "txtMaKH_Xoa";
            this.txtMaKH_Xoa.Size = new System.Drawing.Size(178, 26);
            this.txtMaKH_Xoa.TabIndex = 7;
            // 
            // view_XoaKH
            // 
            this.view_XoaKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_XoaKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.view_XoaKH.Location = new System.Drawing.Point(20, 330);
            this.view_XoaKH.Name = "view_XoaKH";
            this.view_XoaKH.Size = new System.Drawing.Size(506, 145);
            this.view_XoaKH.TabIndex = 9;
            this.view_XoaKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_XoaKH_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MAKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TENKH";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "SĐT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TIENNO";
            this.Column5.HeaderText = "Tiền nợ";
            this.Column5.Name = "Column5";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(423, 481);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 31);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(55, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            // 
            // frmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 524);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.view_XoaKH);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label30);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQLKH";
            this.Text = "Quản Lý Khách Hàng";
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_XoaKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaKH_Xoa;
        private System.Windows.Forms.DataGridView view_XoaKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}