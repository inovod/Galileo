using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPromocion
    {
        public MetaPromocion()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaPromocionCadena = new HashSet<MetaPromocionCadena>();
            MetaPromocionCategoria = new HashSet<MetaPromocionCategoria>();
            MetaPromocionCodigoInterno = new HashSet<MetaPromocionCodigoInterno>();
            MetaPromocionEnsena = new HashSet<MetaPromocionEnsena>();
            MetaPromocionFotografia = new HashSet<MetaPromocionFotografia>();
            MetaPromocionMarca = new HashSet<MetaPromocionMarca>();
            MetaPromocionReferencia = new HashSet<MetaPromocionReferencia>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdPromocion { get; set; }
        public string DsPromocion { get; set; }
        public string DsDescripcion { get; set; }
        public int CdCliente { get; set; }
        public int? CdCanal { get; set; }
        public int? CdZona { get; set; }
        public int NmOrden { get; set; }
        public int? CdNivel1 { get; set; }
        public int? CdNivel2 { get; set; }
        public int? CdNivel3 { get; set; }
        public int? CdNivel4 { get; set; }
        public int? CdNivel5 { get; set; }
        public int? CdNivel6 { get; set; }
        public byte ItVisibilidad { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public DateTime FcAltaSistema { get; set; }
        public string DsUseralta { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }
        public byte[] TsVersion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaCategoriaCliente CdNivel { get; set; }
        public virtual MetaCZona CdZonaNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaPromocionCadena> MetaPromocionCadena { get; set; }
        public virtual ICollection<MetaPromocionCategoria> MetaPromocionCategoria { get; set; }
        public virtual ICollection<MetaPromocionCodigoInterno> MetaPromocionCodigoInterno { get; set; }
        public virtual ICollection<MetaPromocionEnsena> MetaPromocionEnsena { get; set; }
        public virtual ICollection<MetaPromocionFotografia> MetaPromocionFotografia { get; set; }
        public virtual ICollection<MetaPromocionMarca> MetaPromocionMarca { get; set; }
        public virtual ICollection<MetaPromocionReferencia> MetaPromocionReferencia { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
