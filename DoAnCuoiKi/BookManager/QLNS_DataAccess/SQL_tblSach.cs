using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_Entity;
using System.Data;

namespace QLNS_DataAccess
{
    public class SQL_tblSach
    {
        KetNoiDB cn = new KetNoiDB();

        //ham them du lieu
        public void ThemDuLieu(E_tblSach et)
        {
            cn.ThaoTacSQL(@"INSERT INTO SACH (MASACH, TENSACH, THELOAI, TACGIA, GIA, SOLUONG, NGAYNHAP) VALUES (N'" + et.MASACH + "',N'" + et.TENSACH + "',N'" + et.THELOAI + "',N'" + et.TACGIA + "',N'" + et.GIA + "',N'" + et.SOLUONG + "',N '" + et.NGAYNHAP + "')");
        }

        //ham sua du lieu
        public void SuaDuLieu(E_tblSach et)
        {
            cn.ThaoTacSQL(@"UPDATE SACH SET TENSACH =N'" + et.TENSACH + "', THELOAI =N'" + et.THELOAI + "', TACGIA =N'" + et.TACGIA + "', GIA =N'" + et.GIA + "', SOLUONG =N'" + et.SOLUONG + "', NGAYNHAP =N'" + et.NGAYNHAP + "' Where MASACH = N'" + et.MASACH + "'");
        }

        //ham xoa du lieu
        public void XoaDuLieu(E_tblSach et)
        {
            cn.ThaoTacSQL(@"DELETE from SACH Where MASACH =N'" + et.MASACH + "'");
        }

        //ham lay du lieu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from SACH " + DieuKien);
        }


        public DataTable TimMASACH(string DieuKien)
        {
            return cn.GetDataTable("Select * from SACH where MASACH = '" + DieuKien + "'");
        }

        public DataTable TimTENSACH(string DieuKien)
        {
            return cn.GetDataTable("Select * from SACH where TENSACH = '" + DieuKien + "'");
        }

        public DataTable TimTHELOAI(string DieuKien)
        {
            return cn.GetDataTable("Select * from SACH where THELOAI = '" + DieuKien + "'");
        }

        public DataTable TimTACGIA(string DieuKien)
        {
            return cn.GetDataTable("Select * from SACH where TACGIA = '" + DieuKien + "'");
        }
    }
}
