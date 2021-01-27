using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCMunicipio
    {
        public MetaCMunicipio()
        {
            MetaCCpostal = new HashSet<MetaCCpostal>();
            MetaDirecciones = new HashSet<MetaDirecciones>();
            MetaFestivo = new HashSet<MetaFestivo>();
            MetaZonaMunicipios = new HashSet<MetaZonaMunicipios>();
        }

        public string CdProv { get; set; }
        public string CdMuni { get; set; }
        public string DsMuni { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCProvincia CdProvNavigation { get; set; }
        public virtual ICollection<MetaCCpostal> MetaCCpostal { get; set; }
        public virtual ICollection<MetaDirecciones> MetaDirecciones { get; set; }
        public virtual ICollection<MetaFestivo> MetaFestivo { get; set; }
        public virtual ICollection<MetaZonaMunicipios> MetaZonaMunicipios { get; set; }
    }
}
