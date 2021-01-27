using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCartaVentasFaq
    {
        public int CdFaq { get; set; }
        public int CdCartaVentas { get; set; }
        public string DsPregunta { get; set; }
        public string DsRespuesta { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCartaVentas CdCartaVentasNavigation { get; set; }
    }
}
