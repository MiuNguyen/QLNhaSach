using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNS_DataAccess
{
    public class KetNoiDB
    {
        public static SqlConnection connect;

        //Mo ket noi voi Database
        public void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
            {
                KetNoiDB.connect = new SqlConnection("Data Source=Miu-PC\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=SSPI;");
            }
            if (KetNoiDB.connect.State != ConnectionState.Open)
            {
                KetNoiDB.connect.Open();
            }
        }

        //Dong ket noi voi Database
        public void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
            }
        }

        //Ham them ,sua, xoa
        public void ThaoTacSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery(); // ExecuteNonQuery khong tra ve
                DongKetNoi();
            }
            catch
            {
                //thong bao loi;
            }
        }

        //su dung cau lenh Select va tra ve Table
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //su dung cau lenh Select va tra ve gia tri Value
        public string GetValue(string strSQL)
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;

        }
    }
}
