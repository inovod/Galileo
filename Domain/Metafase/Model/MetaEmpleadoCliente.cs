using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleadoCliente
    {
        public int CdEmpleadoCliente { get; set; }
        public int CdEmpleado { get; set; }
        public int CdCliente { get; set; }
        public bool ItCompetidor { get; set; }
        public DateTime FcInicio { get; set; }
        public DateTime? FcFin { get; set; }
        public Guid Rowguid { get; set; }
        public bool ItHistorico { get; set; }
        public string DsNombreEquipo { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
    }
}
