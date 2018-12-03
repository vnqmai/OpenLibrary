using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhanBoSach
    {
        public string MaSach { get; set; }
        public string MaChiNhanh { get; set; }
        public int SoLuongGoc { get; set; }
        public int SoLuongCon { get; set; }
    }
}
