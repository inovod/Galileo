using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPromocionReferencia
    {
        public int CdPromocion { get; set; }
        public int CdReferencia { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPromocion CdPromocionNavigation { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
    }
}
