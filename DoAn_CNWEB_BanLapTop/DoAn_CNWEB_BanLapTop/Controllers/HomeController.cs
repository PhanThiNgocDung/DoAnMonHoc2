using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        QL_LapTopDataContext ql = new QL_LapTopDataContext();

        public ActionResult timkiem(FormCollection f)
        {
            var lst = ql.SanPhams.Where(s => s.TenSanPham.Contains(f["TuKhoaTimKiem"].ToString())).ToList();
            return View(lst);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeThongSieuThi()
        {
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult ds()
        {
            return Content("HEKKKKKK");
        }
        [HttpGet]
        public ActionResult lienHe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult lienHe(LienHe kh, FormCollection f)
        {
            //Gán các giá trị người dùng nhập từ form f cho các biến
            var tenDN = f["TenDN"];
            var hinhanh = f["HinhAnh"];
            var noidung = f["NoiDung"];
            if (String.IsNullOrEmpty(tenDN))
            {
                ViewData["Loi1"] = "Tên đăng nhập không được bỏ trống";
            }
            if (String.IsNullOrEmpty(hinhanh))
            {
                ViewData["Loi2"] = "Hình ảnh không được bỏ trống";
            }
            if (String.IsNullOrEmpty(noidung))
            {
                ViewData["Loi3"] = "Nội dung không được bỏ trống";
            }
            if (!String.IsNullOrEmpty(tenDN) && !String.IsNullOrEmpty(hinhanh) && !String.IsNullOrEmpty(noidung))
            {
                    //Gán đối tượng    
                    kh.MaKhachHang = tenDN;
                    kh.AnhMoTa = hinhanh;
                    kh.NoiDung = noidung;
                    //Ghi xuống CSDL
                    ql.LienHes.InsertOnSubmit(kh);
                    ql.SubmitChanges();
                    return RedirectToAction("Thongbao", "Home");
            }
            return View();
        }
        public ActionResult Thongbao()
        {
            return View();
        }

    }
}
