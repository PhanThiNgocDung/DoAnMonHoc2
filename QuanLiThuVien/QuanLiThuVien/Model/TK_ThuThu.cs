using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Model
{
    public class TK_ThuThu
    {
        private string matt, matkhau;

        public TK_ThuThu() { }

        public TK_ThuThu(string matt, string matkhau)
        {
            this.matt = matt;
            this.matkhau = matkhau;
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

        public string Matt
        {
            get
            {
                return matt;
            }

            set
            {
                matt = value;
            }
        }
    }
}
