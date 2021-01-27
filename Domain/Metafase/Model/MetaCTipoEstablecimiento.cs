using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoEstablecimiento
    {
        public MetaCTipoEstablecimiento()
        {
            MetaTienda = new HashSet<MetaTienda>();
        }

        public int CdTipoEstablecimiento { get; set; }
        public string DsTipoEstablecimiento { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaTienda> MetaTienda { get; set; }
    }
}
