using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaSeccion
    {
        public int CdDato { get; set; }
        public int CdTienda { get; set; }
        public int CdSeccion { get; set; }
        public int? NmModulos { get; set; }
        public int? NmCabecerasGondola { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCSeccion CdSeccionNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
