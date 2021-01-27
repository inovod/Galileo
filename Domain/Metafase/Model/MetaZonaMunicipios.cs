using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaZonaMunicipios
    {
        public int CdZona { get; set; }
        public string CdProv { get; set; }
        public string CdMuni { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCMunicipio Cd { get; set; }
        public virtual MetaCZona CdZonaNavigation { get; set; }
    }
}
