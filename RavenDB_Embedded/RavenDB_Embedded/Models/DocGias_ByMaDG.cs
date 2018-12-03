using Raven.Client.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class DocGias_ByMaDG : AbstractMultiMapIndexCreationTask
    {
        public DocGias_ByMaDG()
        {
            AddMap<DocGiaGV>(DocGiaGVs => from x in DocGiaGVs select new { x.Id });
            AddMap<DocGiaSV>(DocGiaSVs => from x in DocGiaSVs select new { x.Id });
            AddMap<DocGiaThuong>(DocGiaThuongs => from x in DocGiaThuongs select new { x.Id });
        }
    }
}
