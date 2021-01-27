using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCSector
    {
        public MetaCSector()
        {
            MetaCFamilia = new HashSet<MetaCFamilia>();
        }

        public int CdSector { get; set; }
        public string DsSector { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaCFamilia> MetaCFamilia { get; set; }
    }
}
