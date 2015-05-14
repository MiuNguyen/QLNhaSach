using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                frmQuanLyNhaSach frm = new frmQuanLyNhaSach();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }

        /*private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "admin" && txtMatKhau.Text != "admin")
            {
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            else
            { 
                if (txtTaiKhoan.Text != "admin")
                    txtTaiKhoan.Clear();
                else
                    txtMatKhau.Clear();
            }
        }*/

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
