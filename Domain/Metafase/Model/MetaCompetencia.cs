using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCompetencia
    {
        public int CdCliente { get; set; }
        public int CdCompetidor { get; set; }
        public string DsDescripcion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaCliente CdCompetidorNavigation { get; set; }
    }
}
