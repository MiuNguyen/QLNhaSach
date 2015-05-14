using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_Entity;
using System.Data;

namespace QLNS_DataAccess
{
    public class SQL_tblCTHD
    {
        KetNoiDB cn = new KetNoiDB();

        public int KiemTra(string mahd, string masach)
        {
            return int.Parse(cn.GetValue("Select count(*) from CTHD where MAHD =N'" + mahd + "' And MASACH =N'" + masach + "'"));
        }

        public void ThemDuLieu(E_tblCTHD et)
        {
            cn.ThaoTacSQL("INSERT INTO CTHD (MAHD, MASACH, SL, DONGIA, THANHTIEN) VALUES (N'" + et.MAHD + "',N'" + et.MASACH + "','" + et.SL + "','" + et.DONGIA + "',(" + et.SL + "*" + et.DONGIA + "))");
        }

        public void SuaDuLieu(E_tblCTHD et)
        {
            cn.ThaoTacSQL("UPDATE CTHD SET SL ='" + et.SL + "', DONGIA ='" + et.DONGIA + "', THANHTIEN = (" + et.SL + "*" + et.DONGIA + ") WHERE MAHD = N'" + et.MAHD + "' And MASACH = N'" + et.MASACH + "'");
        }

        public void XoaDuLieu(E_tblCTHD et)
        {
            cn.ThaoTacSQL("DELETE from CTHD WHERE MAHD = N'" + et.MAHD + "' And MASACH =N'" + et.MASACH + "'");
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from CTHD " + DieuKien);
        }

        public DataTable TimMAHD(string DieuKien)
        {
            return cn.GetDataTable("Select * from CTHD where MAHD = '" + DieuKien + "'");
        }
    }
}
