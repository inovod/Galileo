using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCEstadoHojaGastos
    {
        public MetaCEstadoHojaGastos()
        {
            MetaHojaGastos = new HashSet<MetaHojaGastos>();
        }

        public int CdEstado { get; set; }
        public string DsEstado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaHojaGastos> MetaHojaGastos { get; set; }
    }
}
