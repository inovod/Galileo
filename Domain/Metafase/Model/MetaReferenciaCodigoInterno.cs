using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaReferenciaCodigoInterno
    {
        public int CdEnsena { get; set; }
        public int CdCadena { get; set; }
        public int CdReferencia { get; set; }
        public string DsCodigoInterno { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
    }
}
