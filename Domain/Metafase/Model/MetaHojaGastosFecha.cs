using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaHojaGastosFecha
    {
        public MetaHojaGastosFecha()
        {
            MetaHojaGastosFechaApunte = new HashSet<MetaHojaGastosFechaApunte>();
        }

        public int CdFecha { get; set; }
        public Guid CdHoja { get; set; }
        public string DsObservaciones { get; set; }
        public DateTime FcFecha { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaHojaGastos CdHojaNavigation { get; set; }
        public virtual ICollection<MetaHojaGastosFechaApunte> MetaHojaGastosFechaApunte { get; set; }
    }
}
