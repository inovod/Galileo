using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCEstadoTarea
    {
        public MetaCEstadoTarea()
        {
            MetaTarea = new HashSet<MetaTarea>();
        }

        public int CdEstadoTarea { get; set; }
        public string DsEstadoTarea { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaTarea> MetaTarea { get; set; }
    }
}
