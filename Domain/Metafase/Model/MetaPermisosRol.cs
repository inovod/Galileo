using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPermisosRol
    {
        public Guid RoleId { get; set; }
        public int CdPermiso { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPermisos CdPermisoNavigation { get; set; }
        public virtual AspnetRoles Role { get; set; }
    }
}
