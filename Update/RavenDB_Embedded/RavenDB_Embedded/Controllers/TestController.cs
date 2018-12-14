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
   
        public void LayThongTinTuSession(ref string ngay, ref string macn, ref string madg, ref List<PMSItem> pmsitems)
        {
            ngay = DateTime.Now.ToString("dd/MM/yyyy");                         //Lấy ngày hiện tại
            macn = CleanString(HttpContext.Session.GetString("ChiNhanh"));      //Lấy chi nhánh từ session
            madg = CleanString(HttpContext.Session.GetString("DocGia"));        //Lấy độc giả từ session
            pmsitems = HttpContext.Session.Get<List<PMSItem>>("PMSItems");      //Lấy các chi tiết phiếu mượn
        }
        public IActionResult Index()
        {          
            return View();
        }        
        public IActionResult XemTruocPMS()
        {
            return View();
        }        
        public IActionResult AddPMSGV()
        {
            try
            {
                string ngay = "", maCN = "", maDG = "";
                List<PMSItem> listsach = new List<PMSItem>();
                LayThongTinTuSession(ref ngay,ref maCN,ref maDG,ref listsach);

                DocGia dgg = RavenDBHelper.ListDocGia(null, maDG)[0];                
                DocGiaGV dg = new DocGiaGV();
                dg.CastToGV(dgg);

                PhieuMuonSachGV pmsgv = dg.DangKyMuon(listsach, null, null);
                if (pmsgv != null)//kiểm tra đăng ký được
                {
                    // tạo phiếu mới trống
                    RavenDBHelper.Add(new PhieuMuonSachGV());
                    
                    do
                    {

                    } while (RavenDBHelper.ListPhieuMuon(null,null).Count == 0);
                    pmsgv.CastToPMSGV(RavenDBHelper.ListPhieuMuon(null,null).First());   //lấy pms vừa tạo
                    string pmsid = pmsgv.Id;                                        //lấy id pms vừa tạo
                    
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
                        RavenDBHelper.Add(dg.DangKyMuon(listsach,maCN,ngay));
                    }
                    ViewBag.Status = "Đăng ký thành công!";
                }
                else {
                    PhieuMuonSachGV pms = new PhieuMuonSachGV();
                    int sl = pms.KiemTraDK(dg,listsach.Sum(x=>x.SoLuong));
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
                string ngay = "", maCN = "", maDG = "";
                List<PMSItem> listsach = new List<PMSItem>();
                LayThongTinTuSession(ref ngay, ref maCN, ref maDG, ref listsach);

                DocGia dgg = RavenDBHelper.ListDocGia(null, maDG)[0];
                DocGiaSV dg = new DocGiaSV();
                dg.CastToSV(dgg);                

                if (dg.DangKyMuon(listsach, null, null) != null)//kiểm tra đăng ký được
                {
                    // tạo phiếu mới trống
                    RavenDBHelper.Add(new PhieuMuonSachSV());
                    PhieuMuonSachSV pmssv = new PhieuMuonSachSV();
                    do
                    {

                    } while (RavenDBHelper.ListPhieuMuon(null, null).Count == 0);
                    pmssv.CastToPMSSV(RavenDBHelper.ListPhieuMuon(null,null).First());//lấy pms vừa tạo
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
                    string n = pms.KiemTraDK(dg);
                    if (n == "DangMuon")
                        ViewBag.Status = "Bạn đang mượn sách. Vui lòng trả sách trước khi mượn.";
                    else
                    {
                        string[] p = n.Split('-');
                        int so_ntre = Int32.Parse(p[1]);
                        DateTime nthoa = DateTime.ParseExact(p[0], "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(so_ntre);
                        ViewBag.Status = "Bạn đã trả sách trễ " + so_ntre.ToString() + " ngày. Bạn được mượn sách lại vào ngày " + nthoa.ToString("dd/MM/yyyy") + ". Sinh viên không được mượn sách quá 7 ngày!";
                    }
                    
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
            string ngay = "", maCN = "", maDG = "";
            List<PMSItem> listsach = new List<PMSItem>();
            LayThongTinTuSession(ref ngay, ref maCN, ref maDG, ref listsach);

            DocGia dgg = RavenDBHelper.ListDocGia(null, maDG)[0];
            DocGiaThuong dg = new DocGiaThuong();
            dg.CastToThuong(dgg);            

            if (dg.DangKyMuon(listsach, null, null) != null)//kiểm tra đăng ký được
            {
                // tạo phiếu mới trống
                RavenDBHelper.Add(new PhieuMuonSachThuong());
                PhieuMuonSachThuong pmst = new PhieuMuonSachThuong();
                do
                {

                } while (RavenDBHelper.ListPhieuMuon(null,null).Count == 0);
                pmst.CastToPMSThuong(RavenDBHelper.ListPhieuMuon(null,null).First());//lấy pms vừa tạo
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
                if(res == "DangMuon")
                {
                    ViewBag.Status = "Bạn đang mượn sách. Vui lòng trả sách trước khi mượn.";
                }
                else if (res.Contains("-"))
                {
                    string[] p = res.Split("-");
                    string[] p1 = p[1].Split('*');
                    int so_ntre = Int32.Parse(p1[1]); 
                    DateTime nthoa = DateTime.ParseExact(p1[0],"dd/MM/yyyy",CultureInfo.InvariantCulture).AddDays(so_ntre);
                    if (Int32.Parse(p[0]) < 0)
                        ViewBag.Status = "Bạn đã mượn " + (-Int32.Parse(p[0])) + " quyển sách VÀ trả sách trễ "+p1[1]+" ngày. Bạn được mượn lại vào ngày " + nthoa + ". Độc giả thường không được mượn quá 3 quyển sách và mượn không quá 7 ngày!";
                    else
                        ViewBag.Status = "Bạn đã trả sách trễ " + p1[1] + " ngày. Bạn được mượn lại vào ngày "+nthoa.ToString("dd/MM/yyyy")+". Độc giả thường không được mượn sách quá 7 ngày!";                    
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

        public IActionResult YeuCauMuaSach(YeuCauMuaSach yc)
        {
            RavenDBHelper.Add(yc);
            return View();
        }
        public IActionResult XemChiTiet(string id)
        {
            Sach res = RavenDBHelper.ListSach_ByMaSach(id).SingleOrDefault();
            return View(res);
        }
        public string CleanString(string input)
        {
            input = input.Split("\"")[1];
            return input;
        }
        public IActionResult ViewQT()
        {
            return View();
        }
        public IActionResult NhanSachDGTra([Bind("Id", "MaPhieu", "DocGia", "ChiNhanh")] PhieuMuonSach pm)
        {

            ViewBag.MaPhieu = pm.MaPhieu;

            if (ModelState.IsValid && pm.MaPhieu != null)
            {

                var Store = DatabaseHelper.store;
                Store.Initialize();
                using (var session = Store.OpenSession())
                {
                    DocGia dg = session.Query<DocGia, DocGias_ByMaDG>().Where(x => x.MaDG == pm.DocGia).SingleOrDefault();
                    if (dg == null)
                    {
                        string flag = "Trả sách thất bại";
                        ViewBag.Flat = flag;
                    }
                    else
                    {
                    if (dg.MaLoaiDG == "T")
                    {
                        session.Advanced.Patch<PhieuMuonSachThuong, string>(
                         pm.MaPhieu,
                         x => x.TrangThai, "DaTra");
                        session.SaveChanges();
                        session.Advanced.Patch<PhieuMuonSachThuong, string>(
                         pm.MaPhieu,
                         x => x.NgayTra, DateTime.Now.ToString());
                        session.SaveChanges();
                        PhieuMuonSachThuong pms = session.Query<PhieuMuonSachThuong>().Where(p => p.Id == pm.Id).SingleOrDefault();
                        int[] sls = new int[100];
                        string[] mss = new string[100];
                        int dem = 0;

                        foreach (PMSItem item in pms.PMSItem)
                        {
                            mss[dem] = item.SachId;
                            sls[dem] = item.SoLuong;
                            dem++;
                        }

                      
                        PhanBoSach[] pb = new PhanBoSach[100];
                        for (int i = 0; i < dem; i++)
                        {
                            string ms = mss[i];
                            pb[i] = session.Query<PhanBoSach>().Where(p => p.MaSach == ms && p.MaChiNhanh == pm.ChiNhanh).SingleOrDefault();
                            int soluong = pb[i].SoLuongCon;
                            int cn = soluong + sls[i];
                            session.Advanced.Patch<PhanBoSach, int>(
                                 pb[i].Id,
                                 x => x.SoLuongCon, cn);
                            session.SaveChanges();
                        }
                        string flag = "Trả sách thành công";
                        ViewBag.Flat = flag;


                    }
                    else if (dg.MaLoaiDG == "SV")
                    {
                        session.Advanced.Patch<PhieuMuonSachSV, string>(
                          pm.MaPhieu,
                          x => x.TrangThai, "DaTra");
                        session.SaveChanges();
                        session.Advanced.Patch<PhieuMuonSachSV, string>(
                         pm.MaPhieu,
                         x => x.NgayTra, DateTime.Now.ToString());
                        session.SaveChanges();
                        PhieuMuonSachSV pms = session.Query<PhieuMuonSachSV>().Where(p => p.MaPhieu == pm.MaPhieu).SingleOrDefault();
                        int[] sls = new int[100];
                        string[] mss = new string[100];
                        int dem = 0;

                        foreach (PMSItem item in pms.PMSItem)
                        {
                            mss[dem] = item.SachId;
                            sls[dem] = item.SoLuong;
                            dem++;
                        }

                      
                        PhanBoSach[] pb = new PhanBoSach[100];
                        for (int i = 0; i < dem; i++)
                        {
                            string ms = mss[i];
                            pb[i] = session.Query<PhanBoSach>().Where(p => p.MaSach == ms && p.MaChiNhanh == pm.ChiNhanh).SingleOrDefault();
                            int soluong = pb[i].SoLuongCon;
                            int cn = soluong + sls[i];
                            session.Advanced.Patch<PhanBoSach, int>(
                                 pb[i].Id,
                                 x => x.SoLuongCon, cn);
                            session.SaveChanges();
                        }

                       
                        string flag = "Trả sách thành công";
                        ViewBag.Flat = flag;

                    }
                    else if(dg.MaLoaiDG=="GV")
                    {
                        session.Advanced.Patch<PhieuMuonSachGV, string>(
                            pm.MaPhieu,
                            x => x.TrangThai, "DaTra");
                        session.SaveChanges();
                        session.Advanced.Patch<PhieuMuonSachGV, string>(
                         pm.MaPhieu,
                         x => x.NgayTra, DateTime.Now.ToString());
                        session.SaveChanges();

                        PhieuMuonSachGV pms = session.Query<PhieuMuonSachGV>().Where(p => p.MaPhieu == pm.MaPhieu).SingleOrDefault();
                        int[] sls = new int[100];
                        string[] mss = new string[100];
                        int dem = 0;

                        foreach (PMSItem item in pms.PMSItem)
                        {
                            mss[dem] = item.SachId;
                            sls[dem] = item.SoLuong;
                            dem++;
                        }

                      
                        PhanBoSach[] pb = new PhanBoSach[100];
                        for (int i = 0; i < dem; i++)
                        {
                            string ms = mss[i];
                            pb[i] = session.Query<PhanBoSach>().Where(p => p.MaSach == ms && p.MaChiNhanh == pm.ChiNhanh).SingleOrDefault();
                            int soluong = pb[i].SoLuongCon;
                            int cn = soluong + sls[i];
                            session.Advanced.Patch<PhanBoSach, int>(
                                 pb[i].Id,
                                 x => x.SoLuongCon, cn);
                            session.SaveChanges();
                        }

                        string flag = "Trả sách thành công";
                        ViewBag.Flat = flag;
                    }else{
                    string flag = "Trả sách thất bại";
                        ViewBag.Flat = flag;
                    }
                    }

                }
            }
            return View();

        }

    }
}
