using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPromocionEnsena
    {
        public int CdPromocion { get; set; }
        public int CdEnsena { get; set; }
        public int CdCadena { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual MetaPromocion CdPromocionNavigation { get; set; }
    }
}
