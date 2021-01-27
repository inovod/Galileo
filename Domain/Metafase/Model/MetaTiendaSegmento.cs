using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaSegmento
    {
        public int CdDato { get; set; }
        public int? NmModulos { get; set; }
        public int? NmMueblesFijos { get; set; }
        public int? NmBaldas { get; set; }
        public int? NmMedidaBalda { get; set; }
        public int? NmSeparacionBaldas { get; set; }
        public int CdSegmento { get; set; }
        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public int? CdTienda { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCSegmento Cd { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
