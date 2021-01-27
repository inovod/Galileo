using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaUsuarioClienteCategoria
    {
        public string UserName { get; set; }
        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }

        public virtual MetaCCategoria Cd { get; set; }
    }
}
