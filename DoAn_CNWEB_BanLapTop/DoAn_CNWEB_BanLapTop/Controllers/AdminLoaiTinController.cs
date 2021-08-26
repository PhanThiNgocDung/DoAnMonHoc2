using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class AdminLoaiTinController : Controller
    {
        //
        // GET: /AdminLoaiTin/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult LoaiTin()
        {
            return View(ql.LoaiTinTucs.ToList());
        }
        public ActionResult hieThiTenTin()
        {
            return View(ql.LoaiTinTucs.ToList());
        }
        //Thêm
        public ActionResult ThemLoaiTin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemLoaiTin(Loai loai)
        {
            if (ModelState.IsValid)
            {
                ql.Loais.InsertOnSubmit(loai);
                ql.SubmitChanges();
                return RedirectToAction("LoaiTin", "AdminLoaiTin");
            }
            return View(loai);
        }
        //cập nhập


        public ActionResult ChinhSuaLoaiTin(int id = 0)
        {
            LoaiTinTuc loai = ql.LoaiTinTucs.Single(d => d.MaLoaiTin == id);
            if (loai == null)
            {
                return HttpNotFound();
            }
            return View(loai);
        }
        [HttpPost]
        public ActionResult ChinhSuaLoaiTin(LoaiTinTuc loai)
        {
            if (ModelState.IsValid)
            {
                    ql.LoaiTinTucs.Attach(loai);
                    //ql.Entry(loai).State = System.Data.EntityState.Modified;
                    ql.SubmitChanges();
                return RedirectToAction("LoaiTin", "AdminLoaiTin");
            }
            return View(loai);
        }
        //Xóa
        public ActionResult XoaLoaiTin(int id = 0)
        {
            LoaiTinTuc sp = ql.LoaiTinTucs.Single(d => d.MaLoaiTin == id);
            if (sp == null) return HttpNotFound();
            return View(sp);
        }

        [HttpPost, ActionName("XoaLoaiTin")]
        public ActionResult DeleteSPConfirm(int id = 0)
        {
            LoaiTinTuc sp = ql.LoaiTinTucs.Single(d => d.MaLoaiTin == id);
            if (sp == null) return HttpNotFound();
            ql.LoaiTinTucs.DeleteOnSubmit(sp);
            ql.SubmitChanges();
            return RedirectToAction("LoaiTin", "AdminLoaiTin");
        }

    }
}
