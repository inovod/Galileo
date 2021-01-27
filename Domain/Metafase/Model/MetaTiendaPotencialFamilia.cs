using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaPotencialFamilia
    {
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public int CdTienda { get; set; }
        public double NmPotencial { get; set; }

        public virtual MetaCFamilia Cd { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
