using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCpostalDistrito
    {
        public string CdProv { get; set; }
        public string CdMuni { get; set; }
        public string CdCpostal { get; set; }
        public int CdDistrito { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCpostal Cd { get; set; }
        public virtual MetaCDistrito CdDistritoNavigation { get; set; }
    }
}
