using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSach
    {
        public string Id { get; set; }
        public string MaPhieu {
            get
            {
                return Id;
            }
        }
        public string DocGia { get; set; }
        public string ChiNhanh { get; set; }
        public List<PMSItem> PMSItem { get; set; }
        public int SoLuongMuon {
            get {
                if (this.PMSItem == null) return 0;
                else
                {
                    int tongsl = 0;
                    foreach (PMSItem x in this.PMSItem)
                    {
                        tongsl += x.SoLuong;
                    }
                    return tongsl;
                }
            }
        }
        public string NgayMuon { get; set; }
        public string TrangThai { get; set; } //DangKy, DangMuon, DaTra

        //public abstract bool KiemTraDK(DocGia dg);
    }
}
