using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCAutonomia
    {
        public MetaCAutonomia()
        {
            MetaCProvincia = new HashSet<MetaCProvincia>();
            MetaFestivo = new HashSet<MetaFestivo>();
        }

        public string CdAutonomia { get; set; }
        public string DsAutonomia { get; set; }
        public string DsAbrevGmaps { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaCProvincia> MetaCProvincia { get; set; }
        public virtual ICollection<MetaFestivo> MetaFestivo { get; set; }
    }
}
