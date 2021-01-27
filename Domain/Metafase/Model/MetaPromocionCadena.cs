using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPromocionCadena
    {
        public int CdPromocion { get; set; }
        public int CdCadena { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCadena CdCadenaNavigation { get; set; }
        public virtual MetaPromocion CdPromocionNavigation { get; set; }
    }
}
