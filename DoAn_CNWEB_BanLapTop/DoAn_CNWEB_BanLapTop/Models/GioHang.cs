using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_CNWEB_BanLapTop.Models
{
    public class GioHang
    {
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public int iMaSP { set; get; }
        public string sTenSP { set; get; }
        public string sAnhBia { set; get; }
        public double dGia { set; get; }
        public int iSoLuong { set; get; }
        public double dThanhTien
        {
            get { return iSoLuong * dGia; }
        }
        //Khởi tạo giỏ hàng
        public GioHang(int MaSanPham)
        {
            iMaSP = MaSanPham;
            SanPham Sp = ql.SanPhams.Single(s => s.MaSanPham == iMaSP);
            sTenSP = Sp.TenSanPham;
            sAnhBia = Sp.AnhBia;
            dGia = double.Parse(Sp.Gia.ToString());
            iSoLuong = 1;
        }
    }
}