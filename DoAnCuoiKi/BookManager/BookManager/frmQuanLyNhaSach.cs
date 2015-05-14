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
    public partial class frmQuanLyNhaSach : Form
    {
        public frmQuanLyNhaSach()
        {
            InitializeComponent();
        }

        private void TimSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimSach frm = new frmTimSach();
            frm.Show();
            this.Hide();
        }

        private void ThemSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemSach frm = new frmThemSach();
            frm.Show();
            this.Hide();
        }

        private void SuaXoaSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSach frm = new frmQLSach();
            frm.Show();
            this.Hide();

        }

        private void TimKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKH frm = new frmTimKH();
            frm.Show();
            this.Hide();
        }

        private void ThemKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemKH frm = new frmThemKH();
            frm.Show();
            this.Hide();
        }

        private void SuaXoaKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKH frm = new frmQLKH();
            frm.Show();
            this.Hide();
        }

        private void ThemHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemHD frm = new frmThemHD();
            frm.Show();
            this.Hide();
        }

        private void SuaXoaHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHD frm = new frmQLHD();
            frm.Show();
            this.Hide();
        }

        private void TTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            frm.Show();
            this.Hide();
        }

        private void SuaPQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiQD frm = new frmThayDoiQD();
            frm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThemSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemSach frm = new frmThemSach();
            frm.Show();
            this.Hide();
        }

        private void ThemKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemKH frm = new frmThemKH();
            frm.Show();
            this.Hide();
        }

        private void qlSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSach frm = new frmQLSach();
            frm.Show();
            this.Hide();
        }

        private void qlKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKH frm = new frmQLKH();
            frm.Show();
            this.Hide();
        }

        private void ThemHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemHD frm = new frmThemHD();
            frm.Show();
            this.Hide();
        }

        private void qlHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHD frm = new frmQLHD();
            frm.Show();
            this.Hide();
        }

        private void tcSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimSach frm = new frmTimSach();
            frm.Show();
            this.Hide();
        }

        private void tcKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKH frm = new frmTimKH();
            frm.Show();
            this.Hide();
        }

        private void ThayDoiQDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiQD frm = new frmThayDoiQD();
            frm.Show();
            this.Hide();
        }

        private void tcHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimHD frm = new frmTimHD();
            frm.Show();
            this.Hide();
        }

        private void GTPMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu();
            frm.Show();
            this.Hide();
        }

        private void QuyDinhPQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            frm.Show();
            this.Hide();
        }
    }
}
