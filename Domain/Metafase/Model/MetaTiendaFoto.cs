using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaFoto
    {
        public int CdTienda { get; set; }
        public byte[] FsFotografia { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
