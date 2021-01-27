using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaDepartamento
    {
        public MetaDepartamento()
        {
            MetaPuesto = new HashSet<MetaPuesto>();
        }

        public int CdDepartamento { get; set; }
        public string DsDepartamento { get; set; }
        public string DsDescripcion { get; set; }
        public int NmOrden { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaPuesto> MetaPuesto { get; set; }
    }
}
