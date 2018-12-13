using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class SearchSachView
    {
        public string MaSach { get; set; }
        public string Hinh { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string GioiThieu { get; set; }
        public int SoLuongCon { get; set; }
    }
}
