using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaAnotacion
    {
        public MetaAnotacion()
        {
            MetaAnotacionTipo = new HashSet<MetaAnotacionTipo>();
            MetaFotografiaFoto = new HashSet<MetaFotografiaFoto>();
        }

        public Guid CdAnotacion { get; set; }
        public DateTime FcVisita { get; set; }
        public int? CdSector { get; set; }
        public int? CdFamilia { get; set; }
        public int? CdCategoria { get; set; }
        public int? CdSegmento { get; set; }
        public int? CdSubcategoria { get; set; }
        public int? CdSubsegmento { get; set; }
        public int? CdReferencia { get; set; }
        public int? CdMaterial { get; set; }
        public int? CdPromocion { get; set; }
        public int? CdMarca { get; set; }
        public int CdCliente { get; set; }
        public int? CdTienda { get; set; }
        public byte ItObjeto { get; set; }
        public string UserName { get; set; }
        public Guid RowguidVisita { get; set; }
        public bool? ItHistorico { get; set; }

        public virtual MetaMarca Cd { get; set; }
        public virtual MetaCSegmento Cd1 { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaMaterialVisibilidad CdMaterialNavigation { get; set; }
        public virtual MetaCCategoria CdNavigation { get; set; }
        public virtual MetaPromocion CdPromocionNavigation { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
        public virtual MetaCSubcategoria CdSubcategoriaNavigation { get; set; }
        public virtual MetaCSubsegmento CdSubsegmentoNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
        public virtual MetaVisita RowguidVisitaNavigation { get; set; }
        public virtual ICollection<MetaAnotacionTipo> MetaAnotacionTipo { get; set; }
        public virtual ICollection<MetaFotografiaFoto> MetaFotografiaFoto { get; set; }
    }
}
