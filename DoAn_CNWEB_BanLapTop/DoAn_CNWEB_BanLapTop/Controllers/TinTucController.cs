using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class TinTucController : Controller
    {
        //
        // GET: /TinTuc/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult TinTucProduct()
        {
            return View(ql.LoaiTinTucs.OrderBy(cd => cd.TenLoaiTin).ToList());
        }
        public ActionResult hienThiDSTinTuc(int matin)
        {
            var hienSP = ql.TinTucs.Where(s => s.MaLoaiTin == matin).ToList();
            if (hienSP.Count == 0)
            {
                ViewBag.Loai = "Hiện tại tin tức này trống";
            }
            return View(hienSP);
        }
        public ActionResult hienThiTinTuc()
        {
            var hienSP = ql.TinTucs.ToList();
            return View(hienSP);
        }
        public ActionResult XemChiTietTinTuc(int mt)
        {
            TinTuc tintuc = ql.TinTucs.Single(s => s.MaTin == mt);
            if (tintuc == null)
            {
                return HttpNotFound();
            }
            return View(tintuc);
        }

    }
}
