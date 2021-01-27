using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCMedida
    {
        public MetaCMedida()
        {
            MetaCCategoriaExplotacionMedida = new HashSet<MetaCCategoriaExplotacionMedida>();
            MetaCuboBiMedida = new HashSet<MetaCuboBiMedida>();
        }

        public int CdMedida { get; set; }
        public string DsMedida { get; set; }
        public string DsDescripcion { get; set; }
        public bool? ItMedida { get; set; }

        public virtual ICollection<MetaCCategoriaExplotacionMedida> MetaCCategoriaExplotacionMedida { get; set; }
        public virtual ICollection<MetaCuboBiMedida> MetaCuboBiMedida { get; set; }
    }
}
