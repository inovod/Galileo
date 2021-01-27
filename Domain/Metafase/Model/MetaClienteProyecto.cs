using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaClienteProyecto
    {
        public int CdProyecto { get; set; }
        public int CdCliente { get; set; }
        public string DsProyecto { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
    }
}
