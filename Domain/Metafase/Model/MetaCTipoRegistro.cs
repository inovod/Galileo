using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoRegistro
    {
        public MetaCTipoRegistro()
        {
            MetaLog = new HashSet<MetaLog>();
            MetaLogH = new HashSet<MetaLogH>();
        }

        public int CdTipoRegistro { get; set; }
        public string DsTipoRegistro { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaLog> MetaLog { get; set; }
        public virtual ICollection<MetaLogH> MetaLogH { get; set; }
    }
}
