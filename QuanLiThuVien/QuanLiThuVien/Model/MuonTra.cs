using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Model
{
    public class MuonTra
    {
        private string mamt, madg, matt, mash, ngaymuon,tinhtrang, ngaytradukien, ngaytrathucte;

        public MuonTra()
        { }

        public MuonTra(string mamt, string madg, string matt, string mash, string ngaymuon, string tinhtrang, string ngaytradukien, string ngaytrathucte)
        {
            this.mamt = mamt;
            this.madg = madg;
            this.matt = matt;
            this.mash = mash;
            this.ngaymuon = ngaymuon;
            this.tinhtrang = tinhtrang;
            this.ngaytradukien = ngaytradukien;
            this.ngaytrathucte = ngaytrathucte;
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

        public string Mamt
        {
            get
            {
                return mamt;
            }

            set
            {
                mamt = value;
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

        public string Ngaymuon
        {
            get
            {
                return ngaymuon;
            }

            set
            {
                ngaymuon = value;
            }
        }

        public string Ngaytradukien
        {
            get
            {
                return ngaytradukien;
            }

            set
            {
                ngaytradukien = value;
            }
        }

        public string Ngaytrathucte
        {
            get
            {
                return ngaytrathucte;
            }

            set
            {
                ngaytrathucte = value;
            }
        }

        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }
    }
}
