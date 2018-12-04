using Microsoft.AspNetCore.Http;
using Raven.Client.Documents;
using Raven.Client.Documents.Conventions;
using Raven.Client.Documents.Indexes;
using Raven.Client.Documents.Operations.Indexes;
using Raven.Client.Documents.Session;
using RavenDB_Embedded.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RavenDB_Embedded
{
    public class RavenDBHelper
    {
        static X509Certificate2 clientCertificate = new X509Certificate2("C:\\Users\\vnqma\\Downloads\\Compressed\\nhom85.Cluster.Settings\\Cer\\admin.client.certificate.nhom85.pfx", "vnqmai");
        public static IDocumentStore store = new DocumentStore {
            Urls = new[] { "https://doan.nhom85.ravendb.community" },
            Certificate = clientCertificate,
            Database = "QLTHUVIEN"
        }.Initialize();        

    //load phiếu mượn
    public static List<PhieuMuonSach> ListPhieuMuon(string docgiaid)
        {
            List<PhieuMuonSach> pms = new List<PhieuMuonSach>();
            using (IDocumentSession session = store.OpenSession())
            {
                pms = session.Query<PhieuMuonSach,PhieuMuonSaches_ByMaPhieu>().Where(x => x.DocGia == docgiaid).ToList();
                pms = SortByDateDesc(pms);
                for (int i = 0;i<pms.Count;++i)
                {
                    if (pms[i].NgayMuon != null)
                    {
                        DateTime pngaymuon = DateTime.ParseExact(pms[i].NgayMuon, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        if (pngaymuon.Year != DateTime.Now.Year)
                            pms.RemoveAt(i);
                    }                    
                }
            }
            return pms;
        }      

        //Load độc giả
        public static List<DocGia> ListDocGia(string loaidg, string id)
        {
            List<DocGia> res = new List<DocGia>();
            
            using (IDocumentSession session = store.OpenSession())
            {
                if (loaidg != null)
                {
                    if (id != null)
                    {
                        res = session
                            .Query<DocGia, DocGias_ByMaDG>()
                            .Where(x => x.MaLoaiDG == loaidg&&x.MaDG==id)
                            .ToList();
                    }
                    else
                    {                        
                        res = session
                            .Query<DocGia,DocGias_ByMaDG>()
                            .Where(x => x.MaLoaiDG == loaidg)
                            .ToList();
                    }
                }
                else
                {
                    if (id != null)
                    {
                        res = session                            
                            .Query<DocGia,DocGias_ByMaDG>()
                            .Where(x=>x.MaDG==id)
                            .ToList();
                    }
                    else
                    {
                        var tmp = session
                            .Query<DocGia, DocGias_ByMaDG>()
                            .ToList();
                        foreach (var x in tmp)
                        {
                            res.Add(x);                            
                        }
                    }                    
                }
            }
            return res;
        }

        //Load sách
        public static List<Sach> ListSach()
        {
            List<Sach> res = new List<Sach>();
            using (IDocumentSession session = store.OpenSession())
            {
                res = session
                    .Query<Sach>()
                    .ToList();
            }
            return res;
        }

        //Load sách
        public static List<Sach> ListSach_ByMaSach(string idsach)
        {
            List<Sach> res = new List<Sach>();
            using (IDocumentSession session = store.OpenSession())
            {
                res = session
                    .Query<Sach>()
                    .Where(x=>x.MaSach==idsach)
                    .ToList();
            }
            return res;
        }

        //tím sách theo tên sách, chi nhánh
        public static List<SearchSachView> SearchSach(string macn, string tensach)
        {
            List<SearchSachView> res = new List<SearchSachView>();
            using (var session = store.OpenSession())
            {
                List<PhanBoSach> q = session.Query<PhanBoSach>().Include(x=>x.MaSach).Where(x=>x.MaChiNhanh==macn&&x.SoLuongCon>0).ToList();
                foreach (PhanBoSach x in q)
                {
                    Sach s = session.Load<Sach>(x.MaSach);
                    if (tensach == "" || tensach == null)
                    {
                        SearchSachView i = new SearchSachView
                        {
                            MaSach = s.MaSach,
                            Hinh = s.Hinh,
                            TenSach = s.TenSach,
                            TacGia = s.TenTacGia,
                            GioiThieu = s.LoiGioiThieu,
                            SoLuongCon = x.SoLuongCon
                        };
                        res.Add(i);
                    }
                    else
                    {
                        tensach = tensach.ToLower();
                        if (s.TenSach.ToLower().Contains(tensach))
                        {
                            SearchSachView i = new SearchSachView
                            {
                                MaSach = s.MaSach,
                                Hinh = s.Hinh,
                                TenSach = s.TenSach,
                                TacGia = s.TenTacGia,
                                GioiThieu = s.LoiGioiThieu,
                                SoLuongCon = x.SoLuongCon
                            };
                            res.Add(i);
                        }
                    }        
                }
            }
            //res = res.Where(x=>x.TenSach.Contains(tensach)).ToList();
            return res;
        }

        //Load chi nhánh
        public static List<ChiNhanh> ListChiNhanh()
        {
            List<ChiNhanh> res = new List<ChiNhanh>();
            using (IDocumentSession session = store.OpenSession())
            {
                res = session
                    .Query<ChiNhanh>()
                    .ToList();

            }
            return res;
        }

        //store
        public static void Add(Object x)
        {
            using (var session = store.OpenSession())
            {
                session.Store(x);
                session.SaveChanges();                
            }
           // store.Dispose();            
        }
        public static PhanBoSach TimPhanBoSach(string masach, string macn)
        {
            using (var session = store.OpenSession())
            {
                var pbs = session.Query<PhanBoSach>().Where(x=>x.MaSach==masach&&x.MaChiNhanh==macn).Select(x=>x).First();
                return pbs;
            }            
        }
        public static TaiKhoan KiemTraTaiKhoan(string tendn, string matkhau)
        {
            using (var session = store.OpenSession())
            {
                TaiKhoan tk = session.Query<TaiKhoan>().Where(x=>x.TenDN==tendn&&x.MatKhau==matkhau).SingleOrDefault();
                if (tk != null) {                    
                    return tk;
                }
            }
            return null;
        }
        public static List<PhieuMuonSach> SortByDateDesc(List<PhieuMuonSach> pms)
        {
            for (int i = 0;i<pms.Count-1;++i)
            {
                for (int j = i+1; j < pms.Count; ++j)
                {
                    DateTime pi = DateTime.ParseExact(pms[i].NgayMuon,"dd/MM/yyyy",CultureInfo.InvariantCulture);
                    DateTime pj = DateTime.ParseExact(pms[j].NgayMuon, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (pi < pj)
                    {
                        PhieuMuonSach tmp = pms[i];
                        pms[i] = pms[j];
                        pms[j] = tmp;
                    }
                }
            }
            return pms;
        }
    }
}
