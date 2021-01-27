using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaEmpleado
    {
        public MetaEmpleado()
        {
            MetaAvisoCdEmpDestinatarioNavigation = new HashSet<MetaAviso>();
            MetaAvisoCdEmpRemitenteNavigation = new HashSet<MetaAviso>();
            MetaEmpleadoAusencia = new HashSet<MetaEmpleadoAusencia>();
            MetaEmpleadoCliente = new HashSet<MetaEmpleadoCliente>();
            MetaEmpleadoDepartamentoCdEmpleadoNavigation = new HashSet<MetaEmpleadoDepartamento>();
            MetaEmpleadoDepartamentoCdResponsableNavigation = new HashSet<MetaEmpleadoDepartamento>();
            MetaEmpleadoFotografia = new HashSet<MetaEmpleadoFotografia>();
            MetaEmpleadoGrupoContabilidad = new HashSet<MetaEmpleadoGrupoContabilidad>();
            MetaEmpleadoLimite = new HashSet<MetaEmpleadoLimite>();
            MetaHojaGastos = new HashSet<MetaHojaGastos>();
            MetaHojaGastosInforme = new HashSet<MetaHojaGastosInforme>();
            MetaRuta = new HashSet<MetaRuta>();
            MetaTarea = new HashSet<MetaTarea>();
            MetaTiendaObjetivo = new HashSet<MetaTiendaObjetivo>();
            MetaTiendaPalanca = new HashSet<MetaTiendaPalanca>();
            MetaTiendaPersonalTrato = new HashSet<MetaTiendaPersonalTrato>();
        }

        public int CdEmpleado { get; set; }
        public string DsNombre { get; set; }
        public string DsApellido1 { get; set; }
        public string DsApellido2 { get; set; }
        public DateTime? FcNacimiento { get; set; }
        public string DsDniNif { get; set; }
        public string DsTelefono { get; set; }
        public string DsExtension { get; set; }
        public string DsTelefono2 { get; set; }
        public string DsMovil { get; set; }
        public string DsMovil2 { get; set; }
        public int? CdDir { get; set; }
        public string DsEmail { get; set; }
        public string DsEmail2 { get; set; }
        public string DsEmail3 { get; set; }
        public int CdZonaEmpleado { get; set; }
        public string DsObservaciones { get; set; }
        public int NmDiasLibresLastYear { get; set; }
        public int NmDiasLibres { get; set; }
        public string UserName { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcFinPeriodoPrueba { get; set; }
        public DateTime? FcBaja { get; set; }
        public int? CdCausaBaja { get; set; }
        public DateTime FcAltaSistema { get; set; }
        public string DsUseralta { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCausaBaja CdCausaBajaNavigation { get; set; }
        public virtual MetaDirecciones CdDirNavigation { get; set; }
        public virtual MetaZonaEmpleado CdZonaEmpleadoNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
        public virtual MetaEmpleadoContabilidad MetaEmpleadoContabilidad { get; set; }
        public virtual ICollection<MetaAviso> MetaAvisoCdEmpDestinatarioNavigation { get; set; }
        public virtual ICollection<MetaAviso> MetaAvisoCdEmpRemitenteNavigation { get; set; }
        public virtual ICollection<MetaEmpleadoAusencia> MetaEmpleadoAusencia { get; set; }
        public virtual ICollection<MetaEmpleadoCliente> MetaEmpleadoCliente { get; set; }
        public virtual ICollection<MetaEmpleadoDepartamento> MetaEmpleadoDepartamentoCdEmpleadoNavigation { get; set; }
        public virtual ICollection<MetaEmpleadoDepartamento> MetaEmpleadoDepartamentoCdResponsableNavigation { get; set; }
        public virtual ICollection<MetaEmpleadoFotografia> MetaEmpleadoFotografia { get; set; }
        public virtual ICollection<MetaEmpleadoGrupoContabilidad> MetaEmpleadoGrupoContabilidad { get; set; }
        public virtual ICollection<MetaEmpleadoLimite> MetaEmpleadoLimite { get; set; }
        public virtual ICollection<MetaHojaGastos> MetaHojaGastos { get; set; }
        public virtual ICollection<MetaHojaGastosInforme> MetaHojaGastosInforme { get; set; }
        public virtual ICollection<MetaRuta> MetaRuta { get; set; }
        public virtual ICollection<MetaTarea> MetaTarea { get; set; }
        public virtual ICollection<MetaTiendaObjetivo> MetaTiendaObjetivo { get; set; }
        public virtual ICollection<MetaTiendaPalanca> MetaTiendaPalanca { get; set; }
        public virtual ICollection<MetaTiendaPersonalTrato> MetaTiendaPersonalTrato { get; set; }
    }
}
