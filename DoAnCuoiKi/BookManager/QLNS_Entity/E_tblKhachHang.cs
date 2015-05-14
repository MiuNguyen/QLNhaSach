using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Entity
{
    public class E_tblKhachHang
    {
        private string _MAKH;

        public string MAKH
        {
            get { return _MAKH; }
            set { _MAKH = value; }
        }
        private string _TENKH;

        public string TENKH
        {
            get { return _TENKH; }
            set { _TENKH = value; }
        }
        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _TIENNO;

        public string TIENNO
        {
            get { return _TIENNO; }
            set { _TIENNO = value; }
        }
    }
}
