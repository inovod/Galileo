using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaClienteVistaCuboBi
    {
        public int CdCliente { get; set; }
        public int CdVistaCubo { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaVistaCuboBi CdVistaCuboNavigation { get; set; }
    }
}
