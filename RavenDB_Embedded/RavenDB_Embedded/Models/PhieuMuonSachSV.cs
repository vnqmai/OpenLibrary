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
            List<PhieuMuonSach> pms = RavenDBHelper.ListPhieuMuon(dg.Id,"DangMuon");
            if (pms.Capacity == 0)//nếu trong năm không có mượn thì cho mượn (true)
            {
                return null;
            }
            else// nếu trong năm có mượn
            {
                DateTime nm = DateTime.ParseExact(pms[0].NgayMuon,"dd/MM/yyyy",CultureInfo.InvariantCulture);
                DateTime now = DateTime.Now;
                if (now.DayOfYear- nm.DayOfYear>7) //nếu mượn nhiều hơn 7 ngày --> ko cho mượn
                    return nm.ToString("dd/MM/yyyy");
                else // ngược lại cho mượn
                {
                    return null; 
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
