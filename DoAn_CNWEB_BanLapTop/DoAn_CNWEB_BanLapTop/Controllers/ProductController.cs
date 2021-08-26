using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult SanPham()
        {
            return View(ql.SanPhams.ToList());
        }
        public ActionResult chiTietSP(int maSP)
        {
            //Lấy ra mã sách:
            SanPham SP = ql.SanPhams.Single(s => s.MaSanPham == maSP);
            if (SP == null)
            {
                return HttpNotFound();
            }
            if (SP.SoLuongTon == 0)
            {
               ViewBag.T = "SẢN PHẨM NÀY ĐÃ HẾT !!";
                return View(SP);
            }
            return View(SP);
        }
       
    }
}
