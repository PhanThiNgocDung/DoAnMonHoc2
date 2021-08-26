using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;

namespace BLL_DAL
{
   public class Class_ThanhToan
    {
       SDDICHVUTableAdapter sd = new SDDICHVUTableAdapter();
       DATTOURTableAdapter dt = new DATTOURTableAdapter();
       public decimal? tongTien(string maDatTour)
       {
           decimal? tiendichvu = sd.tongTienDichVu(maDatTour);
           decimal? tongTienDatTour = dt.LayThanhTien(maDatTour);
           if (tiendichvu == null)
           {
               tiendichvu = 0;
           }
           return tiendichvu + tongTienDatTour;
       }
       public decimal? tienDatTour(string maDatTour)
       {
           decimal? tongTienDatTour = dt.LayThanhTien(maDatTour);
           return tongTienDatTour;
       }
       THANHTOANTableAdapter tt = new THANHTOANTableAdapter();
       public int? layMaThanhToan()
       {
           return tt.LayMaThanhToan();
       }
       public void themMaThanhToan(string maTT, string maTour, DateTime ngayThanhToan, string hinhthuc, decimal? tienconlai, decimal? tienthanhtoan, decimal? thanhTien, string ghichu)
       {
           tt.Insert(maTT, maTour, ngayThanhToan, thanhTien, hinhthuc, tienconlai, tienthanhtoan, ghichu);
       }
       public bool soLanThanhToan(string maDatTour)
       {
           if (tt.soLanThanhToan(maDatTour) == 0)
           {
               return true;
           }
           return false;
       }
    }
}
