using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCPalanca
    {
        public MetaCPalanca()
        {
            MetaTiendaPalanca = new HashSet<MetaTiendaPalanca>();
        }

        public int CdPalanca { get; set; }
        public string DsPalanca { get; set; }
        public string DsDescripcion { get; set; }
        public int? CdCanal { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual ICollection<MetaTiendaPalanca> MetaTiendaPalanca { get; set; }
    }
}
