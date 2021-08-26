using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class LoaiSPController : Controller
    {
        //
        // GET: /LoaiSP/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
         public ActionResult LoaiProduct()
        {
            return View(ql.Loais.OrderBy(cd => cd.TenLoai).ToList());
        }
        public ViewResult HienSPTheoLoai(int maLoai)
        {
            var hienSP = ql.SanPhams.Where(s => s.MaLoai == maLoai).OrderBy(cd => cd.Gia).ToList();
            if (hienSP.Count == 0)
            {
                ViewBag.Loai = "Máy tính loại này của hàng chúng tôi đã hết!";
            }
            return View(hienSP);
        }

    }
}
