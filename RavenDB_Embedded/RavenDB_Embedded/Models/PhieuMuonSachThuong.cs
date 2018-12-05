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
            List<PhieuMuonSach> pms = RavenDBHelper.ListPhieuMuon(dg.Id,"DangMuon");
            if (pms.Capacity == 0)//nếu trong năm không có mượn thì cho mượn (true)
            {
                return "3";
            }
            else// nếu trong năm có mượn
            {
                DateTime nm = DateTime.ParseExact(pms[0].NgayMuon, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime now = DateTime.Now;
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
                if (now.DayOfYear - nm.DayOfYear > 7)
                {
                    if(res=="")
                        res += nm.ToString("dd/MM/yyyy");
                    else
                        res = res+"-"+ nm.ToString("dd/MM/yyyy");
                }
                //if (pms[0].SoLuongMuon > 3 || now.DayOfYear - nm.DayOfYear > 7) //nếu phiếu mượn gần nhất có sl > 3 hoặc mượn nhiều hơn 7 ngày thì ko cho mượn
                //{
                //    if(pms[0].SoLuongMuon > 3 && now.DayOfYear - nm.DayOfYear > 7)
                //    {
                //        int sl = -pms[0].SoLuongMuon;
                //        return sl.ToString() + "-" + nm.ToString("dd/MM/yyyy");
                //    }
                //    else
                //    {
                //        if (pms[0].SoLuongMuon > 3)
                //        {
                //            int sl = -pms[0].SoLuongMuon;
                //            return sl.ToString();
                //        }
                //        else if (now.DayOfYear - nm.DayOfYear > 7)
                //            return nm.ToString("dd/MM/yyyy");
                //        else
                //            return null;
                //    }                                                                
                //}                
                //else//ngược lại
                //{                    
                //    int tong = 0;
                //    foreach (PhieuMuonSach p in pms)
                //    {
                //        tong += p.SoLuongMuon;
                //    }
                //    if (tong > 3) return (-tong).ToString();// nếu tổng sl mượn của các phiếu mượn > 3 thì ko cho mượn
                //    else return (3-tong).ToString(); // ngược lại cho mượn
                //}
                return res;
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
