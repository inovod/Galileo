using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleadoDepartamento
    {
        public int CdEmpleadoDepartamento { get; set; }
        public int CdEmpleado { get; set; }
        public int CdDepartamento { get; set; }
        public int? CdResponsable { get; set; }
        public int CdPuesto { get; set; }
        public DateTime FcInicio { get; set; }
        public DateTime? FcFin { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPuesto Cd { get; set; }
        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaEmpleado CdResponsableNavigation { get; set; }
    }
}
