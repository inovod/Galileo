using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaDupDwh
    {
        public int CdTienda { get; set; }
        public int CdTiendaDup { get; set; }

        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
