using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViecLamViecNam.Models;

namespace ViecLamViecNam.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        ModelCty dbc = new ModelCty();
        public ActionResult MainDocument()
        {
            //1910:Phiếu Đăng Ký Tham Gia Sàn
            var model = dbc.VBPQ_TaiLieu.Where(t => t.PortalId == 81 && t.LoaiTaiLieuId == 1910)
                                            .Take(10)
                                         .OrderByDescending(t => t.Id)
                                         .ToList();
            Session["TenLoaiTaiLieu"] = dbc.VBPQ_LoaiTaiLieu.FirstOrDefault(p => p.PortalId == 81 && p.Id == 1910).TenLoaiTaiLieu;
            return View(model);
        }
        public ActionResult DocumentCategory()
        {
            var model = dbc.VBPQ_LoaiTaiLieu.Where(p => p.PortalId == 81)
                                            .OrderByDescending(p => p.Id)
                                            .ToList();
            return PartialView(model);
        }
        public ActionResult DocumentByCategory(int Id)
        {
            var model = dbc.VBPQ_TaiLieu.Where(t => t.LoaiTaiLieuId == Id && t.PortalId == 81)
                                         .OrderByDescending(t => t.Id)
                                         .ToList();
            Session["TenLoaiTaiLieu"] = dbc.VBPQ_LoaiTaiLieu.FirstOrDefault(p => p.PortalId == 81 && p.Id == Id).TenLoaiTaiLieu;
            return View("MainDocument", model);
        }
    }
}