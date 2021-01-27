using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPromocionMarca
    {
        public int CdPromocion { get; set; }
        public int CdMarca { get; set; }
        public int CdCliente { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaMarca Cd { get; set; }
        public virtual MetaPromocion CdPromocionNavigation { get; set; }
    }
}
