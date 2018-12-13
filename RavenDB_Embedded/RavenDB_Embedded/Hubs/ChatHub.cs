using Microsoft.AspNetCore.SignalR;
using RavenDB_Embedded.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Hubs
{
    public class ChatHub : Hub
    {
        public async Task GuiTinNhan(string name, string mess)
        {            
            await Clients.All.SendAsync("NhanTinNhan",name,mess);
        }
        public async Task PushBinhLuan(string masach,string dg, string nhanxet, int rating)
        {
            DocGia docgia = RavenDBHelper.ListDocGia(null,dg).SingleOrDefault();
            Sach s = RavenDBHelper.ListSach_ByMaSach(masach).SingleOrDefault();
            docgia.BinhLuan(s,nhanxet,rating);
            
            await Clients.All.SendAsync("PullBinhLuan",masach,dg,nhanxet,rating);
        }
    }
}
