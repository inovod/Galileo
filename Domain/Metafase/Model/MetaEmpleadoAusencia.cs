using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleadoAusencia
    {
        public int CdPermiso { get; set; }
        public int CdEmpleado { get; set; }
        public DateTime FcFecha { get; set; }
        public int CdEstadoAusencia { get; set; }
        public int CdTipoAusencia { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaCEstadoAusencia CdEstadoAusenciaNavigation { get; set; }
        public virtual MetaCTipoAusencia CdTipoAusenciaNavigation { get; set; }
    }
}
