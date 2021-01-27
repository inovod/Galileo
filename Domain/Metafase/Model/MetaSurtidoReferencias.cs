using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaSurtidoReferencias
    {
        public int CdSurtidoReferencia { get; set; }
        public int CdSurtido { get; set; }
        public int CdReferencia { get; set; }
        public int? CdCluster { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCluster CdClusterNavigation { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
        public virtual MetaSurtido CdSurtidoNavigation { get; set; }
    }
}
