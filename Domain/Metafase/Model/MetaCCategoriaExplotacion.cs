using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCategoriaExplotacion
    {
        public MetaCCategoriaExplotacion()
        {
            MetaCCategoriaExplotacionMedida = new HashSet<MetaCCategoriaExplotacionMedida>();
            MetaCuboBi = new HashSet<MetaCuboBi>();
            MetaInforme = new HashSet<MetaInforme>();
        }

        public int CdCategoria { get; set; }
        public string DsCategoria { get; set; }
        public string DsCubo { get; set; }

        public virtual ICollection<MetaCCategoriaExplotacionMedida> MetaCCategoriaExplotacionMedida { get; set; }
        public virtual ICollection<MetaCuboBi> MetaCuboBi { get; set; }
        public virtual ICollection<MetaInforme> MetaInforme { get; set; }
    }
}
