using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaUsuarioClienteEnsena
    {
        public int CdEnsena { get; set; }
        public int CdCadena { get; set; }
        public string UserName { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
    }
}
