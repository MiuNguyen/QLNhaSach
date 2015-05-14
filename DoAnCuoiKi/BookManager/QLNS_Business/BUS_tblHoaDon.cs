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
    public class BUS_tblHoaDon
    {
        SQL_tblHoaDon sql = new SQL_tblHoaDon();

        public void ThemDuLieu(E_tblHoaDon et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(E_tblHoaDon et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(E_tblHoaDon et)
        {
            sql.XoaDuLieu(et);
        }

        public DataTable TimMAHD(string DieuKien)
        {
            return sql.TimMAHD(DieuKien);
        }
    }
}
