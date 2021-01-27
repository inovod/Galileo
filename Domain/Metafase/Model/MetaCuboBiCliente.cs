using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCuboBiCliente
    {
        public int CdCubo { get; set; }
        public int CdCliente { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaCuboBi CdCuboNavigation { get; set; }
    }
}
