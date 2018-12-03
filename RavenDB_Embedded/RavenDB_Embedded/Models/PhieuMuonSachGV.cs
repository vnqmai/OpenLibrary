﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSachGV : PhieuMuonSach
    {        
        public bool KiemTraDK(DocGia dg)
        {
            List<PhieuMuonSach> pms = RavenDBHelper.ListPhieuMuon(dg.Id);
            if (pms.Capacity==0)//nếu trong năm không có mượn thì cho mượn (true)
            {
                return true;
            }
            else// nếu trong năm có mượn
            {
                if (pms[0].SoLuongMuon > 5) //nếu phiếu mượn gần nhất có sl > 5 thì ko cho mượn
                    return false;
                else//nếu phiếu mượn gần nhất có sl <= 5
                {
                    int tong = 0;
                    foreach (PhieuMuonSach p in pms)
                    {
                        tong += p.SoLuongMuon;
                    }
                    if (tong > 5) return false;// nếu tổng sl mượn của các phiếu mượn > 5 thì ko cho mượn
                    else return true; // ngược lại cho mượn
                }
            }            
        }
        public void CastToPMSGV(PhieuMuonSach pms)
        {
            Id = pms.Id;
            DocGia = pms.DocGia;
            ChiNhanh = pms.ChiNhanh;
            PMSItem = pms.PMSItem;
            NgayMuon = pms.NgayMuon;
        }
    }
}
