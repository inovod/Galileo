using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaClienteLogo
    {
        public int CdLogo { get; set; }
        public int CdCliente { get; set; }
        public byte[] FsLogo { get; set; }
        public bool ItPrincipal { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
    }
}
