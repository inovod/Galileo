using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaHojaGastosInforme
    {
        public Guid CdHoja { get; set; }
        public int CdEmpleado { get; set; }
        public byte[] FsInforme { get; set; }
        public byte[] FsInformeGestion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaHojaGastos CdHojaNavigation { get; set; }
    }
}
