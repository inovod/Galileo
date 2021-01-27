using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPermisosInforme
    {
        public Guid RoleId { get; set; }
        public int CdInforme { get; set; }

        public virtual MetaInforme CdInformeNavigation { get; set; }
        public virtual AspnetRoles Role { get; set; }
    }
}
