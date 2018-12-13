using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSachGV : PhieuMuonSach
    {        
        public int KiemTraDK(DocGia dg, int slmuon)//trả về số lượng được mượn thêm
        {
            List<PhieuMuonSach> pms = RavenDBHelper.ListPhieuMuon(dg.Id,null);
            if (pms.Count==0)//nếu trong năm không có mượn thì cho mượn (true)
            {
                if (slmuon <= 5)
                    return slmuon;
                else
                    return -slmuon;
            }
            else// nếu trong năm có mượn
            {
                if (RavenDBHelper.ListPhieuMuon(dg.Id, "DangMuon").Count == 0)
                {
                    if (slmuon > 5) //nếu phiếu mượn gần nhất có sl > 5 thì ko cho mượn
                        return -slmuon;
                    else//nếu phiếu mượn gần nhất có sl <= 5
                    {
                        int tong = 0;
                        foreach (PhieuMuonSach p in pms)
                        {
                            tong += p.SoLuongMuon;
                        }
                        if (tong > 5) return -tong;// nếu tổng sl mượn của các phiếu mượn > 5 thì ko cho mượn
                        else {
                            if (slmuon <= 5 - tong)
                                return (5 - tong);
                            else
                                return -slmuon;
                        } 
                    }
                }
                else return 0;
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
