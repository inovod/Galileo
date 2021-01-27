using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCProvincia
    {
        public MetaCProvincia()
        {
            MetaCMunicipio = new HashSet<MetaCMunicipio>();
            MetaDirecciones = new HashSet<MetaDirecciones>();
        }

        public string CdProv { get; set; }
        public string CdAutonomia { get; set; }
        public string DsProv { get; set; }
        public decimal? NmLatitud { get; set; }
        public decimal? NmLongitud { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCAutonomia CdAutonomiaNavigation { get; set; }
        public virtual ICollection<MetaCMunicipio> MetaCMunicipio { get; set; }
        public virtual ICollection<MetaDirecciones> MetaDirecciones { get; set; }
    }
}
