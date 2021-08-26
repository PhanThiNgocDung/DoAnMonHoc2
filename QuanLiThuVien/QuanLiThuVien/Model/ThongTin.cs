using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Model
{
    public class ThongTin
    {
        private int tuoi;
        private string theloai;

        public ThongTin() { }

        public int Tuoi
        {
            get
            {
                return tuoi;
            }

            set
            {
                tuoi = value;
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

        public ThongTin(int tuoi, string theloai)
        {
            this.tuoi = tuoi;
            this.theloai = theloai;
        }
    }
}
