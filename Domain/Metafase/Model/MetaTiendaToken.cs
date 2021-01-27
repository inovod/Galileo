using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaToken
    {
        public int CdTienda { get; set; }
        public string DsUsertoken { get; set; }
        public DateTime? FcUltModificacionTienda { get; set; }

        public virtual MetaTienda CdTiendaNavigation { get; set; }
        public virtual AspnetUsers DsUsertokenNavigation { get; set; }
    }
}
