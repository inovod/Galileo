using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCDistrito
    {
        public MetaCDistrito()
        {
            MetaCCpostalDistrito = new HashSet<MetaCCpostalDistrito>();
        }

        public int CdDistrito { get; set; }
        public string DsDistrito { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaCCpostalDistrito> MetaCCpostalDistrito { get; set; }
    }
}
