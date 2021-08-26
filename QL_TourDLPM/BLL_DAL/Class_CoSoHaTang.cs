using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;

namespace BLL_DAL
{
  public  class Class_CoSoHaTang
    {
        DICHVUTableAdapter dv = new DICHVUTableAdapter();
        public void themDV(string madv, string tendv, decimal? gia)
        {
            dv.Insert(madv, tendv, gia);
        }

        public void xoaDV(string masv)
        {
            dv.XoaDV(masv);
        }

        public void suaDV(string tendv, decimal? gia, string madv)
        {
            dv.SuaDV(tendv, gia, madv);
        }

        public int? TaoMaDV()
        {
            return dv.LayMaDV();
        }
        public bool kiemtratonDV(string ma)
        {
            if (dv.KTTonTai(ma) > 0)
            {
                return true;
            }
            return false;
        }
        KHACHSANTableAdapter da = new KHACHSANTableAdapter();

     

        public int? LayMaKhachSan()
        {
            return da.LayMaKS();
        }

        public void ThemKhachSan(string maks, string tenks, Decimal? gia, string hinh)
        {
            da.Insert(maks, tenks, gia, hinh);
        }

        public void Xoa(string maks)
        {
            da.XoaKS(maks);
        }

        public void CapNhat(string tenks, Decimal? gia, string hinh, string maks)
        {
            da.SuaKS(tenks, gia, hinh, maks);
        }
        public bool kiemtraton(string ma)
        {
            if (da.KTTonTaiKS(ma) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
