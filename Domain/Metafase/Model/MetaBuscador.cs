using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaBuscador
    {
        public MetaBuscador()
        {
            MetaBuscadorConfig = new HashSet<MetaBuscadorConfig>();
        }

        public int CdBuscador { get; set; }
        public string DsBuscador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaBuscadorConfig> MetaBuscadorConfig { get; set; }
    }
}
