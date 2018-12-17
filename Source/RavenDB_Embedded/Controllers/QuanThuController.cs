using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RavenDB_Embedded.Models;

namespace RavenDB_Embedded.Controllers
{
    public class QuanThuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TimPhieuMuon(string act)
        {
            if (act == "Tim")
                ViewBag.Act = "Tim";
            if (act=="TraSach")
                ViewBag.Act = "TraSach";
            return View();
        }
        public IActionResult KetQuaTimPhieu(string id)
        {
            if(id.Contains("*"))
                id = id.Replace("*","/");
            PhieuMuonSach pms = RavenDBHelper.LayPhieuMuon(id);
            return PartialView(pms);
        }
        public IActionResult NhanSachDGTra(PhieuMuonSach pms)
        {
            string quanthuid = HttpContext.Session.GetString("QuanThu").Replace("\"","").Replace("\"", "");
            QuanThu qt = new QuanThu { MaQT =  quanthuid};            
            ViewBag.Status = qt.NhanSachDGTra(pms.Id);            
            return View(pms);
        }
        public IActionResult TiepNhanPhieuMuon()
        {
            return View();
        }        
    }
}