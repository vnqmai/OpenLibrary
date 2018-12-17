using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class QuanThu
    {
        public string MaQT { get; set; }
        public string TenQT { get; set; }
        public string SoDienThoai { get; set; }
       
        public string NhanSachDGTra(string pmsid)
        {            
            if (pmsid != null)
            {
                if (pmsid.Contains("*"))
                    pmsid = pmsid.Replace("*", "/");
                var Store = RavenDBHelper.store;
                Store.Initialize();
                using (var session = Store.OpenSession())
                {
                    PhieuMuonSach pms = session.Query<PhieuMuonSach, PhieuMuonSaches_ByMaPhieu>().Where(x => x.Id == pmsid).SingleOrDefault();
                    pms.TrangThai = "DaTra";
                    pms.NgayTra = DateTime.Now.ToString("dd/MM/yyyy");
                    pms.QuanThu = MaQT;
                    RavenDBHelper.Add(pms);

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
                        pb[i] = session.Query<PhanBoSach>().Where(p => p.MaSach == ms && p.MaChiNhanh == pms.ChiNhanh).SingleOrDefault();
                        int soluong = pb[i].SoLuongCon;
                        int cn = soluong + sls[i];
                        session.Advanced.Patch<PhanBoSach, int>(
                             pb[i].Id,
                             x => x.SoLuongCon, cn);
                        //session.SaveChanges();
                    }
                    return "Trả sách thành công";
                }
            }
            else
                return "Trả sách thất bại";
        }
    }
}
