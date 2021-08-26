using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class AdminKhachHangController : Controller
    {
        //
        // GET: /AdminNhanVien/
        
        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult KhachHang()
        {
            return View(ql.KhachHangs.ToList());
        }
        //Xóa
        public ActionResult XoaKhachHang(string id)
        {
            KhachHang sp = ql.KhachHangs.Single(d => d.MaKhachHang == id);
            if (sp == null) return HttpNotFound();
            return View(sp);
        }

        [HttpPost, ActionName("XoaKhachHang")]
        public ActionResult DeleteSPConfirm(string id)
        {
            KhachHang sp = ql.KhachHangs.Single(d => d.MaKhachHang == id);
            if (sp == null) return HttpNotFound();
            ql.KhachHangs.DeleteOnSubmit(sp);
            ql.SubmitChanges();
            return RedirectToAction("KhachHang", "AdminKhachHang");
        }

        public ActionResult ChiTietKhachHang(string id)
        {
            KhachHang sp = ql.KhachHangs.Single(d => d.MaKhachHang == id);
            return View(sp);
        }


    }
}
