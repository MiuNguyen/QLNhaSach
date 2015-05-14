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
    public partial class frmSuaCTHD : Form
    {
        public frmSuaCTHD()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaSach frm = new frmQuanLyNhaSach();
            frm.Show();
            this.Hide();
        }

        private void btnQVQLHD_Click(object sender, EventArgs e)
        {
            frmQLHD frm = new frmQLHD();
            frm.Show();
            this.Hide();
        }
    }
}
