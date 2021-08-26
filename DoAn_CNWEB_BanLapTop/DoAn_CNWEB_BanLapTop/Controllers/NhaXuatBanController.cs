using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;
namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class NhaXuatBanController : Controller
    {
        //
        // GET: /NhaXuatBan/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult NhaSanXuatProduct()
        {
            return View(ql.NhaSanXuats.OrderBy(cd => cd.TenNSX).ToList());
        }
        public ViewResult HienSPTheoNXB(int maNXB)
        {
            var hienSP = ql.SanPhams.Where(s => s.MaNSX == maNXB).OrderBy(cd => cd.Gia).ToList();
            if (hienSP.Count == 0)
            {
                ViewBag.Loai = "Máy tính loại NXB này của hàng chúng tôi đã hết!";
            }
            return View(hienSP);
        }
    }
}
