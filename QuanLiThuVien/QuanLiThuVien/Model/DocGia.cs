using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Model
{
    public class DocGia
    {
        private string madg, tendg, gioitinh, diachi, ngaybd, ngaykt, phicoc;

        public DocGia() { }

        public DocGia(string madg, string tendg, string gioitinh, string diachi, string ngaybd, string ngaykt, string phicoc)
        {
            this.madg = madg;
            this.tendg = tendg;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.phicoc = phicoc;
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
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

        public string Ngaybd
        {
            get
            {
                return ngaybd;
            }

            set
            {
                ngaybd = value;
            }
        }

        public string Ngaykt
        {
            get
            {
                return ngaykt;
            }

            set
            {
                ngaykt = value;
            }
        }

        public string Phicoc
        {
            get
            {
                return phicoc;
            }

            set
            {
                phicoc = value;
            }
        }

        public string Tendg
        {
            get
            {
                return tendg;
            }

            set
            {
                tendg = value;
            }
        }
    }
}
