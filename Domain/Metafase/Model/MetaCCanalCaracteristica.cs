using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCanalCaracteristica
    {
        public Guid Rowguid { get; set; }
        public string DsCaracteristica { get; set; }
        public int? CdCanal { get; set; }

        public virtual MetaCCanal CdCanalNavigation { get; set; }
    }
}
