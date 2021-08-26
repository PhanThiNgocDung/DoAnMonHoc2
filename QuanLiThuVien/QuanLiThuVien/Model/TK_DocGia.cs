using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Model
{
    public class TK_DocGia
    {
        private string madg, matkhau;

        public TK_DocGia() { }

        public TK_DocGia(string madg, string matkhau)
        {
            this.madg = madg;
            this.matkhau = matkhau;
        }

        public string Madg
        {
            get
            {
                return madg;
            }

            set
            {
                madg = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }
    }
}
