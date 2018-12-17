using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Raven.Client.Documents.Session;
using RavenDB_Embedded.Models;

namespace RavenDB_Embedded.Controllers
{
    public class QuanLyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListYeuCau()
        {
            List<YeuCauMuaSach> li = RavenDBHelper.LoadListYC();
            return View(li);
        }
        public IActionResult ListPhanBo()
        {
            List<PhanBoSach> pb = RavenDBHelper.ListPhanBoSach();
            return View(pb);
        }
        //Delete yêu cầu (sau khi xem)
        public IActionResult DeleteYC(string id)
        {
            id = id.Replace("*", "/");
            var store = RavenDBHelper.store.Initialize();
            YeuCauMuaSach ms = new YeuCauMuaSach();
            using (IDocumentSession session = store.OpenSession())
            {
                ms = session.Load<YeuCauMuaSach>(id);
                session.Delete<YeuCauMuaSach>(ms);
                session.SaveChanges();
            }
            return RedirectToAction("ListYeuCau");
        }

        //CRUD phân bố sách
        public IActionResult CreatePBSach()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePBSach(PhanBoSach pbs)
        {
            var store = RavenDBHelper.store.Initialize();
            if (!ModelState.IsValid)
                return View();
            using (IDocumentSession session = store.OpenSession())
            {
                if (pbs.KiemTra == true)
                {
                    session.Store(pbs);
                    session.SaveChanges();
                }
            }
            return RedirectToAction("ListPhanBo");
        }

        public IActionResult EditPBSach(string id)
        {
            var store = RavenDBHelper.store.Initialize();
            using (IDocumentSession session = store.OpenSession())
            {
                id = id.Replace("*","/");
                var pbs = session.Load<PhanBoSach>(id);
                if (pbs == null)
                    return RedirectToAction("ListPhanBo");
                pbs.Id = pbs.Id.Replace("*","/");
                return View(pbs);
            }
        }

        [HttpPost]
        public IActionResult EditPBSach(PhanBoSach pbs)
        {
            if (pbs.Id.Contains("*"))
                pbs.Id.Replace("*","/");
            var store = RavenDBHelper.store.Initialize();
            if (!ModelState.IsValid)
                return View();
            using (IDocumentSession session = store.OpenSession())
            {
                if (pbs.KiemTra == true)
                {                    
                    session.Store(pbs);
                    session.SaveChanges();                    
                }
            }
            return RedirectToAction("ListPhanBo");
        }

        [ActionName("DeletePBSach")]

        public IActionResult DeletePBSach(string id)
        {
            var store = RavenDBHelper.store.Initialize();
            PhanBoSach pb = new PhanBoSach();
            using (IDocumentSession session = store.OpenSession())
            {
                id = id.Replace("*","/");
                pb = session.Load<PhanBoSach>(id);
                session.Delete<PhanBoSach>(pb);
                session.SaveChanges();
            }
            return RedirectToAction("ListPhanBo");
        }

        public IActionResult ListSach()
        {
            return View(RavenDBHelper.ListSach());
        }


        //CRUD Quản lý sách
        public IActionResult AddSach()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSach(Sach s)
        {
            var store = RavenDBHelper.store.Initialize();
            if (!ModelState.IsValid)
                return View();
            using (IDocumentSession session = store.OpenSession())
            {
                session.Store(s);
                session.SaveChanges();
            }
            return RedirectToAction("ListSach");            
        }

        public IActionResult EditSach(string id)
        {
            var store = RavenDBHelper.store.Initialize();
            using (IDocumentSession session = store.OpenSession())
            {
                id = id.Replace("*", "/");
                var s = session.Load<Sach>(id);
                if (s == null)
                    return RedirectToAction("ListSach");
                return View(s);
            }            
        }
        [HttpPost]
        public IActionResult EditSach(Sach s)
        {
            if (s.Id.Contains("*"))
                s.Id.Replace("*", "/");
            var store = RavenDBHelper.store.Initialize();
            if (!ModelState.IsValid)
                return View();
            using (IDocumentSession session = store.OpenSession())
            {
                session.Store(s);
                session.SaveChanges();
            }
            return RedirectToAction("ListSach");
        }
        [ActionName("DeleteSach")]
        public IActionResult DeleteSach(string id)
        {
            var store = RavenDBHelper.store.Initialize();
            Sach s = new Sach();
            using (IDocumentSession session = store.OpenSession())
            {
                id = id.Replace("*", "/");
                s = session.Load<Sach>(id);
                session.Delete<Sach>(s);
                session.SaveChanges();
            }
            return RedirectToAction("ListSach");            
        }

