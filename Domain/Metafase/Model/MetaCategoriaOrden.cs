using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCategoriaOrden
    {
        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public int CdCliente { get; set; }
        public byte NmOrden { get; set; }
        public byte NmOrdenInforme { get; set; }

        public virtual MetaCCategoria Cd { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
    }
}
