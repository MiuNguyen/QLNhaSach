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
    public partial class frmCHTD : Form
    {
        public frmCHTD()
        {
            InitializeComponent();
        }

        private void frmCHTD_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaSach frm = new frmQuanLyNhaSach();
            frm.Show();
            this.Hide();
        }

        private void btnQVQL_Click(object sender, EventArgs e)
        {
            frmQLHD frm = new frmQLHD();
            frm.Show();
            this.Hide();
        }

        private void btnQVHD_Click(object sender, EventArgs e)
        {
            frmThemHD frm = new frmThemHD();
            frm.Show();
            this.Hide();
        }
    }
}
