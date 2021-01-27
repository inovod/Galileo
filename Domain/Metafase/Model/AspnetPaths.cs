using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetPaths
    {
        public AspnetPaths()
        {
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
        }

        public Guid PathId { get; set; }
        public Guid ApplicationId { get; set; }
        public string Path { get; set; }
        public string LoweredPath { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetApplications Application { get; set; }
        public virtual AspnetPersonalizationAllUsers AspnetPersonalizationAllUsers { get; set; }
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
    }
}
