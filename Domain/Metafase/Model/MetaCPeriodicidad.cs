using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCPeriodicidad
    {
        public MetaCPeriodicidad()
        {
            MetaRuta = new HashSet<MetaRuta>();
        }

        public byte CdPeriodicidad { get; set; }
        public string DsPeriodicidad { get; set; }
        public string DsAbreviatura { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaRuta> MetaRuta { get; set; }
    }
}
