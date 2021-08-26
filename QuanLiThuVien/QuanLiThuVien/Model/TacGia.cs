using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Model
{
    public class TacGia
    {
        private string matg, tentg, ngaysinh, gioitinh, quequan;

        public TacGia() { }

        public TacGia(string matg, string tentg, string ngaysinh, string gioitinh, string quequan)
        {
            this.matg = matg;
            this.tentg = tentg;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.quequan = quequan;
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Matg
        {
            get
            {
                return matg;
            }

            set
            {
                matg = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Quequan
        {
            get
            {
                return quequan;
            }

            set
            {
                quequan = value;
            }
        }

        public string Tentg
        {
            get
            {
                return tentg;
            }

            set
            {
                tentg = value;
            }
        }
    }
}
