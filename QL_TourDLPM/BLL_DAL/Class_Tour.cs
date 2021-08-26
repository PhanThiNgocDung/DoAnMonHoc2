using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;
using System.Data;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class Class_Tour
    {
       TOURTableAdapter ql = new TOURTableAdapter();
       public void ThemTour(string maTour, string tenTour, string phuongtien, string diadiem, string mien, string chauluc, decimal? gia, int? soluong, string thoiLuong, string hinhanh, DateTime? ngayBD, DateTime? ngayKT)
       {
           ql.Insert(maTour, tenTour, phuongtien, diadiem, mien, chauluc, gia, soluong, thoiLuong, hinhanh, ngayBD, ngayKT);
       }
       public int? LayMaTour()
       {
           int? kq = ql.layMaTour();
           return kq;
       }
       public void XoaTour(string s)
       {
           ql.XoaTour(s);
       }
       public void suaTour(string maTour, string tenTour, string phuongtien, string diadiem, string mien, string chauluc, decimal? gia, int? soluong, string thoiLuong, string hinhanh, string ngayBD, string ngayKT)
       {
           ql.SuaTour(tenTour, phuongtien, diadiem, mien, chauluc, gia, soluong, thoiLuong, hinhanh, ngayBD, ngayKT, maTour );
       }
       public int? kTTonTaiTour(string maTour)
       {
           int? kq = ql.KTTonTaiTour(maTour);
           return kq;
       }
    }
}
