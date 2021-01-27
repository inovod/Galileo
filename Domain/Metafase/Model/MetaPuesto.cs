using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPuesto
    {
        public MetaPuesto()
        {
            InverseCd = new HashSet<MetaPuesto>();
            MetaEmpleadoDepartamento = new HashSet<MetaEmpleadoDepartamento>();
        }

        public int CdDepartamento { get; set; }
        public int CdPuesto { get; set; }
        public int? CdDepartamentoDepende { get; set; }
        public int? CdPuestoDepende { get; set; }
        public string DsPuesto { get; set; }
        public string ItVisibleMapa { get; set; }
        public int NmOrden { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPuesto Cd { get; set; }
        public virtual MetaDepartamento CdDepartamentoNavigation { get; set; }
        public virtual ICollection<MetaPuesto> InverseCd { get; set; }
        public virtual ICollection<MetaEmpleadoDepartamento> MetaEmpleadoDepartamento { get; set; }
    }
}
