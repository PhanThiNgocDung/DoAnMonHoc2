using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class NguoiDungController : Controller
    {
        //
        // GET: /NguoiDung/

        public ActionResult Index()
        {
            return View();
        }
     
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(KhachHang kh, FormCollection f)
        {
            //Gán các giá trị người dùng nhập từ form f cho các biến
            var hoTen = f["HoTen"];
            var tenDN = f["TenDN"];
            var matKhau = f["MatKhau"];
            var reMatKhau = f["ReMatKhau"];
            var dienThoai = f["DienThoai"];
            var ngaySinh = String.Format("{0:MM/DD/YYYY}", f["NgaySinh"]);
            var gioiTinh = f["GioiTinh"];
            var email = f["Email"];
            var diaChi = f["DiaChi"];

            if (String.IsNullOrEmpty(hoTen))
            {
                ViewData["Loi1"] = "Họ tên không được bỏ trống";
            }
            if (String.IsNullOrEmpty(tenDN))
            {
                ViewData["Loi2"] = "Tên đăng nhập không được bỏ trống";
            }
            if (String.IsNullOrEmpty(matKhau))
            {
                ViewData["Loi3"] = "mật khẩu không được bỏ trống";
            }
            if (String.IsNullOrEmpty(reMatKhau))
            {
                ViewData["Loi4"] = " không được bỏ trống";
            }
            if (String.IsNullOrEmpty(dienThoai))
            {
                ViewData["Loi5"] = "SDT không được bỏ trống";
            }
            if (String.IsNullOrEmpty(ngaySinh))
            {
                ViewData["Loi6"] = "ngày sinh không được bỏ trống";
            }
            if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi7"] = "Email không được bỏ trống";
            }
            if (!String.IsNullOrEmpty(hoTen) && !String.IsNullOrEmpty(tenDN) && !String.IsNullOrEmpty(matKhau) && !String.IsNullOrEmpty(reMatKhau) && !String.IsNullOrEmpty(dienThoai)  && !String.IsNullOrEmpty(email))
            {
                KhachHang kh1 = ql.KhachHangs.SingleOrDefault(c => c.MaKhachHang == tenDN);
                Admin ad = ql.Admins.SingleOrDefault(c => c.TenTaiKhoan == tenDN);
               if (kh1 != null || ad != null)
               {
                     ViewBag.TB = "Tài khoản đã tồn tại (^-^)";
                 }
                 else
                 {
                     //Gán đối tượng    
                     kh.MaKhachHang = tenDN;
                     kh.TenKhachHang = hoTen;
                     kh.MatKhau = matKhau;
                     kh.DienThoai = dienThoai;
                     kh.NgaySinh = DateTime.Parse(ngaySinh);
                     kh.DiaChi = diaChi;
                     kh.Email = email;
                     kh.GioiTinh = gioiTinh;
                     //Ghi xuống CSDL
                     ql.KhachHangs.InsertOnSubmit(kh);
                     ql.SubmitChanges();
                     return RedirectToAction("SanPham", "Product");
                 }
            }
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap( FormCollection f)
        {
            var tenDN = f["TenDN"];
            var matKhau = f["MatKhau"];
            if (String.IsNullOrEmpty(tenDN))
            {
                ViewData["Loi1"] = "Tên đăng nhập không bỏ trống";
            }
            if (String.IsNullOrEmpty(matKhau))
            {
                ViewData["Loi2"] = "Vui lòng nhập mật khẩu";
            }
            if (!String.IsNullOrEmpty(tenDN) && !String.IsNullOrEmpty(matKhau))
            {
                KhachHang kh1 = ql.KhachHangs.SingleOrDefault(c => c.MaKhachHang == tenDN && c.MatKhau == matKhau);
                Admin ad = ql.Admins.SingleOrDefault(c => c.TenTaiKhoan == tenDN && c.MatKhau == matKhau);
                if (kh1 != null)
                {
                    ViewBag.TB = "Đăng nhập thành công";
                    Session["taiKhoan"] = kh1;
                    Session["tenTaiKhoan"] = kh1.TenKhachHang;
                    return RedirectToAction("GioHang", "GioHang");
                }
                else if( ad != null)
                {
                    ViewBag.TB = "Đăng nhập thành công";
                    Session["taiKhoan"] = ad;
                    Session["tenTaiKhoan"] = "Chủ cửa hàng: "+ ad.HoTen;
                    return RedirectToAction("SanPham", "AdminSP");
                }
                else
                {
                    ViewBag.TB = "Sai tên DN hoặc mật khẩu";
                }
            }
            return View();
        }
        public ActionResult DangXuat()
        {
            if (Session["TaiKhoan"] != null) {

                Session["TaiKhoan"] = null;
                return RedirectToAction("SanPham", "Product");
            }
            return RedirectToAction("SanPham", "Product");
        }

    }
}
