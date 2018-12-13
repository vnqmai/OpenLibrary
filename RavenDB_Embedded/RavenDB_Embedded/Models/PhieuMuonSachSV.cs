using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSachSV : PhieuMuonSach
    {
        public string KiemTraDK(DocGia dg)//trả vê null nếu đúng, trả về ngày gần nhất nếu sai
        {
            if(RavenDBHelper.ListPhieuMuon(dg.Id, "DangMuon").Count!=0)
            {
                return "DangMuon";
            }
            else
            {
                List<PhieuMuonSach> pms = RavenDBHelper.ListPhieuMuon(dg.Id, "DaTra");
                if (pms.Count == 0)//nếu trong năm không có mượn thì cho mượn (true)
                {
                    return null;
                }
                else// nếu trong năm có mượn
                {
                    DateTime nm = DateTime.ParseExact(pms[0].NgayMuon, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DateTime nt = DateTime.ParseExact(pms[0].NgayTra, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if ((nt - nm).TotalDays > 7) //nếu mượn nhiều hơn 7 ngày --> ko cho mượn
                    {
                        if (nt.AddDays((nt - nm).TotalDays - 7) >= DateTime.Now)
                            return nt.ToString("dd/MM/yyyy") + "-" + ((nt - nm).TotalDays - 7).ToString();
                        else
                            return null;
                    }
                    else // ngược lại cho mượn
                    {
                        return null;
                    }
                }
            }
            
        }
        public void CastToPMSSV(PhieuMuonSach pms)
        {
            Id = pms.Id;
            DocGia = pms.DocGia;
            ChiNhanh = pms.ChiNhanh;
            PMSItem = pms.PMSItem;
            NgayMuon = pms.NgayMuon;
        }

    }
}
