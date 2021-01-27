using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaConcepto
    {
        public MetaConcepto()
        {
            MetaEmpleadoLimite = new HashSet<MetaEmpleadoLimite>();
            MetaHojaGastosFechaApunte = new HashSet<MetaHojaGastosFechaApunte>();
        }

        public int CdConcepto { get; set; }
        public string DsConcepto { get; set; }
        public int? NmLimite { get; set; }
        public decimal NmMultiplicador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaEmpleadoLimite> MetaEmpleadoLimite { get; set; }
        public virtual ICollection<MetaHojaGastosFechaApunte> MetaHojaGastosFechaApunte { get; set; }
    }
}
