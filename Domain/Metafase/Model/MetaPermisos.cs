using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPermisos
    {
        public MetaPermisos()
        {
            MetaPermisosRol = new HashSet<MetaPermisosRol>();
        }

        public int CdPermiso { get; set; }
        public Guid ApplicationId { get; set; }
        public string DsPermiso { get; set; }
        public string DsDescripcion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetApplications Application { get; set; }
        public virtual ICollection<MetaPermisosRol> MetaPermisosRol { get; set; }
    }
}
