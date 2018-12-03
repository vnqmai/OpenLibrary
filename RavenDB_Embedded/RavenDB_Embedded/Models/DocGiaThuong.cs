﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    
    public class DocGiaThuong:DocGia
    {
        public PhieuMuonSachThuong DangKyMuon(List<PMSItem> s, string cn, string ngaymuon)
        {
            PhieuMuonSachThuong pms = new PhieuMuonSachThuong();
            if (pms.KiemTraDK(this))
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
        public void CastToThuong(DocGia dg)
        {
            Id = dg.Id;
            MaDG = dg.Id;
            MaLoaiDG = dg.MaLoaiDG;
            TenDG = dg.TenDG;
            SoDienThoai = dg.SoDienThoai;
        }        
    }
}
