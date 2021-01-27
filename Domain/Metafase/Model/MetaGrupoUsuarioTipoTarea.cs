using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaGrupoUsuarioTipoTarea
    {
        public int CdGrupoUsuario { get; set; }
        public int CdTipoTarea { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaGrupoUsuario CdGrupoUsuarioNavigation { get; set; }
        public virtual MetaCTipoTarea CdTipoTareaNavigation { get; set; }
    }
}
