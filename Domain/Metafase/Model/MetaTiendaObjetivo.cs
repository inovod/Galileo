using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaObjetivo
    {
        public Guid Rowguid { get; set; }
        public int CdTienda { get; set; }
        public DateTime FcAlta { get; set; }
        public string DsObjetivo { get; set; }
        public int CdCliente { get; set; }
        public int? CdEmpleado { get; set; }
        public Guid RowguidVisita { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
