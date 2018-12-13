using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PMSItem
    {
        public string PMSID { get; set; }
        public string SachId { get; set; }
        public string TenSach { get; set; }
        public string Hinh { get; set; }
        public int SoLuong { get; set; }

        public bool KiemTraKho(string masach, string macn, int slmuon)
        {
            PhanBoSach pbs = RavenDBHelper.TimPhanBoSach(masach, macn);
            if (pbs.SoLuongCon - slmuon > 0) return true;
            else return false;
        }
    }
}
