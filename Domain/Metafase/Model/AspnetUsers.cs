using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetUsers
    {
        public AspnetUsers()
        {
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
            MetaBuscadorConfig = new HashSet<MetaBuscadorConfig>();
            MetaClienteDsUseraltaNavigation = new HashSet<MetaCliente>();
            MetaClienteDsUserbajaNavigation = new HashSet<MetaCliente>();
            MetaClienteDsUsermodifNavigation = new HashSet<MetaCliente>();
            MetaConfiguracion = new HashSet<MetaConfiguracion>();
            MetaCuestionarioDsUseraltaNavigation = new HashSet<MetaCuestionario>();
            MetaCuestionarioDsUserbajaNavigation = new HashSet<MetaCuestionario>();
            MetaCuestionarioDsUsermodifNavigation = new HashSet<MetaCuestionario>();
            MetaDirecciones = new HashSet<MetaDirecciones>();
            MetaDocumento = new HashSet<MetaDocumento>();
            MetaEmpleadoDsUseraltaNavigation = new HashSet<MetaEmpleado>();
            MetaEmpleadoDsUserbajaNavigation = new HashSet<MetaEmpleado>();
            MetaEmpleadoDsUsermodifNavigation = new HashSet<MetaEmpleado>();
            MetaEmpleadoUserNameNavigation = new HashSet<MetaEmpleado>();
            MetaHojaGastosDsUseraltaNavigation = new HashSet<MetaHojaGastos>();
            MetaHojaGastosDsUserbajaNavigation = new HashSet<MetaHojaGastos>();
            MetaHojaGastosDsUsermodifNavigation = new HashSet<MetaHojaGastos>();
            MetaInformeClienteWeb = new HashSet<MetaInformeClienteWeb>();
            MetaLog = new HashSet<MetaLog>();
            MetaLogH = new HashSet<MetaLogH>();
            MetaMaterialVisibilidadDsUseraltaNavigation = new HashSet<MetaMaterialVisibilidad>();
            MetaMaterialVisibilidadDsUserbajaNavigation = new HashSet<MetaMaterialVisibilidad>();
            MetaMaterialVisibilidadDsUsermodifNavigation = new HashSet<MetaMaterialVisibilidad>();
            MetaPromocionDsUseraltaNavigation = new HashSet<MetaPromocion>();
            MetaPromocionDsUserbajaNavigation = new HashSet<MetaPromocion>();
            MetaPromocionDsUsermodifNavigation = new HashSet<MetaPromocion>();
            MetaReferenciaDsUseraltaNavigation = new HashSet<MetaReferencia>();
            MetaReferenciaDsUserbajaNavigation = new HashSet<MetaReferencia>();
            MetaReferenciaDsUsermodifNavigation = new HashSet<MetaReferencia>();
            MetaRutaDsUseraltaNavigation = new HashSet<MetaRuta>();
            MetaRutaDsUserbajaNavigation = new HashSet<MetaRuta>();
            MetaRutaDsUsermodifNavigation = new HashSet<MetaRuta>();
            MetaSurtidoDsUseraltaNavigation = new HashSet<MetaSurtido>();
            MetaSurtidoDsUserbajaNavigation = new HashSet<MetaSurtido>();
            MetaSurtidoDsUsermodifNavigation = new HashSet<MetaSurtido>();
            MetaTareaDsUseraltaNavigation = new HashSet<MetaTarea>();
            MetaTareaDsUserbajaNavigation = new HashSet<MetaTarea>();
            MetaTiendaConfiguracionDsUseraltaNavigation = new HashSet<MetaTiendaConfiguracion>();
            MetaTiendaConfiguracionDsUsermodifNavigation = new HashSet<MetaTiendaConfiguracion>();
            MetaTiendaDsUseraltaNavigation = new HashSet<MetaTienda>();
            MetaTiendaDsUserbajaNavigation = new HashSet<MetaTienda>();
            MetaTiendaToken = new HashSet<MetaTiendaToken>();
            MetaUsuarioEquipo = new HashSet<MetaUsuarioEquipo>();
            MetaUsuarioGrupoUsuario = new HashSet<MetaUsuarioGrupoUsuario>();
            MetaVistaInforme = new HashSet<MetaVistaInforme>();
        }

        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetApplications Application { get; set; }
        public virtual AspnetMembership AspnetMembership { get; set; }
        public virtual AspnetProfile AspnetProfile { get; set; }
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual ICollection<MetaBuscadorConfig> MetaBuscadorConfig { get; set; }
        public virtual ICollection<MetaCliente> MetaClienteDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaCliente> MetaClienteDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaCliente> MetaClienteDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaConfiguracion> MetaConfiguracion { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionarioDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionarioDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionarioDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaDirecciones> MetaDirecciones { get; set; }
        public virtual ICollection<MetaDocumento> MetaDocumento { get; set; }
        public virtual ICollection<MetaEmpleado> MetaEmpleadoDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaEmpleado> MetaEmpleadoDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaEmpleado> MetaEmpleadoDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaEmpleado> MetaEmpleadoUserNameNavigation { get; set; }
        public virtual ICollection<MetaHojaGastos> MetaHojaGastosDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaHojaGastos> MetaHojaGastosDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaHojaGastos> MetaHojaGastosDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaInformeClienteWeb> MetaInformeClienteWeb { get; set; }
        public virtual ICollection<MetaLog> MetaLog { get; set; }
        public virtual ICollection<MetaLogH> MetaLogH { get; set; }
        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidadDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidadDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidadDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaPromocion> MetaPromocionDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaPromocion> MetaPromocionDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaPromocion> MetaPromocionDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferenciaDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferenciaDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferenciaDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaRuta> MetaRutaDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaRuta> MetaRutaDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaRuta> MetaRutaDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaSurtido> MetaSurtidoDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaSurtido> MetaSurtidoDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaSurtido> MetaSurtidoDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaTarea> MetaTareaDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaTarea> MetaTareaDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaTiendaConfiguracion> MetaTiendaConfiguracionDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaTiendaConfiguracion> MetaTiendaConfiguracionDsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaTienda> MetaTiendaDsUseraltaNavigation { get; set; }
        public virtual ICollection<MetaTienda> MetaTiendaDsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaTiendaToken> MetaTiendaToken { get; set; }
        public virtual ICollection<MetaUsuarioEquipo> MetaUsuarioEquipo { get; set; }
        public virtual ICollection<MetaUsuarioGrupoUsuario> MetaUsuarioGrupoUsuario { get; set; }
        public virtual ICollection<MetaVistaInforme> MetaVistaInforme { get; set; }
    }
}
