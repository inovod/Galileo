using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaVisitaVuelta
    {
        public Guid RowguidVisita { get; set; }
        public int NmVuelta { get; set; }
        public byte ItEstadoDwh { get; set; }

        public virtual MetaVisita RowguidVisitaNavigation { get; set; }
    }
}
