using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaMarca
    {
        public MetaMarca()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaMaterialMarca = new HashSet<MetaMaterialMarca>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaPromocionMarca = new HashSet<MetaPromocionMarca>();
            MetaReferencia = new HashSet<MetaReferencia>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdMarca { get; set; }
        public int CdCliente { get; set; }
        public string DsMarca { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaMaterialMarca> MetaMaterialMarca { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaPromocionMarca> MetaPromocionMarca { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferencia { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
