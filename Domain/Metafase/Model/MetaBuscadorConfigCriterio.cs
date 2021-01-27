using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaBuscadorConfigCriterio
    {
        public Guid CdConfig { get; set; }
        public int CdCriterio { get; set; }
        public string DsCriterio { get; set; }
        public string DsValor { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaBuscadorConfig CdConfigNavigation { get; set; }
    }
}
