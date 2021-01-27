using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetApplications
    {
        public AspnetApplications()
        {
            AspnetMembership = new HashSet<AspnetMembership>();
            AspnetPaths = new HashSet<AspnetPaths>();
            AspnetRoles = new HashSet<AspnetRoles>();
            AspnetUsers = new HashSet<AspnetUsers>();
            MetaConfiguracion = new HashSet<MetaConfiguracion>();
            MetaConfiguracionUsuario = new HashSet<MetaConfiguracionUsuario>();
            MetaPermisos = new HashSet<MetaPermisos>();
        }

        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string LoweredApplicationName { get; set; }
        public string Description { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<AspnetMembership> AspnetMembership { get; set; }
        public virtual ICollection<AspnetPaths> AspnetPaths { get; set; }
        public virtual ICollection<AspnetRoles> AspnetRoles { get; set; }
        public virtual ICollection<AspnetUsers> AspnetUsers { get; set; }
        public virtual ICollection<MetaConfiguracion> MetaConfiguracion { get; set; }
        public virtual ICollection<MetaConfiguracionUsuario> MetaConfiguracionUsuario { get; set; }
        public virtual ICollection<MetaPermisos> MetaPermisos { get; set; }
    }
}
