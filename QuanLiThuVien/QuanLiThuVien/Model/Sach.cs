using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Model
{
    public class Sach
    {
        private string mash, tensh, matg, soluong, theloai, nhaxuatban, phidenbu, make, ngaynhap, nxb;

        public Sach() { }

        public Sach(string mash, string tensh, string matg, string soluong, string theloai, string nhaxuatban, string phidenbu, string make, string ngaynhap, string nxb)
        {
            this.mash = mash;
            this.tensh = tensh;
            this.matg = matg;
            this.soluong = soluong;
            this.theloai = theloai;
            this.nhaxuatban = nhaxuatban;
            this.phidenbu = phidenbu;
            this.make = make;
            this.ngaynhap = ngaynhap;
            this.nxb = nxb;
        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Mash
        {
            get
            {
                return mash;
            }

            set
            {
                mash = value;
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

        public string Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
            }
        }

        public string Nhaxuatban
        {
            get
            {
                return nhaxuatban;
            }

            set
            {
                nhaxuatban = value;
            }
        }

        public string Nxb
        {
            get
            {
                return nxb;
            }

            set
            {
                nxb = value;
            }
        }

        public string Phidenbu
        {
            get
            {
                return phidenbu;
            }

            set
            {
                phidenbu = value;
            }
        }

        public string Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Tensh
        {
            get
            {
                return tensh;
            }

            set
            {
                tensh = value;
            }
        }

        public string Theloai
        {
            get
            {
                return theloai;
            }

            set
            {
                theloai = value;
            }
        }
    }
}
