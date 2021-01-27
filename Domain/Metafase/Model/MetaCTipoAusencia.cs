using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoAusencia
    {
        public MetaCTipoAusencia()
        {
            MetaEmpleadoAusencia = new HashSet<MetaEmpleadoAusencia>();
        }

        public int CdTipoAusencia { get; set; }
        public string DsTipoAusencia { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaEmpleadoAusencia> MetaEmpleadoAusencia { get; set; }
    }
}
