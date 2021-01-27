using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaGrupoUsuario
    {
        public MetaGrupoUsuario()
        {
            MetaGrupoUsuarioTipoTarea = new HashSet<MetaGrupoUsuarioTipoTarea>();
            MetaUsuarioGrupoUsuario = new HashSet<MetaUsuarioGrupoUsuario>();
        }

        public int CdGrupoUsuario { get; set; }
        public string DsGrupoUsuario { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaGrupoUsuarioTipoTarea> MetaGrupoUsuarioTipoTarea { get; set; }
        public virtual ICollection<MetaUsuarioGrupoUsuario> MetaUsuarioGrupoUsuario { get; set; }
    }
}
