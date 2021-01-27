using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaDuracionVisita
    {
        public int CdCanal { get; set; }
        public int CdCliente { get; set; }
        public int? NmDuracionVisita { get; set; }

        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
    }
}
