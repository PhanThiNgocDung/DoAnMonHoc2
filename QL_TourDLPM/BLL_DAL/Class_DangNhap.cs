using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_DAL.qlTourTableAdapters;
namespace BLL_DAL
{
  public  class Class_DangNhap
    {
      NHANVIENTableAdapter nv = new NHANVIENTableAdapter();
      public Boolean kiemTraDangNhap(string tenDN, string matKhau)
      {
          if (nv.KiemTraKT(tenDN, matKhau) != 0)
          {
              return true;
          }
          return false;
      }
      public string layTenNhanVien(string tenDN, string matKhau)
      {
          string s = "";
          s = nv.layTenNV(tenDN, matKhau);
          return s;
      }
    }
}
