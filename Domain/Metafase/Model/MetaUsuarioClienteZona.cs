using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaUsuarioClienteZona
    {
        public int CdZona { get; set; }
        public string UserName { get; set; }

        public virtual MetaCZona CdZonaNavigation { get; set; }
    }
}
