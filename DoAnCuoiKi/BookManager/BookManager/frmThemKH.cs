using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS_Business;
using QLNS_Entity;
using QLNS_DataAccess;

namespace BookManager
{
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
            HienThi("");
            Set_Null();
        }

        BUS_tblKhachHang bus = new BUS_tblKhachHang();
        E_tblKhachHang ent = new E_tblKhachHang();

        void Set_Null()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDC.Clear();
            txtTienNo.Text = "0";
        }

        void HienThi(string where)
        {
            ViewKH.DataSource = bus.TaoBang(where);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chưa có mã khách hàng! Không thể thêm");
                return;
            }
            try
            {
              
                ent.MAKH = txtMaKH.Text;
                ent.TENKH = txtTenKH.Text;
                ent.SDT = txtSDT.Text;
                ent.DIACHI = txtDC.Text;
                ent.TIENNO = txtTienNo.Text;
                bus.ThemDuLieu(ent);
                MessageBox.Show("Đã thêm thành công!");
                HienThi("");
                Set_Null();
            }
            catch
            {
                MessageBox.Show("Lỗi! Không thể thêm");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaSach frm = new frmQuanLyNhaSach();
            frm.Show();
            this.Close();
        }

        private void ViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = ViewKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTienNo.Text = ViewKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenKH.Text = ViewKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDC.Text = ViewKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = ViewKH.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch 
            {
            }
        }

    }
}
