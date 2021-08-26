using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;

namespace BLL_DAL
{
   public class Class_KhachHang
    {
       KHACHHANGTableAdapter da = new KHACHHANGTableAdapter();
       public void themKH(string maKH, string tenKH, DateTime? ngaySinh, string sdt, string email, string diachim, string hinhanh)
       {
           da.Insert(maKH, tenKH, ngaySinh, sdt, email, diachim, hinhanh);
       }
       public int? layMaKH()
       {
           return da.LayMaKH();
       }
       public bool kiemtratontaiKH(string s)
       {
           if (da.KTTonTaiKH(s) > 0)
           {
               return true;
           }
           return false;
       }
       public void DeleteKH(string masv)
       {
           da.xoaKH(masv);
       }

       public void UpdateKH(string tenkh, string ngaysinh, string sdt, string email, string diachi, string hinhanhkh, string makh)
       {
           da.suaKH(tenkh, ngaysinh, sdt, email, diachi, hinhanhkh, makh);
       }
    }
}
