using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSachThuong : PhieuMuonSach
    {
        public int KiemTraDK(DocGia dg)
        {
            List<PhieuMuonSach> pms = RavenDBHelper.ListPhieuMuon(dg.Id);
            if (pms.Capacity == 0)//nếu trong năm không có mượn thì cho mượn (true)
            {
                return 3;
            }
            else// nếu trong năm có mượn
            {
                DateTime nm = DateTime.ParseExact(pms[0].NgayMuon, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime now = DateTime.Now;
                if (pms[0].SoLuongMuon > 3 || now.DayOfYear - nm.DayOfYear > 7) //nếu phiếu mượn gần nhất có sl > 3 hoặc mượn nhiều hơn 7 ngày thì ko cho mượn
                {
                    if (pms[0].SoLuongMuon > 3)
                        return -1;
                    else if (now.DayOfYear - nm.DayOfYear > 7)
                        return -2;
                    else return -3;
                }                
                else//ngược lại
                {                    
                    int tong = 0;
                    foreach (PhieuMuonSach p in pms)
                    {
                        tong += p.SoLuongMuon;
                    }
                    if (tong > 3) return -1;// nếu tổng sl mượn của các phiếu mượn > 3 thì ko cho mượn
                    else return (3-tong); // ngược lại cho mượn
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
