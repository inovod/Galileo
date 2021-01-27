using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCEstadoTienda
    {
        public MetaCEstadoTienda()
        {
            MetaTienda = new HashSet<MetaTienda>();
        }

        public int CdEstadoTienda { get; set; }
        public string DsEstadoTienda { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaTienda> MetaTienda { get; set; }
    }
}
