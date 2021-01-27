using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPermisosCuboBi
    {
        public Guid RoleId { get; set; }
        public int CdCubo { get; set; }

        public virtual MetaCuboBi CdCuboNavigation { get; set; }
        public virtual AspnetRoles Role { get; set; }
    }
}
