using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCliente
    {
        public MetaCliente()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaAviso = new HashSet<MetaAviso>();
            MetaCTipoObservacion = new HashSet<MetaCTipoObservacion>();
            MetaCZona = new HashSet<MetaCZona>();
            MetaCartaVentas = new HashSet<MetaCartaVentas>();
            MetaCategoriaCliente = new HashSet<MetaCategoriaCliente>();
            MetaCategoriaOrden = new HashSet<MetaCategoriaOrden>();
            MetaClienteLogo = new HashSet<MetaClienteLogo>();
            MetaClienteProyecto = new HashSet<MetaClienteProyecto>();
            MetaClienteVistaCuboBi = new HashSet<MetaClienteVistaCuboBi>();
            MetaCompetenciaCdClienteNavigation = new HashSet<MetaCompetencia>();
            MetaCompetenciaCdCompetidorNavigation = new HashSet<MetaCompetencia>();
            MetaCuboBiCliente = new HashSet<MetaCuboBiCliente>();
            MetaCuestionarioCdClienteNavigation = new HashSet<MetaCuestionario>();
            MetaCuestionarioCdCompetidorNavigation = new HashSet<MetaCuestionario>();
            MetaDuracionVisita = new HashSet<MetaDuracionVisita>();
            MetaEmpleadoCliente = new HashSet<MetaEmpleadoCliente>();
            MetaInformeCliente = new HashSet<MetaInformeCliente>();
            MetaMarca = new HashSet<MetaMarca>();
            MetaMaterialVisibilidad = new HashSet<MetaMaterialVisibilidad>();
            MetaNivelCategoriaCliente = new HashSet<MetaNivelCategoriaCliente>();
            MetaPromocion = new HashSet<MetaPromocion>();
            MetaRuta = new HashSet<MetaRuta>();
            MetaSegmentoOrden = new HashSet<MetaSegmentoOrden>();
            MetaSurtido = new HashSet<MetaSurtido>();
            MetaTiendaObjetivo = new HashSet<MetaTiendaObjetivo>();
            MetaVisita = new HashSet<MetaVisita>();
        }

        public int CdCliente { get; set; }
        public string DsCliente { get; set; }
        public string DsAbreviatura { get; set; }
        public int CdFabricante { get; set; }
        public string ItCompetidor { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }
        public string DsUseralta { get; set; }
        public DateTime FcAltaSistema { get; set; }
        public string DsUsermodif { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUserbaja { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaFabricante CdFabricanteNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual MetaClienteContrato MetaClienteContrato { get; set; }
        public virtual MetaClienteFtp MetaClienteFtp { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaAviso> MetaAviso { get; set; }
        public virtual ICollection<MetaCTipoObservacion> MetaCTipoObservacion { get; set; }
        public virtual ICollection<MetaCZona> MetaCZona { get; set; }
        public virtual ICollection<MetaCartaVentas> MetaCartaVentas { get; set; }
        public virtual ICollection<MetaCategoriaCliente> MetaCategoriaCliente { get; set; }
        public virtual ICollection<MetaCategoriaOrden> MetaCategoriaOrden { get; set; }
        public virtual ICollection<MetaClienteLogo> MetaClienteLogo { get; set; }
        public virtual ICollection<MetaClienteProyecto> MetaClienteProyecto { get; set; }
        public virtual ICollection<MetaClienteVistaCuboBi> MetaClienteVistaCuboBi { get; set; }
        public virtual ICollection<MetaCompetencia> MetaCompetenciaCdClienteNavigation { get; set; }
        public virtual ICollection<MetaCompetencia> MetaCompetenciaCdCompetidorNavigation { get; set; }
        public virtual ICollection<MetaCuboBiCliente> MetaCuboBiCliente { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionarioCdClienteNavigation { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionarioCdCompetidorNavigation { get; set; }
        public virtual ICollection<MetaDuracionVisita> MetaDuracionVisita { get; set; }
        public virtual ICollection<MetaEmpleadoCliente> MetaEmpleadoCliente { get; set; }
        public virtual ICollection<MetaInformeCliente> MetaInformeCliente { get; set; }
        public virtual ICollection<MetaMarca> MetaMarca { get; set; }
        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidad { get; set; }
        public virtual ICollection<MetaNivelCategoriaCliente> MetaNivelCategoriaCliente { get; set; }
        public virtual ICollection<MetaPromocion> MetaPromocion { get; set; }
        public virtual ICollection<MetaRuta> MetaRuta { get; set; }
        public virtual ICollection<MetaSegmentoOrden> MetaSegmentoOrden { get; set; }
        public virtual ICollection<MetaSurtido> MetaSurtido { get; set; }
        public virtual ICollection<MetaTiendaObjetivo> MetaTiendaObjetivo { get; set; }
        public virtual ICollection<MetaVisita> MetaVisita { get; set; }
    }
}
