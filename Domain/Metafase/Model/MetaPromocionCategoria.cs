using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPromocionCategoria
    {
        public int CdPromocion { get; set; }
        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCategoria Cd { get; set; }
        public virtual MetaPromocion CdPromocionNavigation { get; set; }
    }
}
