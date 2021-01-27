using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetPersonalizationAllUsers
    {
        public Guid PathId { get; set; }
        public byte[] PageSettings { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetPaths Path { get; set; }
    }
}
