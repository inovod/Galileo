using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaGrupoContabilidad
    {
        public MetaGrupoContabilidad()
        {
            MetaEmpleadoGrupoContabilidad = new HashSet<MetaEmpleadoGrupoContabilidad>();
        }

        public int CdGrupoContabilidad { get; set; }
        public string DsGrupoContabilidad { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaEmpleadoGrupoContabilidad> MetaEmpleadoGrupoContabilidad { get; set; }
    }
}
