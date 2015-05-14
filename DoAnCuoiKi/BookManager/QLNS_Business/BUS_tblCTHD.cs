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
    public class BUS_tblCTHD
    {
        SQL_tblCTHD sql = new SQL_tblCTHD();

        public void ThemDuLieu(E_tblCTHD et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(E_tblCTHD et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(E_tblCTHD et)
        {
            sql.XoaDuLieu(et);
        }

        public DataTable TimMAHD(string DieuKien)
        {
            return sql.TimMAHD(DieuKien);
        }
    }
}
