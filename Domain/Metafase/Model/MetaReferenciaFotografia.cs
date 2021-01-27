using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaReferenciaFotografia
    {
        public int CdReferencia { get; set; }
        public int CdFotografia { get; set; }
        public byte[] FsFotografia { get; set; }
        public bool ItPrincipal { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
    }
}
