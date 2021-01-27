using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCPais
    {
        public MetaCPais()
        {
            MetaDirecciones = new HashSet<MetaDirecciones>();
            MetaFestivo = new HashSet<MetaFestivo>();
        }

        public string CdPais { get; set; }
        public string DsPais { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaDirecciones> MetaDirecciones { get; set; }
        public virtual ICollection<MetaFestivo> MetaFestivo { get; set; }
    }
}
