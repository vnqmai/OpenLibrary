using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class MuonSachView
    {        
        public string Id { get; set; }

        public string MaPhieu { get; set; }

        public string TenDG { get; set; }

        public string TenSach { get; set; }

        public string TenChiNhanh { get; set; }

        public int SoLuongMuon { get; set; }

        public string NgayMuon { get; set; }                

    }
}
