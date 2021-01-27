using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaInformeCliente
    {
        public int CdCliente { get; set; }
        public int CdInforme { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaInforme CdInformeNavigation { get; set; }
    }
}
