using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;

namespace BLL_DAL
{
  public  class Class_SuDungDV
    {
        KHACHHANGTableAdapter kh = new KHACHHANGTableAdapter();
        public object tenKhachHang(string sdt)
        {
            return kh.LayTenKH(sdt);
        }
        DICHVUTableAdapter dv = new DICHVUTableAdapter();
        public decimal? layGiaDichVu(string maDV)
        {
            return dv.LayGiaDichVu(maDV);
        }
        SDDICHVUTableAdapter sd = new SDDICHVUTableAdapter();
        public void themSDDICHVu(string mDV, string madaTour, int? soLuong, decimal? thanhTien)
        {
            sd.Insert(mDV, madaTour, soLuong, thanhTien);
        }
      public bool KTKhoaChinh(string maDV,string maTour)
      {
          if (sd.KiemTraKhoaChinh(maDV, maTour) != 0)
          {
              return true;
          }
          return false;
      }
      public void suaDichVu(string maDV, string maTour, int? soLuong, decimal? thanhTien)
      {
          sd.SuaDichVu(soLuong, thanhTien, maDV, maTour);
      }
      public void xoaDichVu(string maDV, string maTour)
      {
          sd.xoaDV(maDV, maTour);
      }
    }
}
