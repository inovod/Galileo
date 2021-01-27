using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCausaBaja
    {
        public MetaCausaBaja()
        {
            MetaEmpleado = new HashSet<MetaEmpleado>();
        }

        public int CdCausaBaja { get; set; }
        public string DsCausaBaja { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaEmpleado> MetaEmpleado { get; set; }
    }
}
