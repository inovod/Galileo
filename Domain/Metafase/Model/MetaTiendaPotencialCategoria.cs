using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaPotencialCategoria
    {
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public int CdCategoria { get; set; }
        public int CdTienda { get; set; }
        public decimal NmPotencial { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCategoria Cd { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
