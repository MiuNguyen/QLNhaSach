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
    public partial class frmThemHD : Form
    {
        public frmThemHD()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaSach frm = new frmQuanLyNhaSach();
            frm.Show();
            this.Close();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            frmCHTD frm = new frmCHTD();
            frm.Show();
            this.Hide();
        }
    }
}
