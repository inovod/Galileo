using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCategoriaExplotacionMedida
    {
        public int CdCategoria { get; set; }
        public int CdMedida { get; set; }

        public virtual MetaCCategoriaExplotacion CdCategoriaNavigation { get; set; }
        public virtual MetaCMedida CdMedidaNavigation { get; set; }
    }
}
