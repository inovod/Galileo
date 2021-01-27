using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaPalanca
    {
        public int CdPalancaTienda { get; set; }
        public int CdPalanca { get; set; }
        public int CdTienda { get; set; }
        public int? CdEmpleado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaCPalanca CdPalancaNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
