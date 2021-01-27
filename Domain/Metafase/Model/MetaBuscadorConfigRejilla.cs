using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaBuscadorConfigRejilla
    {
        public Guid CdConfig { get; set; }
        public byte[] TlRejilla { get; set; }

        public virtual MetaBuscadorConfig CdConfigNavigation { get; set; }
    }
}
