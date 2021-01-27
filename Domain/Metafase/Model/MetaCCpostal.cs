using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCpostal
    {
        public MetaCCpostal()
        {
            MetaCCpostalDistrito = new HashSet<MetaCCpostalDistrito>();
        }

        public string CdProv { get; set; }
        public string CdMuni { get; set; }
        public string CdCpostal { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCMunicipio Cd { get; set; }
        public virtual ICollection<MetaCCpostalDistrito> MetaCCpostalDistrito { get; set; }
    }
}
