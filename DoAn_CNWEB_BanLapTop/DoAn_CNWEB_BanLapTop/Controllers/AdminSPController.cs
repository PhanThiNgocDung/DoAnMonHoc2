using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class AdminSPController : Controller
    {
        //
        // GET: /Admin/
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult SanPham()
        {
             return View(ql.SanPhams.ToList());
        }
        //Thêm sản phẩm
        public ActionResult TaoSP()
        {
            //Lấy dữ liệu cho dropdown list
            ViewBag.MaLoai = new SelectList(ql.Loais, "MaLoai", "TenLoai");
            ViewBag.MaNSX = new SelectList(ql.NhaSanXuats, "MaNSX", "TenNSX");
            return View();
        }
        [HttpPost]
        public ActionResult TaoSP(SanPham sp)
        {
            if (ModelState.IsValid)
            {
                ql.SanPhams.InsertOnSubmit(sp);
                ql.SubmitChanges();
                return RedirectToAction("SanPham", "AdminSP");
            }
            return View(sp);
        }
        //Chỉnh sửa
        public ActionResult ChinhSuaSP(int id = 0)
        {
            SanPham sp = ql.SanPhams.Single(d => d.MaSanPham == id);
            if (sp == null)
            {
                return HttpNotFound();
            }
            return View(sp);
        }
        [HttpPost]
        public ActionResult ChinhSuaSP(int id, FormCollection f)
        {
            SanPham sp = ql.SanPhams.Single(d => d.MaSanPham == id);
            if (sp != null)
            {
                View(sp);
                sp.SoLuongTon = int.Parse(f["txt_SoLuong"].ToString());
                sp.Gia = int.Parse(f["Gia"].ToString());
                ql.SubmitChanges();
                return RedirectToAction("SanPham", "AdminSP");
            }
            return View(sp);
        }

        //Xóa
        public ActionResult XoaSP(int id = 0)
        {
            SanPham sp = ql.SanPhams.Single(d => d.MaSanPham == id);
            MoTa mt = ql.MoTas.Single(d => d.MaSanPham == id);
            if (sp == null && mt == null) return HttpNotFound();
            return View(sp);
        }

        [HttpPost, ActionName("XoaSP")]
        public ActionResult DeleteSPConfirm(int id = 0)
        {
            SanPham sp = ql.SanPhams.Single(d => d.MaSanPham == id);
            MoTa mt = ql.MoTas.Single(d => d.MaSanPham == id);
            if (sp == null && mt == null) return HttpNotFound();
            ql.SanPhams.DeleteOnSubmit(sp);
            ql.MoTas.DeleteOnSubmit(mt);
            ql.SubmitChanges();
            return RedirectToAction("SanPham", "AdminSP");
        }

        public ActionResult ChiTietSP(int id = 0)
        {
            SanPham sp = ql.SanPhams.Single(d => d.MaSanPham == id);
            return View(sp);
        }
    }
}
