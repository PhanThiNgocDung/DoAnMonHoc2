using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;
namespace BLL_DAL
{
  public  class Class_NhanVien
    {
      NHANVIENTableAdapter da = new NHANVIENTableAdapter();
      public void ThemNhanVien(string manv, string tennv, DateTime? ngaysinh, string sdt, string email, string diachi, string mk, string hinh)
      {
          da.Insert(manv, tennv, ngaysinh, sdt, email, diachi, mk, hinh);
      }
      public int? layMaNV()
      {
          return da.LayMaNV();
      }
      public bool kiemtratontaiNV(string s)
      {
          if (da.KTTonTaiNV(s) > 0)
          {
              return true;
          }
          return false;
      }
      public void XoaNhanVien(string masv)
      {
          da.xoaNV(masv);
      }

      public void CapNhat(string tennv, string ngaysinh, string sdt, string email, string diachi, string mk, string hinh, string manv)
      {
          da.SuaNV(tennv, ngaysinh, sdt, email, diachi, mk, hinh, manv);
      }
    }
}
