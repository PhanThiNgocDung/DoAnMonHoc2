using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class AdminTinTucController : Controller
    {
        //
        // GET: /AdminTinTuc/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult TinTuc()
        {
            return View(ql.TinTucs.ToList());
        }
        public ActionResult TinTucTheoMa(int id = 0)
        {
            var listSP = ql.TinTucs.Where(loai => loai.MaLoaiTin == id).ToList();
            return View(listSP);
        }
        //Thêm sản phẩm
        public ActionResult TaoTinTuc()
        {
            //Lấy dữ liệu cho dropdown list
            ViewBag.MaLoai = new SelectList(ql.LoaiTinTucs, "MaLoaiTin", "TenLoaiTin");
            return View();
        }
        [HttpPost]
        public ActionResult TaoTinTuc(TinTuc sp)
        {
            if (ModelState.IsValid)
            {
                ql.TinTucs.InsertOnSubmit(sp);
                ql.SubmitChanges();
                return RedirectToAction("TinTuc", "AdminTinTuc");
            }
            return View(sp);
        }
        //Chỉnh sửa
        public ActionResult ChinhSuaTinTuc(int id = 0)
        {
            TinTuc sp = ql.TinTucs.Single(d => d.MaLoaiTin == id);
            if (sp == null)
            {
                return HttpNotFound();
            }
            return View(sp);
        }
        [HttpPost]
        public ActionResult ChinhSuaTinTuc(int id, FormCollection f)
        {
            TinTuc sp = ql.TinTucs.Single(d => d.MaTin == id);
            if (sp != null)
            {
                View(sp);
                sp.NgayTao = DateTime.Parse(f["ngayTao"].ToString());
                ql.SubmitChanges();
                return RedirectToAction("TinTuc", "AdminTinTuc");
            }
            return View(sp);
        }

        //Ajax
        public JsonResult Update(TinTuc f)
        {
            int kq = 1;
            try
            {
                TinTuc f1 = ql.TinTucs.FirstOrDefault(m => m.MaTin == f.MaTin);
                f1.TieuDe = f.TieuDe;
                f1.NoiDung = f.NoiDung;
                f1.NgayTao = f.NgayTao;
                UpdateModel(f1);
                ql.SubmitChanges();
            }
            catch
            { kq = 0; }
            return Json(kq, JsonRequestBehavior.AllowGet);
        }
        //Xóa
        public ActionResult XoaTinTuc(int id = 0)
        {
            TinTuc sp = ql.TinTucs.Single(d => d.MaTin == id);
            if (sp == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(sp);
            }
        }

        [HttpPost, ActionName("XoaTinTuc")]
        public ActionResult DeleteSPConfirm(int id = 0)
        {
            TinTuc sp = ql.TinTucs.Single(d => d.MaTin == id);
            if (sp == null) return HttpNotFound();
            ql.TinTucs.DeleteOnSubmit(sp);
            ql.SubmitChanges();
            return RedirectToAction("TinTuc", "AdminTinTuc");
        }
    }
}
