using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaClienteContrato
    {
        public int CdCliente { get; set; }
        public int NmLicencias { get; set; }
        public int? NmDiasMaximo { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
    }
}
