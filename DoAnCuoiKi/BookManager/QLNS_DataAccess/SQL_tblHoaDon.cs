using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_Entity;
using System.Data;

namespace QLNS_DataAccess
{
    public class SQL_tblHoaDon
    {
        KetNoiDB cn = new KetNoiDB();

        public void ThemDuLieu(E_tblHoaDon et)
        {
            cn.ThaoTacSQL("INSERT INTO HOADON (MAHD, MAKH, NGAYLAP) VALUES (N'" + et.MAHD + "',N'" + et.MAKH + "','" + et.NGAYLAP + "')");
        }

        public void SuaDuLieu(E_tblHoaDon et)
        {
            cn.ThaoTacSQL("UPDATE HOADON SET MAKH =N'" + et.MAKH + "', NGAYLAP ='" + et.NGAYLAP + "' WHERE MAHD = N'" + et.MAHD + "' ");
        }

        public void XoaDuLieu(E_tblHoaDon et)
        {
            cn.ThaoTacSQL("DELETE from HOADON where MAHD=N'" + et.MAHD + "'");
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from HOADON " + DieuKien);
        }


        public DataTable TimMAHD(string DieuKien)
        {
            return cn.GetDataTable("Select * from HOADON where MAHD = '" + DieuKien + "'");
        }

        public DataTable LayThongTinKH(string DieuKien)
        {
            return cn.GetDataTable("Select MAKH, TENKH form KHACHHANG " + DieuKien);
        }


    }
}
