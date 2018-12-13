using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RavenDB_Embedded.Models;

namespace RavenDB_Embedded.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }        
        public IActionResult ChonChiNhanh()
        {
            return View();
        }
        public bool LuuChiNhanh(string chinhanh)
        {            
            HttpContext.Session.Set("ChiNhanh", chinhanh);
            return true;
        }
        public bool DangNhap(string tendn_matkhau)
        {
            string[] p = tendn_matkhau.Split("-");
            TaiKhoan tk = RavenDBHelper.KiemTraTaiKhoan(p[0], p[1]);
            if (tk != null)
            {
                HttpContext.Session.Set("DocGia", tk.MaDG);
                HttpContext.Session.Set("TenDN", tk.TenDN);
                HttpContext.Session.Set("LoaiDG", RavenDBHelper.LayMaLoaiDG(tk.MaDG));
                return true;
            }
            else
                return false;
        }        
    }
}

