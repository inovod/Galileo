using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaUsuarioGrupoUsuario
    {
        public int CdGrupoUsuario { get; set; }
        public string UserName { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaGrupoUsuario CdGrupoUsuarioNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
    }
}
