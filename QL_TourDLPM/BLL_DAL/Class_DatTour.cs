using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;

namespace BLL_DAL
{
   public class Class_DatTour
    {
       KHACHHANGTableAdapter kh = new KHACHHANGTableAdapter();
       public object tenKhachHang(string sdt)
       {
           return kh.LayTenKH(sdt);
       }
       DATTOURTableAdapter dt = new DATTOURTableAdapter();
       public int? laymaDatTour()
       {
           return dt.LayMaDatTour();
       }
       public bool LuuTour(string maDTour, string maTour, string maKS, string maKH, string maHDV, string maNV, int? sLTreem, int? slNgLOn, DateTime? ngayDatTour, decimal? giaTour, decimal? thanhTien)
       {
           if (slNgLOn > 0)
           {
               dt.Insert(maDTour, maTour, null, maKS, maKH, maHDV, maNV, slNgLOn, sLTreem, giaTour , thanhTien, ngayDatTour);
               return true;
           }
           else
           {
               return false;
           }
       }
    }
}
