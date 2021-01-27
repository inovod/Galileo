using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCEstadoAusencia
    {
        public MetaCEstadoAusencia()
        {
            MetaEmpleadoAusencia = new HashSet<MetaEmpleadoAusencia>();
        }

        public int CdEstadoAusencia { get; set; }
        public string DsEstadoAusencia { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaEmpleadoAusencia> MetaEmpleadoAusencia { get; set; }
    }
}
