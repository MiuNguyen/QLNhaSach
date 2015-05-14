using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_Entity;
using System.Data;

namespace QLNS_DataAccess
{
    public class SQL_tblKhachHang
    {
        KetNoiDB cn = new KetNoiDB();

        //ham them du lieu
        public void ThemDuLieu(E_tblKhachHang et)
        {
            cn.ThaoTacSQL(@"INSERT INTO KHACHHANG(MAKH, TENKH, DIACHI, SDT, TIENNO)VALUES(N'" + et.MAKH + "',N'" + et.TENKH + "',N'" + et.DIACHI + "',N'" + et.SDT + "',N'" + et.TIENNO + "')");
        }

        //ham sua du lieu
        public void SuaDuLieu(E_tblKhachHang et)
        {
            cn.ThaoTacSQL(@"UPDATE KHACHHANG SET TENKH =N'" + et.TENKH + "', DIACHI =N'" + et.DIACHI + "', SDT = N'" + et.SDT + "', TIENNO = N'" + et.TIENNO + "' Where MAKH = N'" + et.MAKH + "'");
        }

        //ham xoa du lieu
        public void XoaDuLieu(E_tblKhachHang et)
        {
            cn.ThaoTacSQL(@"DELETE from KHACHHANG Where MAKH = N'" + et.MAKH + "'");
        }

        //ham lay du lieu

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from KHACHHANG " + DieuKien);
        }

        public DataTable TimMAKH(string DieuKien)
        {
            return cn.GetDataTable("Select * from KHACHHANG where MAKH = '" + DieuKien + "'");
        }

        public DataTable TimTENKH(string DieuKien)
        {
            return cn.GetDataTable("Select * from KHACHHANG where TENKH = '" + DieuKien + "'");
        }

        public DataTable TimSDT(int DieuKien)
        {
            return cn.GetDataTable("Select * from KHACHHANG where SDT = " + DieuKien);
        }
    }
}
