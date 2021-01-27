using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPromocionFotografia
    {
        public int CdPromocion { get; set; }
        public int CdFotografia { get; set; }
        public byte[] FsFotografia { get; set; }
        public bool ItPrincipal { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPromocion CdPromocionNavigation { get; set; }
    }
}
