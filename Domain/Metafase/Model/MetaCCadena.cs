using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCadena
    {
        public MetaCCadena()
        {
            MetaCCanalCadena = new HashSet<MetaCCanalCadena>();
            MetaCEnsena = new HashSet<MetaCEnsena>();
            MetaCSubagrupacion = new HashSet<MetaCSubagrupacion>();
            MetaMaterialCadena = new HashSet<MetaMaterialCadena>();
            MetaPromocionCadena = new HashSet<MetaPromocionCadena>();
        }

        public int CdCadena { get; set; }
        public string DsCadena { get; set; }
        public string DsRutaLogo { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaCCanalCadena> MetaCCanalCadena { get; set; }
        public virtual ICollection<MetaCEnsena> MetaCEnsena { get; set; }
        public virtual ICollection<MetaCSubagrupacion> MetaCSubagrupacion { get; set; }
        public virtual ICollection<MetaMaterialCadena> MetaMaterialCadena { get; set; }
        public virtual ICollection<MetaPromocionCadena> MetaPromocionCadena { get; set; }
    }
}
