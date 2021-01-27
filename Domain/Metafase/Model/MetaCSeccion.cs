using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCSeccion
    {
        public MetaCSeccion()
        {
            MetaTiendaSeccion = new HashSet<MetaTiendaSeccion>();
        }

        public int CdSeccion { get; set; }
        public string DsSeccion { get; set; }
        public int CdCanal { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual ICollection<MetaTiendaSeccion> MetaTiendaSeccion { get; set; }
    }
}
