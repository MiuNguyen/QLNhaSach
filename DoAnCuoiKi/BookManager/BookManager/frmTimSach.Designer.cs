namespace BookManager
{
    partial class frmTimSach
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnTacGia = new System.Windows.Forms.RadioButton();
            this.rdbtnTenSach = new System.Windows.Forms.RadioButton();
            this.rdbtnMaSach = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTraSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHienThiAll = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnTacGia);
            this.groupBox3.Controls.Add(this.rdbtnTenSach);
            this.groupBox3.Controls.Add(this.rdbtnMaSach);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTraSach);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(70, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // rdbtnTacGia
            // 
            this.rdbtnTacGia.AutoSize = true;
            this.rdbtnTacGia.Location = new System.Drawing.Point(263, 56);
            this.rdbtnTacGia.Name = "rdbtnTacGia";
            this.rdbtnTacGia.Size = new System.Drawing.Size(71, 23);
            this.rdbtnTacGia.TabIndex = 4;
            this.rdbtnTacGia.TabStop = true;
            this.rdbtnTacGia.Text = "Tác giả";
            this.rdbtnTacGia.UseVisualStyleBackColor = true;
            // 
            // rdbtnTenSach
            // 
            this.rdbtnTenSach.AutoSize = true;
            this.rdbtnTenSach.Location = new System.Drawing.Point(176, 56);
            this.rdbtnTenSach.Name = "rdbtnTenSach";
            this.rdbtnTenSach.Size = new System.Drawing.Size(81, 23);
            this.rdbtnTenSach.TabIndex = 3;
            this.rdbtnTenSach.TabStop = true;
            this.rdbtnTenSach.Text = "Tên sách";
            this.rdbtnTenSach.UseVisualStyleBackColor = true;
            // 
            // rdbtnMaSach
            // 
            this.rdbtnMaSach.AutoSize = true;
            this.rdbtnMaSach.Location = new System.Drawing.Point(91, 56);
            this.rdbtnMaSach.Name = "rdbtnMaSach";
            this.rdbtnMaSach.Size = new System.Drawing.Size(79, 23);
            this.rdbtnMaSach.TabIndex = 2;
            this.rdbtnMaSach.TabStop = true;
            this.rdbtnMaSach.Text = "Mã sách";
            this.rdbtnMaSach.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(414, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 28);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTraSach
            // 
            this.txtTraSach.Location = new System.Drawing.Point(66, 25);
            this.txtTraSach.Name = "txtTraSach";
            this.txtTraSach.Size = new System.Drawing.Size(324, 26);
            this.txtTraSach.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhập";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridView2.Location = new System.Drawing.Point(12, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(648, 181);
            this.dataGridView2.TabIndex = 7;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "MASACH";
            this.Column8.HeaderText = "Mã sách";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "TENSACH";
            this.Column9.HeaderText = "Tên sách";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "THELOAI";
            this.Column10.HeaderText = "Thể loại";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "TACGIA";
            this.Column11.HeaderText = "Tác giả";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "GIA";
            this.Column12.HeaderText = "Giá";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.DataPropertyName = "SOLUONG";
            this.Column13.HeaderText = "Số lượng";
            this.Column13.Name = "Column13";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(569, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 31);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(283, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "TRA SÁCH";
            // 
            // btnHienThiAll
            // 
            this.btnHienThiAll.Location = new System.Drawing.Point(220, 151);
            this.btnHienThiAll.Name = "btnHienThiAll";
            this.btnHienThiAll.Size = new System.Drawing.Size(152, 33);
            this.btnHienThiAll.TabIndex = 6;
            this.btnHienThiAll.Text = "Hiển thị tất cả sách";
            this.btnHienThiAll.UseVisualStyleBackColor = true;
            // 
            // frmTimSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 447);
            this.ControlBox = false;
            this.Controls.Add(this.btnHienThiAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTimSach";
            this.Text = "Tra Sách";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtnTacGia;
        private System.Windows.Forms.RadioButton rdbtnTenSach;
        private System.Windows.Forms.RadioButton rdbtnMaSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTraSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHienThiAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}