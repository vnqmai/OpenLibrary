using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class DocGiaGV : DocGia
    {
        
        public PhieuMuonSachGV DangKyMuon(List<PMSItem> s, string cn,string ngaymuon)
        {
            PhieuMuonSachGV pms = new PhieuMuonSachGV();
            int sldcmuonthem = pms.KiemTraDK(this,s.Sum(x=>x.SoLuong));
            if (sldcmuonthem>0)
            {                               
                if(s.Count!=0)
                    pms.Id = s[0].PMSID;
                pms.DocGia = this.Id;
                pms.PMSItem = s;                
                pms.ChiNhanh = cn;
                pms.NgayMuon = ngaymuon;
                pms.NgayTra = "";
                pms.TrangThai = "DangMuon";                
                return pms;                
            }     
            else if (sldcmuonthem==0)
            {
                PhieuMuonSachGV pgv = new PhieuMuonSachGV();
                pgv.CastToPMSGV(RavenDBHelper.ListPhieuMuon(this.Id, "DangMuon").SingleOrDefault());
                
                pms.Id = pgv.Id;
                pms.DocGia = this.Id;
                pms.PMSItem = pgv.PMSItem;
                foreach (PMSItem p in s)
                {
                    if (pms.PMSItem.Where(x => x.SachId == p.SachId).SingleOrDefault() != null)
                    {
                        pms.PMSItem.Where(x => x.SachId == p.SachId).SingleOrDefault().SoLuong += p.SoLuong;
                    }
                    else
                        pms.PMSItem.Add(p);
                }                
                pms.ChiNhanh = pgv.ChiNhanh;
                pms.NgayMuon = pgv.NgayMuon;
                pms.NgayTra = "";
                pms.TrangThai = "DangMuon";
                if(pms.SoLuongMuon+RavenDBHelper.ListPhieuMuon(this.Id,"DaTra").Sum(x=>x.SoLuongMuon)>5) return null;
                else return pms;
            }
            else return null;            
        }
        public void CastToGV(DocGia dg)
        {
            Id = dg.Id;
            MaDG = dg.Id;
            MaLoaiDG = dg.MaLoaiDG;
            TenDG = dg.TenDG;
            SoDienThoai = dg.SoDienThoai;          
        }
    }
}
