using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNS_Entity;
using QLNS_DataAccess;

namespace QLNS_Business
{
    public class BUS_tblKhachHang
    {
        SQL_tblKhachHang sql = new SQL_tblKhachHang();

        //ham them du lieu
        public void ThemDuLieu(E_tblKhachHang et)
        {
            sql.ThemDuLieu(et);
        }

        //ham sua du lieu
        public void SuaDuLieu(E_tblKhachHang et)
        {
            sql.SuaDuLieu(et);
        }

        //ham xoa du lieu
        public void XoaDuLieu(E_tblKhachHang et)
        {
            sql.XoaDuLieu(et);
        }

        //ham lay du lieu

        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }

        public DataTable TimMAKH(string DieuKien)
        {
            return sql.TimMAKH(DieuKien);
        }

        public DataTable TimTENKH(string DieuKien)
        {
            return sql.TimTENKH(DieuKien);
        }

        public DataTable TimSDT(int DieuKien)
        {
            return sql.TimSDT(DieuKien);
        }
    }
}
