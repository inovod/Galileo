using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCSituacionTarea
    {
        public MetaCSituacionTarea()
        {
            MetaTarea = new HashSet<MetaTarea>();
        }

        public short CdSituacionTarea { get; set; }
        public string DsSituacionTarea { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaTarea> MetaTarea { get; set; }
    }
}
