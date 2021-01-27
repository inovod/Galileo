using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleadoContabilidad
    {
        public int CdEmpleado { get; set; }
        public decimal? NmAnticipo { get; set; }
        public string DsNumeroCuenta { get; set; }
        public int? NmBeneficiario { get; set; }
        public bool ItVisa { get; set; }
        public bool ItSolred { get; set; }
        public int? NmUltimaHoja { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
    }
}
