using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoDocumento
    {
        public MetaCTipoDocumento()
        {
            MetaDocumento = new HashSet<MetaDocumento>();
        }

        public int CdTipoDocumento { get; set; }
        public string DsTipoDocumento { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaDocumento> MetaDocumento { get; set; }
    }
}
