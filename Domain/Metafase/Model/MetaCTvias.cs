using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTvias
    {
        public MetaCTvias()
        {
            MetaDirecciones = new HashSet<MetaDirecciones>();
        }

        public string CdTvia { get; set; }
        public string DsTvia { get; set; }
        public string DsAbreviada { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaDirecciones> MetaDirecciones { get; set; }
    }
}
