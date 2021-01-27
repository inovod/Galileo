using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaMaterialReferencia
    {
        public int CdMaterial { get; set; }
        public int CdReferencia { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaMaterialVisibilidad CdMaterialNavigation { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
    }
}
