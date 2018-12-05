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
        public IActionResult AddPMSGV()
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

                //Lấy các chi tiết phiếu mượn                
                List<PMSItem> listsach = HttpContext.Session.Get<List<PMSItem>>("PMSItems");

                if (dg.DangKyMuon(listsach, null, null) != null)//kiểm tra đăng ký được
                {
                    // tạo phiếu mới trống
                    RavenDBHelper.Add(new PhieuMuonSachGV());
                    PhieuMuonSachGV pmsgv = new PhieuMuonSachGV();
                    do
                    {

                    } while (RavenDBHelper.ListPhieuMuon(null).Count == 0);
                    pmsgv.CastToPMSGV(RavenDBHelper.ListPhieuMuon(null).First());//lấy pms vừa tạo
                    string pmsid = pmsgv.Id; //lấy id pms vừa tạo


                    foreach (PMSItem p in listsach)
                    {
                        //gán id cho các chi tiết mượn
                        p.PMSID = pmsid;

                        //cập nhật số lượng còn kho sách
                        PhanBoSach pb = RavenDBHelper.TimPhanBoSach(p.SachId, maCN);
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
                else {
                    PhieuMuonSachGV pms = new PhieuMuonSachGV();
                    int sl = pms.KiemTraDK(dg);
                    if(sl<0)
                        ViewBag.Status = "Bạn đã mượn " + (-sl) + " quyển sách. Giáo viên chỉ được mượn tối đa 5 quyển/1 năm!";
                    else if(sl>0)
                        ViewBag.Status = "Bạn đã mượn "+(5-sl)+" quyển sách. Bạn chỉ được mượn thêm " + (sl) + " quyển sách. Giáo viên chỉ được mượn tối đa 5 quyển/1 năm!";
                    else
                        ViewBag.Status = "Giáo viên chỉ được mượn tối đa 5 quyển/1 năm!";
                }                
            }
            catch (Exception e)
            {
                ViewBag.Status = "Đăng ký thất bại!";
            }
            return PartialView()
;
        }
        public IActionResult AddPMSSV()
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
                DocGiaSV dg = new DocGiaSV();
                dg.CastToSV(dgg);

                //Lấy các chi tiết phiếu mượn                
                List<PMSItem> listsach = HttpContext.Session.Get<List<PMSItem>>("PMSItems");

                if (dg.DangKyMuon(listsach, null, null) != null)//kiểm tra đăng ký được
                {
                    // tạo phiếu mới trống
                    RavenDBHelper.Add(new PhieuMuonSachSV());
                    PhieuMuonSachSV pmssv = new PhieuMuonSachSV();
                    do
                    {

                    } while (RavenDBHelper.ListPhieuMuon(null).Count == 0);
                    pmssv.CastToPMSSV(RavenDBHelper.ListPhieuMuon(null).First());//lấy pms vừa tạo
                    string pmsid = pmssv.Id; //lấy id pms vừa tạo


                    foreach (PMSItem p in listsach)
                    {
                        //gán id cho các chi tiết mượn
                        p.PMSID = pmsid;

                        //cập nhật số lượng còn kho sách
                        PhanBoSach pb = RavenDBHelper.TimPhanBoSach(p.SachId, maCN);
                        pb.SoLuongCon -= p.SoLuong;
                        RavenDBHelper.Add(pb);
                    }

                    //Add nội dung vào phiếu mượn sách đã tạo
                    if (pmssv != null)
                    {
                        RavenDBHelper.Add(dg.DangKyMuon(listsach, maCN, ngay));
                    }
                    ViewBag.Status = "Đăng ký thành công!";
                }
                else {
                    PhieuMuonSachSV pms = new PhieuMuonSachSV();
                    string nm = pms.KiemTraDK(dg);
                    ViewBag.Status = "Ngày mượn sách gần nhất của bạn là "+nm+". Sinh viên không được mượn sách quá 7 ngày!";
                } 
            }
            catch (Exception e)
            {
                ViewBag.Status = "Đăng ký thất bại!";
            }
            return PartialView();
        }
        public IActionResult AddPMSThuong()
        {
            //Lấy ngày hiện tại
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");

            //Lấy chi nhánh từ session
            string maCN = CleanString(HttpContext.Session.GetString("ChiNhanh"));

            //Lấy độc giả từ session
            string maDG = CleanString(HttpContext.Session.GetString("DocGia"));
            DocGia dgg = RavenDBHelper.ListDocGia(null, maDG)[0];
            DocGiaThuong dg = new DocGiaThuong();
            dg.CastToThuong(dgg);

            //Lấy các chi tiết phiếu mượn                
            List<PMSItem> listsach = HttpContext.Session.Get<List<PMSItem>>("PMSItems");

            if (dg.DangKyMuon(listsach, null, null) != null)//kiểm tra đăng ký được
            {
                // tạo phiếu mới trống
                RavenDBHelper.Add(new PhieuMuonSachThuong());
                PhieuMuonSachThuong pmst = new PhieuMuonSachThuong();
                do
                {

                } while (RavenDBHelper.ListPhieuMuon(null).Count == 0);
                pmst.CastToPMSThuong(RavenDBHelper.ListPhieuMuon(null).First());//lấy pms vừa tạo
                string pmsid = pmst.Id; //lấy id pms vừa tạo


                foreach (PMSItem p in listsach)
                {
                    //gán id cho các chi tiết mượn
                    p.PMSID = pmsid;

                    //cập nhật số lượng còn kho sách
                    PhanBoSach pb = RavenDBHelper.TimPhanBoSach(p.SachId, maCN);
                    pb.SoLuongCon -= p.SoLuong;
                    RavenDBHelper.Add(pb);
                }

                //Add nội dung vào phiếu mượn sách đã tạo
                if (pmst != null)
                {
                    RavenDBHelper.Add(dg.DangKyMuon(listsach, maCN, ngay));
                }
                ViewBag.Status = "Đăng ký thành công!";
            }
            else
            {
                PhieuMuonSachThuong pms = new PhieuMuonSachThuong();
                string res = pms.KiemTraDK(dg);
                if (res.Contains("-"))
                {
                    string[] p = res.Split("-");
                    if (Int32.Parse(p[0]) < 0)
                        ViewBag.Status = "Bạn đã mượn " + (-Int32.Parse(p[0])) + " quyển sách VÀ mượn vào ngày " + p[1] + ". Độc giả thường không được mượn quá 3 quyển sách và mượn không quá 7 ngày!";
                    else
                        ViewBag.Status = "Bạn đã mượn sách vào ngày " + p[1] + ". Độc giả thường không được mượn sách quá 7 ngày!";                    
                }
                else
                {
                    int sl = Int32.Parse(res);
                    if (sl<0)
                        ViewBag.Status = "Bạn đã mượn "+(-sl).ToString()+" quyển sách. Độc giả không được mượn quá 3 quyển sách!";
                    else
                        ViewBag.Status = "Bạn đã mượn " + (3-sl).ToString() + " quyển sách. Độc giả không được mượn quá 3 quyển sách!";
                }                
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