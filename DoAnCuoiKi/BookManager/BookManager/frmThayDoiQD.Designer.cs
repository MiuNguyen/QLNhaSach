namespace BookManager
{
    partial class frmThayDoiQD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBaomat = new System.Windows.Forms.TextBox();
            this.txtQD1 = new System.Windows.Forms.TextBox();
            this.txtQD2 = new System.Windows.Forms.TextBox();
            this.txtQD3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "****************************************************";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xin mời bạn nhập bảo mật để thay đổi quy định";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng nhập ít nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chỉ nhập sách có số lượng tồn ít hơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chỉ bán sách cho KH nợ không quá";
            // 
            // txtBaomat
            // 
            this.txtBaomat.Location = new System.Drawing.Point(177, 115);
            this.txtBaomat.Name = "txtBaomat";
            this.txtBaomat.Size = new System.Drawing.Size(212, 26);
            this.txtBaomat.TabIndex = 1;
            // 
            // txtQD1
            // 
            this.txtQD1.Enabled = false;
            this.txtQD1.Location = new System.Drawing.Point(282, 159);
            this.txtQD1.Name = "txtQD1";
            this.txtQD1.Size = new System.Drawing.Size(127, 26);
            this.txtQD1.TabIndex = 2;
            // 
            // txtQD2
            // 
            this.txtQD2.Enabled = false;
            this.txtQD2.Location = new System.Drawing.Point(282, 192);
            this.txtQD2.Name = "txtQD2";
            this.txtQD2.Size = new System.Drawing.Size(127, 26);
            this.txtQD2.TabIndex = 3;
            // 
            // txtQD3
            // 
            this.txtQD3.Enabled = false;
            this.txtQD3.Location = new System.Drawing.Point(282, 224);
            this.txtQD3.Name = "txtQD3";
            this.txtQD3.Size = new System.Drawing.Size(127, 26);
            this.txtQD3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "****************************************************";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(233, 284);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(85, 32);
            this.btnThayDoi.TabIndex = 5;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(324, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThayDoiQD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 325);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQD3);
            this.Controls.Add(this.txtQD2);
            this.Controls.Add(this.txtQD1);
            this.Controls.Add(this.txtBaomat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmThayDoiQD";
            this.Text = "Sửa Thông Tin Phân Quyền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBaomat;
        private System.Windows.Forms.TextBox txtQD1;
        private System.Windows.Forms.TextBox txtQD2;
        private System.Windows.Forms.TextBox txtQD3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnThoat;
    }
}