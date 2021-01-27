using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaZonaEmpleado
    {
        public MetaZonaEmpleado()
        {
            MetaEmpleado = new HashSet<MetaEmpleado>();
        }

        public int CdZonaEmpleado { get; set; }
        public string DsZonaEmpleado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaEmpleado> MetaEmpleado { get; set; }
    }
}
