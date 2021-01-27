using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoAviso
    {
        public MetaCTipoAviso()
        {
            MetaAviso = new HashSet<MetaAviso>();
        }

        public int CdTipoAviso { get; set; }
        public string DsTipoAviso { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaAviso> MetaAviso { get; set; }
    }
}
