using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class TaiKhoan
    {
        public string Id { get; set; }
        public string MaDG { get; set; }        
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public string MaLoaiTK { get; set; }
    }
}
