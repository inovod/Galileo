using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaMaterialVisibilidad
    {
        public MetaMaterialVisibilidad()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaMaterialCadena = new HashSet<MetaMaterialCadena>();
            MetaMaterialCategoria = new HashSet<MetaMaterialCategoria>();
            MetaMaterialEnsena = new HashSet<MetaMaterialEnsena>();
            MetaMaterialFotografia = new HashSet<MetaMaterialFotografia>();
            MetaMaterialMarca = new HashSet<MetaMaterialMarca>();
            MetaMaterialReferencia = new HashSet<MetaMaterialReferencia>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdMaterial { get; set; }
        public string DsMaterial { get; set; }
        public string DsDescripcion { get; set; }
        public int? CdTipoMaterial { get; set; }
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
        public DateTime FcAltaSistema { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUseralta { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }
        public byte[] TsVersion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaCategoriaCliente CdNivel { get; set; }
        public virtual MetaCTipoMaterialVisibilidad CdTipoMaterialNavigation { get; set; }
        public virtual MetaCZona CdZonaNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaMaterialCadena> MetaMaterialCadena { get; set; }
        public virtual ICollection<MetaMaterialCategoria> MetaMaterialCategoria { get; set; }
        public virtual ICollection<MetaMaterialEnsena> MetaMaterialEnsena { get; set; }
        public virtual ICollection<MetaMaterialFotografia> MetaMaterialFotografia { get; set; }
        public virtual ICollection<MetaMaterialMarca> MetaMaterialMarca { get; set; }
        public virtual ICollection<MetaMaterialReferencia> MetaMaterialReferencia { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
