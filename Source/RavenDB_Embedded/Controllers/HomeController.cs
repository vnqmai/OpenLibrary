using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public IActionResult TrangChu()
        {
            return View();
        }
        public IActionResult ThuVien()
        {
            return View(RavenDBHelper.ListSach());
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
        public string DangNhap(string tendn_matkhau)
        {
            string[] p = tendn_matkhau.Split("-");
            TaiKhoan tk = RavenDBHelper.KiemTraTaiKhoan(p[0], p[1]);
            string loaitk = "";
            if (tk != null)
            {                
                if (tk.MaLoaiTK == "DG")
                {
                    loaitk = "DG";
                    HttpContext.Session.Set("DocGia", tk.MaDG);
                }                    
                if(tk.MaLoaiTK == "QT")
                {
                    loaitk = "QT";
                    HttpContext.Session.Set("QuanThu", tk.MaDG);
                }                    
                if (tk.MaLoaiTK == "QL")
                {
                    loaitk = "QL";
                    HttpContext.Session.Set("QuanLy", tk.MaDG);
                }
                HttpContext.Session.Set("TaiKhoanId", tk.Id);
                HttpContext.Session.Set("TenDN", tk.TenDN);
                HttpContext.Session.Set("MatKhau", tk.MatKhau);
                HttpContext.Session.Set("LoaiDG", RavenDBHelper.LayMaLoaiDG(tk.MaDG));                
                return loaitk;
            }
            else
                return loaitk;
        }        
    }
}

