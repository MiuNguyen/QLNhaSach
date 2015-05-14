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
    public class BUS_tblSach
    {
        SQL_tblSach sql = new SQL_tblSach();

        //ham them du lieu
        public void ThemDuLieu(E_tblSach et)
        {
            sql.ThemDuLieu(et);
        }

        //ham sua du lieu
        public void SuaDuLieu(E_tblSach et)
        {
            sql.SuaDuLieu(et);
        }

        //ham xoa du lieu
        public void XoaDuLieu(E_tblSach et)
        {
            sql.XoaDuLieu(et);
        }

        //ham lay du lieu
        public DataTable TimMASACH(string DieuKien)
        {
            return sql.TimMASACH(DieuKien);
        }

        public DataTable TimTENSACH(string DieuKien)
        {
            return sql.TimTENSACH(DieuKien);
        }

        public DataTable TimTHELOAI(string DieuKien)
        {
            return sql.TimTHELOAI(DieuKien);
        }

        public DataTable TimTACGIA(string DieuKien)
        {
            return sql.TimTACGIA(DieuKien);
        }
    }
}
