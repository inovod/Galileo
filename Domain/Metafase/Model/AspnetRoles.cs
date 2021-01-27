using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetRoles
    {
        public AspnetRoles()
        {
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
            MetaPermisosCuboBi = new HashSet<MetaPermisosCuboBi>();
            MetaPermisosInforme = new HashSet<MetaPermisosInforme>();
            MetaPermisosRol = new HashSet<MetaPermisosRol>();
        }

        public Guid RoleId { get; set; }
        public Guid ApplicationId { get; set; }
        public string RoleName { get; set; }
        public string LoweredRoleName { get; set; }
        public string Description { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetApplications Application { get; set; }
        public virtual ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual ICollection<MetaPermisosCuboBi> MetaPermisosCuboBi { get; set; }
        public virtual ICollection<MetaPermisosInforme> MetaPermisosInforme { get; set; }
        public virtual ICollection<MetaPermisosRol> MetaPermisosRol { get; set; }
    }
}
