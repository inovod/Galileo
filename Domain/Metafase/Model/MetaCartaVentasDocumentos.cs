using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCartaVentasDocumentos
    {
        public int CdCartaVentas { get; set; }
        public int CdDocumento { get; set; }
        public string DsDocumento { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCartaVentas CdCartaVentasNavigation { get; set; }
        public virtual MetaDocumento CdDocumentoNavigation { get; set; }
    }
}
