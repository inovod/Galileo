using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCSubagrupacion
    {
        public MetaCSubagrupacion()
        {
            MetaCEnsena = new HashSet<MetaCEnsena>();
        }

        public int CdSubagrupacion { get; set; }
        public int CdCadena { get; set; }
        public string DsSubagrupacion { get; set; }
        public string DsRutaLogo { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCadena CdCadenaNavigation { get; set; }
        public virtual ICollection<MetaCEnsena> MetaCEnsena { get; set; }
    }
}
