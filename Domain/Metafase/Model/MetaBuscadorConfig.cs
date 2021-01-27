using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaBuscadorConfig
    {
        public MetaBuscadorConfig()
        {
            MetaBuscadorConfigCriterio = new HashSet<MetaBuscadorConfigCriterio>();
        }

        public Guid CdConfig { get; set; }
        public int CdBuscador { get; set; }
        public string DsConfiguracion { get; set; }
        public bool ItFavorita { get; set; }
        public string UserName { get; set; }

        public virtual MetaBuscador CdBuscadorNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
        public virtual MetaBuscadorConfigRejilla MetaBuscadorConfigRejilla { get; set; }
        public virtual ICollection<MetaBuscadorConfigCriterio> MetaBuscadorConfigCriterio { get; set; }
    }
}