        //CRUD Quản lý độc giả
        public IActionResult ListDocGia()
        {
            List<DocGia> dg = RavenDBHelper.ListDocGia(null,null);
            return View(dg);
        }
        public IActionResult AddDocGia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDocGia(DocGia dg)
        {
            var store = RavenDBHelper.store.Initialize();
            if (!ModelState.IsValid)
                return View();
            using (IDocumentSession session = store.OpenSession())
            {
                if (dg.MaLoaiDG == "GV")
                {
                    DocGiaGV gv = new DocGiaGV();
                    gv.CastToGV(dg);
                    session.Store(gv);
                }
                else if (dg.MaLoaiDG == "SV")
                {
                    DocGiaSV sv = new DocGiaSV();
                    sv.CastToSV(dg);
                    session.Store(sv);
                }
                else if (dg.MaLoaiDG == "T")
                {
                    DocGiaThuong t = new DocGiaThuong();
                    t.CastToThuong(dg);
                    session.Store(t);
                }
                session.SaveChanges();
            }
            return RedirectToAction("ListDocGia");
        }

        public IActionResult EditDocGia(string id)
        {
            var store = RavenDBHelper.store.Initialize();
            using (IDocumentSession session = store.OpenSession())
            {
                id = id.Replace("*", "/");                               
                var dg = session.Load<DocGia>(id);                
                if (dg == null)
                    return RedirectToAction("ListDocGia");
                return View(dg);
            }
        }
        [HttpPost]
        public IActionResult EditDocGia(DocGia dg)
        {
            if (dg.Id.Contains("*"))
                dg.Id.Replace("*", "/");
            var store = RavenDBHelper.store.Initialize();
            if (!ModelState.IsValid)
                return View();
            using (IDocumentSession session = store.OpenSession())
            {
                if (dg.MaLoaiDG == "GV")
                {
                    DocGiaGV gv = new DocGiaGV();
                    gv.CastToGV(dg);
                    session.Store(gv);
                }
                else if (dg.MaLoaiDG == "SV")
                {
                    DocGiaSV sv = new DocGiaSV();
                    sv.CastToSV(dg);
                    session.Store(sv);
                }
                else if (dg.MaLoaiDG == "T")
                {
                    DocGiaThuong t = new DocGiaThuong();
                    t.CastToThuong(dg);
                    session.Store(t);
                }
                session.SaveChanges();
            }
            return RedirectToAction("ListDocGia");
        }
        [ActionName("DeleteDocGia")]
        public IActionResult DeleteDocGia(string id)
        {
            var store = RavenDBHelper.store.Initialize();            
            using (IDocumentSession session = store.OpenSession())
            {
                id = id.Replace("*", "/");
                DocGia dg = session.Query<DocGia, DocGias_ByMaDG>().Where(x=>x.Id == id).SingleOrDefault();
                if (dg.MaLoaiDG == "GV") {
                    var tmp = session.Load<DocGiaGV>(dg.Id);
                    session.Delete<DocGiaGV>(tmp);
                }
                else if (dg.MaLoaiDG == "SV")
                {
                    var tmp = session.Load<DocGiaSV>(dg.Id);
                    session.Delete<DocGiaSV>(tmp);
                }
                else if (dg.MaLoaiDG == "T")
                {                    
                    var tmp = session.Load<DocGiaThuong>(dg.Id);
                    session.Delete<DocGiaThuong>(tmp);
                }
                session.SaveChanges();
            }
            return RedirectToAction("ListDocGia");
        }
    }
}