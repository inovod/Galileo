using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCategoria
    {
        public MetaCCategoria()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaCSegmento = new HashSet<MetaCSegmento>();
            MetaCSubcategoria = new HashSet<MetaCSubcategoria>();
            MetaCategoriaOrden = new HashSet<MetaCategoriaOrden>();
            MetaMaterialCategoria = new HashSet<MetaMaterialCategoria>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaPromocionCategoria = new HashSet<MetaPromocionCategoria>();
            MetaTiendaCategoria = new HashSet<MetaTiendaCategoria>();
            MetaTiendaPotencialCategoria = new HashSet<MetaTiendaPotencialCategoria>();
            MetaUsuarioClienteCategoria = new HashSet<MetaUsuarioClienteCategoria>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public string DsCategoria { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCFamilia Cd { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaCSegmento> MetaCSegmento { get; set; }
        public virtual ICollection<MetaCSubcategoria> MetaCSubcategoria { get; set; }
        public virtual ICollection<MetaCategoriaOrden> MetaCategoriaOrden { get; set; }
        public virtual ICollection<MetaMaterialCategoria> MetaMaterialCategoria { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaPromocionCategoria> MetaPromocionCategoria { get; set; }
        public virtual ICollection<MetaTiendaCategoria> MetaTiendaCategoria { get; set; }
        public virtual ICollection<MetaTiendaPotencialCategoria> MetaTiendaPotencialCategoria { get; set; }
        public virtual ICollection<MetaUsuarioClienteCategoria> MetaUsuarioClienteCategoria { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
