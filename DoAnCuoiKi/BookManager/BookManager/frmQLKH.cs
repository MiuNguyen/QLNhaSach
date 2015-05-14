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
using QLNS_DataAccess;
using QLNS_Entity;

namespace BookManager
{
    public partial class frmQLKH : Form
    {
        public frmQLKH()
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
            txtMaKH_Xoa.Clear();
            txtTienNo.Text = "0";
        }

        void HienThi(string where)
        {
           view_XoaKH.DataSource = bus.TaoBang(where);
        }

         private void view_XoaKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = view_XoaKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = view_XoaKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDC.Text = view_XoaKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = view_XoaKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTienNo.Text = view_XoaKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMaKH_Xoa.Text = view_XoaKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

       
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaSach frm = new frmQuanLyNhaSach();
            frm.Show();
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
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
                bus.SuaDuLieu(ent);
                MessageBox.Show("Đã sửa thành công!");
                HienThi("");
                Set_Null();
            }
            catch
            {
                MessageBox.Show("Lỗi! Không thể sửa");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ent.MAKH = txtMaKH_Xoa.Text;
                bus.XoaDuLieu(ent);
                MessageBox.Show("Đã xóa thành công!");
                HienThi("");
                Set_Null();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
        }

       
    }
}
