using Raven.Client.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSaches_ByMaPhieu : AbstractMultiMapIndexCreationTask
    {
        public PhieuMuonSaches_ByMaPhieu()
        {
            AddMap<PhieuMuonSachGV>(PhieuMuonSachGVs => from x in PhieuMuonSachGVs select new { x.Id });
            AddMap<PhieuMuonSachSV>(PhieuMuonSachSVs => from x in PhieuMuonSachSVs select new { x.Id });
            AddMap<PhieuMuonSachThuong>(PhieuMuonSachThuongs => from x in PhieuMuonSachThuongs select new { x.Id });
        }
    }
}
