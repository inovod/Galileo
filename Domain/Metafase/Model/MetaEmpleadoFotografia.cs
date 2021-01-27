using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleadoFotografia
    {
        public int CdEmpleado { get; set; }
        public int CdFotografia { get; set; }
        public byte[] FsFotografia { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
    }
}
