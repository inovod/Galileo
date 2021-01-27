using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaFestivo
    {
        public int CdFestivo { get; set; }
        public DateTime FcFecha { get; set; }
        public string CdPais { get; set; }
        public string CdAutonomia { get; set; }
        public string CdProv { get; set; }
        public string CdMuni { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCMunicipio Cd { get; set; }
        public virtual MetaCAutonomia CdAutonomiaNavigation { get; set; }
        public virtual MetaCPais CdPaisNavigation { get; set; }
    }
}
