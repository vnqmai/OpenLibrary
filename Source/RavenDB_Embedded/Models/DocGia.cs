using Raven.Client.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class DocGia
    {        
        public string Id { get; set; }
        public string MaLoaiDG { get; set; }
        public string MaDG { get; set; }
        public string TenDG { get; set; }
        public string SoDienThoai { get; set; }

        public void BinhLuan(Sach s,string nhanxet,int rating)
        {
            BinhLuan bl = new BinhLuan
            {
                NhanXet = nhanxet,
                MaDG = this.MaDG,
                Rating = rating
            };
            s.BinhLuan.Add(bl);
            RavenDBHelper.Add(s);
        }
                
    }
}
