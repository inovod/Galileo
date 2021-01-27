using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleadoLimite
    {
        public int CdConcepto { get; set; }
        public int CdEmpleado { get; set; }
        public int? NmLimite { get; set; }
        public decimal NmMultiplicador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaConcepto CdConceptoNavigation { get; set; }
        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
    }
}
