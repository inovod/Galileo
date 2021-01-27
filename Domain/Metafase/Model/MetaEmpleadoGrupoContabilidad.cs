using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleadoGrupoContabilidad
    {
        public int CdGrupoContabilidad { get; set; }
        public int CdEmpleado { get; set; }
        public decimal NmPorcentajeDedicacion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaGrupoContabilidad CdGrupoContabilidadNavigation { get; set; }
    }
}
