using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using RavenDB_Embedded.Models;

namespace RavenDB_Embedded.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Set("DocGia", "DG01");
            HttpContext.Session.Set("ChiNhanh", "CN02");
            return View();
        }
        public IActionResult TestGV()
        {            
            return View(RavenDBHelper.ListDocGia("GV", null));
        }
        public IActionResult TestSV()
        {
            return View(RavenDBHelper.ListDocGia("SV", null));
        }
        public IActionResult XemTruocPMS()
        {
            return View();
        }
        public IActionResult TestAddPMS()
        {
            try
            {
                //Lấy ngày hiện tại
                string ngay = DateTime.Now.ToString("dd/MM/yyyy");

                //Lấy chi nhánh từ session
                string maCN = CleanString(HttpContext.Session.GetString("ChiNhanh"));

                //Lấy độc giả từ session
                string maDG = CleanString(HttpContext.Session.GetString("DocGia"));
                DocGia dgg = RavenDBHelper.ListDocGia(null, maDG)[0];                
                DocGiaGV dg = new DocGiaGV();
                dg.CastToGV(dgg);

                if (dg.DangKyMuon(new List<PMSItem>(), null, null) != null)//kiểm tra đăng ký được
                {
                    // tạo phiếu mới trống
                    RavenDBHelper.Add(new PhieuMuonSachGV());
                    PhieuMuonSachGV pmsgv = new PhieuMuonSachGV();
                    do
                    {

                    } while (RavenDBHelper.ListPhieuMuon(null).Count == 0);
                    pmsgv.CastToPMSGV(RavenDBHelper.ListPhieuMuon(null).First());//lấy pms vừa tạo
                    string pmsid = pmsgv.Id; //lấy id pms vừa tạo

                    //Thêm chi tiết phiếu mượn
                    //List<PMSItem> listsach = new List<PMSItem>();
                    List<PMSItem> listsach = HttpContext.Session.Get<List<PMSItem>>("PMSItems");
                    foreach (PMSItem p in listsach)
                    {
                        //gán id cho các chi tiết mượn
                        p.PMSID = pmsid;

                        //cập nhật số lượng còn kho sách
                        PhanBoSach pb = RavenDBHelper.TimPhanBoSach(p.SachId,maCN);
                        pb.SoLuongCon -= p.SoLuong;                        
                        RavenDBHelper.Add(pb);
                    }

                    //Add nội dung vào phiếu mượn sách đã tạo
                    if (pmsgv != null)
                    {
                        RavenDBHelper.Add(dg.DangKyMuon(listsach, maCN, ngay));                        
                    }                    
                    ViewBag.Status = "Đăng ký thành công!";
                }                
                else ViewBag.Status = "Không thể mượn sách!";
            }
            catch (Exception e)
            {
                ViewBag.Status = "Đăng ký thất bại!";
            }
            return PartialView();
        }
        public IActionResult ChooseDG(string dgid)
        {
            DocGia dg = RavenDBHelper.ListDocGia(null,dgid).First();
            return PartialView(dg);
        }
        public IActionResult SearchSach(string tensach="")
        {
            string[] p = tensach.Split('-');
            string ten = p[0];
            string cn = p[1];
            List<SearchSachView> res = RavenDBHelper.SearchSach(cn,ten);
            return PartialView(res);
        }
        public List<PMSItem> PMSItems
        {
            get
            {                
                List<PMSItem> myPMSItem = HttpContext.Session.Get<List<PMSItem>>("PMSItems");
                if (myPMSItem == default(List<PMSItem>))
                {
                    myPMSItem = new List<PMSItem>();
                }

                return myPMSItem;
            }
        }
        public IActionResult AddPMSItem(string sach_sl)
        {
            if (sach_sl == null)
                return PartialView(HttpContext.Session.Get<List<PMSItem>>("PMSItems"));
            string[] p = sach_sl.Split('-');            
            List<PMSItem> items = HttpContext.Session.Get<List<PMSItem>>("PMSItems");
            //List<PMSItem> items = PMSItems;            
            if(items == null)
            {
                Sach s = RavenDBHelper.ListSach_ByMaSach(p[0]).First();
                PMSItem i = new PMSItem
                {
                    SachId = s.MaSach,
                    TenSach = s.TenSach,
                    Hinh = s.Hinh,
                    SoLuong = Int32.Parse(p[1])
                };
                items = new List<PMSItem>(); ;
                items.Add(i);
            }
            else
            {
                PMSItem item = items.SingleOrDefault(x => x.SachId == p[0]);
                if (item != null)
                {
                    item.SoLuong += Int32.Parse(p[1]);
                }
                else
                {
                    Sach s = RavenDBHelper.ListSach_ByMaSach(p[0]).First();
                    PMSItem i = new PMSItem
                    {
                        SachId = s.MaSach,
                        TenSach = s.TenSach,
                        Hinh = s.Hinh,
                        SoLuong = Int32.Parse(p[1])
                    };
                    items.Add(i);
                }
            }            
            HttpContext.Session.Set("PMSItems",items);
            return PartialView(items);
        }
        public string CleanString(string input)
        {
            input = input.Split("\"")[1];
            return input;
        }
    }
}