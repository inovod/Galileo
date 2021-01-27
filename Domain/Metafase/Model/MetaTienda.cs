using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTienda
    {
        public MetaTienda()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaAviso = new HashSet<MetaAviso>();
            MetaRespuestasCuestionario = new HashSet<MetaRespuestasCuestionario>();
            MetaTiendaCategoria = new HashSet<MetaTiendaCategoria>();
            MetaTiendaConfiguracion = new HashSet<MetaTiendaConfiguracion>();
            MetaTiendaDupDwh = new HashSet<MetaTiendaDupDwh>();
            MetaTiendaObjetivo = new HashSet<MetaTiendaObjetivo>();
            MetaTiendaPalanca = new HashSet<MetaTiendaPalanca>();
            MetaTiendaPersonal = new HashSet<MetaTiendaPersonal>();
            MetaTiendaPotencialCategoria = new HashSet<MetaTiendaPotencialCategoria>();
            MetaTiendaPotencialFamilia = new HashSet<MetaTiendaPotencialFamilia>();
            MetaTiendaSeccion = new HashSet<MetaTiendaSeccion>();
            MetaTiendaSegmento = new HashSet<MetaTiendaSegmento>();
            MetaTiendasRuta = new HashSet<MetaTiendasRuta>();
            MetaVisita = new HashSet<MetaVisita>();
            MetaVisitaDisponible = new HashSet<MetaVisitaDisponible>();
        }

        public int CdTienda { get; set; }
        public string DsCodNielsen { get; set; }
        public string DsCodCadena { get; set; }
        public int CdCanal { get; set; }
        public int CdCadena { get; set; }
        public int CdEnsena { get; set; }
        public int CdDir { get; set; }
        public int CdEstadoTienda { get; set; }
        public string DsTelefono { get; set; }
        public string DsFax { get; set; }
        public string DsWeb { get; set; }
        public decimal? NmLatitud { get; set; }
        public decimal? NmLongitud { get; set; }
        public string DsLote { get; set; }
        public string DsObservaciones { get; set; }
        public string DsObservacionesVend { get; set; }
        public decimal? NmSuperficie { get; set; }
        public int? NmEscaparates { get; set; }
        public int? NmCajas { get; set; }
        public bool? ItComidas { get; set; }
        public int? CdTipoEstablecimiento { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }
        public DateTime FcAltaSistema { get; set; }
        public string DsUseralta { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }
        public byte[] TsVersion { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual MetaDirecciones CdDirNavigation { get; set; }
        public virtual MetaCEstadoTienda CdEstadoTiendaNavigation { get; set; }
        public virtual MetaCTipoEstablecimiento CdTipoEstablecimientoNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual MetaTiendaFoto MetaTiendaFoto { get; set; }
        public virtual MetaTiendaToken MetaTiendaToken { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaAviso> MetaAviso { get; set; }
        public virtual ICollection<MetaRespuestasCuestionario> MetaRespuestasCuestionario { get; set; }
        public virtual ICollection<MetaTiendaCategoria> MetaTiendaCategoria { get; set; }
        public virtual ICollection<MetaTiendaConfiguracion> MetaTiendaConfiguracion { get; set; }
        public virtual ICollection<MetaTiendaDupDwh> MetaTiendaDupDwh { get; set; }
        public virtual ICollection<MetaTiendaObjetivo> MetaTiendaObjetivo { get; set; }
        public virtual ICollection<MetaTiendaPalanca> MetaTiendaPalanca { get; set; }
        public virtual ICollection<MetaTiendaPersonal> MetaTiendaPersonal { get; set; }
        public virtual ICollection<MetaTiendaPotencialCategoria> MetaTiendaPotencialCategoria { get; set; }
        public virtual ICollection<MetaTiendaPotencialFamilia> MetaTiendaPotencialFamilia { get; set; }
        public virtual ICollection<MetaTiendaSeccion> MetaTiendaSeccion { get; set; }
        public virtual ICollection<MetaTiendaSegmento> MetaTiendaSegmento { get; set; }
        public virtual ICollection<MetaTiendasRuta> MetaTiendasRuta { get; set; }
        public virtual ICollection<MetaVisita> MetaVisita { get; set; }
        public virtual ICollection<MetaVisitaDisponible> MetaVisitaDisponible { get; set; }
    }
}
