using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaHojaGastosFechaApunte
    {
        public int CdFecha { get; set; }
        public Guid CdHoja { get; set; }
        public int CdConcepto { get; set; }
        public decimal NmValor { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaHojaGastosFecha Cd { get; set; }
        public virtual MetaConcepto CdConceptoNavigation { get; set; }
    }
}
