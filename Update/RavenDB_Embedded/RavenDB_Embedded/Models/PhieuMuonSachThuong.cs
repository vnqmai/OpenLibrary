using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSachThuong : PhieuMuonSach
    {
        public string KiemTraDK(DocGia dg)
        {
            if(RavenDBHelper.ListPhieuMuon(dg.Id, "DangMuon").Count!=0)
            {
                return "DangMuon";
            }
            else
            {
                List<PhieuMuonSach> pms = RavenDBHelper.ListPhieuMuon(dg.Id, "DaTra");
                if (pms.Capacity == 0)//nếu trong năm không có mượn thì cho mượn (true)
                {
                    return "3";
                }
                else// nếu trong năm có mượn
                {
                    DateTime nm = DateTime.ParseExact(pms[0].NgayMuon, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DateTime nt = DateTime.ParseExact(pms[0].NgayTra, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string res = "";
                    //xét số lượng mượn
                    if (pms[0].SoLuongMuon > 3)
                    {
                        int sl = -pms[0].SoLuongMuon;
                        if (res != "")
                            res += sl.ToString();
                    }
                    else
                    {
                        int tong = 0;
                        foreach (PhieuMuonSach p in pms)
                        {
                            tong += p.SoLuongMuon;
                        }
                        if (tong > 3)
                            res += (-tong).ToString();
                        else
                            res += (3 - tong).ToString();
                    }
                    //xét ngày
                    if ((nt - nm).TotalDays > 7)
                    {
                        if(nt.AddDays((nt - nm).TotalDays - 7) <= DateTime.Now)
                        {
                            if (res == "")
                                res += nm.ToString("dd/MM/yyyy") + "*" + ((nt - nm).TotalDays - 7);
                            else
                                res = res + "-" + nm.ToString("dd/MM/yyyy") + "*" + ((nt - nm).TotalDays - 7);
                        }                        
                    }
                    return res;
                }
            }
            
        }
        public void CastToPMSThuong(PhieuMuonSach pms)
        {
            Id = pms.Id;
            DocGia = pms.DocGia;
            ChiNhanh = pms.ChiNhanh;
            PMSItem = pms.PMSItem;
            NgayMuon = pms.NgayMuon;
        }

    }
}
