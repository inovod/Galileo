using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoTarea
    {
        public MetaCTipoTarea()
        {
            MetaGrupoUsuarioTipoTarea = new HashSet<MetaGrupoUsuarioTipoTarea>();
            MetaTarea = new HashSet<MetaTarea>();
        }

        public int CdTipoTarea { get; set; }
        public string DsTipoTarea { get; set; }
        public string DsColor { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaGrupoUsuarioTipoTarea> MetaGrupoUsuarioTipoTarea { get; set; }
        public virtual ICollection<MetaTarea> MetaTarea { get; set; }
    }
}
