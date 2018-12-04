using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class DocGiaSV : DocGia
    {
        public PhieuMuonSachSV DangKyMuon(List<PMSItem> s, string cn, string ngaymuon)
        {
            PhieuMuonSachSV pms = new PhieuMuonSachSV();
            if (pms.KiemTraDK(this)==null)
            {
                if (s.Count != 0)
                    pms.Id = s[0].PMSID;
                pms.DocGia = this.Id;
                pms.PMSItem = s;
                pms.ChiNhanh = cn;
                pms.NgayMuon = ngaymuon;
                return pms;
            }
            else return null;
        }
        public void CastToSV(DocGia dg)
        {
            Id = dg.Id;
            MaDG = dg.Id;
            MaLoaiDG = dg.MaLoaiDG;
            TenDG = dg.TenDG;
            SoDienThoai = dg.SoDienThoai;
        }
    }
}
