using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class AdminLoaiController : Controller
    {
        //
        // GET: /AdminLoai/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult Loai()
        {
            return View(ql.Loais.ToList());
        }
       //Thêm
        public ActionResult ThemLoai()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemLoai(Loai loai)
        {
            if (ModelState.IsValid)
            {
                ql.Loais.InsertOnSubmit(loai);
                ql.SubmitChanges();
                return RedirectToAction("Loai", "AdminLoai");
            }
            return View(loai);
        }
        //cập nhập


        public ActionResult ChinhSuaLoai(int id = 0)
        {
            Loai loai = ql.Loais.Single(d => d.MaLoai == id);
            if (loai == null)
            {
                return HttpNotFound();
            }
            return View(loai);
        }
        [HttpPost]
        public ActionResult ChinhSuaLoai(Loai loai)
        {
            if (ModelState.IsValid)
            {
                ql.Loais.Attach(loai);
                //ql.Entry(loai).State = System.Data.EntityState.Modified;
                ql.SubmitChanges();
                return RedirectToAction("Loai", "AdminLoai");
            }
            return View(loai);
        }
        //Xóa
        public ActionResult XoaLoai(int id = 0)
        {
            Loai sp = ql.Loais.Single(d => d.MaLoai == id);
            if (sp == null) return HttpNotFound();
            return View(sp);
        }

        [HttpPost, ActionName("XoaLoai")]
        public ActionResult DeleteSPConfirm(int id = 0)
        {
            Loai sp = ql.Loais.Single(d => d.MaLoai == id);
            if (sp == null) return HttpNotFound();
            ql.Loais.DeleteOnSubmit(sp);
            ql.SubmitChanges();
            return RedirectToAction("Loai", "AdminLoai");
        }
    }
}
