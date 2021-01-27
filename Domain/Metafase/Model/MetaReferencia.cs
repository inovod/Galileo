using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaReferencia
    {
        public MetaReferencia()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaLimites = new HashSet<MetaLimites>();
            MetaMaterialReferencia = new HashSet<MetaMaterialReferencia>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaPromocionReferencia = new HashSet<MetaPromocionReferencia>();
            MetaReferenciaCodigoInterno = new HashSet<MetaReferenciaCodigoInterno>();
            MetaReferenciaFotografia = new HashSet<MetaReferenciaFotografia>();
            MetaReferenciaPrioridad = new HashSet<MetaReferenciaPrioridad>();
            MetaSurtidoReferencias = new HashSet<MetaSurtidoReferencias>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdReferencia { get; set; }
        public string DsCodEan { get; set; }
        public string DsCodFabricante { get; set; }
        public string DsDescripcion { get; set; }
        public int CdSector { get; set; }
        public int CdFamilia { get; set; }
        public int CdCategoria { get; set; }
        public int? CdSubcategoria { get; set; }
        public int CdSegmento { get; set; }
        public int? CdSubsegmento { get; set; }
        public int CdCliente { get; set; }
        public int CdMarca { get; set; }
        public int? CdNivel1 { get; set; }
        public int? CdNivel2 { get; set; }
        public int? CdNivel3 { get; set; }
        public int? CdNivel4 { get; set; }
        public int? CdNivel5 { get; set; }
        public int? CdNivel6 { get; set; }
        public byte ItVisibilidad { get; set; }
        public bool? ItActiva { get; set; }
        public int? NmRanking { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }
        public DateTime FcAltaSistema { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUseralta { get; set; }
        public string DsUserbaja { get; set; }
        public string DsUsermodif { get; set; }
        public byte[] TsVersion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaMarca Cd { get; set; }
        public virtual MetaCSegmento CdNavigation { get; set; }
        public virtual MetaCategoriaCliente CdNivel { get; set; }
        public virtual MetaCSubcategoria CdSubcategoriaNavigation { get; set; }
        public virtual MetaCSubsegmento CdSubsegmentoNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaLimites> MetaLimites { get; set; }
        public virtual ICollection<MetaMaterialReferencia> MetaMaterialReferencia { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaPromocionReferencia> MetaPromocionReferencia { get; set; }
        public virtual ICollection<MetaReferenciaCodigoInterno> MetaReferenciaCodigoInterno { get; set; }
        public virtual ICollection<MetaReferenciaFotografia> MetaReferenciaFotografia { get; set; }
        public virtual ICollection<MetaReferenciaPrioridad> MetaReferenciaPrioridad { get; set; }
        public virtual ICollection<MetaSurtidoReferencias> MetaSurtidoReferencias { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
