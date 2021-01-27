using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.Metafase.Model
{
    public partial class Metafase : DbContext
    {
        public Metafase()
        {
        }

        public Metafase(DbContextOptions<Metafase> options)
            : base(options)
        {
        }

        public virtual DbSet<AlturaCdm> AlturaCdm { get; set; }
        public virtual DbSet<AlturaCdmg1> AlturaCdmg1 { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<CustomCuboCabecera> CustomCuboCabecera { get; set; }
        public virtual DbSet<ExhibicionesCdm> ExhibicionesCdm { get; set; }
        public virtual DbSet<ExhibicionesCdmg2> ExhibicionesCdmg2 { get; set; }
        public virtual DbSet<FacingCdm> FacingCdm { get; set; }
        public virtual DbSet<FacingCdmg1> FacingCdmg1 { get; set; }
        public virtual DbSet<LogAurora> LogAurora { get; set; }
        public virtual DbSet<MejoraCdmg1> MejoraCdmg1 { get; set; }
        public virtual DbSet<MejoraCdmg2> MejoraCdmg2 { get; set; }
        public virtual DbSet<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual DbSet<MetaAnotacionFoto> MetaAnotacionFoto { get; set; }
        public virtual DbSet<MetaAnotacionTipo> MetaAnotacionTipo { get; set; }
        public virtual DbSet<MetaAviso> MetaAviso { get; set; }
        public virtual DbSet<MetaBuscador> MetaBuscador { get; set; }
        public virtual DbSet<MetaBuscadorConfig> MetaBuscadorConfig { get; set; }
        public virtual DbSet<MetaBuscadorConfigCriterio> MetaBuscadorConfigCriterio { get; set; }
        public virtual DbSet<MetaBuscadorConfigRejilla> MetaBuscadorConfigRejilla { get; set; }
        public virtual DbSet<MetaCAutonomia> MetaCAutonomia { get; set; }
        public virtual DbSet<MetaCCadena> MetaCCadena { get; set; }
        public virtual DbSet<MetaCCanal> MetaCCanal { get; set; }
        public virtual DbSet<MetaCCanalCadena> MetaCCanalCadena { get; set; }
        public virtual DbSet<MetaCCanalCaracteristica> MetaCCanalCaracteristica { get; set; }
        public virtual DbSet<MetaCCategoria> MetaCCategoria { get; set; }
        public virtual DbSet<MetaCCategoriaExplotacion> MetaCCategoriaExplotacion { get; set; }
        public virtual DbSet<MetaCCategoriaExplotacionMedida> MetaCCategoriaExplotacionMedida { get; set; }
        public virtual DbSet<MetaCCluster> MetaCCluster { get; set; }
        public virtual DbSet<MetaCCpostal> MetaCCpostal { get; set; }
        public virtual DbSet<MetaCCpostalDistrito> MetaCCpostalDistrito { get; set; }
        public virtual DbSet<MetaCDistrito> MetaCDistrito { get; set; }
        public virtual DbSet<MetaCEnsena> MetaCEnsena { get; set; }
        public virtual DbSet<MetaCEstadoAusencia> MetaCEstadoAusencia { get; set; }
        public virtual DbSet<MetaCEstadoHojaGastos> MetaCEstadoHojaGastos { get; set; }
        public virtual DbSet<MetaCEstadoTarea> MetaCEstadoTarea { get; set; }
        public virtual DbSet<MetaCEstadoTienda> MetaCEstadoTienda { get; set; }
        public virtual DbSet<MetaCFamilia> MetaCFamilia { get; set; }
        public virtual DbSet<MetaCMedida> MetaCMedida { get; set; }
        public virtual DbSet<MetaCMensajeUsuario> MetaCMensajeUsuario { get; set; }
        public virtual DbSet<MetaCMunicipio> MetaCMunicipio { get; set; }
        public virtual DbSet<MetaCPais> MetaCPais { get; set; }
        public virtual DbSet<MetaCPalanca> MetaCPalanca { get; set; }
        public virtual DbSet<MetaCPeriodicidad> MetaCPeriodicidad { get; set; }
        public virtual DbSet<MetaCProvincia> MetaCProvincia { get; set; }
        public virtual DbSet<MetaCSeccion> MetaCSeccion { get; set; }
        public virtual DbSet<MetaCSector> MetaCSector { get; set; }
        public virtual DbSet<MetaCSegmento> MetaCSegmento { get; set; }
        public virtual DbSet<MetaCSituacionTarea> MetaCSituacionTarea { get; set; }
        public virtual DbSet<MetaCSubagrupacion> MetaCSubagrupacion { get; set; }
        public virtual DbSet<MetaCSubcategoria> MetaCSubcategoria { get; set; }
        public virtual DbSet<MetaCSubsegmento> MetaCSubsegmento { get; set; }
        public virtual DbSet<MetaCTipoAusencia> MetaCTipoAusencia { get; set; }
        public virtual DbSet<MetaCTipoAviso> MetaCTipoAviso { get; set; }
        public virtual DbSet<MetaCTipoDocumento> MetaCTipoDocumento { get; set; }
        public virtual DbSet<MetaCTipoEstablecimiento> MetaCTipoEstablecimiento { get; set; }
        public virtual DbSet<MetaCTipoMaterialVisibilidad> MetaCTipoMaterialVisibilidad { get; set; }
        public virtual DbSet<MetaCTipoObservacion> MetaCTipoObservacion { get; set; }
        public virtual DbSet<MetaCTipoRegistro> MetaCTipoRegistro { get; set; }
        public virtual DbSet<MetaCTipoTarea> MetaCTipoTarea { get; set; }
        public virtual DbSet<MetaCTvias> MetaCTvias { get; set; }
        public virtual DbSet<MetaCVersion> MetaCVersion { get; set; }
        public virtual DbSet<MetaCZona> MetaCZona { get; set; }
        public virtual DbSet<MetaCartaVentas> MetaCartaVentas { get; set; }
        public virtual DbSet<MetaCartaVentasDocumentos> MetaCartaVentasDocumentos { get; set; }
        public virtual DbSet<MetaCartaVentasEnsena> MetaCartaVentasEnsena { get; set; }
        public virtual DbSet<MetaCartaVentasFaq> MetaCartaVentasFaq { get; set; }
        public virtual DbSet<MetaCategoriaCliente> MetaCategoriaCliente { get; set; }
        public virtual DbSet<MetaCategoriaOrden> MetaCategoriaOrden { get; set; }
        public virtual DbSet<MetaCausaBaja> MetaCausaBaja { get; set; }
        public virtual DbSet<MetaCausaNoVisita> MetaCausaNoVisita { get; set; }
        public virtual DbSet<MetaCliente> MetaCliente { get; set; }
        public virtual DbSet<MetaClienteContrato> MetaClienteContrato { get; set; }
        public virtual DbSet<MetaClienteFtp> MetaClienteFtp { get; set; }
        public virtual DbSet<MetaClienteLogo> MetaClienteLogo { get; set; }
        public virtual DbSet<MetaClienteProyecto> MetaClienteProyecto { get; set; }
        public virtual DbSet<MetaClienteVistaCuboBi> MetaClienteVistaCuboBi { get; set; }
        public virtual DbSet<MetaCompetencia> MetaCompetencia { get; set; }
        public virtual DbSet<MetaConcepto> MetaConcepto { get; set; }
        public virtual DbSet<MetaConfiguracion> MetaConfiguracion { get; set; }
        public virtual DbSet<MetaConfiguracionUsuario> MetaConfiguracionUsuario { get; set; }
        public virtual DbSet<MetaCuboBi> MetaCuboBi { get; set; }
        public virtual DbSet<MetaCuboBiCliente> MetaCuboBiCliente { get; set; }
        public virtual DbSet<MetaCuboBiMedida> MetaCuboBiMedida { get; set; }
        public virtual DbSet<MetaCuestionario> MetaCuestionario { get; set; }
        public virtual DbSet<MetaDepartamento> MetaDepartamento { get; set; }
        public virtual DbSet<MetaDirecciones> MetaDirecciones { get; set; }
        public virtual DbSet<MetaDocumento> MetaDocumento { get; set; }
        public virtual DbSet<MetaDuracionVisita> MetaDuracionVisita { get; set; }
        public virtual DbSet<MetaEmpleado> MetaEmpleado { get; set; }
        public virtual DbSet<MetaEmpleadoAusencia> MetaEmpleadoAusencia { get; set; }
        public virtual DbSet<MetaEmpleadoCliente> MetaEmpleadoCliente { get; set; }
        public virtual DbSet<MetaEmpleadoContabilidad> MetaEmpleadoContabilidad { get; set; }
        public virtual DbSet<MetaEmpleadoDepartamento> MetaEmpleadoDepartamento { get; set; }
        public virtual DbSet<MetaEmpleadoFotografia> MetaEmpleadoFotografia { get; set; }
        public virtual DbSet<MetaEmpleadoGrupoContabilidad> MetaEmpleadoGrupoContabilidad { get; set; }
        public virtual DbSet<MetaEmpleadoLimite> MetaEmpleadoLimite { get; set; }
        public virtual DbSet<MetaFabricante> MetaFabricante { get; set; }
        public virtual DbSet<MetaFestivo> MetaFestivo { get; set; }
        public virtual DbSet<MetaFotoAurora> MetaFotoAurora { get; set; }
        public virtual DbSet<MetaFotografiaFoto> MetaFotografiaFoto { get; set; }
        public virtual DbSet<MetaGrupoContabilidad> MetaGrupoContabilidad { get; set; }
        public virtual DbSet<MetaGrupoUsuario> MetaGrupoUsuario { get; set; }
        public virtual DbSet<MetaGrupoUsuarioTipoTarea> MetaGrupoUsuarioTipoTarea { get; set; }
        public virtual DbSet<MetaHojaGastos> MetaHojaGastos { get; set; }
        public virtual DbSet<MetaHojaGastosFecha> MetaHojaGastosFecha { get; set; }
        public virtual DbSet<MetaHojaGastosFechaApunte> MetaHojaGastosFechaApunte { get; set; }
        public virtual DbSet<MetaHojaGastosInforme> MetaHojaGastosInforme { get; set; }
        public virtual DbSet<MetaInforme> MetaInforme { get; set; }
        public virtual DbSet<MetaInformeCliente> MetaInformeCliente { get; set; }
        public virtual DbSet<MetaInformeClienteWeb> MetaInformeClienteWeb { get; set; }
        public virtual DbSet<MetaInformePlantilla> MetaInformePlantilla { get; set; }
        public virtual DbSet<MetaInformeQuery> MetaInformeQuery { get; set; }
        public virtual DbSet<MetaLimites> MetaLimites { get; set; }
        public virtual DbSet<MetaLog> MetaLog { get; set; }
        public virtual DbSet<MetaLogH> MetaLogH { get; set; }
        public virtual DbSet<MetaMarca> MetaMarca { get; set; }
        public virtual DbSet<MetaMaterialCadena> MetaMaterialCadena { get; set; }
        public virtual DbSet<MetaMaterialCategoria> MetaMaterialCategoria { get; set; }
        public virtual DbSet<MetaMaterialEnsena> MetaMaterialEnsena { get; set; }
        public virtual DbSet<MetaMaterialFotografia> MetaMaterialFotografia { get; set; }
        public virtual DbSet<MetaMaterialMarca> MetaMaterialMarca { get; set; }
        public virtual DbSet<MetaMaterialReferencia> MetaMaterialReferencia { get; set; }
        public virtual DbSet<MetaMaterialVisibilidad> MetaMaterialVisibilidad { get; set; }
        public virtual DbSet<MetaNivelCategoriaCliente> MetaNivelCategoriaCliente { get; set; }
        public virtual DbSet<MetaPermisos> MetaPermisos { get; set; }
        public virtual DbSet<MetaPermisosCuboBi> MetaPermisosCuboBi { get; set; }
        public virtual DbSet<MetaPermisosInforme> MetaPermisosInforme { get; set; }
        public virtual DbSet<MetaPermisosRol> MetaPermisosRol { get; set; }
        public virtual DbSet<MetaPreguntas> MetaPreguntas { get; set; }
        public virtual DbSet<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual DbSet<MetaPreguntasLista> MetaPreguntasLista { get; set; }
        public virtual DbSet<MetaPreguntasListaValores> MetaPreguntasListaValores { get; set; }
        public virtual DbSet<MetaPreguntasSubtipoLista> MetaPreguntasSubtipoLista { get; set; }
        public virtual DbSet<MetaPreguntasSubtipoListaValores> MetaPreguntasSubtipoListaValores { get; set; }
        public virtual DbSet<MetaPromocion> MetaPromocion { get; set; }
        public virtual DbSet<MetaPromocionCadena> MetaPromocionCadena { get; set; }
        public virtual DbSet<MetaPromocionCategoria> MetaPromocionCategoria { get; set; }
        public virtual DbSet<MetaPromocionCodigoInterno> MetaPromocionCodigoInterno { get; set; }
        public virtual DbSet<MetaPromocionEnsena> MetaPromocionEnsena { get; set; }
        public virtual DbSet<MetaPromocionFotografia> MetaPromocionFotografia { get; set; }
        public virtual DbSet<MetaPromocionMarca> MetaPromocionMarca { get; set; }
        public virtual DbSet<MetaPromocionReferencia> MetaPromocionReferencia { get; set; }
        public virtual DbSet<MetaPuesto> MetaPuesto { get; set; }
        public virtual DbSet<MetaReferencia> MetaReferencia { get; set; }
        public virtual DbSet<MetaReferenciaCodigoInterno> MetaReferenciaCodigoInterno { get; set; }
        public virtual DbSet<MetaReferenciaFotografia> MetaReferenciaFotografia { get; set; }
        public virtual DbSet<MetaReferenciaPrioridad> MetaReferenciaPrioridad { get; set; }
        public virtual DbSet<MetaRespuestasCuestionario> MetaRespuestasCuestionario { get; set; }
        public virtual DbSet<MetaRespuestasCuestionarioDwh> MetaRespuestasCuestionarioDwh { get; set; }
        public virtual DbSet<MetaRuta> MetaRuta { get; set; }
        public virtual DbSet<MetaSegmentoOrden> MetaSegmentoOrden { get; set; }
        public virtual DbSet<MetaSincronizacion> MetaSincronizacion { get; set; }
        public virtual DbSet<MetaSurtido> MetaSurtido { get; set; }
        public virtual DbSet<MetaSurtidoReferencias> MetaSurtidoReferencias { get; set; }
        public virtual DbSet<MetaTarea> MetaTarea { get; set; }
        public virtual DbSet<MetaTienda> MetaTienda { get; set; }
        public virtual DbSet<MetaTiendaCategoria> MetaTiendaCategoria { get; set; }
        public virtual DbSet<MetaTiendaConfiguracion> MetaTiendaConfiguracion { get; set; }
        public virtual DbSet<MetaTiendaDupDwh> MetaTiendaDupDwh { get; set; }
        public virtual DbSet<MetaTiendaFoto> MetaTiendaFoto { get; set; }
        public virtual DbSet<MetaTiendaObjetivo> MetaTiendaObjetivo { get; set; }
        public virtual DbSet<MetaTiendaPalanca> MetaTiendaPalanca { get; set; }
        public virtual DbSet<MetaTiendaPersonal> MetaTiendaPersonal { get; set; }
        public virtual DbSet<MetaTiendaPersonalTrato> MetaTiendaPersonalTrato { get; set; }
        public virtual DbSet<MetaTiendaPotencialCategoria> MetaTiendaPotencialCategoria { get; set; }
        public virtual DbSet<MetaTiendaPotencialFamilia> MetaTiendaPotencialFamilia { get; set; }
        public virtual DbSet<MetaTiendaSeccion> MetaTiendaSeccion { get; set; }
        public virtual DbSet<MetaTiendaSegmento> MetaTiendaSegmento { get; set; }
        public virtual DbSet<MetaTiendaToken> MetaTiendaToken { get; set; }
        public virtual DbSet<MetaTiendasRuta> MetaTiendasRuta { get; set; }
        public virtual DbSet<MetaUsuarioCliente> MetaUsuarioCliente { get; set; }
        public virtual DbSet<MetaUsuarioClienteCategoria> MetaUsuarioClienteCategoria { get; set; }
        public virtual DbSet<MetaUsuarioClienteEnsena> MetaUsuarioClienteEnsena { get; set; }
        public virtual DbSet<MetaUsuarioClienteZona> MetaUsuarioClienteZona { get; set; }
        public virtual DbSet<MetaUsuarioEquipo> MetaUsuarioEquipo { get; set; }
        public virtual DbSet<MetaUsuarioGrupoUsuario> MetaUsuarioGrupoUsuario { get; set; }
        public virtual DbSet<MetaVisita> MetaVisita { get; set; }
        public virtual DbSet<MetaVisitaDisponible> MetaVisitaDisponible { get; set; }
        public virtual DbSet<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
        public virtual DbSet<MetaVisitaVuelta> MetaVisitaVuelta { get; set; }
        public virtual DbSet<MetaVistaCuboBi> MetaVistaCuboBi { get; set; }
        public virtual DbSet<MetaVistaInforme> MetaVistaInforme { get; set; }
        public virtual DbSet<MetaZonaEmpleado> MetaZonaEmpleado { get; set; }
        public virtual DbSet<MetaZonaMunicipios> MetaZonaMunicipios { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<PromocionCdm> PromocionCdm { get; set; }
        public virtual DbSet<PromocionCdmg1> PromocionCdmg1 { get; set; }
        public virtual DbSet<PromocionCdmg1fechas> PromocionCdmg1fechas { get; set; }
        public virtual DbSet<PromocionCdmg2> PromocionCdmg2 { get; set; }
        public virtual DbSet<SurtidoCdm> SurtidoCdm { get; set; }
        public virtual DbSet<SurtidoCdmg2> SurtidoCdmg2 { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<VisitaCdmg2> VisitaCdmg2 { get; set; }

        // Unable to generate entity type for table 'dbo.surtidoCDMG1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.surtidoCDMG1Fechas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.surtidoCDMPDV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ESTADO_INDICES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1421_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1435_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1461_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1463_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1467_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fotos_jpg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1483_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fotosDLV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1494_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1495_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fotos_png'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1499_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fotos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1503_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.plv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cluster$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1506_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1507_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1509_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1511_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1512_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1517_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1520_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1525_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pvpCDMG2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1526_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1528_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1529_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.surtido'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1535_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1537_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1550_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1551_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1552_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1559_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fotos_new'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1566_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1568_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1569_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1570_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1571_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1572_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_CUBO_1573_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TELLO$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_TIENDA_AUX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMPETENCIATELLO$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.alturaCDMG2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.exhibicionesCDMG1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.facingCDMG1Fechas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.facingCDMG2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mejoraCDM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tiendas$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fotos_vileda$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.META_USUARIO_CLIENTE_MARCA'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AlturaCdm>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("AlturaCDM");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Altura).HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.DsPregunta)
                    .HasColumnName("DS_PREGUNTA")
                    .HasMaxLength(150);

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");
            });

            modelBuilder.Entity<AlturaCdmg1>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("AlturaCDMG1");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Altura).HasMaxLength(150);

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.DsPregunta)
                    .HasColumnName("DS_PREGUNTA")
                    .HasMaxLength(150);

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .HasMaxLength(150);

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_applications")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__3091033107020F21")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK3aspnet_Applications")
                    .IsUnique();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tmp_ms_x__1788CC4D0D3AD6BB")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1aspnet_Membership")
                    .IsUnique();

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasName("aspnet_Membership_index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDateLocal)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(dateadd(minute,datediff(minute,getutcdate(),getdate()),[LastLoginDate]))");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Applications_aspnet_Membership");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Users_aspnet_Membership");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5859063A47")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK2aspnet_Paths")
                    .IsUnique();

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath })
                    .HasName("aspnet_Paths_index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Applications_aspnet_Paths");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5960A75C0F");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1aspnet_PersonalizationAllUsers")
                    .IsUnique();

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__628FA481");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC06656C112C")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK3aspnet_PersonalizationPerUser")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("XIF2aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId })
                    .HasName("aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId })
                    .HasName("aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__68487DD7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Users_aspnet_PersonalizationPerUser");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C36B12243");

                entity.ToTable("aspnet_Profile");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1aspnet_Profile")
                    .IsUnique();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Users_aspnet_Profile");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_Roles")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK2aspnet_Roles")
                    .IsUnique();

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasName("aspnet_Roles_index1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Applications_aspnet_Roles");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC11367E606");

                entity.ToTable("aspnet_SchemaVersions");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1aspnet_SchemaVersions")
                    .IsUnique();

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Users")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK3aspnet_Users")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XAKaspnet_Users")
                    .IsUnique();

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Applications_aspnet_Users");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_UsersInRoles");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("aspnet_UsersInRoles_index");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1aspnet_UsersInRoles")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("XIF1aspnet_UsersInRoles");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Roles_aspnet_UsersInRoles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Users_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810797309D9");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1aspnet_WebEvent_Events")
                    .IsUnique();

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.Rowguid);

                entity.ToTable("BITACORA");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0BITACORA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EventInfo).IsRequired();

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FcFecha)
                    .HasColumnName("fc_Fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_Usuario")
                    .HasDefaultValueSql("(@@spid)");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<CustomCuboCabecera>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PKCustomCuboCabecera");

                entity.ToTable("CUSTOM_CUBO_CABECERA");

                entity.Property(e => e.Uid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.IdUsuario).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Xml).IsUnicode(false);
            });

            modelBuilder.Entity<ExhibicionesCdm>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("exhibicionesCDM");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Escala).HasColumnName("ESCALA");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Unidadescolocadas).HasColumnName("UNIDADESCOLOCADAS");

                entity.Property(e => e.Unidadesencontradas).HasColumnName("UNIDADESENCONTRADAS");

                entity.Property(e => e.Unidadesmantenidas).HasColumnName("UNIDADESMANTENIDAS");
            });

            modelBuilder.Entity<ExhibicionesCdmg2>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("exhibicionesCDMG2");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(50);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(50);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(50);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("date");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda).HasColumnName("TIENDA");

                entity.Property(e => e.Tipomaterial)
                    .HasColumnName("TIPOMATERIAL")
                    .HasMaxLength(50);

                entity.Property(e => e.Unidadescolocadas).HasColumnName("UNIDADESCOLOCADAS");

                entity.Property(e => e.Unidadesencontradas).HasColumnName("UNIDADESENCONTRADAS");

                entity.Property(e => e.Unidadesmantenidas).HasColumnName("UNIDADESMANTENIDAS");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FacingCdm>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("facingCDM");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.DsPregunta)
                    .HasColumnName("DS_PREGUNTA")
                    .HasMaxLength(20);

                entity.Property(e => e.Facing).HasColumnName("FACING");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Potencial).HasColumnName("POTENCIAL");

                entity.Property(e => e.Promedio).HasColumnName("%PROMEDIO");
            });

            modelBuilder.Entity<FacingCdmg1>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("facingCDMG1");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(50);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(50);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.DsPregunta)
                    .HasColumnName("DS_PREGUNTA")
                    .HasMaxLength(150);

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(50);

                entity.Property(e => e.Facing).HasColumnName("FACING");

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .HasMaxLength(50);

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Potencial).HasColumnName("POTENCIAL");

                entity.Property(e => e.Promedio).HasColumnName("%PROMEDIO");

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogAurora>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("log_aurora");

                entity.Property(e => e.IdLog).HasColumnName("id_log");

                entity.Property(e => e.GuidVisita).HasColumnName("guid_visita");

                entity.Property(e => e.Json).HasColumnName("json");
            });

            modelBuilder.Entity<MejoraCdmg1>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("mejoraCDMG1");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Categoria)
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pregunta)
                    .HasColumnName("PREGUNTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Respuesta)
                    .HasColumnName("RESPUESTA")
                    .HasMaxLength(150);

                entity.Property(e => e.Segmento)
                    .HasColumnName("SEGMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MejoraCdmg2>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("mejoraCDMG2");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Categoria)
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(150);

                entity.Property(e => e.Pregunta)
                    .HasColumnName("PREGUNTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Respuesta)
                    .HasColumnName("RESPUESTA")
                    .HasMaxLength(150);

                entity.Property(e => e.Segmento)
                    .HasColumnName("SEGMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.Tienda).HasColumnName("TIENDA");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MetaAnotacion>(entity =>
            {
                entity.HasKey(e => e.CdAnotacion)
                    .HasName("XPKMETA_ANOTACION");

                entity.ToTable("META_ANOTACION");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF10META_ANOTACION");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF8META_ANOTACION");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF6META_ANOTACION");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF5META_ANOTACION");

                entity.HasIndex(e => e.CdSubcategoria)
                    .HasName("XIF3META_ANOTACION");

                entity.HasIndex(e => e.CdSubsegmento)
                    .HasName("XIF4META_ANOTACION");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF9META_ANOTACION");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_ANOTACION");

                entity.HasIndex(e => e.ItObjeto)
                    .HasName("XIE1META_ANOTACION");

                entity.HasIndex(e => e.RowguidVisita)
                    .HasName("XIF12META_ANOTACION");

                entity.HasIndex(e => new { e.CdMarca, e.CdCliente })
                    .HasName("XIF7META_ANOTACION");

                entity.HasIndex(e => new { e.CdAnotacion, e.CdTienda, e.ItHistorico })
                    .HasName("XMI0_META_ANOTACION");

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF2META_ANOTACION");

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_ANOTACION");

                entity.Property(e => e.CdAnotacion)
                    .HasColumnName("CD_ANOTACION")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdMarca).HasColumnName("CD_MARCA");

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.CdSubcategoria).HasColumnName("CD_SUBCATEGORIA");

                entity.Property(e => e.CdSubsegmento).HasColumnName("CD_SUBSEGMENTO");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.FcVisita)
                    .HasColumnName("FC_VISITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItHistorico)
                    .IsRequired()
                    .HasColumnName("IT_HISTORICO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItObjeto).HasColumnName("IT_OBJETO");

                entity.Property(e => e.RowguidVisita).HasColumnName("ROWGUID_VISITA");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_ANOTACION");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.CdMaterial)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_ANOTACION");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.CdPromocion)
                    .HasConstraintName("FK_META_PROMOCION_META_ANOTACION");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.CdReferencia)
                    .HasConstraintName("FK_META_REFERENCIA_META_ANOTACION");

                entity.HasOne(d => d.CdSubcategoriaNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.CdSubcategoria)
                    .HasConstraintName("FK_META_C_SUBCATEGORIA_META_ANOTACION");

                entity.HasOne(d => d.CdSubsegmentoNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.CdSubsegmento)
                    .HasConstraintName("FK_META_C_SUBSEGMENTO_META_ANOTACION");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.CdTienda)
                    .HasConstraintName("FK_META_TIENDA_META_ANOTACION");

                entity.HasOne(d => d.RowguidVisitaNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => d.RowguidVisita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_VISITA_META_ANOTACION");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => new { d.CdMarca, d.CdCliente })
                    .HasConstraintName("FK_META_MARCA_META_ANOTACION");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .HasConstraintName("FK_META_C_CATEGORIA_META_ANOTACION");

                entity.HasOne(d => d.Cd1)
                    .WithMany(p => p.MetaAnotacion)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .HasConstraintName("FK_META_C_SEGMENTO_META_ANOTACION");
            });

            modelBuilder.Entity<MetaAnotacionFoto>(entity =>
            {
                entity.HasKey(e => e.CdAnotacionFoto)
                    .HasName("XPKMETA_ANOTACION_FOTO");

                entity.ToTable("META_ANOTACION_FOTO");

                entity.HasIndex(e => new { e.CdAnotacion, e.CdTipoObservacion })
                    .HasName("XIF1META_ANOTACION_FOTO");

                entity.Property(e => e.CdAnotacionFoto)
                    .HasColumnName("CD_ANOTACION_FOTO")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdAnotacion)
                    .HasColumnName("CD_ANOTACION")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdTipoObservacion).HasColumnName("CD_TIPO_OBSERVACION");

                entity.Property(e => e.ItDestacado).HasColumnName("IT_DESTACADO");

                entity.Property(e => e.ItEstado)
                    .HasColumnName("IT_ESTADO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItFtp).HasColumnName("IT_FTP");

                entity.Property(e => e.ItRelAmpliacion).HasColumnName("IT_REL_AMPLIACION");

                entity.Property(e => e.ItRelAntDesp).HasColumnName("IT_REL_ANT_DESP");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaAnotacionFoto)
                    .HasForeignKey(d => new { d.CdAnotacion, d.CdTipoObservacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_ANOTACION_TIPO_META_ANOTACION_FOTO");
            });

            modelBuilder.Entity<MetaAnotacionTipo>(entity =>
            {
                entity.HasKey(e => new { e.CdAnotacion, e.CdTipoObservacion })
                    .HasName("XPKMETA_ANOTACION_TIPO");

                entity.ToTable("META_ANOTACION_TIPO");

                entity.HasIndex(e => e.CdAnotacion)
                    .HasName("XIF2META_ANOTACION_TIPO");

                entity.HasIndex(e => e.CdTipoObservacion)
                    .HasName("XIF1META_ANOTACION_TIPO");

                entity.HasIndex(e => e.ItEstado)
                    .HasName("XIE1META_ANOTACION_TIPO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_ANOTACION_TIPO")
                    .IsUnique();

                entity.Property(e => e.CdAnotacion)
                    .HasColumnName("CD_ANOTACION")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdTipoObservacion).HasColumnName("CD_TIPO_OBSERVACION");

                entity.Property(e => e.DsComentario)
                    .HasColumnName("DS_COMENTARIO")
                    .IsUnicode(false);

                entity.Property(e => e.DsObservacion)
                    .HasColumnName("DS_OBSERVACION")
                    .IsUnicode(false);

                entity.Property(e => e.DsObservacionDef)
                    .HasColumnName("DS_OBSERVACION_DEF")
                    .IsUnicode(false);

                entity.Property(e => e.ItDestacado).HasColumnName("IT_DESTACADO");

                entity.Property(e => e.ItEstado).HasColumnName("IT_ESTADO");

                entity.Property(e => e.ItValoracion).HasColumnName("IT_VALORACION");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdAnotacionNavigation)
                    .WithMany(p => p.MetaAnotacionTipo)
                    .HasForeignKey(d => d.CdAnotacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_ANOTACION_META_ANOTACION_TIPO");

                entity.HasOne(d => d.CdTipoObservacionNavigation)
                    .WithMany(p => p.MetaAnotacionTipo)
                    .HasForeignKey(d => d.CdTipoObservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_TIPO_OBSERVACION_META_ANOTACION_TIPO");
            });

            modelBuilder.Entity<MetaAviso>(entity =>
            {
                entity.HasKey(e => e.CdAviso)
                    .HasName("XPKMETA_AVISO");

                entity.ToTable("META_AVISO");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF2META_AVISO");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_AVISO");

                entity.HasIndex(e => e.CdEmpDestinatario)
                    .HasName("XIF7META_AVISO");

                entity.HasIndex(e => e.CdEmpRemitente)
                    .HasName("XIF6META_AVISO");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF5META_AVISO");

                entity.HasIndex(e => e.CdTipoAviso)
                    .HasName("XIF8META_AVISO");

                entity.HasIndex(e => e.CdZona)
                    .HasName("XIF4META_AVISO");

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF3META_AVISO");

                entity.Property(e => e.CdAviso)
                    .HasColumnName("CD_AVISO")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdAvisoManual).HasColumnName("CD_AVISO_MANUAL");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdEmpDestinatario).HasColumnName("CD_EMP_DESTINATARIO");

                entity.Property(e => e.CdEmpRemitente).HasColumnName("CD_EMP_REMITENTE");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.CdTipoAviso).HasColumnName("CD_TIPO_AVISO");

                entity.Property(e => e.CdZona).HasColumnName("CD_ZONA");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitulo)
                    .IsRequired()
                    .HasColumnName("DS_TITULO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItArchivado).HasColumnName("IT_ARCHIVADO");

                entity.Property(e => e.ItEmail)
                    .IsRequired()
                    .HasColumnName("IT_EMAIL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaAviso)
                    .HasForeignKey(d => d.CdCanal)
                    .HasConstraintName("FK_META_CANAL_META_AVISO");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaAviso)
                    .HasForeignKey(d => d.CdCliente)
                    .HasConstraintName("FK_META_CLIENTE_META_AVISO");

                entity.HasOne(d => d.CdEmpDestinatarioNavigation)
                    .WithMany(p => p.MetaAvisoCdEmpDestinatarioNavigation)
                    .HasForeignKey(d => d.CdEmpDestinatario)
                    .HasConstraintName("FK_META_EMPLEADO_META_AVISO_DESTINATARIO");

                entity.HasOne(d => d.CdEmpRemitenteNavigation)
                    .WithMany(p => p.MetaAvisoCdEmpRemitenteNavigation)
                    .HasForeignKey(d => d.CdEmpRemitente)
                    .HasConstraintName("FK_META_EMPLEADO_META_AVISO_REMITENTE");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaAviso)
                    .HasForeignKey(d => d.CdTienda)
                    .HasConstraintName("FK_META_TIENDA_META_AVISO");

                entity.HasOne(d => d.CdTipoAvisoNavigation)
                    .WithMany(p => p.MetaAviso)
                    .HasForeignKey(d => d.CdTipoAviso)
                    .HasConstraintName("FK_META_C_TIPO_AVISO_META_AVISO");

                entity.HasOne(d => d.CdZonaNavigation)
                    .WithMany(p => p.MetaAviso)
                    .HasForeignKey(d => d.CdZona)
                    .HasConstraintName("FK_META_C_ZONA_META_AVISO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaAviso)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .HasConstraintName("FK_META_C_ENSENA_META_AVISO");
            });

            modelBuilder.Entity<MetaBuscador>(entity =>
            {
                entity.HasKey(e => e.CdBuscador)
                    .HasName("XPKMETA_BUSCADOR");

                entity.ToTable("META_BUSCADOR");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_BUSCADOR")
                    .IsUnique();

                entity.Property(e => e.CdBuscador)
                    .HasColumnName("CD_BUSCADOR")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsBuscador)
                    .IsRequired()
                    .HasColumnName("DS_BUSCADOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaBuscadorConfig>(entity =>
            {
                entity.HasKey(e => e.CdConfig)
                    .HasName("XPKMETA_BUSCADOR_CONFIG");

                entity.ToTable("META_BUSCADOR_CONFIG");

                entity.HasIndex(e => e.CdBuscador)
                    .HasName("XIF2META_BUSCADOR_CONFIG");

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF1META_BUSCADOR_CONFIG");

                entity.Property(e => e.CdConfig)
                    .HasColumnName("CD_CONFIG")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdBuscador).HasColumnName("CD_BUSCADOR");

                entity.Property(e => e.DsConfiguracion)
                    .IsRequired()
                    .HasColumnName("DS_CONFIGURACION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItFavorita).HasColumnName("IT_FAVORITA");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CdBuscadorNavigation)
                    .WithMany(p => p.MetaBuscadorConfig)
                    .HasForeignKey(d => d.CdBuscador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_BUSCADOR_META_BUSCADOR_CONFIG");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaBuscadorConfig)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_ASPNET_USERS_META_BUSCADOR_CONFIG");
            });

            modelBuilder.Entity<MetaBuscadorConfigCriterio>(entity =>
            {
                entity.HasKey(e => new { e.CdConfig, e.CdCriterio })
                    .HasName("XPKMETA_BUSCADOR_CONFIG_CRITERIO");

                entity.ToTable("META_BUSCADOR_CONFIG_CRITERIO");

                entity.HasIndex(e => e.CdConfig)
                    .HasName("XIF1META_BUSCADOR_CONFIG_CRITERIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_BUSCADOR_CONFIG_CRITERIO")
                    .IsUnique();

                entity.Property(e => e.CdConfig).HasColumnName("CD_CONFIG");

                entity.Property(e => e.CdCriterio).HasColumnName("CD_CRITERIO");

                entity.Property(e => e.DsCriterio)
                    .IsRequired()
                    .HasColumnName("DS_CRITERIO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsValor)
                    .HasColumnName("DS_VALOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdConfigNavigation)
                    .WithMany(p => p.MetaBuscadorConfigCriterio)
                    .HasForeignKey(d => d.CdConfig)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_BUSCADOR_CONFIG_META_BUSCADOR_CONFIG_CRITERIO");
            });

            modelBuilder.Entity<MetaBuscadorConfigRejilla>(entity =>
            {
                entity.HasKey(e => e.CdConfig)
                    .HasName("XPKMETA_BUSCADOR_CONFIG_REJILLA");

                entity.ToTable("META_BUSCADOR_CONFIG_REJILLA");

                entity.Property(e => e.CdConfig)
                    .HasColumnName("CD_CONFIG")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TlRejilla).HasColumnName("TL_REJILLA");

                entity.HasOne(d => d.CdConfigNavigation)
                    .WithOne(p => p.MetaBuscadorConfigRejilla)
                    .HasForeignKey<MetaBuscadorConfigRejilla>(d => d.CdConfig)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_BUSCADOR_CONFIG_META_BUSCADOR_CONFIG_REJILLA");
            });

            modelBuilder.Entity<MetaCAutonomia>(entity =>
            {
                entity.HasKey(e => e.CdAutonomia)
                    .HasName("XPKMETA_C_AUTONOMIA");

                entity.ToTable("META_C_AUTONOMIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK2META_C_AUTONOMIA")
                    .IsUnique();

                entity.Property(e => e.CdAutonomia)
                    .HasColumnName("CD_AUTONOMIA")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DsAbrevGmaps)
                    .HasColumnName("DS_ABREV_GMAPS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DsAutonomia)
                    .IsRequired()
                    .HasColumnName("DS_AUTONOMIA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCCadena>(entity =>
            {
                entity.HasKey(e => e.CdCadena)
                    .HasName("XPKMETA_C_CADENA");

                entity.ToTable("META_C_CADENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_CADENA")
                    .IsUnique();

                entity.Property(e => e.CdCadena)
                    .HasColumnName("CD_CADENA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsCadena)
                    .IsRequired()
                    .HasColumnName("DS_CADENA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsRutaLogo)
                    .HasColumnName("DS_RUTA_LOGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCCanal>(entity =>
            {
                entity.HasKey(e => e.CdCanal)
                    .HasName("XPKMETA_C_CANAL");

                entity.ToTable("META_C_CANAL");

                entity.HasIndex(e => e.CdCanalSuperior)
                    .HasName("XIF1META_C_CANAL");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_CANAL")
                    .IsUnique();

                entity.Property(e => e.CdCanal)
                    .HasColumnName("CD_CANAL")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCanalSuperior).HasColumnName("CD_CANAL_SUPERIOR");

                entity.Property(e => e.DsCanal)
                    .IsRequired()
                    .HasColumnName("DS_CANAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCanalSuperiorNavigation)
                    .WithMany(p => p.InverseCdCanalSuperiorNavigation)
                    .HasForeignKey(d => d.CdCanalSuperior)
                    .HasConstraintName("FK_META_C_CANAL_META_C_CANAL");
            });

            modelBuilder.Entity<MetaCCanalCadena>(entity =>
            {
                entity.HasKey(e => new { e.CdCanal, e.CdCadena })
                    .HasName("XPKMETA_C_CANAL_CADENA");

                entity.ToTable("META_C_CANAL_CADENA");

                entity.HasIndex(e => e.CdCadena)
                    .HasName("XIF2META_C_CANAL_CADENA");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF1META_C_CANAL_CADENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_CANAL_CADENA")
                    .IsUnique();

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCadenaNavigation)
                    .WithMany(p => p.MetaCCanalCadena)
                    .HasForeignKey(d => d.CdCadena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CADENA_META_C_CANAL_CADENA");

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaCCanalCadena)
                    .HasForeignKey(d => d.CdCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CANAL_META_C_CANAL_CADENA");
            });

            modelBuilder.Entity<MetaCCanalCaracteristica>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_C_CANAL_CARACTERISTICA");

                entity.ToTable("META_C_CANAL_CARACTERISTICA");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF1META_C_CANAL_CARACTERISTICA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.DsCaracteristica)
                    .HasColumnName("DS_CARACTERISTICA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaCCanalCaracteristica)
                    .HasForeignKey(d => d.CdCanal)
                    .HasConstraintName("FK_META_C_CANAL_META_C_CANAL_CARACTERISITCA");
            });

            modelBuilder.Entity<MetaCCategoria>(entity =>
            {
                entity.HasKey(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XPKMETA_C_CATEGORIA");

                entity.ToTable("META_C_CATEGORIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_CATEGORIA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_C_CATEGORIA");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.DsCategoria)
                    .IsRequired()
                    .HasColumnName("DS_CATEGORIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCCategoria)
                    .HasForeignKey(d => new { d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_FAMILIA_META_C_CATEGORIA");
            });

            modelBuilder.Entity<MetaCCategoriaExplotacion>(entity =>
            {
                entity.HasKey(e => e.CdCategoria)
                    .HasName("XPKMETA_C_CATEGORIA_EXPLOTACION");

                entity.ToTable("META_C_CATEGORIA_EXPLOTACION");

                entity.Property(e => e.CdCategoria)
                    .HasColumnName("CD_CATEGORIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsCategoria)
                    .HasColumnName("DS_CATEGORIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsCubo)
                    .HasColumnName("DS_CUBO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetaCCategoriaExplotacionMedida>(entity =>
            {
                entity.HasKey(e => new { e.CdCategoria, e.CdMedida })
                    .HasName("XPKMETA_C_CATEGORIA_EXPLOTACION_MEDIDA");

                entity.ToTable("META_C_CATEGORIA_EXPLOTACION_MEDIDA");

                entity.HasIndex(e => e.CdCategoria)
                    .HasName("XIF1META_C_CATEGORIA_EXPLOTACION_MEDIDA");

                entity.HasIndex(e => e.CdMedida)
                    .HasName("XIF2META_C_CATEGORIA_EXPLOTACION_MEDIDA");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdMedida).HasColumnName("CD_MEDIDA");

                entity.HasOne(d => d.CdCategoriaNavigation)
                    .WithMany(p => p.MetaCCategoriaExplotacionMedida)
                    .HasForeignKey(d => d.CdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_EXPLOTCION_META_C_CATEGORIA_EXPLOTACION");

                entity.HasOne(d => d.CdMedidaNavigation)
                    .WithMany(p => p.MetaCCategoriaExplotacionMedida)
                    .HasForeignKey(d => d.CdMedida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_MEDIDA_META_C_CATEGORIA_EXPLOTACION_MEDIDA");
            });

            modelBuilder.Entity<MetaCCluster>(entity =>
            {
                entity.HasKey(e => e.CdCluster)
                    .HasName("XPKMETA_C_CLUSTER");

                entity.ToTable("META_C_CLUSTER");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_CLUSTER")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF1META_C_CLUSTER");

                entity.Property(e => e.CdCluster)
                    .HasColumnName("CD_CLUSTER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.DsCluster)
                    .IsRequired()
                    .HasColumnName("DS_CLUSTER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCCluster)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_C_CLUSTER");
            });

            modelBuilder.Entity<MetaCCpostal>(entity =>
            {
                entity.HasKey(e => new { e.CdProv, e.CdMuni, e.CdCpostal })
                    .HasName("XPKMETA_C_CPOSTAL");

                entity.ToTable("META_C_CPOSTAL");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_CPOSTAL")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdProv, e.CdMuni })
                    .HasName("XIF1META_C_CPOSTAL");

                entity.Property(e => e.CdProv)
                    .HasColumnName("CD_PROV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CdMuni)
                    .HasColumnName("CD_MUNI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdCpostal)
                    .HasColumnName("CD_CPOSTAL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCCpostal)
                    .HasForeignKey(d => new { d.CdProv, d.CdMuni })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_MUNICIPIO_META_C_CPOSTAL");
            });

            modelBuilder.Entity<MetaCCpostalDistrito>(entity =>
            {
                entity.HasKey(e => new { e.CdProv, e.CdMuni, e.CdCpostal, e.CdDistrito })
                    .HasName("XPKMETA_C_CPOSTAL_DISTRITO");

                entity.ToTable("META_C_CPOSTAL_DISTRITO");

                entity.HasIndex(e => e.CdDistrito)
                    .HasName("XIF2META_C_CPOSTAL_DISTRITO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_CPOSTAL_DISTRITO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdProv, e.CdMuni, e.CdCpostal })
                    .HasName("XIF1META_C_CPOSTAL_DISTRITO");

                entity.Property(e => e.CdProv)
                    .HasColumnName("CD_PROV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CdMuni)
                    .HasColumnName("CD_MUNI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdCpostal)
                    .HasColumnName("CD_CPOSTAL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdDistrito).HasColumnName("CD_DISTRITO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdDistritoNavigation)
                    .WithMany(p => p.MetaCCpostalDistrito)
                    .HasForeignKey(d => d.CdDistrito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_DISTRITO_META_C_CPOSTAL_DISTRITO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCCpostalDistrito)
                    .HasForeignKey(d => new { d.CdProv, d.CdMuni, d.CdCpostal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_POSTAL_META_C_CPOSTAL_DISTRITO");
            });

            modelBuilder.Entity<MetaCDistrito>(entity =>
            {
                entity.HasKey(e => e.CdDistrito)
                    .HasName("XPKMETA_C_DISTRITO");

                entity.ToTable("META_C_DISTRITO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_DISTRITO")
                    .IsUnique();

                entity.Property(e => e.CdDistrito)
                    .HasColumnName("CD_DISTRITO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsDistrito)
                    .IsRequired()
                    .HasColumnName("DS_DISTRITO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCEnsena>(entity =>
            {
                entity.HasKey(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XPKMETA_C_ENSENA");

                entity.ToTable("META_C_ENSENA");

                entity.HasIndex(e => e.CdCadena)
                    .HasName("XIF1META_C_ENSENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_ENSENA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdSubagrupacion, e.CdCadena })
                    .HasName("XIF2META_C_ENSENA");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdSubagrupacion).HasColumnName("CD_SUBAGRUPACION");

                entity.Property(e => e.DsAbreviatura)
                    .HasColumnName("DS_ABREVIATURA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DsEnsena)
                    .IsRequired()
                    .HasColumnName("DS_ENSENA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsRutaLogo)
                    .HasColumnName("DS_RUTA_LOGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCadenaNavigation)
                    .WithMany(p => p.MetaCEnsena)
                    .HasForeignKey(d => d.CdCadena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CADENA_META_C_ENSENA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCEnsena)
                    .HasForeignKey(d => new { d.CdSubagrupacion, d.CdCadena })
                    .HasConstraintName("FK_META_C_SUBAGRUPACION_META_C_ENSENA");
            });

            modelBuilder.Entity<MetaCEstadoAusencia>(entity =>
            {
                entity.HasKey(e => e.CdEstadoAusencia)
                    .HasName("XPKMETA_C_ESTADO_AUSENCIA");

                entity.ToTable("META_C_ESTADO_AUSENCIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_ESTADO_AUSENCIA")
                    .IsUnique();

                entity.Property(e => e.CdEstadoAusencia)
                    .HasColumnName("CD_ESTADO_AUSENCIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsEstadoAusencia)
                    .IsRequired()
                    .HasColumnName("DS_ESTADO_AUSENCIA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCEstadoHojaGastos>(entity =>
            {
                entity.HasKey(e => e.CdEstado)
                    .HasName("XPKMETA_C_ESTADO_HOJA_GASTOS");

                entity.ToTable("META_C_ESTADO_HOJA_GASTOS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_ESTADO_HOJA_GASTOS")
                    .IsUnique();

                entity.Property(e => e.CdEstado)
                    .HasColumnName("CD_ESTADO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsEstado)
                    .IsRequired()
                    .HasColumnName("DS_ESTADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCEstadoTarea>(entity =>
            {
                entity.HasKey(e => e.CdEstadoTarea)
                    .HasName("XPKMETA_C_ESTADO_TAREA");

                entity.ToTable("META_C_ESTADO_TAREA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_ESTADO_TAREA")
                    .IsUnique();

                entity.Property(e => e.CdEstadoTarea)
                    .HasColumnName("CD_ESTADO_TAREA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsEstadoTarea)
                    .IsRequired()
                    .HasColumnName("DS_ESTADO_TAREA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCEstadoTienda>(entity =>
            {
                entity.HasKey(e => e.CdEstadoTienda)
                    .HasName("XPKMETA_C_ESTADO_TIENDA");

                entity.ToTable("META_C_ESTADO_TIENDA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_ESTADO_TIENDA")
                    .IsUnique();

                entity.Property(e => e.CdEstadoTienda)
                    .HasColumnName("CD_ESTADO_TIENDA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsEstadoTienda)
                    .IsRequired()
                    .HasColumnName("DS_ESTADO_TIENDA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCFamilia>(entity =>
            {
                entity.HasKey(e => new { e.CdFamilia, e.CdSector })
                    .HasName("XPKMETA_C_FAMILIA");

                entity.ToTable("META_C_FAMILIA");

                entity.HasIndex(e => e.CdSector)
                    .HasName("XIF1META_C_FAMILIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_FAMILIA")
                    .IsUnique();

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.DsFamilia)
                    .IsRequired()
                    .HasColumnName("DS_FAMILIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdSectorNavigation)
                    .WithMany(p => p.MetaCFamilia)
                    .HasForeignKey(d => d.CdSector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SECTOR_META_C_FAMILIA");
            });

            modelBuilder.Entity<MetaCMedida>(entity =>
            {
                entity.HasKey(e => e.CdMedida)
                    .HasName("XPKMETA_C_MEDIDA");

                entity.ToTable("META_C_MEDIDA");

                entity.Property(e => e.CdMedida)
                    .HasColumnName("CD_MEDIDA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsMedida)
                    .HasColumnName("DS_MEDIDA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ItMedida)
                    .IsRequired()
                    .HasColumnName("IT_MEDIDA")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MetaCMensajeUsuario>(entity =>
            {
                entity.HasKey(e => e.CdCMensajeUsuario)
                    .HasName("XPKMETA_C_MENSAJE_USUARIO");

                entity.ToTable("META_C_MENSAJE_USUARIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_MENSAJE_USUARIO")
                    .IsUnique();

                entity.Property(e => e.CdCMensajeUsuario)
                    .HasColumnName("CD_C_MENSAJE_USUARIO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsCMensajeUsuario)
                    .IsRequired()
                    .HasColumnName("DS_C_MENSAJE_USUARIO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItTipoMensaje).HasColumnName("IT_TIPO_MENSAJE");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCMunicipio>(entity =>
            {
                entity.HasKey(e => new { e.CdProv, e.CdMuni })
                    .HasName("XPKMETA_C_MUNICIPIO");

                entity.ToTable("META_C_MUNICIPIO");

                entity.HasIndex(e => e.CdProv)
                    .HasName("XIF1META_C_MUNICIPIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_MUNICIPIO")
                    .IsUnique();

                entity.Property(e => e.CdProv)
                    .HasColumnName("CD_PROV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CdMuni)
                    .HasColumnName("CD_MUNI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DsMuni)
                    .IsRequired()
                    .HasColumnName("DS_MUNI")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdProvNavigation)
                    .WithMany(p => p.MetaCMunicipio)
                    .HasForeignKey(d => d.CdProv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_PROVINCIA_META_C_MUNICIPIO");
            });

            modelBuilder.Entity<MetaCPais>(entity =>
            {
                entity.HasKey(e => e.CdPais)
                    .HasName("XPKMETA_C_PAIS");

                entity.ToTable("META_C_PAIS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_PAIS")
                    .IsUnique();

                entity.Property(e => e.CdPais)
                    .HasColumnName("CD_PAIS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DsPais)
                    .IsRequired()
                    .HasColumnName("DS_PAIS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCPalanca>(entity =>
            {
                entity.HasKey(e => e.CdPalanca)
                    .HasName("XPKMETA_C_PALANCA");

                entity.ToTable("META_C_PALANCA");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF1META_C_PALANCA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_PALANCA")
                    .IsUnique();

                entity.Property(e => e.CdPalanca)
                    .HasColumnName("CD_PALANCA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsPalanca)
                    .IsRequired()
                    .HasColumnName("DS_PALANCA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaCPalanca)
                    .HasForeignKey(d => d.CdCanal)
                    .HasConstraintName("FK_META_C_CANAL_META_C_PALANCA");
            });

            modelBuilder.Entity<MetaCPeriodicidad>(entity =>
            {
                entity.HasKey(e => e.CdPeriodicidad)
                    .HasName("XPKMETA_C_PERIODICIDAD");

                entity.ToTable("META_C_PERIODICIDAD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_PERIODICIDAD")
                    .IsUnique();

                entity.Property(e => e.CdPeriodicidad).HasColumnName("CD_PERIODICIDAD");

                entity.Property(e => e.DsAbreviatura)
                    .IsRequired()
                    .HasColumnName("DS_ABREVIATURA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DsPeriodicidad)
                    .IsRequired()
                    .HasColumnName("DS_PERIODICIDAD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCProvincia>(entity =>
            {
                entity.HasKey(e => e.CdProv)
                    .HasName("XPKMETA_C_PROVINCIA");

                entity.ToTable("META_C_PROVINCIA");

                entity.HasIndex(e => e.CdAutonomia)
                    .HasName("XIF1META_C_PROVINCIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_PROVINCIA")
                    .IsUnique();

                entity.Property(e => e.CdProv)
                    .HasColumnName("CD_PROV")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAutonomia)
                    .IsRequired()
                    .HasColumnName("CD_AUTONOMIA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DsProv)
                    .IsRequired()
                    .HasColumnName("DS_PROV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NmLatitud)
                    .HasColumnName("NM_LATITUD")
                    .HasColumnType("numeric(8, 5)");

                entity.Property(e => e.NmLongitud)
                    .HasColumnName("NM_LONGITUD")
                    .HasColumnType("numeric(8, 5)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdAutonomiaNavigation)
                    .WithMany(p => p.MetaCProvincia)
                    .HasForeignKey(d => d.CdAutonomia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_AUTONOMIA_META_PROVINCIA");
            });

            modelBuilder.Entity<MetaCSeccion>(entity =>
            {
                entity.HasKey(e => e.CdSeccion)
                    .HasName("XPKMETA_C_SECCION");

                entity.ToTable("META_C_SECCION");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF1META_C_SECCION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_SECCION")
                    .IsUnique();

                entity.Property(e => e.CdSeccion)
                    .HasColumnName("CD_SECCION")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.DsSeccion)
                    .IsRequired()
                    .HasColumnName("DS_SECCION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaCSeccion)
                    .HasForeignKey(d => d.CdCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CANAL_META_C_SECCION");
            });

            modelBuilder.Entity<MetaCSector>(entity =>
            {
                entity.HasKey(e => e.CdSector)
                    .HasName("XPKMETA_C_SECTOR");

                entity.ToTable("META_C_SECTOR");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_SECTOR")
                    .IsUnique();

                entity.Property(e => e.CdSector)
                    .HasColumnName("CD_SECTOR")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsSector)
                    .IsRequired()
                    .HasColumnName("DS_SECTOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCSegmento>(entity =>
            {
                entity.HasKey(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XPKMETA_C_SEGMENTO");

                entity.ToTable("META_C_SEGMENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_SEGMENTO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_C_SEGMENTO");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.DsSegmento)
                    .IsRequired()
                    .HasColumnName("DS_SEGMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCSegmento)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_C_SEGMENTO");
            });

            modelBuilder.Entity<MetaCSituacionTarea>(entity =>
            {
                entity.HasKey(e => e.CdSituacionTarea)
                    .HasName("XPKMETA_C_SITUACION_TAREA");

                entity.ToTable("META_C_SITUACION_TAREA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_SITUACION_TAREA")
                    .IsUnique();

                entity.Property(e => e.CdSituacionTarea)
                    .HasColumnName("CD_SITUACION_TAREA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsSituacionTarea)
                    .HasColumnName("DS_SITUACION_TAREA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCSubagrupacion>(entity =>
            {
                entity.HasKey(e => new { e.CdSubagrupacion, e.CdCadena })
                    .HasName("XPKMETA_C_SUBAGRUPACION");

                entity.ToTable("META_C_SUBAGRUPACION");

                entity.HasIndex(e => e.CdCadena)
                    .HasName("XIF1META_C_SUBAGRUPACION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_SUBAGRUPACION")
                    .IsUnique();

                entity.Property(e => e.CdSubagrupacion).HasColumnName("CD_SUBAGRUPACION");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.DsRutaLogo)
                    .HasColumnName("DS_RUTA_LOGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsSubagrupacion)
                    .IsRequired()
                    .HasColumnName("DS_SUBAGRUPACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCadenaNavigation)
                    .WithMany(p => p.MetaCSubagrupacion)
                    .HasForeignKey(d => d.CdCadena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CADENA_META_C_SUBAGRUPACION");
            });

            modelBuilder.Entity<MetaCSubcategoria>(entity =>
            {
                entity.HasKey(e => e.CdSubcategoria)
                    .HasName("XPKMETA_C_SUBCATEGORIA");

                entity.ToTable("META_C_SUBCATEGORIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_SUBCATEGORIA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_C_SUBCATEGORIA");

                entity.Property(e => e.CdSubcategoria)
                    .HasColumnName("CD_SUBCATEGORIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.DsSubcategoria)
                    .IsRequired()
                    .HasColumnName("DS_SUBCATEGORIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCSubcategoria)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_C_SUBCATEGORIA");
            });

            modelBuilder.Entity<MetaCSubsegmento>(entity =>
            {
                entity.HasKey(e => e.CdSubsegmento)
                    .HasName("XPKMETA_C_SUBSEGMENTO");

                entity.ToTable("META_C_SUBSEGMENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_SUBSEGMENTO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_C_SUBSEGMENTO");

                entity.Property(e => e.CdSubsegmento)
                    .HasColumnName("CD_SUBSEGMENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.DsSubsegmento)
                    .IsRequired()
                    .HasColumnName("DS_SUBSEGMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCSubsegmento)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SEGMENTO_META_C_SUBSEGMENTO");
            });

            modelBuilder.Entity<MetaCTipoAusencia>(entity =>
            {
                entity.HasKey(e => e.CdTipoAusencia)
                    .HasName("XPKMETA_C_TIPO_AUSENCIA");

                entity.ToTable("META_C_TIPO_AUSENCIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_AUSENCIA")
                    .IsUnique();

                entity.Property(e => e.CdTipoAusencia)
                    .HasColumnName("CD_TIPO_AUSENCIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoAusencia)
                    .IsRequired()
                    .HasColumnName("DS_TIPO_AUSENCIA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCTipoAviso>(entity =>
            {
                entity.HasKey(e => e.CdTipoAviso)
                    .HasName("XPKMETA_C_TIPO_AVISO");

                entity.ToTable("META_C_TIPO_AVISO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_AVISO")
                    .IsUnique();

                entity.Property(e => e.CdTipoAviso)
                    .HasColumnName("CD_TIPO_AVISO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoAviso)
                    .HasColumnName("DS_TIPO_AVISO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.CdTipoDocumento)
                    .HasName("XPKMETA_C_TIPO_DOCUMENTO");

                entity.ToTable("META_C_TIPO_DOCUMENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_DOCUMENTO")
                    .IsUnique();

                entity.Property(e => e.CdTipoDocumento)
                    .HasColumnName("CD_TIPO_DOCUMENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoDocumento)
                    .IsRequired()
                    .HasColumnName("DS_TIPO_DOCUMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCTipoEstablecimiento>(entity =>
            {
                entity.HasKey(e => e.CdTipoEstablecimiento)
                    .HasName("XPKMETA_C_TIPO_ESTABLECIMIENTO");

                entity.ToTable("META_C_TIPO_ESTABLECIMIENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_ESTABLECIMIENTO")
                    .IsUnique();

                entity.Property(e => e.CdTipoEstablecimiento)
                    .HasColumnName("CD_TIPO_ESTABLECIMIENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoEstablecimiento)
                    .IsRequired()
                    .HasColumnName("DS_TIPO_ESTABLECIMIENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCTipoMaterialVisibilidad>(entity =>
            {
                entity.HasKey(e => e.CdTipoMaterial)
                    .HasName("XPKMETA_C_TIPO_MATERIAL_VISIBILIDAD");

                entity.ToTable("META_C_TIPO_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_MATERIAL_VISIBILIDAD")
                    .IsUnique();

                entity.Property(e => e.CdTipoMaterial)
                    .HasColumnName("CD_TIPO_MATERIAL")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoMaterial)
                    .IsRequired()
                    .HasColumnName("DS_TIPO_MATERIAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCTipoObservacion>(entity =>
            {
                entity.HasKey(e => e.CdTipoObservacion)
                    .HasName("XPKMETA_C_TIPO_OBSERVACION");

                entity.ToTable("META_C_TIPO_OBSERVACION");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF2META_C_TIPO_OBSERVACION");

                entity.HasIndex(e => e.CdTipoSuperior)
                    .HasName("XIF1META_C_TIPO_OBSERVACION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_OBSERVACION")
                    .IsUnique();

                entity.Property(e => e.CdTipoObservacion)
                    .HasColumnName("CD_TIPO_OBSERVACION")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdTipoSuperior).HasColumnName("CD_TIPO_SUPERIOR");

                entity.Property(e => e.DsTipoObservacion)
                    .IsRequired()
                    .HasColumnName("DS_TIPO_OBSERVACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCTipoObservacion)
                    .HasForeignKey(d => d.CdCliente)
                    .HasConstraintName("FK_META_CLIENTE_META_C_TIPO_OBSERVACION");

                entity.HasOne(d => d.CdTipoSuperiorNavigation)
                    .WithMany(p => p.InverseCdTipoSuperiorNavigation)
                    .HasForeignKey(d => d.CdTipoSuperior)
                    .HasConstraintName("FK_META_C_TIPO_OBSERVACION_META_C_TIPO_OBSERVACION");
            });

            modelBuilder.Entity<MetaCTipoRegistro>(entity =>
            {
                entity.HasKey(e => e.CdTipoRegistro)
                    .HasName("XPKMETA_C_TIPO_REGISTRO");

                entity.ToTable("META_C_TIPO_REGISTRO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_REGISTRO")
                    .IsUnique();

                entity.Property(e => e.CdTipoRegistro)
                    .HasColumnName("CD_TIPO_REGISTRO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoRegistro)
                    .IsRequired()
                    .HasColumnName("DS_TIPO_REGISTRO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCTipoTarea>(entity =>
            {
                entity.HasKey(e => e.CdTipoTarea)
                    .HasName("XPKMETA_C_TIPO_TAREA");

                entity.ToTable("META_C_TIPO_TAREA");

                entity.HasIndex(e => e.DsTipoTarea)
                    .HasName("XAK2META_C_TIPO_TAREA")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TIPO_TAREA")
                    .IsUnique();

                entity.Property(e => e.CdTipoTarea)
                    .HasColumnName("CD_TIPO_TAREA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsColor)
                    .HasColumnName("DS_COLOR")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DsTipoTarea)
                    .HasColumnName("DS_TIPO_TAREA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCTvias>(entity =>
            {
                entity.HasKey(e => e.CdTvia)
                    .HasName("XPKMETA_C_TVIAS");

                entity.ToTable("META_C_TVIAS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_TVIAS")
                    .IsUnique();

                entity.Property(e => e.CdTvia)
                    .HasColumnName("CD_TVIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DsAbreviada)
                    .IsRequired()
                    .HasColumnName("DS_ABREVIADA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DsTvia)
                    .IsRequired()
                    .HasColumnName("DS_TVIA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCVersion>(entity =>
            {
                entity.HasKey(e => e.FcVersion)
                    .HasName("XPKMETA_C_VERSION");

                entity.ToTable("META_C_VERSION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_VERSION")
                    .IsUnique();

                entity.Property(e => e.FcVersion)
                    .HasColumnName("FC_VERSION")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAplicacion)
                    .HasColumnName("DS_APLICACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmComp).HasColumnName("NM_COMP");

                entity.Property(e => e.NmPrim).HasColumnName("NM_PRIM");

                entity.Property(e => e.NmRev).HasColumnName("NM_REV");

                entity.Property(e => e.NmSec).HasColumnName("NM_SEC");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCZona>(entity =>
            {
                entity.HasKey(e => e.CdZona)
                    .HasName("XPKMETA_C_ZONA");

                entity.ToTable("META_C_ZONA");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF2META_C_ZONA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_C_ZONA")
                    .IsUnique();

                entity.Property(e => e.CdZona)
                    .HasColumnName("CD_ZONA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.DsZona)
                    .IsRequired()
                    .HasColumnName("DS_ZONA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCZona)
                    .HasForeignKey(d => d.CdCliente)
                    .HasConstraintName("FK_META_CLIENTE_META_C_ZONA");
            });

            modelBuilder.Entity<MetaCartaVentas>(entity =>
            {
                entity.HasKey(e => e.CdCartaVentas)
                    .HasName("XPKMETA_CARTA_VENTAS");

                entity.ToTable("META_CARTA_VENTAS");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_CARTA_VENTAS");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_CARTA_VENTAS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CARTA_VENTAS")
                    .IsUnique();

                entity.Property(e => e.CdCartaVentas)
                    .HasColumnName("CD_CARTA_VENTAS")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.DsCartaVentas)
                    .IsRequired()
                    .HasColumnName("DS_CARTA_VENTAS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsCompetencia).HasColumnName("DS_COMPETENCIA");

                entity.Property(e => e.DsLanzamiento).HasColumnName("DS_LANZAMIENTO");

                entity.Property(e => e.DsObjetivo).HasColumnName("DS_OBJETIVO");

                entity.Property(e => e.DsOtros).HasColumnName("DS_OTROS");

                entity.Property(e => e.DsPromociones).HasColumnName("DS_PROMOCIONES");

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCartaVentas)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CARTA_VENTAS");
            });

            modelBuilder.Entity<MetaCartaVentasDocumentos>(entity =>
            {
                entity.HasKey(e => new { e.CdCartaVentas, e.CdDocumento })
                    .HasName("XPKMETA_CARTA_VENTAS_DOCUMENTOS");

                entity.ToTable("META_CARTA_VENTAS_DOCUMENTOS");

                entity.HasIndex(e => e.CdCartaVentas)
                    .HasName("XIF1META_CARTA_VENTAS_DOCUMENTOS");

                entity.HasIndex(e => e.CdDocumento)
                    .HasName("XIF2META_CARTA_VENTAS_DOCUMENTOS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CARTA_VENTAS_DOCUMENTOS")
                    .IsUnique();

                entity.Property(e => e.CdCartaVentas).HasColumnName("CD_CARTA_VENTAS");

                entity.Property(e => e.CdDocumento).HasColumnName("CD_DOCUMENTO");

                entity.Property(e => e.DsDocumento).HasColumnName("DS_DOCUMENTO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCartaVentasNavigation)
                    .WithMany(p => p.MetaCartaVentasDocumentos)
                    .HasForeignKey(d => d.CdCartaVentas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CARTA_VENTAS_META_CARTA_VENTAS_DOCUMENTOS");

                entity.HasOne(d => d.CdDocumentoNavigation)
                    .WithMany(p => p.MetaCartaVentasDocumentos)
                    .HasForeignKey(d => d.CdDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_DOCUMENTO_META_CARTA_VENTAS_DOCUMENTOS");
            });

            modelBuilder.Entity<MetaCartaVentasEnsena>(entity =>
            {
                entity.HasKey(e => e.CdCartaVentasEnsena)
                    .HasName("XPKMETA_CARTA_VENTAS_ENSENA");

                entity.ToTable("META_CARTA_VENTAS_ENSENA");

                entity.HasIndex(e => e.CdCartaVentas)
                    .HasName("XIF1META_CARTA_VENTAS_ENSENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CARTA_VENTAS_ENSENA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF2META_CARTA_VENTAS_ENSENA");

                entity.Property(e => e.CdCartaVentasEnsena)
                    .HasColumnName("CD_CARTA_VENTAS_ENSENA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdCartaVentas).HasColumnName("CD_CARTA_VENTAS");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.DsCompetencia).HasColumnName("DS_COMPETENCIA");

                entity.Property(e => e.DsLanzamiento).HasColumnName("DS_LANZAMIENTO");

                entity.Property(e => e.DsObjetivo).HasColumnName("DS_OBJETIVO");

                entity.Property(e => e.DsPromociones).HasColumnName("DS_PROMOCIONES");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCartaVentasNavigation)
                    .WithMany(p => p.MetaCartaVentasEnsena)
                    .HasForeignKey(d => d.CdCartaVentas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CARTA_VENTAS_META_CARTA_VENTAS_ENSENA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCartaVentasEnsena)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_CARTA_VENTAS_ENSENA");
            });

            modelBuilder.Entity<MetaCartaVentasFaq>(entity =>
            {
                entity.HasKey(e => e.CdFaq)
                    .HasName("XPKMETA_CARTA_VENTAS_FAQ");

                entity.ToTable("META_CARTA_VENTAS_FAQ");

                entity.HasIndex(e => e.CdCartaVentas)
                    .HasName("XIF1META_CARTA_VENTAS_FAQ");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CARTA_VENTAS_FAQ")
                    .IsUnique();

                entity.Property(e => e.CdFaq)
                    .HasColumnName("CD_FAQ")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCartaVentas).HasColumnName("CD_CARTA_VENTAS");

                entity.Property(e => e.DsPregunta).HasColumnName("DS_PREGUNTA");

                entity.Property(e => e.DsRespuesta).HasColumnName("DS_RESPUESTA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCartaVentasNavigation)
                    .WithMany(p => p.MetaCartaVentasFaq)
                    .HasForeignKey(d => d.CdCartaVentas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CARTA_VENTAS_META_CARTA_VENTAS_FAQ");
            });

            modelBuilder.Entity<MetaCategoriaCliente>(entity =>
            {
                entity.HasKey(e => new { e.CdCategoriaCliente, e.CdCliente })
                    .HasName("XPKMETA_CATEGORIA_CLIENTE");

                entity.ToTable("META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdNivel1)
                    .HasName("XIF2META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdNivel2)
                    .HasName("XIF3META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdNivel3)
                    .HasName("XIF4META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdNivel4)
                    .HasName("XIF5META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdNivel5)
                    .HasName("XIF6META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdNivel6)
                    .HasName("XIF7META_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK2META_CATEGORIA_CLIENTE")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdNivel1, e.CdNivel2, e.CdNivel3, e.CdNivel4, e.CdNivel5, e.CdNivel6 })
                    .HasName("XAK1META_CATEGORIA_CLIENTE")
                    .IsUnique();

                entity.Property(e => e.CdCategoriaCliente).HasColumnName("CD_CATEGORIA_CLIENTE");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdNivel1)
                    .IsRequired()
                    .HasColumnName("CD_NIVEL1");

                entity.Property(e => e.CdNivel2)
                    .IsRequired()
                    .HasColumnName("CD_NIVEL2");

                entity.Property(e => e.CdNivel3)
                    .IsRequired()
                    .HasColumnName("CD_NIVEL3");

                entity.Property(e => e.CdNivel4)
                    .IsRequired()
                    .HasColumnName("CD_NIVEL4");

                entity.Property(e => e.CdNivel5)
                    .IsRequired()
                    .HasColumnName("CD_NIVEL5");

                entity.Property(e => e.CdNivel6)
                    .IsRequired()
                    .HasColumnName("CD_NIVEL6");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCategoriaCliente)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CATEGORIA_CLIENTE");

                entity.HasOne(d => d.CdNivel1Navigation)
                    .WithMany(p => p.MetaCategoriaClienteCdNivel1Navigation)
                    .HasForeignKey(d => d.CdNivel1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_NIVEL_CATEGORIA_CLIENTE_META_CATEGORIA_CLIENTE_1");

                entity.HasOne(d => d.CdNivel2Navigation)
                    .WithMany(p => p.MetaCategoriaClienteCdNivel2Navigation)
                    .HasForeignKey(d => d.CdNivel2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_NIVEL_CATEGORIA_CLIENTE_META_CATEGORIA_CLIENTE_2");

                entity.HasOne(d => d.CdNivel3Navigation)
                    .WithMany(p => p.MetaCategoriaClienteCdNivel3Navigation)
                    .HasForeignKey(d => d.CdNivel3)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_NIVEL_CATEGORIA_CLIENTE_META_CATEGORIA_CLIENTE_3");

                entity.HasOne(d => d.CdNivel4Navigation)
                    .WithMany(p => p.MetaCategoriaClienteCdNivel4Navigation)
                    .HasForeignKey(d => d.CdNivel4)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_NIVEL_CATEGORIA_CLIENTE_META_CATEGORIA_CLIENTE_4");

                entity.HasOne(d => d.CdNivel5Navigation)
                    .WithMany(p => p.MetaCategoriaClienteCdNivel5Navigation)
                    .HasForeignKey(d => d.CdNivel5)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_NIVEL_CATEGORIA_CLIENTE_META_CATEGORIA_CLIENTE_5");

                entity.HasOne(d => d.CdNivel6Navigation)
                    .WithMany(p => p.MetaCategoriaClienteCdNivel6Navigation)
                    .HasForeignKey(d => d.CdNivel6)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_NIVEL_CATEGORIA_CLIENTE_META_CATEGORIA_CLIENTE_6");
            });

            modelBuilder.Entity<MetaCategoriaOrden>(entity =>
            {
                entity.HasKey(e => new { e.CdCategoria, e.CdFamilia, e.CdSector, e.CdCliente })
                    .HasName("XPKMETA_CATEGORIA_ORDEN");

                entity.ToTable("META_CATEGORIA_ORDEN");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF2META_CATEGORIA_ORDEN");

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_CATEGORIA_ORDEN");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.NmOrdenInforme).HasColumnName("NM_ORDEN_INFORME");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCategoriaOrden)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CATEGORIA_ORDEN");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCategoriaOrden)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_CATEGORIA_ORDEN");
            });

            modelBuilder.Entity<MetaCausaBaja>(entity =>
            {
                entity.HasKey(e => e.CdCausaBaja)
                    .HasName("XPKMETA_CAUSA_BAJA");

                entity.ToTable("META_CAUSA_BAJA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CAUSA_BAJA")
                    .IsUnique();

                entity.Property(e => e.CdCausaBaja)
                    .HasColumnName("CD_CAUSA_BAJA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsCausaBaja)
                    .IsRequired()
                    .HasColumnName("DS_CAUSA_BAJA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCausaNoVisita>(entity =>
            {
                entity.HasKey(e => e.CdCausaNoVisita)
                    .HasName("XPKMETA_CAUSA_NO_VISITA");

                entity.ToTable("META_CAUSA_NO_VISITA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CAUSA_NO_VISITA")
                    .IsUnique();

                entity.Property(e => e.CdCausaNoVisita)
                    .HasColumnName("CD_CAUSA_NO_VISITA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsCausaNoVisita)
                    .HasColumnName("DS_CAUSA_NO_VISITA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItRecuperable)
                    .IsRequired()
                    .HasColumnName("IT_RECUPERABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaCliente>(entity =>
            {
                entity.HasKey(e => e.CdCliente)
                    .HasName("XPKMETA_CLIENTE");

                entity.ToTable("META_CLIENTE");

                entity.HasIndex(e => e.CdFabricante)
                    .HasName("XIF1META_CLIENTE");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF2META_CLIENTE");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF4META_CLIENTE");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF3META_CLIENTE");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CLIENTE")
                    .IsUnique();

                entity.Property(e => e.CdCliente)
                    .HasColumnName("CD_CLIENTE")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFabricante).HasColumnName("CD_FABRICANTE");

                entity.Property(e => e.DsAbreviatura)
                    .HasColumnName("DS_ABREVIATURA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DsCliente)
                    .IsRequired()
                    .HasColumnName("DS_CLIENTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItCompetidor)
                    .HasColumnName("IT_COMPETIDOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdFabricanteNavigation)
                    .WithMany(p => p.MetaCliente)
                    .HasForeignKey(d => d.CdFabricante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_FABRICANTE_META_CLIENTE");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaClienteDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_CLIENTE_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaClienteDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_CLIENTE_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaClienteDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_CLIENTE_MODIF");
            });

            modelBuilder.Entity<MetaClienteContrato>(entity =>
            {
                entity.HasKey(e => e.CdCliente)
                    .HasName("XPKMETA_CLIENTE_CONTRATO");

                entity.ToTable("META_CLIENTE_CONTRATO");

                entity.Property(e => e.CdCliente)
                    .HasColumnName("CD_CLIENTE")
                    .ValueGeneratedNever();

                entity.Property(e => e.NmDiasMaximo).HasColumnName("NM_DIAS_MAXIMO");

                entity.Property(e => e.NmLicencias).HasColumnName("NM_LICENCIAS");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithOne(p => p.MetaClienteContrato)
                    .HasForeignKey<MetaClienteContrato>(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CLIENTE_CONTRATO");
            });

            modelBuilder.Entity<MetaClienteFtp>(entity =>
            {
                entity.HasKey(e => e.CdCliente)
                    .HasName("XPKMETA_CLIENTE_FTP");

                entity.ToTable("META_CLIENTE_FTP");

                entity.Property(e => e.CdCliente)
                    .HasColumnName("CD_CLIENTE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsEmail)
                    .IsRequired()
                    .HasColumnName("DS_EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsFtp)
                    .IsRequired()
                    .HasColumnName("DS_FTP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsMascaraFoto)
                    .IsRequired()
                    .HasColumnName("DS_MASCARA_FOTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsPassword)
                    .IsRequired()
                    .HasColumnName("DS_PASSWORD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsRutaLog)
                    .IsRequired()
                    .HasColumnName("DS_RUTA_LOG")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("DS_USUARIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NmDuracion).HasColumnName("NM_DURACION");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithOne(p => p.MetaClienteFtp)
                    .HasForeignKey<MetaClienteFtp>(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CLIENTE_FTP");
            });

            modelBuilder.Entity<MetaClienteLogo>(entity =>
            {
                entity.HasKey(e => new { e.CdLogo, e.CdCliente })
                    .HasName("XPKMETA_CLIENTE_LOGO");

                entity.ToTable("META_CLIENTE_LOGO");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_CLIENTE_LOGO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CLIENTE_LOGO")
                    .IsUnique();

                entity.Property(e => e.CdLogo).HasColumnName("CD_LOGO");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.FsLogo).HasColumnName("FS_LOGO");

                entity.Property(e => e.ItPrincipal).HasColumnName("IT_PRINCIPAL");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaClienteLogo)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CLIENTE_LOGO");
            });

            modelBuilder.Entity<MetaClienteProyecto>(entity =>
            {
                entity.HasKey(e => e.CdProyecto)
                    .HasName("XPKMETA_CLIENTE_PROYECTO");

                entity.ToTable("META_CLIENTE_PROYECTO");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_CLIENTE_PROYECTO");

                entity.Property(e => e.CdProyecto)
                    .HasColumnName("CD_PROYECTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.DsProyecto)
                    .IsRequired()
                    .HasColumnName("DS_PROYECTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaClienteProyecto)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CLIENTE_PROYECTO");
            });

            modelBuilder.Entity<MetaClienteVistaCuboBi>(entity =>
            {
                entity.HasKey(e => new { e.CdCliente, e.CdVistaCubo })
                    .HasName("XPKMETA_CLIENTE_VISTA_CUBO_BI");

                entity.ToTable("META_CLIENTE_VISTA_CUBO_BI");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF3META_CLIENTE_VISTA_CUBO_BI");

                entity.HasIndex(e => e.CdVistaCubo)
                    .HasName("XIF2META_CLIENTE_VISTA_CUBO_BI");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdVistaCubo).HasColumnName("CD_VISTA_CUBO");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaClienteVistaCuboBi)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CLIENTE_VISTA_CUBO_BI");

                entity.HasOne(d => d.CdVistaCuboNavigation)
                    .WithMany(p => p.MetaClienteVistaCuboBi)
                    .HasForeignKey(d => d.CdVistaCubo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_VISTA_CUBO_BI_META_CLIENTE_VISTA_CUBO_BI");
            });

            modelBuilder.Entity<MetaCompetencia>(entity =>
            {
                entity.HasKey(e => new { e.CdCliente, e.CdCompetidor })
                    .HasName("XPKMETA_COMPETENCIA");

                entity.ToTable("META_COMPETENCIA");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_COMPETENCIA");

                entity.HasIndex(e => e.CdCompetidor)
                    .HasName("XIF2META_COMPETENCIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_COMPETENCIA")
                    .IsUnique();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdCompetidor).HasColumnName("CD_COMPETIDOR");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCompetenciaCdClienteNavigation)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_COMPETENCIA");

                entity.HasOne(d => d.CdCompetidorNavigation)
                    .WithMany(p => p.MetaCompetenciaCdCompetidorNavigation)
                    .HasForeignKey(d => d.CdCompetidor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_COMPETENCIA_COMPETIDOR");
            });

            modelBuilder.Entity<MetaConcepto>(entity =>
            {
                entity.HasKey(e => e.CdConcepto)
                    .HasName("XPKMETA_CONCEPTO");

                entity.ToTable("META_CONCEPTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CONCEPTO")
                    .IsUnique();

                entity.Property(e => e.CdConcepto)
                    .HasColumnName("CD_CONCEPTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsConcepto)
                    .IsRequired()
                    .HasColumnName("DS_CONCEPTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmLimite).HasColumnName("NM_LIMITE");

                entity.Property(e => e.NmMultiplicador)
                    .HasColumnName("NM_MULTIPLICADOR")
                    .HasColumnType("numeric(4, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaConfiguracion>(entity =>
            {
                entity.HasKey(e => e.CdConfiguracion)
                    .HasName("XPKMETA_CONFIGURACION");

                entity.ToTable("META_CONFIGURACION");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("XIF1META_CONFIGURACION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CONFIGURACION")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF2META_CONFIGURACION");

                entity.HasIndex(e => new { e.UserName, e.ApplicationId, e.CdClave })
                    .HasName("XAK2META_CONFIGURACION")
                    .IsUnique();

                entity.Property(e => e.CdConfiguracion)
                    .HasColumnName("CD_CONFIGURACION")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CdClave)
                    .IsRequired()
                    .HasColumnName("CD_CLAVE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsDescripcion)
                    .IsRequired()
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsValor)
                    .IsRequired()
                    .HasColumnName("DS_VALOR")
                    .HasMaxLength(1000);

                entity.Property(e => e.ItMantenible).HasColumnName("IT_MANTENIBLE");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.MetaConfiguracion)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Applications_META_CONFIGURACION");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaConfiguracion)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_aspnet_Users_META_CONFIGURACION");
            });

            modelBuilder.Entity<MetaConfiguracionUsuario>(entity =>
            {
                entity.HasKey(e => e.CdConfiguracionUsuario)
                    .HasName("XPKMETA_CONFIGURACION_USUARIO");

                entity.ToTable("META_CONFIGURACION_USUARIO");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("XIF1META_CONFIGURACION_USUARIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK2META_CONFIGURACION_USUARIO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdClave, e.ApplicationId })
                    .HasName("XAK1META_CONFIGURACION_USUARIO")
                    .IsUnique();

                entity.Property(e => e.CdConfiguracionUsuario)
                    .HasColumnName("CD_CONFIGURACION_USUARIO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CdClave)
                    .IsRequired()
                    .HasColumnName("CD_CLAVE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsDescripcion)
                    .IsRequired()
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsValorDefecto)
                    .IsRequired()
                    .HasColumnName("DS_VALOR_DEFECTO")
                    .HasMaxLength(1000);

                entity.Property(e => e.ItAplicacion).HasColumnName("IT_APLICACION");

                entity.Property(e => e.ItMantenible).HasColumnName("IT_MANTENIBLE");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.MetaConfiguracionUsuario)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Applications_META_CONFIGURACION_USUARIO");
            });

            modelBuilder.Entity<MetaCuboBi>(entity =>
            {
                entity.HasKey(e => e.CdCubo)
                    .HasName("XPKMETA_CUBO_BI");

                entity.ToTable("META_CUBO_BI");

                entity.HasIndex(e => e.CdCategoria)
                    .HasName("XIF1META_CUBO_BI");

                entity.Property(e => e.CdCubo)
                    .HasColumnName("CD_CUBO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.DsDescripcion)
                    .IsRequired()
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItSistema).HasColumnName("IT_SISTEMA");

                entity.Property(e => e.NmCuboOrigen).HasColumnName("NM_CUBO_ORIGEN");

                entity.HasOne(d => d.CdCategoriaNavigation)
                    .WithMany(p => p.MetaCuboBi)
                    .HasForeignKey(d => d.CdCategoria)
                    .HasConstraintName("FK_META_C_CATEGORIA_EXPLOTACION_META_CUBO_BI");
            });

            modelBuilder.Entity<MetaCuboBiCliente>(entity =>
            {
                entity.HasKey(e => new { e.CdCubo, e.CdCliente })
                    .HasName("XPKMETA_CUBO_BI_CLIENTE");

                entity.ToTable("META_CUBO_BI_CLIENTE");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF2META_CUBO_BI_CLIENTE");

                entity.HasIndex(e => e.CdCubo)
                    .HasName("XIF1META_CUBO_BI_CLIENTE");

                entity.Property(e => e.CdCubo).HasColumnName("CD_CUBO");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCuboBiCliente)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CUBO_BI_CLIENTE");

                entity.HasOne(d => d.CdCuboNavigation)
                    .WithMany(p => p.MetaCuboBiCliente)
                    .HasForeignKey(d => d.CdCubo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CUBO_BI_META_CUBO_BI_CLIENTE");
            });

            modelBuilder.Entity<MetaCuboBiMedida>(entity =>
            {
                entity.HasKey(e => new { e.CdCubo, e.CdMedida })
                    .HasName("XPKMETA_CUBO_BI_MEDIDA");

                entity.ToTable("META_CUBO_BI_MEDIDA");

                entity.HasIndex(e => e.CdCubo)
                    .HasName("XIF1META_CUBO_BI_MEDIDA");

                entity.HasIndex(e => e.CdMedida)
                    .HasName("XIF2META_CUBO_BI_MEDIDA");

                entity.Property(e => e.CdCubo).HasColumnName("CD_CUBO");

                entity.Property(e => e.CdMedida).HasColumnName("CD_MEDIDA");

                entity.HasOne(d => d.CdCuboNavigation)
                    .WithMany(p => p.MetaCuboBiMedida)
                    .HasForeignKey(d => d.CdCubo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CUBO_BI_META_CUBO_BI_MEDIDA");

                entity.HasOne(d => d.CdMedidaNavigation)
                    .WithMany(p => p.MetaCuboBiMedida)
                    .HasForeignKey(d => d.CdMedida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_MEDIDA_META_CUBO_BI_MEDIDA");
            });

            modelBuilder.Entity<MetaCuestionario>(entity =>
            {
                entity.HasKey(e => e.CdCuestionario)
                    .HasName("XPKMETA_CUESTIONARIO");

                entity.ToTable("META_CUESTIONARIO");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF4META_CUESTIONARIO");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF5META_CUESTIONARIO");

                entity.HasIndex(e => e.CdCompetidor)
                    .HasName("XIF6META_CUESTIONARIO");

                entity.HasIndex(e => e.CdZona)
                    .HasName("XIF3META_CUESTIONARIO");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF7META_CUESTIONARIO");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF9META_CUESTIONARIO");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF8META_CUESTIONARIO");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_CUESTIONARIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_CUESTIONARIO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF2META_CUESTIONARIO");

                entity.Property(e => e.CdCuestionario)
                    .HasColumnName("CD_CUESTIONARIO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdCompetidor).HasColumnName("CD_COMPETIDOR");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdZona).HasColumnName("CD_ZONA");

                entity.Property(e => e.DsCuestionario)
                    .HasColumnName("DS_CUESTIONARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.ItPublicado)
                    .IsRequired()
                    .HasColumnName("IT_PUBLICADO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaCuestionario)
                    .HasForeignKey(d => d.CdCanal)
                    .HasConstraintName("FK_META_C_CANAL_META_CUESTIONARIO");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaCuestionarioCdClienteNavigation)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_CUESTIONARIO");

                entity.HasOne(d => d.CdCompetidorNavigation)
                    .WithMany(p => p.MetaCuestionarioCdCompetidorNavigation)
                    .HasForeignKey(d => d.CdCompetidor)
                    .HasConstraintName("FK_META_CLIENTE_META_CUESTIONARIO_COMPETIDOR");

                entity.HasOne(d => d.CdZonaNavigation)
                    .WithMany(p => p.MetaCuestionario)
                    .HasForeignKey(d => d.CdZona)
                    .HasConstraintName("FK_META_C_ZONA_META_CUESTIONARIO");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaCuestionarioDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_CUESTIONARIO_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaCuestionarioDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_CUESTIONARIO_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaCuestionarioDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_CUESTIONARIO_MODIF");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaCuestionario)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .HasConstraintName("FK_META_C_ENSENA_META_CUESTIONARIO");
            });

            modelBuilder.Entity<MetaDepartamento>(entity =>
            {
                entity.HasKey(e => e.CdDepartamento)
                    .HasName("XPKMETA_DEPARTAMENTO");

                entity.ToTable("META_DEPARTAMENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_DEPARTAMENTO")
                    .IsUnique();

                entity.Property(e => e.CdDepartamento)
                    .HasColumnName("CD_DEPARTAMENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsDepartamento)
                    .IsRequired()
                    .HasColumnName("DS_DEPARTAMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaDirecciones>(entity =>
            {
                entity.HasKey(e => e.CdDir)
                    .HasName("XPKSITE_DIRECCIONES");

                entity.ToTable("META_DIRECCIONES");

                entity.HasIndex(e => e.CdPais)
                    .HasName("XIF2SIPR_DIRECCIONES");

                entity.HasIndex(e => e.CdProv)
                    .HasName("XIF5SIPR_DIRECCIONES");

                entity.HasIndex(e => e.CdTvia)
                    .HasName("XIF3SIPR_DIRECCIONES");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_DIRECCIONES")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF5META_DIRECCIONES");

                entity.HasIndex(e => new { e.CdProv, e.CdMuni })
                    .HasName("XIF6META_DIRECCIONES");

                entity.HasIndex(e => new { e.CdProv, e.CdMuni, e.CdCpostal })
                    .HasName("XIF7SITE_DIRECCIONES");

                entity.Property(e => e.CdDir)
                    .HasColumnName("CD_DIR")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCpostal)
                    .HasColumnName("CD_CPOSTAL")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CdMuni)
                    .HasColumnName("CD_MUNI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdPais)
                    .HasColumnName("CD_PAIS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdProv)
                    .HasColumnName("CD_PROV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CdTvia)
                    .HasColumnName("CD_TVIA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DsEscalera)
                    .HasColumnName("DS_ESCALERA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DsLindir1)
                    .HasColumnName("DS_LINDIR1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DsLindir2)
                    .HasColumnName("DS_LINDIR2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DsLindir3)
                    .HasColumnName("DS_LINDIR3")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DsNumvia)
                    .HasColumnName("DS_NUMVIA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DsPiso)
                    .HasColumnName("DS_PISO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DsPuerta)
                    .HasColumnName("DS_PUERTA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DsVia)
                    .HasColumnName("DS_VIA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CdPaisNavigation)
                    .WithMany(p => p.MetaDirecciones)
                    .HasForeignKey(d => d.CdPais)
                    .HasConstraintName("FK_META_C_PAIS_META_DIRECCIONES");

                entity.HasOne(d => d.CdProvNavigation)
                    .WithMany(p => p.MetaDirecciones)
                    .HasForeignKey(d => d.CdProv)
                    .HasConstraintName("FK_META_C_PROVINCIA_META_DIRECCIONES");

                entity.HasOne(d => d.CdTviaNavigation)
                    .WithMany(p => p.MetaDirecciones)
                    .HasForeignKey(d => d.CdTvia)
                    .HasConstraintName("FK_META_C_TVIAS_META_DIRECCIONES");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaDirecciones)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_ASPNET_USERS_META_DIRECCIONES");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaDirecciones)
                    .HasForeignKey(d => new { d.CdProv, d.CdMuni })
                    .HasConstraintName("FK_META_C_MUNICIPIO_META_DIRECCIONES");
            });

            modelBuilder.Entity<MetaDocumento>(entity =>
            {
                entity.HasKey(e => e.CdDocumento)
                    .HasName("XPKMETA_DOCUMENTO");

                entity.ToTable("META_DOCUMENTO");

                entity.HasIndex(e => e.CdTipoDocumento)
                    .HasName("XIF1META_DOCUMENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_DOCUMENTO")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF2META_DOCUMENTO");

                entity.Property(e => e.CdDocumento)
                    .HasColumnName("CD_DOCUMENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTipoDocumento).HasColumnName("CD_TIPO_DOCUMENTO");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DsDocumento)
                    .IsRequired()
                    .HasColumnName("DS_DOCUMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsRutaDocumento)
                    .IsRequired()
                    .HasColumnName("DS_RUTA_DOCUMENTO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CdTipoDocumentoNavigation)
                    .WithMany(p => p.MetaDocumento)
                    .HasForeignKey(d => d.CdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIPO_DOCUMENTO_META_DOCUMENTO");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaDocumento)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_DOCUMENTO");
            });

            modelBuilder.Entity<MetaDuracionVisita>(entity =>
            {
                entity.HasKey(e => new { e.CdCanal, e.CdCliente })
                    .HasName("XPKMETA_DURACION_VISITA");

                entity.ToTable("META_DURACION_VISITA");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF1META_DURACION_VISITA");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF3META_DURACION_VISITA");

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.NmDuracionVisita).HasColumnName("NM_DURACION_VISITA");

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaDuracionVisita)
                    .HasForeignKey(d => d.CdCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CANAL_META_DURACION_VISITA");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaDuracionVisita)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_DURACION_VISITA");
            });

            modelBuilder.Entity<MetaEmpleado>(entity =>
            {
                entity.HasKey(e => e.CdEmpleado)
                    .HasName("XPKMETA_EMPLEADO");

                entity.ToTable("META_EMPLEADO");

                entity.HasIndex(e => e.CdCausaBaja)
                    .HasName("XIF7META_EMPLEADO");

                entity.HasIndex(e => e.CdDir)
                    .HasName("XIF1META_EMPLEADO");

                entity.HasIndex(e => e.CdZonaEmpleado)
                    .HasName("XIF2META_EMPLEADO");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF4META_EMPLEADO");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF6META_EMPLEADO");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF5META_EMPLEADO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_EMPLEADO")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF3META_EMPLEADO");

                entity.Property(e => e.CdEmpleado)
                    .HasColumnName("CD_EMPLEADO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCausaBaja).HasColumnName("CD_CAUSA_BAJA");

                entity.Property(e => e.CdDir).HasColumnName("CD_DIR");

                entity.Property(e => e.CdZonaEmpleado).HasColumnName("CD_ZONA_EMPLEADO");

                entity.Property(e => e.DsApellido1)
                    .HasColumnName("DS_APELLIDO1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsApellido2)
                    .HasColumnName("DS_APELLIDO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsDniNif)
                    .HasColumnName("DS_DNI_NIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("DS_EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail2)
                    .HasColumnName("DS_EMAIL2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail3)
                    .HasColumnName("DS_EMAIL3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsExtension)
                    .HasColumnName("DS_EXTENSION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsMovil)
                    .HasColumnName("DS_MOVIL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsMovil2)
                    .HasColumnName("DS_MOVIL2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsNombre)
                    .IsRequired()
                    .HasColumnName("DS_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservaciones)
                    .HasColumnName("DS_OBSERVACIONES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefono)
                    .HasColumnName("DS_TELEFONO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefono2)
                    .HasColumnName("DS_TELEFONO2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcFinPeriodoPrueba)
                    .HasColumnName("FC_FIN_PERIODO_PRUEBA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcNacimiento)
                    .HasColumnName("FC_NACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmDiasLibres).HasColumnName("NM_DIAS_LIBRES");

                entity.Property(e => e.NmDiasLibresLastYear).HasColumnName("NM_DIAS_LIBRES_LAST_YEAR");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CdCausaBajaNavigation)
                    .WithMany(p => p.MetaEmpleado)
                    .HasForeignKey(d => d.CdCausaBaja)
                    .HasConstraintName("FK_META_CAUSA_BAJA_META_EMPLEADO");

                entity.HasOne(d => d.CdDirNavigation)
                    .WithMany(p => p.MetaEmpleado)
                    .HasForeignKey(d => d.CdDir)
                    .HasConstraintName("FK_META_DIRECCIONES_META_EMPLEADO");

                entity.HasOne(d => d.CdZonaEmpleadoNavigation)
                    .WithMany(p => p.MetaEmpleado)
                    .HasForeignKey(d => d.CdZonaEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_ZONA_EMPLEADO_META_EMPLEADO");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaEmpleadoDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_EMPLEADO_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaEmpleadoDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_EMPLEADO_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaEmpleadoDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_EMPLEADO_MODIF");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaEmpleadoUserNameNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_ASPNET_USERS_META_EMPLEADO");
            });

            modelBuilder.Entity<MetaEmpleadoAusencia>(entity =>
            {
                entity.HasKey(e => e.CdPermiso)
                    .HasName("XPKMETA_EMPLEADO_AUSENCIA");

                entity.ToTable("META_EMPLEADO_AUSENCIA");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF1META_EMPLEADO_AUSENCIA");

                entity.HasIndex(e => e.CdEstadoAusencia)
                    .HasName("XIF3META_EMPLEADO_AUSENCIA");

                entity.HasIndex(e => e.CdTipoAusencia)
                    .HasName("XIF4META_EMPLEADO_AUSENCIA");

                entity.Property(e => e.CdPermiso)
                    .HasColumnName("CD_PERMISO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdEstadoAusencia).HasColumnName("CD_ESTADO_AUSENCIA");

                entity.Property(e => e.CdTipoAusencia).HasColumnName("CD_TIPO_AUSENCIA");

                entity.Property(e => e.FcFecha)
                    .HasColumnName("FC_FECHA")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaEmpleadoAusencia)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_AUSENCIA");

                entity.HasOne(d => d.CdEstadoAusenciaNavigation)
                    .WithMany(p => p.MetaEmpleadoAusencia)
                    .HasForeignKey(d => d.CdEstadoAusencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_ESTADO_AUSENCIA_META_EMPLEADO_AUSENCIA");

                entity.HasOne(d => d.CdTipoAusenciaNavigation)
                    .WithMany(p => p.MetaEmpleadoAusencia)
                    .HasForeignKey(d => d.CdTipoAusencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIPO_AUSENCIA_META_EMPLEADO_AUSENCIA");
            });

            modelBuilder.Entity<MetaEmpleadoCliente>(entity =>
            {
                entity.HasKey(e => e.CdEmpleadoCliente)
                    .HasName("XPKMETA_EMPLEADO_CLIENTE");

                entity.ToTable("META_EMPLEADO_CLIENTE");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF3META_EMPLEADO_CLIENTE");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF1META_EMPLEADO_CLIENTE");

                entity.HasIndex(e => e.FcFin)
                    .HasName("IE2_META_EMPLEADO_CLIENTE");

                entity.HasIndex(e => e.FcInicio)
                    .HasName("IE1_META_EMPLEADO_CLIENTE");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_EMPLEADO_CLIENTE");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_EMPLEADO_CLIENTE")
                    .IsUnique();

                entity.Property(e => e.CdEmpleadoCliente)
                    .HasColumnName("CD_EMPLEADO_CLIENTE")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.DsNombreEquipo)
                    .HasColumnName("DS_NOMBRE_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItCompetidor).HasColumnName("IT_COMPETIDOR");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaEmpleadoCliente)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_EMPLEADO_CLIENTE");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaEmpleadoCliente)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_CLIENTE");
            });

            modelBuilder.Entity<MetaEmpleadoContabilidad>(entity =>
            {
                entity.HasKey(e => e.CdEmpleado)
                    .HasName("XPKMETA_EMPLEADO_CONTABILIDAD");

                entity.ToTable("META_EMPLEADO_CONTABILIDAD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_EMPLEADO_CONTABILIDAD")
                    .IsUnique();

                entity.Property(e => e.CdEmpleado)
                    .HasColumnName("CD_EMPLEADO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsNumeroCuenta)
                    .HasColumnName("DS_NUMERO_CUENTA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItSolred).HasColumnName("IT_SOLRED");

                entity.Property(e => e.ItVisa).HasColumnName("IT_VISA");

                entity.Property(e => e.NmAnticipo)
                    .HasColumnName("NM_ANTICIPO")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.NmBeneficiario).HasColumnName("NM_BENEFICIARIO");

                entity.Property(e => e.NmUltimaHoja).HasColumnName("NM_ULTIMA_HOJA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithOne(p => p.MetaEmpleadoContabilidad)
                    .HasForeignKey<MetaEmpleadoContabilidad>(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_CONTABILIDAD");
            });

            modelBuilder.Entity<MetaEmpleadoDepartamento>(entity =>
            {
                entity.HasKey(e => e.CdEmpleadoDepartamento)
                    .HasName("XPKMETA_EMPLEADO_DEPARTAMENTO");

                entity.ToTable("META_EMPLEADO_DEPARTAMENTO");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF1META_EMPLEADO_DEPARTAMENTO");

                entity.HasIndex(e => e.CdResponsable)
                    .HasName("XIF4META_EMPLEADO_DEPARTAMENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_EMPLEADO_DEPARTAMENTO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdPuesto, e.CdDepartamento })
                    .HasName("XIF3META_EMPLEADO_DEPARTAMENTO");

                entity.Property(e => e.CdEmpleadoDepartamento)
                    .HasColumnName("CD_EMPLEADO_DEPARTAMENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDepartamento).HasColumnName("CD_DEPARTAMENTO");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdPuesto).HasColumnName("CD_PUESTO");

                entity.Property(e => e.CdResponsable).HasColumnName("CD_RESPONSABLE");

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaEmpleadoDepartamentoCdEmpleadoNavigation)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_DPTO2");

                entity.HasOne(d => d.CdResponsableNavigation)
                    .WithMany(p => p.MetaEmpleadoDepartamentoCdResponsableNavigation)
                    .HasForeignKey(d => d.CdResponsable)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_DPTO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaEmpleadoDepartamento)
                    .HasForeignKey(d => new { d.CdDepartamento, d.CdPuesto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PUESTO_META_EMPLEADO_DEPARTAMENTO");
            });

            modelBuilder.Entity<MetaEmpleadoFotografia>(entity =>
            {
                entity.HasKey(e => new { e.CdEmpleado, e.CdFotografia })
                    .HasName("XPKMETA_EMPLEADO_FOTOGRAFIA");

                entity.ToTable("META_EMPLEADO_FOTOGRAFIA");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF1META_EMPLEADO_FOTOGRAFIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_EMPLEADO_FOTOGRAFIA")
                    .IsUnique();

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdFotografia).HasColumnName("CD_FOTOGRAFIA");

                entity.Property(e => e.FsFotografia).HasColumnName("FS_FOTOGRAFIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaEmpleadoFotografia)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_FOTOGRAFIA");
            });

            modelBuilder.Entity<MetaEmpleadoGrupoContabilidad>(entity =>
            {
                entity.HasKey(e => new { e.CdGrupoContabilidad, e.CdEmpleado })
                    .HasName("XPKMETA_EMPLEADO_GRUPO_CONTABILIDAD");

                entity.ToTable("META_EMPLEADO_GRUPO_CONTABILIDAD");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF2META_EMPLEADO_GRUPO_CONTABILIDAD");

                entity.HasIndex(e => e.CdGrupoContabilidad)
                    .HasName("XIF1META_EMPLEADO_GRUPO_CONTABILIDAD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_EMPLEADO_GRUPO_CONTABILIDAD")
                    .IsUnique();

                entity.Property(e => e.CdGrupoContabilidad).HasColumnName("CD_GRUPO_CONTABILIDAD");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.NmPorcentajeDedicacion)
                    .HasColumnName("NM_PORCENTAJE_DEDICACION")
                    .HasColumnType("numeric(3, 2)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaEmpleadoGrupoContabilidad)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_GRUPO_CONTABILIDAD");

                entity.HasOne(d => d.CdGrupoContabilidadNavigation)
                    .WithMany(p => p.MetaEmpleadoGrupoContabilidad)
                    .HasForeignKey(d => d.CdGrupoContabilidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_GRUPO_CONTABILIDAD_META_EMPLEADO_GRUPO_CONTABILIDAD");
            });

            modelBuilder.Entity<MetaEmpleadoLimite>(entity =>
            {
                entity.HasKey(e => new { e.CdConcepto, e.CdEmpleado })
                    .HasName("XPKMETA_EMPLEADO_LIMITE");

                entity.ToTable("META_EMPLEADO_LIMITE");

                entity.HasIndex(e => e.CdConcepto)
                    .HasName("XIF2META_EMPLEADO_LIMITE");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF1META_EMPLEADO_LIMITE");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_EMPLEADO_LIMITE")
                    .IsUnique();

                entity.Property(e => e.CdConcepto).HasColumnName("CD_CONCEPTO");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.NmLimite).HasColumnName("NM_LIMITE");

                entity.Property(e => e.NmMultiplicador)
                    .HasColumnName("NM_MULTIPLICADOR")
                    .HasColumnType("numeric(4, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdConceptoNavigation)
                    .WithMany(p => p.MetaEmpleadoLimite)
                    .HasForeignKey(d => d.CdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CONCEPTO_META_EMPLEADO_LIMITE");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaEmpleadoLimite)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_EMPLEADO_LIMITE");
            });

            modelBuilder.Entity<MetaFabricante>(entity =>
            {
                entity.HasKey(e => e.CdFabricante)
                    .HasName("XPKMETA_FABRICANTE");

                entity.ToTable("META_FABRICANTE");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_FABRICANTE")
                    .IsUnique();

                entity.Property(e => e.CdFabricante)
                    .HasColumnName("CD_FABRICANTE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsFabricante)
                    .IsRequired()
                    .HasColumnName("DS_FABRICANTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaFestivo>(entity =>
            {
                entity.HasKey(e => e.CdFestivo)
                    .HasName("XPKMETA_FESTIVO");

                entity.ToTable("META_FESTIVO");

                entity.HasIndex(e => e.CdAutonomia)
                    .HasName("XIF2META_FESTIVO");

                entity.HasIndex(e => e.CdPais)
                    .HasName("XIF1META_FESTIVO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_FESTIVO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdProv, e.CdMuni })
                    .HasName("XIF3META_FESTIVO");

                entity.Property(e => e.CdFestivo)
                    .HasColumnName("CD_FESTIVO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAutonomia)
                    .HasColumnName("CD_AUTONOMIA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdMuni)
                    .HasColumnName("CD_MUNI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdPais)
                    .IsRequired()
                    .HasColumnName("CD_PAIS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdProv)
                    .HasColumnName("CD_PROV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FcFecha)
                    .HasColumnName("FC_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdAutonomiaNavigation)
                    .WithMany(p => p.MetaFestivo)
                    .HasForeignKey(d => d.CdAutonomia)
                    .HasConstraintName("FK_META_C_AUTONOMIA_META_FESTIVO");

                entity.HasOne(d => d.CdPaisNavigation)
                    .WithMany(p => p.MetaFestivo)
                    .HasForeignKey(d => d.CdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_PAIS_META_FESTIVO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaFestivo)
                    .HasForeignKey(d => new { d.CdProv, d.CdMuni })
                    .HasConstraintName("FK_META_C_MUNICIPIO_META_FESTIVO");
            });

            modelBuilder.Entity<MetaFotoAurora>(entity =>
            {
                entity.HasKey(e => e.IdFoto);

                entity.ToTable("META_FOTO_AURORA");

                entity.Property(e => e.IdFoto).HasColumnName("id_foto");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasMaxLength(16);

                entity.Property(e => e.Referencia).HasColumnName("referencia");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.TipoObservacion).HasColumnName("tipoObservacion");

                entity.Property(e => e.UidFoto).HasColumnName("uid_foto");

                entity.Property(e => e.UidVisita).HasColumnName("uid_visita");
            });

            modelBuilder.Entity<MetaFotografiaFoto>(entity =>
            {
                entity.HasKey(e => e.CdAnotacionFoto)
                    .HasName("XPKMETA_FOTOGRAFIA_FOTO");

                entity.ToTable("META_FOTOGRAFIA_FOTO");

                entity.HasIndex(e => e.CdAnotacion)
                    .HasName("XIF3META_FOTOGRAFIA_FOTO");

                entity.Property(e => e.CdAnotacionFoto)
                    .HasColumnName("CD_ANOTACION_FOTO")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdAnotacion)
                    .HasColumnName("CD_ANOTACION")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FsFotografia).HasColumnName("FS_FOTOGRAFIA");

                entity.Property(e => e.FsMiniatura).HasColumnName("FS_MINIATURA");

                entity.HasOne(d => d.CdAnotacionNavigation)
                    .WithMany(p => p.MetaFotografiaFoto)
                    .HasForeignKey(d => d.CdAnotacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_ANOTACION_META_FOTOGRAFIA_FOTO");

                entity.HasOne(d => d.CdAnotacionFotoNavigation)
                    .WithOne(p => p.MetaFotografiaFoto)
                    .HasForeignKey<MetaFotografiaFoto>(d => d.CdAnotacionFoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_ANOTACION_FOTO_META_FOTOGRAFIA_FOTO");
            });

            modelBuilder.Entity<MetaGrupoContabilidad>(entity =>
            {
                entity.HasKey(e => e.CdGrupoContabilidad)
                    .HasName("XPKMETA_GRUPO_CONTABILIDAD");

                entity.ToTable("META_GRUPO_CONTABILIDAD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_GRUPO_CONTABILIDAD")
                    .IsUnique();

                entity.Property(e => e.CdGrupoContabilidad)
                    .HasColumnName("CD_GRUPO_CONTABILIDAD")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsGrupoContabilidad)
                    .IsRequired()
                    .HasColumnName("DS_GRUPO_CONTABILIDAD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaGrupoUsuario>(entity =>
            {
                entity.HasKey(e => e.CdGrupoUsuario)
                    .HasName("XPKMETA_GRUPO_USUARIO");

                entity.ToTable("META_GRUPO_USUARIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_GRUPO_USUARIO")
                    .IsUnique();

                entity.Property(e => e.CdGrupoUsuario)
                    .HasColumnName("CD_GRUPO_USUARIO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsGrupoUsuario)
                    .IsRequired()
                    .HasColumnName("DS_GRUPO_USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaGrupoUsuarioTipoTarea>(entity =>
            {
                entity.HasKey(e => new { e.CdGrupoUsuario, e.CdTipoTarea })
                    .HasName("XPKMETA_GRUPO_USUARIO_TIPO_TAREA");

                entity.ToTable("META_GRUPO_USUARIO_TIPO_TAREA");

                entity.HasIndex(e => e.CdGrupoUsuario)
                    .HasName("XIF1META_GRUPO_USUARIO_TIPO_TAREA");

                entity.HasIndex(e => e.CdTipoTarea)
                    .HasName("XIF2META_GRUPO_USUARIO_TIPO_TAREA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_GRUPO_USUARIO_TIPO_TAREA")
                    .IsUnique();

                entity.Property(e => e.CdGrupoUsuario).HasColumnName("CD_GRUPO_USUARIO");

                entity.Property(e => e.CdTipoTarea).HasColumnName("CD_TIPO_TAREA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdGrupoUsuarioNavigation)
                    .WithMany(p => p.MetaGrupoUsuarioTipoTarea)
                    .HasForeignKey(d => d.CdGrupoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_GRUPO_USUARIO_META_GRUPO_USUARIO_TIPO_TAREA");

                entity.HasOne(d => d.CdTipoTareaNavigation)
                    .WithMany(p => p.MetaGrupoUsuarioTipoTarea)
                    .HasForeignKey(d => d.CdTipoTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_GRUPO_USUARIO_TIPO_TAREA_META_C_TIPO_TAREA");
            });

            modelBuilder.Entity<MetaHojaGastos>(entity =>
            {
                entity.HasKey(e => e.CdHoja)
                    .HasName("XPKMETA_HOJA_GASTOS");

                entity.ToTable("META_HOJA_GASTOS");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF2META_HOJA_GASTOS");

                entity.HasIndex(e => e.CdEstado)
                    .HasName("XIF1META_HOJA_GASTOS");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF3META_HOJA_GASTOS");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF5META_HOJA_GASTOS");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF4META_HOJA_GASTOS");

                entity.Property(e => e.CdHoja)
                    .HasColumnName("CD_HOJA")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdEstado).HasColumnName("CD_ESTADO");

                entity.Property(e => e.DsObservaciones)
                    .HasColumnName("DS_OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.DsOtrosAjustes)
                    .HasColumnName("DS_OTROS_AJUSTES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmAnticipo)
                    .HasColumnName("NM_ANTICIPO")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.NmGastoSolred)
                    .HasColumnName("NM_GASTO_SOLRED")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.NmGastoVisa)
                    .HasColumnName("NM_GASTO_VISA")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.NmHoja).HasColumnName("NM_HOJA");

                entity.Property(e => e.NmKmMensual)
                    .HasColumnName("NM_KM_MENSUAL")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.NmOtrosAjustes)
                    .HasColumnName("NM_OTROS_AJUSTES")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.NmPieA)
                    .HasColumnName("NM_PIE_A")
                    .HasColumnType("numeric(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NmPieB)
                    .HasColumnName("NM_PIE_B")
                    .HasColumnType("numeric(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaHojaGastos)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_HOJA_GASTOS");

                entity.HasOne(d => d.CdEstadoNavigation)
                    .WithMany(p => p.MetaHojaGastos)
                    .HasForeignKey(d => d.CdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ESTADO_HOJA_GASTOS_META_HOJA_GASTOS");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaHojaGastosDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .HasConstraintName("FK_ASPNET_USERS_META_HOJA_GASTOS_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaHojaGastosDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_META_HOJA_GASTOS_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaHojaGastosDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_HOJA_GASTOS_MODIF");
            });

            modelBuilder.Entity<MetaHojaGastosFecha>(entity =>
            {
                entity.HasKey(e => new { e.CdFecha, e.CdHoja })
                    .HasName("XPKMETA_HOJA_GASTOS_FECHA");

                entity.ToTable("META_HOJA_GASTOS_FECHA");

                entity.HasIndex(e => e.CdHoja)
                    .HasName("XIF1META_HOJA_GASTOS_FECHA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK2META_HOJA_GASTOS_FECHA")
                    .IsUnique();

                entity.HasIndex(e => new { e.FcFecha, e.CdHoja })
                    .HasName("XAK1META_HOJA_GASTOS_FECHA")
                    .IsUnique();

                entity.Property(e => e.CdFecha).HasColumnName("CD_FECHA");

                entity.Property(e => e.CdHoja).HasColumnName("CD_HOJA");

                entity.Property(e => e.DsObservaciones)
                    .HasColumnName("DS_OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.FcFecha)
                    .HasColumnName("FC_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdHojaNavigation)
                    .WithMany(p => p.MetaHojaGastosFecha)
                    .HasForeignKey(d => d.CdHoja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_HOJA_GASTOS_META_HOJA_GASTOS_FECHA");
            });

            modelBuilder.Entity<MetaHojaGastosFechaApunte>(entity =>
            {
                entity.HasKey(e => new { e.CdFecha, e.CdHoja, e.CdConcepto })
                    .HasName("XPKMETA_HOJA_GASTOS_FECHA_APUNTE");

                entity.ToTable("META_HOJA_GASTOS_FECHA_APUNTE");

                entity.HasIndex(e => e.CdConcepto)
                    .HasName("XIF2META_HOJA_GASTOS_FECHA_APUNTE");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_HOJA_GASTOS_FECHA_APUNTE")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdFecha, e.CdHoja })
                    .HasName("XIF1META_HOJA_GASTOS_FECHA_APUNTE");

                entity.Property(e => e.CdFecha).HasColumnName("CD_FECHA");

                entity.Property(e => e.CdHoja).HasColumnName("CD_HOJA");

                entity.Property(e => e.CdConcepto).HasColumnName("CD_CONCEPTO");

                entity.Property(e => e.NmValor)
                    .HasColumnName("NM_VALOR")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdConceptoNavigation)
                    .WithMany(p => p.MetaHojaGastosFechaApunte)
                    .HasForeignKey(d => d.CdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CONCEPTO_META_HOJA_GASTOS_FECHA_APUNTE");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaHojaGastosFechaApunte)
                    .HasForeignKey(d => new { d.CdFecha, d.CdHoja })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_HOJA_GASTOS_FECHA_META_HOJA_GASTOS_FECHA_APUNTE");
            });

            modelBuilder.Entity<MetaHojaGastosInforme>(entity =>
            {
                entity.HasKey(e => e.CdHoja)
                    .HasName("XPKMETA_HOJA_GASTOS_INFORME");

                entity.ToTable("META_HOJA_GASTOS_INFORME");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF2META_HOJA_GASTOS_INFORME");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_HOJA_GASTOS_INFORME")
                    .IsUnique();

                entity.Property(e => e.CdHoja)
                    .HasColumnName("CD_HOJA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.FsInforme).HasColumnName("FS_INFORME");

                entity.Property(e => e.FsInformeGestion).HasColumnName("FS_INFORME_GESTION");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaHojaGastosInforme)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_GASTOS_INFORME");

                entity.HasOne(d => d.CdHojaNavigation)
                    .WithOne(p => p.MetaHojaGastosInforme)
                    .HasForeignKey<MetaHojaGastosInforme>(d => d.CdHoja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_HOJA_GASTOS_META_GASTOS_INFORME");
            });

            modelBuilder.Entity<MetaInforme>(entity =>
            {
                entity.HasKey(e => e.CdInforme)
                    .HasName("XPKMETA_INFORME");

                entity.ToTable("META_INFORME");

                entity.HasIndex(e => e.CdCategoria)
                    .HasName("XIF1META_INFORME");

                entity.Property(e => e.CdInforme)
                    .HasColumnName("CD_INFORME")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.DsDescripcion)
                    .IsRequired()
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItSistema).HasColumnName("IT_SISTEMA");

                entity.HasOne(d => d.CdCategoriaNavigation)
                    .WithMany(p => p.MetaInforme)
                    .HasForeignKey(d => d.CdCategoria)
                    .HasConstraintName("FK_META_C_CATEGORIA_EXPLOTACION_META_INFORME");
            });

            modelBuilder.Entity<MetaInformeCliente>(entity =>
            {
                entity.HasKey(e => new { e.CdCliente, e.CdInforme })
                    .HasName("XPKMETA_INFORME_CLIENTE");

                entity.ToTable("META_INFORME_CLIENTE");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_INFORME_CLIENTE");

                entity.HasIndex(e => e.CdInforme)
                    .HasName("XIF2META_INFORME_CLIENTE");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdInforme).HasColumnName("CD_INFORME");

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaInformeCliente)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_INFORME_CLIENTE");

                entity.HasOne(d => d.CdInformeNavigation)
                    .WithMany(p => p.MetaInformeCliente)
                    .HasForeignKey(d => d.CdInforme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_INFORME_META_INFORME_CLIENTE");
            });

            modelBuilder.Entity<MetaInformeClienteWeb>(entity =>
            {
                entity.HasKey(e => e.CdInfClteWeb)
                    .HasName("XPKMETA_INFORME_CLIENTE_WEB");

                entity.ToTable("META_INFORME_CLIENTE_WEB");

                entity.HasIndex(e => e.CdInforme)
                    .HasName("XIF1META_INFORME_CLIENTE_WEB");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_INFORME_CLIENTE_WEB")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF2META_INFORME_CLIENTE_WEB");

                entity.Property(e => e.CdInfClteWeb)
                    .HasColumnName("CD_INF_CLTE_WEB")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdInforme).HasColumnName("CD_INFORME");

                entity.Property(e => e.DsNombre)
                    .IsRequired()
                    .HasColumnName("DS_NOMBRE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FsInforme)
                    .IsRequired()
                    .HasColumnName("FS_INFORME");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CdInformeNavigation)
                    .WithMany(p => p.MetaInformeClienteWeb)
                    .HasForeignKey(d => d.CdInforme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_INFORME_META_INFORME_CLIENTE_WEB");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaInformeClienteWeb)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_INFORME_CLIENTE_WEB");
            });

            modelBuilder.Entity<MetaInformePlantilla>(entity =>
            {
                entity.HasKey(e => e.CdInforme)
                    .HasName("XPKMETA_INFORME_PLANTILLA");

                entity.ToTable("META_INFORME_PLANTILLA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_INFORME_PLANTILLA")
                    .IsUnique();

                entity.Property(e => e.CdInforme)
                    .HasColumnName("CD_INFORME")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsExtension)
                    .IsRequired()
                    .HasColumnName("DS_EXTENSION")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FsPlantilla).HasColumnName("FS_PLANTILLA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdInformeNavigation)
                    .WithOne(p => p.MetaInformePlantilla)
                    .HasForeignKey<MetaInformePlantilla>(d => d.CdInforme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_INFORME_META_INFORME_PLANTILLA");
            });

            modelBuilder.Entity<MetaInformeQuery>(entity =>
            {
                entity.HasKey(e => new { e.CdQuery, e.CdInforme })
                    .HasName("XPKMETA_INFORME_QUERY");

                entity.ToTable("META_INFORME_QUERY");

                entity.HasIndex(e => e.CdInforme)
                    .HasName("XIF1META_INFORME_QUERY");

                entity.Property(e => e.CdQuery).HasColumnName("CD_QUERY");

                entity.Property(e => e.CdInforme).HasColumnName("CD_INFORME");

                entity.Property(e => e.DsComando)
                    .HasColumnName("DS_COMANDO")
                    .HasColumnType("text");

                entity.Property(e => e.DsDiagrama)
                    .HasColumnName("DS_DIAGRAMA")
                    .HasColumnType("text");

                entity.Property(e => e.DsHoja)
                    .IsRequired()
                    .HasColumnName("DS_HOJA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmColumna).HasColumnName("NM_COLUMNA");

                entity.HasOne(d => d.CdInformeNavigation)
                    .WithMany(p => p.MetaInformeQuery)
                    .HasForeignKey(d => d.CdInforme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_INFORME_META_INFORME_QUERY");
            });

            modelBuilder.Entity<MetaLimites>(entity =>
            {
                entity.HasKey(e => e.CdLimite)
                    .HasName("XPKMETA_LIMITES");

                entity.ToTable("META_LIMITES");

                entity.HasIndex(e => e.CdPregunta)
                    .HasName("XIF4META_LIMITES");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF1META_LIMITES");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_LIMITES")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF2META_LIMITES");

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF3META_LIMITES");

                entity.Property(e => e.CdLimite)
                    .HasColumnName("CD_LIMITE")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdPregunta).HasColumnName("CD_PREGUNTA");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmLimiteMax).HasColumnName("NM_LIMITE_MAX");

                entity.Property(e => e.NmLimiteMin).HasColumnName("NM_LIMITE_MIN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPreguntaNavigation)
                    .WithMany(p => p.MetaLimites)
                    .HasForeignKey(d => d.CdPregunta)
                    .HasConstraintName("FK_META_PREGUNTAS_META_LIMITES");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaLimites)
                    .HasForeignKey(d => d.CdReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_REFERENCIA_META_LIMITES");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaLimites)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .HasConstraintName("FK_META_C_ENSENA_META_LIMITES");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.MetaLimites)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .HasConstraintName("FK_META_C_SEGMENTO_META_LIMITES");
            });

            modelBuilder.Entity<MetaLog>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_LOG");

                entity.ToTable("META_LOG");

                entity.HasIndex(e => e.CdTipoRegistro)
                    .HasName("XIF3META_LOG");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_LOG");

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF1META_LOG");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdTipoRegistro).HasColumnName("CD_TIPO_REGISTRO");

                entity.Property(e => e.DsAccion)
                    .IsRequired()
                    .HasColumnName("DS_ACCION")
                    .HasColumnType("text");

                entity.Property(e => e.FcFecha)
                    .HasColumnName("FC_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hostname)
                    .IsRequired()
                    .HasColumnName("HOSTNAME")
                    .HasMaxLength(128);

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.ItSistema).HasColumnName("IT_SISTEMA");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CdTipoRegistroNavigation)
                    .WithMany(p => p.MetaLog)
                    .HasForeignKey(d => d.CdTipoRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_TIPO_REGISTRO_META_LOG");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaLog)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_LOG");
            });

            modelBuilder.Entity<MetaLogH>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_LOG_H");

                entity.ToTable("META_LOG_H");

                entity.HasIndex(e => e.CdTipoRegistro)
                    .HasName("XIF2META_LOG_H");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_LOG");

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF1META_LOG_H");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdTipoRegistro).HasColumnName("CD_TIPO_REGISTRO");

                entity.Property(e => e.DsAccion)
                    .IsRequired()
                    .HasColumnName("DS_ACCION")
                    .HasColumnType("text");

                entity.Property(e => e.FcFecha)
                    .HasColumnName("FC_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hostname)
                    .IsRequired()
                    .HasColumnName("HOSTNAME")
                    .HasMaxLength(128);

                entity.Property(e => e.ItHistorico)
                    .IsRequired()
                    .HasColumnName("it_historico")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItSistema).HasColumnName("IT_SISTEMA");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CdTipoRegistroNavigation)
                    .WithMany(p => p.MetaLogH)
                    .HasForeignKey(d => d.CdTipoRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_TIPO_REGISTRO_META_LOG_H");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaLogH)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_LOG_H");
            });

            modelBuilder.Entity<MetaMarca>(entity =>
            {
                entity.HasKey(e => new { e.CdMarca, e.CdCliente })
                    .HasName("XPKMETA_MARCA");

                entity.ToTable("META_MARCA");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF2META_MARCA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MARCA")
                    .IsUnique();

                entity.Property(e => e.CdMarca).HasColumnName("CD_MARCA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.DsMarca)
                    .IsRequired()
                    .HasColumnName("DS_MARCA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaMarca)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_MARCA");
            });

            modelBuilder.Entity<MetaMaterialCadena>(entity =>
            {
                entity.HasKey(e => new { e.CdMaterial, e.CdCadena })
                    .HasName("XPKMETA_MATERIAL_CADENA");

                entity.ToTable("META_MATERIAL_CADENA");

                entity.HasIndex(e => e.CdCadena)
                    .HasName("XIF2META_MATERIAL_CADENA");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF1META_MATERIAL_CADENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MATERIAL_CADENA")
                    .IsUnique();

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCadenaNavigation)
                    .WithMany(p => p.MetaMaterialCadena)
                    .HasForeignKey(d => d.CdCadena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CADENA_META_MATERIAL_CADENA");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaMaterialCadena)
                    .HasForeignKey(d => d.CdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_MATERIAL_CADENA");
            });

            modelBuilder.Entity<MetaMaterialCategoria>(entity =>
            {
                entity.HasKey(e => new { e.CdMaterial, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XPKMETA_MATERIAL_CATEGORIA");

                entity.ToTable("META_MATERIAL_CATEGORIA");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF1META_MATERIAL_CATEGORIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MATERIAL_CATEGORIA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF2META_MATERIAL_CATEGORIA");

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaMaterialCategoria)
                    .HasForeignKey(d => d.CdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_MATERIAL_CATEGORIA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaMaterialCategoria)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_MATERIAL_CATEGORIA");
            });

            modelBuilder.Entity<MetaMaterialEnsena>(entity =>
            {
                entity.HasKey(e => new { e.CdMaterial, e.CdEnsena, e.CdCadena })
                    .HasName("XPKMETA_MATERIAL_ENSENA");

                entity.ToTable("META_MATERIAL_ENSENA");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF1META_MATERIAL_ENSENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MATERIAL_ENSENA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF2META_MATERIAL_ENSENA");

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaMaterialEnsena)
                    .HasForeignKey(d => d.CdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_MATERIAL_ENSENA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaMaterialEnsena)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_MATERIAL_ENSENA");
            });

            modelBuilder.Entity<MetaMaterialFotografia>(entity =>
            {
                entity.HasKey(e => new { e.CdMaterial, e.CdFotografia })
                    .HasName("XPKMETA_MATERIAL_FOTOGRAFIA");

                entity.ToTable("META_MATERIAL_FOTOGRAFIA");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF1META_MATERIAL_FOTOGRAFIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MATERIAL_FOTOGRAFIA")
                    .IsUnique();

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdFotografia).HasColumnName("CD_FOTOGRAFIA");

                entity.Property(e => e.FsFotografia).HasColumnName("FS_FOTOGRAFIA");

                entity.Property(e => e.ItPrincipal).HasColumnName("IT_PRINCIPAL");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaMaterialFotografia)
                    .HasForeignKey(d => d.CdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_MATERIAL_FOTOGRAFIA");
            });

            modelBuilder.Entity<MetaMaterialMarca>(entity =>
            {
                entity.HasKey(e => new { e.CdMaterial, e.CdMarca, e.CdCliente })
                    .HasName("XPKMETA_MATERIAL_MARCA");

                entity.ToTable("META_MATERIAL_MARCA");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF1META_MATERIAL_MARCA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MATERIAL_MARCA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdMarca, e.CdCliente })
                    .HasName("XIF2META_MATERIAL_MARCA");

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdMarca).HasColumnName("CD_MARCA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaMaterialMarca)
                    .HasForeignKey(d => d.CdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_MATERIAL_MARCA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaMaterialMarca)
                    .HasForeignKey(d => new { d.CdMarca, d.CdCliente })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MARCA_META_MATERIAL_MARCA");
            });

            modelBuilder.Entity<MetaMaterialReferencia>(entity =>
            {
                entity.HasKey(e => new { e.CdMaterial, e.CdReferencia })
                    .HasName("XPKMETA_MATERIAL_REFERENCIA");

                entity.ToTable("META_MATERIAL_REFERENCIA");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF1META_MATERIAL_REFERENCIA");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF2META_MATERIAL_REFERENCIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MATERIAL_REFERENCIA")
                    .IsUnique();

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaMaterialReferencia)
                    .HasForeignKey(d => d.CdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_MATERIAL_REFERENCIA");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaMaterialReferencia)
                    .HasForeignKey(d => d.CdReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_REFERENCIA_META_MATERIAL_REFERENCIA");
            });

            modelBuilder.Entity<MetaMaterialVisibilidad>(entity =>
            {
                entity.HasKey(e => e.CdMaterial)
                    .HasName("XPKMETA_MATERIAL_VISIBILIDAD");

                entity.ToTable("META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF2META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.CdTipoMaterial)
                    .HasName("XIF5META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.CdZona)
                    .HasName("XIF6META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF7META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF11META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF8META_MATERIAL_VISIBILIDAD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_MATERIAL_VISIBILIDAD")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdNivel1, e.CdNivel2, e.CdNivel3, e.CdNivel4, e.CdNivel5, e.CdNivel6 })
                    .HasName("XIF9META_MATERIAL_VISIBILIDAD");

                entity.Property(e => e.CdMaterial)
                    .HasColumnName("CD_MATERIAL")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdNivel1).HasColumnName("CD_NIVEL1");

                entity.Property(e => e.CdNivel2).HasColumnName("CD_NIVEL2");

                entity.Property(e => e.CdNivel3).HasColumnName("CD_NIVEL3");

                entity.Property(e => e.CdNivel4).HasColumnName("CD_NIVEL4");

                entity.Property(e => e.CdNivel5).HasColumnName("CD_NIVEL5");

                entity.Property(e => e.CdNivel6).HasColumnName("CD_NIVEL6");

                entity.Property(e => e.CdTipoMaterial).HasColumnName("CD_TIPO_MATERIAL");

                entity.Property(e => e.CdZona).HasColumnName("CD_ZONA");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsMaterial)
                    .IsRequired()
                    .HasColumnName("DS_MATERIAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItVisibilidad).HasColumnName("IT_VISIBILIDAD");

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TsVersion)
                    .IsRequired()
                    .HasColumnName("TS_VERSION")
                    .IsRowVersion();

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaMaterialVisibilidad)
                    .HasForeignKey(d => d.CdCanal)
                    .HasConstraintName("FK_META_C_CANAL_META_MATERIAL_VISIBILIDAD");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaMaterialVisibilidad)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_MATERIAL_VISIBILIDAD");

                entity.HasOne(d => d.CdTipoMaterialNavigation)
                    .WithMany(p => p.MetaMaterialVisibilidad)
                    .HasForeignKey(d => d.CdTipoMaterial)
                    .HasConstraintName("FK_META_C_TIPO_MATERIAL_VISIBILIDAD_META_MATERIAL_VISIBILIDAD");

                entity.HasOne(d => d.CdZonaNavigation)
                    .WithMany(p => p.MetaMaterialVisibilidad)
                    .HasForeignKey(d => d.CdZona)
                    .HasConstraintName("FK_META_C_ZONA_META_MATERIAL_VISIBILIDAD");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaMaterialVisibilidadDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_MATERIAL_VISIBILIDAD_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaMaterialVisibilidadDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_MATERIAL_VISIBILIDAD_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaMaterialVisibilidadDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_MATERIAL_VISIBILIDAD_MODIF");

                entity.HasOne(d => d.CdNivel)
                    .WithMany(p => p.MetaMaterialVisibilidad)
                    .HasPrincipalKey(p => new { p.CdNivel1, p.CdNivel2, p.CdNivel3, p.CdNivel4, p.CdNivel5, p.CdNivel6 })
                    .HasForeignKey(d => new { d.CdNivel1, d.CdNivel2, d.CdNivel3, d.CdNivel4, d.CdNivel5, d.CdNivel6 })
                    .HasConstraintName("FK_META_CATEGORIA_CLIENTE_META_MATERIAL_VISIBILIDAD");
            });

            modelBuilder.Entity<MetaNivelCategoriaCliente>(entity =>
            {
                entity.HasKey(e => e.CdNivel)
                    .HasName("XPKMETA_NIVEL_CATEGORIA_CLIENTE");

                entity.ToTable("META_NIVEL_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_NIVEL_CATEGORIA_CLIENTE");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_NIVEL_CATEGORIA_CLIENTE")
                    .IsUnique();

                entity.Property(e => e.CdNivel)
                    .HasColumnName("CD_NIVEL")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.DsNivel)
                    .HasColumnName("DS_NIVEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaNivelCategoriaCliente)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_NIVEL_CATEGORIA_CLIENTE");
            });

            modelBuilder.Entity<MetaPermisos>(entity =>
            {
                entity.HasKey(e => e.CdPermiso)
                    .HasName("XPKMETA_PERMISOS");

                entity.ToTable("META_PERMISOS");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("XIF1META_PERMISOS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PERMISOS")
                    .IsUnique();

                entity.Property(e => e.CdPermiso)
                    .HasColumnName("CD_PERMISO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsPermiso)
                    .IsRequired()
                    .HasColumnName("DS_PERMISO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.MetaPermisos)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_APPLICATIONS_META_PERMISOS");
            });

            modelBuilder.Entity<MetaPermisosCuboBi>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.CdCubo })
                    .HasName("XPKMETA_PERMISOS_CUBO_BI");

                entity.ToTable("META_PERMISOS_CUBO_BI");

                entity.HasIndex(e => e.CdCubo)
                    .HasName("XIF2META_PERMISOS_CUBO_BI");

                entity.HasIndex(e => e.RoleId)
                    .HasName("XIF1META_PERMISOS_CUBO_BI");

                entity.Property(e => e.CdCubo).HasColumnName("CD_CUBO");

                entity.HasOne(d => d.CdCuboNavigation)
                    .WithMany(p => p.MetaPermisosCuboBi)
                    .HasForeignKey(d => d.CdCubo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CUBO_BI_META_PERMISOS_CUBO_BI");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MetaPermisosCuboBi)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Roles_META_PERMISOS_CUBO_BI");
            });

            modelBuilder.Entity<MetaPermisosInforme>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.CdInforme })
                    .HasName("XPKMETA_PERMISOS_INFORME");

                entity.ToTable("META_PERMISOS_INFORME");

                entity.HasIndex(e => e.CdInforme)
                    .HasName("XIF2META_PERMISOS_INFORME");

                entity.HasIndex(e => e.RoleId)
                    .HasName("XIF3META_PERMISOS_INFORME");

                entity.Property(e => e.CdInforme).HasColumnName("CD_INFORME");

                entity.HasOne(d => d.CdInformeNavigation)
                    .WithMany(p => p.MetaPermisosInforme)
                    .HasForeignKey(d => d.CdInforme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_INFORMES_META_PERMISOS_INFORME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MetaPermisosInforme)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_ROLES_META_PERMISOS_INFORME");
            });

            modelBuilder.Entity<MetaPermisosRol>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.CdPermiso })
                    .HasName("XPKMETA_PERMISOS_ROL");

                entity.ToTable("META_PERMISOS_ROL");

                entity.HasIndex(e => e.CdPermiso)
                    .HasName("XIF2META_PERMISOS_ROL");

                entity.HasIndex(e => e.RoleId)
                    .HasName("XIF1META_PERMISOS_ROL");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PERMISOS_ROL")
                    .IsUnique();

                entity.Property(e => e.CdPermiso).HasColumnName("CD_PERMISO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPermisoNavigation)
                    .WithMany(p => p.MetaPermisosRol)
                    .HasForeignKey(d => d.CdPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PERMISOS_META_PERMISOS_ROL");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MetaPermisosRol)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_ROLES_META_PERMISOS_ROL");
            });

            modelBuilder.Entity<MetaPreguntas>(entity =>
            {
                entity.HasKey(e => e.CdPregunta)
                    .HasName("XPKMETA_PREGUNTAS");

                entity.ToTable("META_PREGUNTAS");

                entity.HasIndex(e => e.CdDependencia)
                    .HasName("XIF1META_PREGUNTAS");

                entity.HasIndex(e => e.CdListaRespuesta)
                    .HasName("XIF2META_PREGUNTAS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PREGUNTAS")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdSubtipoLista, e.CdListaRespuesta })
                    .HasName("XIF3META_PREGUNTAS");

                entity.Property(e => e.CdPregunta)
                    .HasColumnName("CD_PREGUNTA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDependencia).HasColumnName("CD_DEPENDENCIA");

                entity.Property(e => e.CdListaRespuesta).HasColumnName("CD_LISTA_RESPUESTA");

                entity.Property(e => e.CdSubtipoLista).HasColumnName("CD_SUBTIPO_LISTA");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsPregunta)
                    .IsRequired()
                    .HasColumnName("DS_PREGUNTA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsValorDep)
                    .HasColumnName("DS_VALOR_DEP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItObjeto).HasColumnName("IT_OBJETO");

                entity.Property(e => e.ItOperadorDep).HasColumnName("IT_OPERADOR_DEP");

                entity.Property(e => e.ItTipoPregunta).HasColumnName("IT_TIPO_PREGUNTA");

                entity.Property(e => e.NmDecimales).HasColumnName("NM_DECIMALES");

                entity.Property(e => e.NmLongitud).HasColumnName("NM_LONGITUD");

                entity.Property(e => e.NmMax)
                    .HasColumnName("NM_MAX")
                    .HasColumnType("numeric(8, 3)");

                entity.Property(e => e.NmMin)
                    .HasColumnName("NM_MIN")
                    .HasColumnType("numeric(8, 3)");

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdDependenciaNavigation)
                    .WithMany(p => p.InverseCdDependenciaNavigation)
                    .HasForeignKey(d => d.CdDependencia)
                    .HasConstraintName("FK_META_PREGUNTAS_META_PREGUNTAS");

                entity.HasOne(d => d.CdListaRespuestaNavigation)
                    .WithMany(p => p.MetaPreguntas)
                    .HasForeignKey(d => d.CdListaRespuesta)
                    .HasConstraintName("FK_META_PREGUNTAS_META_PREGUNTAS_LISTA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaPreguntas)
                    .HasForeignKey(d => new { d.CdListaRespuesta, d.CdSubtipoLista })
                    .HasConstraintName("FK_META_PREGUNTAS_SUBTIPO_LISTA_META_PREGUNTAS");
            });

            modelBuilder.Entity<MetaPreguntasCuestionario>(entity =>
            {
                entity.HasKey(e => new { e.CdPreguntaCuestionario, e.CdCuestionario })
                    .HasName("XPKMETA_PREGUNTAS_CUESTIONARIO");

                entity.ToTable("META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdCuestionario)
                    .HasName("XIF9META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF5META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdPregunta)
                    .HasName("XIF2META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF4META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF3META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdSubcategoria)
                    .HasName("XIF13META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdSubsegmento)
                    .HasName("XIF12META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.ItObjeto)
                    .HasName("XIE2META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PREGUNTAS_CUESTIONARIO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCuestionario, e.CdReferencia })
                    .HasName("XIE1META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdCuestionario, e.ItObjeto })
                    .HasName("XIE3META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdDependencia, e.CdCuestionario })
                    .HasName("XIF8META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdMarca, e.CdCliente })
                    .HasName("XIF14META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdSubtipoLista, e.CdListaRespuesta })
                    .HasName("XIF15META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF7META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdPregunta, e.CdCuestionario, e.CdPreguntaCuestionario, e.CdReferencia })
                    .HasName("XIE4META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF11META_PREGUNTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdCuestionario, e.CdPregunta, e.CdSector, e.CdFamilia, e.CdCategoria, e.CdSubcategoria, e.CdSegmento, e.CdSubsegmento, e.CdReferencia, e.CdPromocion, e.CdMaterial, e.CdMarca, e.CdCliente })
                    .HasName("XAK2META_PREGUNTAS_CUESTIONARIO")
                    .IsUnique();

                entity.Property(e => e.CdPreguntaCuestionario).HasColumnName("CD_PREGUNTA_CUESTIONARIO");

                entity.Property(e => e.CdCuestionario).HasColumnName("CD_CUESTIONARIO");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdDependencia).HasColumnName("CD_DEPENDENCIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdListaRespuesta).HasColumnName("CD_LISTA_RESPUESTA");

                entity.Property(e => e.CdMarca).HasColumnName("CD_MARCA");

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdPregunta).HasColumnName("CD_PREGUNTA");

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.CdSubcategoria).HasColumnName("CD_SUBCATEGORIA");

                entity.Property(e => e.CdSubsegmento).HasColumnName("CD_SUBSEGMENTO");

                entity.Property(e => e.CdSubtipoLista).HasColumnName("CD_SUBTIPO_LISTA");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsValorDep)
                    .HasColumnName("DS_VALOR_DEP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItObjeto).HasColumnName("IT_OBJETO");

                entity.Property(e => e.ItObligatoria)
                    .IsRequired()
                    .HasColumnName("IT_OBLIGATORIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.ItOperadorDep).HasColumnName("IT_OPERADOR_DEP");

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCuestionarioNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => d.CdCuestionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CUESTIONARIO_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => d.CdMaterial)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdPreguntaNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => d.CdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PREGUNTAS_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => d.CdPromocion)
                    .HasConstraintName("FK_META_PROMOCION_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => d.CdReferencia)
                    .HasConstraintName("FK_META_REFERENCIA_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdSubcategoriaNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => d.CdSubcategoria)
                    .HasConstraintName("FK_META_C_SUBCATEGORIA_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdSubsegmentoNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => d.CdSubsegmento)
                    .HasConstraintName("FK_META_C_SUBSEGMENTO_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.InverseCd)
                    .HasForeignKey(d => new { d.CdDependencia, d.CdCuestionario })
                    .HasConstraintName("FK_META_PREGUNTAS_CUESTIONARIO_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => new { d.CdListaRespuesta, d.CdSubtipoLista })
                    .HasConstraintName("FK_META_PREGUNTAS_SUBTIPO_LISTA_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.Cd1)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => new { d.CdMarca, d.CdCliente })
                    .HasConstraintName("FK_META_MARCA_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.Cd2)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .HasConstraintName("FK_META_C_CATEGORIA_META_PREGUNTAS_CUESTIONARIO");

                entity.HasOne(d => d.Cd3)
                    .WithMany(p => p.MetaPreguntasCuestionario)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .HasConstraintName("FK_META_C_SEGMENTO_META_PREGUNTAS_CUESTIONARIO");
            });

            modelBuilder.Entity<MetaPreguntasLista>(entity =>
            {
                entity.HasKey(e => e.CdListaRespuesta)
                    .HasName("XPKMETA_PREGUNTAS_LISTA");

                entity.ToTable("META_PREGUNTAS_LISTA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PREGUNTAS_LISTA")
                    .IsUnique();

                entity.Property(e => e.CdListaRespuesta)
                    .HasColumnName("CD_LISTA_RESPUESTA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsListaRespuesta)
                    .HasColumnName("DS_LISTA_RESPUESTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaPreguntasListaValores>(entity =>
            {
                entity.HasKey(e => new { e.CdValorRespuesta, e.CdListaRespuesta })
                    .HasName("XPKMETA_PREGUNTAS_LISTA_VALORES");

                entity.ToTable("META_PREGUNTAS_LISTA_VALORES");

                entity.HasIndex(e => e.CdListaRespuesta)
                    .HasName("XIF1META_PREGUNTAS_LISTA_VALORES");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PREGUNTAS_LISTA_VALORES")
                    .IsUnique();

                entity.Property(e => e.CdValorRespuesta).HasColumnName("CD_VALOR_RESPUESTA");

                entity.Property(e => e.CdListaRespuesta).HasColumnName("CD_LISTA_RESPUESTA");

                entity.Property(e => e.DsValor)
                    .IsRequired()
                    .HasColumnName("DS_VALOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdListaRespuestaNavigation)
                    .WithMany(p => p.MetaPreguntasListaValores)
                    .HasForeignKey(d => d.CdListaRespuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PREGUNTAS_LISTA_META_PREGUNTAS_LISTA_VALORES");
            });

            modelBuilder.Entity<MetaPreguntasSubtipoLista>(entity =>
            {
                entity.HasKey(e => new { e.CdListaRespuesta, e.CdSubtipoLista })
                    .HasName("XPKMETA_PREGUNTAS_SUBTIPO_LISTA");

                entity.ToTable("META_PREGUNTAS_SUBTIPO_LISTA");

                entity.HasIndex(e => e.CdListaRespuesta)
                    .HasName("XIF1META_PREGUNTAS_SUBTIPO_LISTA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PREGUNTAS_SUBTIPO_LISTA")
                    .IsUnique();

                entity.Property(e => e.CdListaRespuesta).HasColumnName("CD_LISTA_RESPUESTA");

                entity.Property(e => e.CdSubtipoLista).HasColumnName("CD_SUBTIPO_LISTA");

                entity.Property(e => e.DsColor)
                    .HasColumnName("DS_COLOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsSubtipoLista)
                    .IsRequired()
                    .HasColumnName("DS_SUBTIPO_LISTA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdListaRespuestaNavigation)
                    .WithMany(p => p.MetaPreguntasSubtipoLista)
                    .HasForeignKey(d => d.CdListaRespuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PREGUNTAS_LISTA_META_PREGUNTAS_SUBTIPO_LISTA");
            });

            modelBuilder.Entity<MetaPreguntasSubtipoListaValores>(entity =>
            {
                entity.HasKey(e => new { e.CdListaRespuesta, e.CdSubtipoLista, e.CdValorRespuesta })
                    .HasName("XPKMETA_PREGUNTAS_SUBTIPO_LISTA_VALORES");

                entity.ToTable("META_PREGUNTAS_SUBTIPO_LISTA_VALORES");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PREGUNTAS_SUBTIPO_LISTA_VALORES")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdSubtipoLista, e.CdListaRespuesta })
                    .HasName("XIF1META_PREGUNTAS_SUBTIPO_LISTA_VALORES");

                entity.HasIndex(e => new { e.CdValorRespuesta, e.CdListaRespuesta })
                    .HasName("XIF2META_PREGUNTAS_SUBTIPO_LISTA_VALORES");

                entity.Property(e => e.CdListaRespuesta).HasColumnName("CD_LISTA_RESPUESTA");

                entity.Property(e => e.CdSubtipoLista).HasColumnName("CD_SUBTIPO_LISTA");

                entity.Property(e => e.CdValorRespuesta).HasColumnName("CD_VALOR_RESPUESTA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaPreguntasSubtipoListaValores)
                    .HasForeignKey(d => new { d.CdListaRespuesta, d.CdSubtipoLista })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PREGUNTAS_SUBTIPO_LISTA_META_PREGUNTAS_SUBTIPO_LISTA_VALORES");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.MetaPreguntasSubtipoListaValores)
                    .HasForeignKey(d => new { d.CdValorRespuesta, d.CdListaRespuesta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PREGUNTAS_LISTA_VALORES_META_PREGUNTAS_SUBTIPO_LISTA_VALORES");
            });

            modelBuilder.Entity<MetaPromocion>(entity =>
            {
                entity.HasKey(e => e.CdPromocion)
                    .HasName("XPKMETA_PROMOCION");

                entity.ToTable("META_PROMOCION");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF2META_PROMOCION");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF3META_PROMOCION");

                entity.HasIndex(e => e.CdZona)
                    .HasName("XIF4META_PROMOCION");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF13META_PROMOCION");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF15META_PROMOCION");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF12META_PROMOCION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdNivel1, e.CdNivel2, e.CdNivel3, e.CdNivel4, e.CdNivel5, e.CdNivel6 })
                    .HasName("XIF11META_PROMOCION");

                entity.Property(e => e.CdPromocion)
                    .HasColumnName("CD_PROMOCION")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdNivel1).HasColumnName("CD_NIVEL1");

                entity.Property(e => e.CdNivel2).HasColumnName("CD_NIVEL2");

                entity.Property(e => e.CdNivel3).HasColumnName("CD_NIVEL3");

                entity.Property(e => e.CdNivel4).HasColumnName("CD_NIVEL4");

                entity.Property(e => e.CdNivel5).HasColumnName("CD_NIVEL5");

                entity.Property(e => e.CdNivel6).HasColumnName("CD_NIVEL6");

                entity.Property(e => e.CdZona).HasColumnName("CD_ZONA");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsPromocion)
                    .IsRequired()
                    .HasColumnName("DS_PROMOCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItVisibilidad).HasColumnName("IT_VISIBILIDAD");

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TsVersion)
                    .IsRequired()
                    .HasColumnName("TS_VERSION")
                    .IsRowVersion();

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaPromocion)
                    .HasForeignKey(d => d.CdCanal)
                    .HasConstraintName("FK_META_C_CANAL_META_PROMOCION");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaPromocion)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_PROMOCION");

                entity.HasOne(d => d.CdZonaNavigation)
                    .WithMany(p => p.MetaPromocion)
                    .HasForeignKey(d => d.CdZona)
                    .HasConstraintName("FK_META_C_ZONA_META_PROMOCION");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaPromocionDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_PROMOCION_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaPromocionDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_PROMOCION_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaPromocionDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_PROMOCION_MODIF");

                entity.HasOne(d => d.CdNivel)
                    .WithMany(p => p.MetaPromocion)
                    .HasPrincipalKey(p => new { p.CdNivel1, p.CdNivel2, p.CdNivel3, p.CdNivel4, p.CdNivel5, p.CdNivel6 })
                    .HasForeignKey(d => new { d.CdNivel1, d.CdNivel2, d.CdNivel3, d.CdNivel4, d.CdNivel5, d.CdNivel6 })
                    .HasConstraintName("FK_META_CATEGORIA_CLIENTE_META_PROMOCION");
            });

            modelBuilder.Entity<MetaPromocionCadena>(entity =>
            {
                entity.HasKey(e => new { e.CdPromocion, e.CdCadena })
                    .HasName("XPKMETA_PROMOCION_CADENA");

                entity.ToTable("META_PROMOCION_CADENA");

                entity.HasIndex(e => e.CdCadena)
                    .HasName("XIF1META_PROMOCION_CADENA");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF2META_PROMOCION_CADENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION_CADENA")
                    .IsUnique();

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCadenaNavigation)
                    .WithMany(p => p.MetaPromocionCadena)
                    .HasForeignKey(d => d.CdCadena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CADENA_META_PROMOCION_CADENA");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPromocionCadena)
                    .HasForeignKey(d => d.CdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PROMOCION_META_PROMOCION_CADENA");
            });

            modelBuilder.Entity<MetaPromocionCategoria>(entity =>
            {
                entity.HasKey(e => new { e.CdPromocion, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XPKMETA_PROMOCION_CATEGORIA");

                entity.ToTable("META_PROMOCION_CATEGORIA");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF1META_PROMOCION_CATEGORIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION_CATEGORIA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF2META_PROMOCION_CATEGORIA");

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPromocionCategoria)
                    .HasForeignKey(d => d.CdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PROMOCION_META_PROMOCION_CATEGORIA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaPromocionCategoria)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_PROMOCION_CATEGORIA");
            });

            modelBuilder.Entity<MetaPromocionCodigoInterno>(entity =>
            {
                entity.HasKey(e => new { e.CdEnsena, e.CdCadena, e.CdPromocion })
                    .HasName("XPKMETA_PROMOCION_CODIGO_INTERNO");

                entity.ToTable("META_PROMOCION_CODIGO_INTERNO");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF2META_PROMOCION_CODIGO_INTERNO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION_CODIGO_INTERNO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF1META_PROMOCION_CODIGO_INTERNO");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.DsCodigoInterno)
                    .IsRequired()
                    .HasColumnName("DS_CODIGO_INTERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPromocionCodigoInterno)
                    .HasForeignKey(d => d.CdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PROMOCION_META_PROMOCION_CODIGO_INTERNO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaPromocionCodigoInterno)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_PROMOCION_CODIGO_INTERNO");
            });

            modelBuilder.Entity<MetaPromocionEnsena>(entity =>
            {
                entity.HasKey(e => new { e.CdPromocion, e.CdEnsena, e.CdCadena })
                    .HasName("XPKMETA_PROMOCION_ENSENA");

                entity.ToTable("META_PROMOCION_ENSENA");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF2META_PROMOCION_ENSENA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION_ENSENA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF1META_PROMOCION_ENSENA");

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPromocionEnsena)
                    .HasForeignKey(d => d.CdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PROMOCION_META_PROMOCION_ENSENA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaPromocionEnsena)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_PROMOCION_ENSENA");
            });

            modelBuilder.Entity<MetaPromocionFotografia>(entity =>
            {
                entity.HasKey(e => new { e.CdPromocion, e.CdFotografia })
                    .HasName("XPKMETA_PROMOCION_FOTOGRAFIA");

                entity.ToTable("META_PROMOCION_FOTOGRAFIA");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF1META_PROMOCION_FOTOGRAFIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION_FOTOGRAFIA")
                    .IsUnique();

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdFotografia).HasColumnName("CD_FOTOGRAFIA");

                entity.Property(e => e.FsFotografia).HasColumnName("FS_FOTOGRAFIA");

                entity.Property(e => e.ItPrincipal).HasColumnName("IT_PRINCIPAL");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPromocionFotografia)
                    .HasForeignKey(d => d.CdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PROMOCION_META_PROMOCION_FOTOGRAFIA");
            });

            modelBuilder.Entity<MetaPromocionMarca>(entity =>
            {
                entity.HasKey(e => new { e.CdPromocion, e.CdMarca, e.CdCliente })
                    .HasName("XPKMETA_PROMOCION_MARCA");

                entity.ToTable("META_PROMOCION_MARCA");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF1META_PROMOCION_MARCA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION_MARCA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdMarca, e.CdCliente })
                    .HasName("XIF2META_PROMOCION_MARCA");

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdMarca).HasColumnName("CD_MARCA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPromocionMarca)
                    .HasForeignKey(d => d.CdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PROMOCION_META_PROMOCION_MARCA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaPromocionMarca)
                    .HasForeignKey(d => new { d.CdMarca, d.CdCliente })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MARCA_META_PROMOCION_MARCA");
            });

            modelBuilder.Entity<MetaPromocionReferencia>(entity =>
            {
                entity.HasKey(e => new { e.CdPromocion, e.CdReferencia })
                    .HasName("XPKMETA_PROMOCION_REFERENCIA");

                entity.ToTable("META_PROMOCION_REFERENCIA");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF1META_PROMOCION_REFERENCIA");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF2META_PROMOCION_REFERENCIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PROMOCION_REFERENCIA")
                    .IsUnique();

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaPromocionReferencia)
                    .HasForeignKey(d => d.CdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PROMOCION_META_PROMOCION_REFERENCIA");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaPromocionReferencia)
                    .HasForeignKey(d => d.CdReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_REFERENCIA_META_PROMOCION_REFERENCIA");
            });

            modelBuilder.Entity<MetaPuesto>(entity =>
            {
                entity.HasKey(e => new { e.CdDepartamento, e.CdPuesto })
                    .HasName("XPKMETA_PUESTO");

                entity.ToTable("META_PUESTO");

                entity.HasIndex(e => e.CdDepartamento)
                    .HasName("XIF1META_PUESTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_PUESTO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdPuestoDepende, e.CdDepartamentoDepende })
                    .HasName("XIF2META_PUESTO");

                entity.Property(e => e.CdDepartamento).HasColumnName("CD_DEPARTAMENTO");

                entity.Property(e => e.CdPuesto).HasColumnName("CD_PUESTO");

                entity.Property(e => e.CdDepartamentoDepende).HasColumnName("CD_DEPARTAMENTO_DEPENDE");

                entity.Property(e => e.CdPuestoDepende).HasColumnName("CD_PUESTO_DEPENDE");

                entity.Property(e => e.DsPuesto)
                    .IsRequired()
                    .HasColumnName("DS_PUESTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItVisibleMapa)
                    .IsRequired()
                    .HasColumnName("IT_VISIBLE_MAPA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdDepartamentoNavigation)
                    .WithMany(p => p.MetaPuesto)
                    .HasForeignKey(d => d.CdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_DEPARTAMENTO_META_PUESTO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.InverseCd)
                    .HasForeignKey(d => new { d.CdDepartamentoDepende, d.CdPuestoDepende })
                    .HasConstraintName("FK_META_PUESTO_META_PUESTO");
            });

            modelBuilder.Entity<MetaReferencia>(entity =>
            {
                entity.HasKey(e => e.CdReferencia)
                    .HasName("XPKMETA_REFERENCIA");

                entity.ToTable("META_REFERENCIA");

                entity.HasIndex(e => e.CdSubcategoria)
                    .HasName("XIF5META_REFERENCIA");

                entity.HasIndex(e => e.CdSubsegmento)
                    .HasName("XIF6META_REFERENCIA");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF8META_REFERENCIA");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF9META_REFERENCIA");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF7META_REFERENCIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_REFERENCIA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCliente, e.ItActiva })
                    .HasName("XIE1META_REFERENCIA");

                entity.HasIndex(e => new { e.CdCliente, e.ItVisibilidad })
                    .HasName("XIE2_META_REFERENCIA");

                entity.HasIndex(e => new { e.CdMarca, e.CdCliente })
                    .HasName("XIF3META_REFERENCIA");

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_REFERENCIA");

                entity.HasIndex(e => new { e.CdNivel1, e.CdNivel2, e.CdNivel3, e.CdNivel4, e.CdNivel5, e.CdNivel6 })
                    .HasName("XIF4META_REFERENCIA");

                entity.Property(e => e.CdReferencia)
                    .HasColumnName("CD_REFERENCIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdMarca).HasColumnName("CD_MARCA");

                entity.Property(e => e.CdNivel1).HasColumnName("CD_NIVEL1");

                entity.Property(e => e.CdNivel2).HasColumnName("CD_NIVEL2");

                entity.Property(e => e.CdNivel3).HasColumnName("CD_NIVEL3");

                entity.Property(e => e.CdNivel4).HasColumnName("CD_NIVEL4");

                entity.Property(e => e.CdNivel5).HasColumnName("CD_NIVEL5");

                entity.Property(e => e.CdNivel6).HasColumnName("CD_NIVEL6");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.CdSubcategoria).HasColumnName("CD_SUBCATEGORIA");

                entity.Property(e => e.CdSubsegmento).HasColumnName("CD_SUBSEGMENTO");

                entity.Property(e => e.DsCodEan)
                    .HasColumnName("DS_COD_EAN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsCodFabricante)
                    .HasColumnName("DS_COD_FABRICANTE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsDescripcion)
                    .IsRequired()
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItActiva)
                    .IsRequired()
                    .HasColumnName("IT_ACTIVA")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItVisibilidad)
                    .HasColumnName("IT_VISIBILIDAD")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.NmRanking).HasColumnName("NM_RANKING");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TsVersion)
                    .IsRequired()
                    .HasColumnName("TS_VERSION")
                    .IsRowVersion();

                entity.HasOne(d => d.CdSubcategoriaNavigation)
                    .WithMany(p => p.MetaReferencia)
                    .HasForeignKey(d => d.CdSubcategoria)
                    .HasConstraintName("FK_META_C_SUBCATEGORIA_META_REFERENCIA");

                entity.HasOne(d => d.CdSubsegmentoNavigation)
                    .WithMany(p => p.MetaReferencia)
                    .HasForeignKey(d => d.CdSubsegmento)
                    .HasConstraintName("FK_META_C_SUBSEGMENTO_META_REFERENCIA");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaReferenciaDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_REFERENCIA_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaReferenciaDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_REFERENCIA_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaReferenciaDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_REFERENCIA_MODIF");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaReferencia)
                    .HasForeignKey(d => new { d.CdMarca, d.CdCliente })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_MARCA_META_REFERENCIA");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.MetaReferencia)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SEGMENTO_META_REFERENCIA");

                entity.HasOne(d => d.CdNivel)
                    .WithMany(p => p.MetaReferencia)
                    .HasPrincipalKey(p => new { p.CdNivel1, p.CdNivel2, p.CdNivel3, p.CdNivel4, p.CdNivel5, p.CdNivel6 })
                    .HasForeignKey(d => new { d.CdNivel1, d.CdNivel2, d.CdNivel3, d.CdNivel4, d.CdNivel5, d.CdNivel6 })
                    .HasConstraintName("FK_META_CATEGORIA_CLIENTE_META_REFERENCIA");
            });

            modelBuilder.Entity<MetaReferenciaCodigoInterno>(entity =>
            {
                entity.HasKey(e => new { e.CdEnsena, e.CdCadena, e.CdReferencia })
                    .HasName("XPKMETA_REFERENCIA_CODIGO_INTERNO");

                entity.ToTable("META_REFERENCIA_CODIGO_INTERNO");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF2META_REFERENCIA_CODIGO_INTERNO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XIE1_META_REFERENCIA_CODIGO_INTERNO");

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF1META_REFERENCIA_CODIGO_INTERNO");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.DsCodigoInterno)
                    .IsRequired()
                    .HasColumnName("DS_CODIGO_INTERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaReferenciaCodigoInterno)
                    .HasForeignKey(d => d.CdReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_REFERENCIA_META_REFERENCIA_CODIGO_INTERNO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaReferenciaCodigoInterno)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_REFERENCIA_CODIGO_INTERNO");
            });

            modelBuilder.Entity<MetaReferenciaFotografia>(entity =>
            {
                entity.HasKey(e => new { e.CdReferencia, e.CdFotografia })
                    .HasName("XPKMETA_REFERENCIA_FOTOGRAFIA");

                entity.ToTable("META_REFERENCIA_FOTOGRAFIA");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF1META_REFERENCIA_FOTOGRAFIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_REFERENCIA_FOTOGRAFIA")
                    .IsUnique();

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.CdFotografia).HasColumnName("CD_FOTOGRAFIA");

                entity.Property(e => e.FsFotografia).HasColumnName("FS_FOTOGRAFIA");

                entity.Property(e => e.ItPrincipal).HasColumnName("IT_PRINCIPAL");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaReferenciaFotografia)
                    .HasForeignKey(d => d.CdReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_REFERENCIA_META_REFERENCIA_FOTOGRAFIA");
            });

            modelBuilder.Entity<MetaReferenciaPrioridad>(entity =>
            {
                entity.HasKey(e => new { e.CdEnsena, e.CdCadena, e.CdReferencia })
                    .HasName("XPKMETA_REFERENCIA_PRIORIDAD");

                entity.ToTable("META_REFERENCIA_PRIORIDAD");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF1META_REFERENCIA_PRIORIDAD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_REFERENCIA_PRIORIDAD")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF3META_REFERENCIA_PRIORIDAD");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaReferenciaPrioridad)
                    .HasForeignKey(d => d.CdReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_REFERENCIA_META_REFERENCIA_PRIORIDAD");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaReferenciaPrioridad)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_REFERENCIA_PRIORIDAD");
            });

            modelBuilder.Entity<MetaRespuestasCuestionario>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_RESPUESTAS_CUESTIONARIO");

                entity.ToTable("META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdCluster)
                    .HasName("XIF4META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdCuestionario)
                    .HasName("XIE2META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => e.DsRespuesta)
                    .HasName("XIE1_META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => e.FcFecha)
                    .HasName("XIE_META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => e.RowguidVisita)
                    .HasName("XIF5META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.CdPreguntaCuestionario, e.CdCuestionario })
                    .HasName("XIF2META_RESPUESTAS_CUESTIONARIO");

                entity.HasIndex(e => new { e.DsRespuesta, e.CdCuestionario, e.RowguidVisita, e.CdPreguntaCuestionario, e.Rowguid })
                    .HasName("XIE3META_RESPUESTAS_CUESTIONARIO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CdCluster).HasColumnName("CD_CLUSTER");

                entity.Property(e => e.CdCuestionario).HasColumnName("CD_CUESTIONARIO");

                entity.Property(e => e.CdPreguntaCuestionario).HasColumnName("CD_PREGUNTA_CUESTIONARIO");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.DsRespuesta)
                    .HasColumnName("DS_RESPUESTA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FcFecha)
                    .HasColumnName("FC_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItSurtido).HasColumnName("IT_SURTIDO");

                entity.Property(e => e.RowguidVisita).HasColumnName("ROWGUID_VISITA");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CdClusterNavigation)
                    .WithMany(p => p.MetaRespuestasCuestionario)
                    .HasForeignKey(d => d.CdCluster)
                    .HasConstraintName("FK_META_C_CLUSTER_META_RESPUESTAS_CUESTIONARIO");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaRespuestasCuestionario)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_RESPUESTAS_CUESTIONARIO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaRespuestasCuestionario)
                    .HasForeignKey(d => new { d.CdPreguntaCuestionario, d.CdCuestionario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_PREGUNTAS_CUESTIONARIO_META_RESPUESTAS_CUESTIONARIO");
            });

            modelBuilder.Entity<MetaRespuestasCuestionarioDwh>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_RESPUESTAS_CUESTIONARIO_DWH");

                entity.ToTable("META_RESPUESTAS_CUESTIONARIO_DWH");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Rowgu)
                    .WithOne(p => p.MetaRespuestasCuestionarioDwh)
                    .HasForeignKey<MetaRespuestasCuestionarioDwh>(d => d.Rowguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_RESPUESTAS_CUESTIONARIO_DWH_META_RESPUESTAS_CUESTIONARIO");
            });

            modelBuilder.Entity<MetaRuta>(entity =>
            {
                entity.HasKey(e => e.CdRuta)
                    .HasName("XPKMETA_RUTA");

                entity.ToTable("META_RUTA");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF4META_RUTA");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF3META_RUTA");

                entity.HasIndex(e => e.CdPeriodicidad)
                    .HasName("XIF8META_RUTA");

                entity.HasIndex(e => e.CdRutaSiguiente)
                    .HasName("XIF2META_RUTA");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF5META_RUTA");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF7META_RUTA");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF6META_RUTA");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE2_META_RUTA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_RUTA")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItHistorico, e.FcBaja })
                    .HasName("XIE1_META_RUTA");

                entity.Property(e => e.CdRuta)
                    .HasColumnName("CD_RUTA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdPeriodicidad).HasColumnName("CD_PERIODICIDAD");

                entity.Property(e => e.CdRutaSiguiente).HasColumnName("CD_RUTA_SIGUIENTE");

                entity.Property(e => e.DsLugarPernoctacion)
                    .HasColumnName("DS_LUGAR_PERNOCTACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsNombreEquipo)
                    .HasColumnName("DS_NOMBRE_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsRuta)
                    .IsRequired()
                    .HasColumnName("DS_RUTA")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.ItTipoJornada)
                    .HasColumnName("IT_TIPO_JORNADA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaRuta)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_RUTA");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaRuta)
                    .HasForeignKey(d => d.CdEmpleado)
                    .HasConstraintName("FK_META_EMPLEADO_META_RUTA");

                entity.HasOne(d => d.CdPeriodicidadNavigation)
                    .WithMany(p => p.MetaRuta)
                    .HasForeignKey(d => d.CdPeriodicidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_PERIODICIDAD_META_RUTA");

                entity.HasOne(d => d.CdRutaSiguienteNavigation)
                    .WithMany(p => p.InverseCdRutaSiguienteNavigation)
                    .HasForeignKey(d => d.CdRutaSiguiente)
                    .HasConstraintName("FK_META_RUTA_META_RUTA");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaRutaDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_RUTA_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaRutaDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_RUTA_BAJA");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaRutaDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_RUTA_MODIF");
            });

            modelBuilder.Entity<MetaSegmentoOrden>(entity =>
            {
                entity.HasKey(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector, e.CdCliente })
                    .HasName("XPKMETA_SEGMENTO_ORDEN");

                entity.ToTable("META_SEGMENTO_ORDEN");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF2META_SEGMENTO_ORDEN");

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_SEGMENTO_ORDEN");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.NmOrden).HasColumnName("NM_ORDEN");

                entity.Property(e => e.NmOrdenInforme).HasColumnName("NM_ORDEN_INFORME");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaSegmentoOrden)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_SEGMENTO_ORDEN");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaSegmentoOrden)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SEGMENTO_META_SEGMENTO_ORDEN");
            });

            modelBuilder.Entity<MetaSincronizacion>(entity =>
            {
                entity.HasKey(e => e.Usuario);

                entity.ToTable("meta_sincronizacion");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MetaSurtido>(entity =>
            {
                entity.HasKey(e => e.CdSurtido)
                    .HasName("XPKMETA_SURTIDO");

                entity.ToTable("META_SURTIDO");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF4META_SURTIDO");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF1META_SURTIDO");

                entity.HasIndex(e => e.CdZona)
                    .HasName("XIF3META_SURTIDO");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF5META_SURTIDO");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF7META_SURTIDO");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF6META_SURTIDO");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_SURTIDO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_SURTIDO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF2META_SURTIDO");

                entity.Property(e => e.CdSurtido)
                    .HasColumnName("CD_SURTIDO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdZona).HasColumnName("CD_ZONA");

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.ItPublicado)
                    .IsRequired()
                    .HasColumnName("IT_PUBLICADO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaSurtido)
                    .HasForeignKey(d => d.CdCanal)
                    .HasConstraintName("FK_META_C_CANAL_META_SURTIDO");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaSurtido)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_SURTIDO");

                entity.HasOne(d => d.CdZonaNavigation)
                    .WithMany(p => p.MetaSurtido)
                    .HasForeignKey(d => d.CdZona)
                    .HasConstraintName("FK_META_C_ZONA_META_SURTIDO");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaSurtidoDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_SURTIDO_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaSurtidoDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_SURTIDO_MODIF");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaSurtidoDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_SURTIDO_BAJA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaSurtido)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .HasConstraintName("FK_META_C_ENSENA_META_SURTIDO");
            });

            modelBuilder.Entity<MetaSurtidoReferencias>(entity =>
            {
                entity.HasKey(e => e.CdSurtidoReferencia)
                    .HasName("XPKMETA_SURTIDO_REFERENCIAS");

                entity.ToTable("META_SURTIDO_REFERENCIAS");

                entity.HasIndex(e => e.CdCluster)
                    .HasName("XIF3META_SURTIDO_REFERENCIAS");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF5META_SURTIDO_REFERENCIAS");

                entity.HasIndex(e => e.CdSurtido)
                    .HasName("XIF4META_SURTIDO_REFERENCIAS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XIE1_META_SURTIDO_REFERENCIAS");

                entity.HasIndex(e => new { e.CdSurtido, e.CdReferencia, e.CdCluster })
                    .HasName("XAK1META_SURTIDO_REFERENCIAS")
                    .IsUnique();

                entity.Property(e => e.CdSurtidoReferencia)
                    .HasColumnName("CD_SURTIDO_REFERENCIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCluster).HasColumnName("CD_CLUSTER");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.CdSurtido).HasColumnName("CD_SURTIDO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClusterNavigation)
                    .WithMany(p => p.MetaSurtidoReferencias)
                    .HasForeignKey(d => d.CdCluster)
                    .HasConstraintName("FK_META_C_CLUSTER_META_SURTIDO_REFERENCIAS");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaSurtidoReferencias)
                    .HasForeignKey(d => d.CdReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_REFERENCIA_META_SURTIDO_REFERENCIAS");

                entity.HasOne(d => d.CdSurtidoNavigation)
                    .WithMany(p => p.MetaSurtidoReferencias)
                    .HasForeignKey(d => d.CdSurtido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_SURTIDO_META_SURTIDO_REFERENCIAS");
            });

            modelBuilder.Entity<MetaTarea>(entity =>
            {
                entity.HasKey(e => e.CdTarea)
                    .HasName("XPKMETA_TAREA");

                entity.ToTable("META_TAREA");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF6META_TAREA");

                entity.HasIndex(e => e.CdEstadoTarea)
                    .HasName("XIF2META_TAREA");

                entity.HasIndex(e => e.CdRuta)
                    .HasName("XIF3META_TAREA");

                entity.HasIndex(e => e.CdSituacionTarea)
                    .HasName("XIF9META_TAREA");

                entity.HasIndex(e => e.CdTipoTarea)
                    .HasName("XIF5META_TAREA");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF7META_TAREA");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF10META_TAREA");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF8META_TAREA");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_TAREA");

                entity.HasIndex(e => new { e.CdEmpleado, e.ItHistorico })
                    .HasName("XIE1_META_TAREA");

                entity.HasIndex(e => new { e.CdTarea, e.CdEmpleado })
                    .HasName("XAK2META_TAREA")
                    .IsUnique();

                entity.Property(e => e.CdTarea)
                    .HasColumnName("CD_TAREA")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdEstadoTarea).HasColumnName("CD_ESTADO_TAREA");

                entity.Property(e => e.CdRuta).HasColumnName("CD_RUTA");

                entity.Property(e => e.CdSituacionTarea).HasColumnName("CD_SITUACION_TAREA");

                entity.Property(e => e.CdTipoEvento).HasColumnName("CD_TIPO_EVENTO");

                entity.Property(e => e.CdTipoTarea).HasColumnName("CD_TIPO_TAREA");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsMotivo)
                    .HasColumnName("DS_MOTIVO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservaciones)
                    .HasColumnName("DS_OBSERVACIONES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsRecurrenceInfo).HasColumnName("DS_RECURRENCE_INFO");

                entity.Property(e => e.DsReminderInfo).HasColumnName("DS_REMINDER_INFO");

                entity.Property(e => e.DsTitulo)
                    .IsRequired()
                    .HasColumnName("DS_TITULO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DsUbicacion)
                    .HasColumnName("DS_UBICACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcFin)
                    .HasColumnName("FC_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcInicio)
                    .HasColumnName("FC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItDiaCompleto)
                    .HasColumnName("IT_DIA_COMPLETO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.ItPrioritaria)
                    .IsRequired()
                    .HasColumnName("IT_PRIORITARIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaTarea)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_TAREA");

                entity.HasOne(d => d.CdEstadoTareaNavigation)
                    .WithMany(p => p.MetaTarea)
                    .HasForeignKey(d => d.CdEstadoTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ESTADO_TAREA_META_TAREA");

                entity.HasOne(d => d.CdRutaNavigation)
                    .WithMany(p => p.MetaTarea)
                    .HasForeignKey(d => d.CdRuta)
                    .HasConstraintName("FK_META_RUTA_META_TAREA");

                entity.HasOne(d => d.CdSituacionTareaNavigation)
                    .WithMany(p => p.MetaTarea)
                    .HasForeignKey(d => d.CdSituacionTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SITUACION_TAREA_META_TAREA");

                entity.HasOne(d => d.CdTipoTareaNavigation)
                    .WithMany(p => p.MetaTarea)
                    .HasForeignKey(d => d.CdTipoTarea)
                    .HasConstraintName("FK_META_C_TIPO_TAREA_META_TAREA");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaTareaDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_TAREA_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaTareaDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_TAREA_BAJA");
            });

            modelBuilder.Entity<MetaTienda>(entity =>
            {
                entity.HasKey(e => e.CdTienda)
                    .HasName("XPKMETA_TIENDA");

                entity.ToTable("META_TIENDA");

                entity.HasIndex(e => e.CdCanal)
                    .HasName("XIF2META_TIENDA");

                entity.HasIndex(e => e.CdDir)
                    .HasName("XIF3META_TIENDA");

                entity.HasIndex(e => e.CdEstadoTienda)
                    .HasName("XIF7META_TIENDA");

                entity.HasIndex(e => e.CdTipoEstablecimiento)
                    .HasName("XIF8META_TIENDA");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF5META_TIENDA");

                entity.HasIndex(e => e.DsUserbaja)
                    .HasName("XIF9META_TIENDA");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF4META_TIENDA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF1META_TIENDA");

                entity.Property(e => e.CdTienda)
                    .HasColumnName("CD_TIENDA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.CdCanal).HasColumnName("CD_CANAL");

                entity.Property(e => e.CdDir).HasColumnName("CD_DIR");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdEstadoTienda).HasColumnName("CD_ESTADO_TIENDA");

                entity.Property(e => e.CdTipoEstablecimiento).HasColumnName("CD_TIPO_ESTABLECIMIENTO");

                entity.Property(e => e.DsCodCadena)
                    .HasColumnName("DS_COD_CADENA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsCodNielsen)
                    .HasColumnName("DS_COD_NIELSEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsFax)
                    .HasColumnName("DS_FAX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DsLote)
                    .IsRequired()
                    .HasColumnName("DS_LOTE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservaciones)
                    .HasColumnName("DS_OBSERVACIONES")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservacionesVend)
                    .HasColumnName("DS_OBSERVACIONES_VEND")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefono)
                    .HasColumnName("DS_TELEFONO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DsUseralta)
                    .IsRequired()
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUserbaja)
                    .HasColumnName("DS_USERBAJA")
                    .HasMaxLength(256);

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.DsWeb)
                    .HasColumnName("DS_WEB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcAltaSistema)
                    .HasColumnName("FC_ALTA_SISTEMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItComidas).HasColumnName("IT_COMIDAS");

                entity.Property(e => e.NmCajas).HasColumnName("NM_CAJAS");

                entity.Property(e => e.NmEscaparates).HasColumnName("NM_ESCAPARATES");

                entity.Property(e => e.NmLatitud)
                    .HasColumnName("NM_LATITUD")
                    .HasColumnType("numeric(8, 5)");

                entity.Property(e => e.NmLongitud)
                    .HasColumnName("NM_LONGITUD")
                    .HasColumnType("numeric(8, 5)");

                entity.Property(e => e.NmSuperficie)
                    .HasColumnName("NM_SUPERFICIE")
                    .HasColumnType("numeric(8, 3)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TsVersion)
                    .IsRequired()
                    .HasColumnName("TS_VERSION")
                    .IsRowVersion();

                entity.HasOne(d => d.CdCanalNavigation)
                    .WithMany(p => p.MetaTienda)
                    .HasForeignKey(d => d.CdCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CANAL_META_TIENDA");

                entity.HasOne(d => d.CdDirNavigation)
                    .WithMany(p => p.MetaTienda)
                    .HasForeignKey(d => d.CdDir)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_DIRECCIONES_META_TIENDA");

                entity.HasOne(d => d.CdEstadoTiendaNavigation)
                    .WithMany(p => p.MetaTienda)
                    .HasForeignKey(d => d.CdEstadoTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ESTADO_TIENDA_META_TIENDA");

                entity.HasOne(d => d.CdTipoEstablecimientoNavigation)
                    .WithMany(p => p.MetaTienda)
                    .HasForeignKey(d => d.CdTipoEstablecimiento)
                    .HasConstraintName("FK_META_C_TIPO_ESTABLECIMIENTO_META_TIENDA");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaTiendaDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_TIENDA_ALTA");

                entity.HasOne(d => d.DsUserbajaNavigation)
                    .WithMany(p => p.MetaTiendaDsUserbajaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUserbaja)
                    .HasConstraintName("FK_ASPNET_USERS_META_TIENDA_BAJA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaTienda)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_TIENDA");
            });

            modelBuilder.Entity<MetaTiendaCategoria>(entity =>
            {
                entity.HasKey(e => e.CdDato)
                    .HasName("XPKMETA_TIENDA_CATEGORIA");

                entity.ToTable("META_TIENDA_CATEGORIA");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDA_CATEGORIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_CATEGORIA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF3META_TIENDA_CATEGORIA");

                entity.Property(e => e.CdDato)
                    .HasColumnName("CD_DATO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.NmBaldas).HasColumnName("NM_BALDAS");

                entity.Property(e => e.NmMedidaBalda).HasColumnName("NM_MEDIDA_BALDA");

                entity.Property(e => e.NmModulos).HasColumnName("NM_MODULOS");

                entity.Property(e => e.NmMueblesFijos).HasColumnName("NM_MUEBLES_FIJOS");

                entity.Property(e => e.NmSeparacionBaldas).HasColumnName("NM_SEPARACION_BALDAS");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaCategoria)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_CATEGORIA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaTiendaCategoria)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_TIENDA_CATEGORIA");
            });

            modelBuilder.Entity<MetaTiendaConfiguracion>(entity =>
            {
                entity.HasKey(e => new { e.CdConfiguracion, e.CdTienda })
                    .HasName("XPKMETA_TIENDA_CONFIGURACION");

                entity.ToTable("META_TIENDA_CONFIGURACION");

                entity.HasIndex(e => e.CdCluster)
                    .HasName("XIF3META_TIENDA_CONFIGURACION");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDA_CONFIGURACION");

                entity.HasIndex(e => e.DsUseralta)
                    .HasName("XIF4META_TIENDA_CONFIGURACION");

                entity.HasIndex(e => e.DsUsermodif)
                    .HasName("XIF5META_TIENDA_CONFIGURACION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_CONFIGURACION")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdSector, e.CdFamilia })
                    .HasName("XIE1_META_TIENDA_CONFIGURACION");

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF2META_TIENDA_CONFIGURACION");

                entity.Property(e => e.CdConfiguracion).HasColumnName("CD_CONFIGURACION");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdCluster).HasColumnName("CD_CLUSTER");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.DsUseralta)
                    .HasColumnName("DS_USERALTA")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DsUsermodif)
                    .HasColumnName("DS_USERMODIF")
                    .HasMaxLength(256);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcUltmodif)
                    .HasColumnName("FC_ULTMODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdClusterNavigation)
                    .WithMany(p => p.MetaTiendaConfiguracion)
                    .HasForeignKey(d => d.CdCluster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CLUSTER_META_TIENDA_CONFIGURACION");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaConfiguracion)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_CONFIGURACION");

                entity.HasOne(d => d.DsUseraltaNavigation)
                    .WithMany(p => p.MetaTiendaConfiguracionDsUseraltaNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUseralta)
                    .HasConstraintName("FK_ASPNET_USERS_META_TIENDA_CONFIGURACION");

                entity.HasOne(d => d.DsUsermodifNavigation)
                    .WithMany(p => p.MetaTiendaConfiguracionDsUsermodifNavigation)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsermodif)
                    .HasConstraintName("FK_ASPNET_USERS_META_TIENDA_CONFIGURACION_2");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaTiendaConfiguracion)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SEGMENTO_META_TIENDA_CONFIGURACION");
            });

            modelBuilder.Entity<MetaTiendaDupDwh>(entity =>
            {
                entity.HasKey(e => new { e.CdTienda, e.CdTiendaDup })
                    .HasName("XPKMETA_TIENDA_DUP_DWH");

                entity.ToTable("META_TIENDA_DUP_DWH");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDA_DUP_DWH");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.CdTiendaDup).HasColumnName("CD_TIENDA_DUP");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaDupDwh)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_DUP_DWH");
            });

            modelBuilder.Entity<MetaTiendaFoto>(entity =>
            {
                entity.HasKey(e => e.CdTienda)
                    .HasName("XPKMETA_TIENDA_FOTO");

                entity.ToTable("META_TIENDA_FOTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_FOTO")
                    .IsUnique();

                entity.Property(e => e.CdTienda)
                    .HasColumnName("CD_TIENDA")
                    .ValueGeneratedNever();

                entity.Property(e => e.FsFotografia).HasColumnName("FS_FOTOGRAFIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithOne(p => p.MetaTiendaFoto)
                    .HasForeignKey<MetaTiendaFoto>(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_FOTO");
            });

            modelBuilder.Entity<MetaTiendaObjetivo>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_TIENDA_OBJETIVO");

                entity.ToTable("META_TIENDA_OBJETIVO");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF4META_TIENDA_OBJETIVO");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF5META_TIENDA_OBJETIVO");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDA_OBJETIVO");

                entity.HasIndex(e => e.RowguidVisita)
                    .HasName("XIF6META_TIENDA_OBJETIVO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.DsObjetivo)
                    .IsRequired()
                    .HasColumnName("DS_OBJETIVO")
                    .IsUnicode(false);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RowguidVisita).HasColumnName("ROWGUID_VISITA");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaTiendaObjetivo)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_TIENDA_OBJETIVO");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaTiendaObjetivo)
                    .HasForeignKey(d => d.CdEmpleado)
                    .HasConstraintName("FK_META_EMPLEADO_META_TIENDA_OBJETIVO");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaObjetivo)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_OBJETIVO");
            });

            modelBuilder.Entity<MetaTiendaPalanca>(entity =>
            {
                entity.HasKey(e => e.CdPalancaTienda)
                    .HasName("XPKMETA_TIENDA_PALANCA");

                entity.ToTable("META_TIENDA_PALANCA");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF6META_TIENDA_PALANCA");

                entity.HasIndex(e => e.CdPalanca)
                    .HasName("XIF4META_TIENDA_PALANCA");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF5META_TIENDA_PALANCA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_PALANCA")
                    .IsUnique();

                entity.Property(e => e.CdPalancaTienda)
                    .HasColumnName("CD_PALANCA_TIENDA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdPalanca).HasColumnName("CD_PALANCA");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaTiendaPalanca)
                    .HasForeignKey(d => d.CdEmpleado)
                    .HasConstraintName("FK_META_EMPLEADO_META_TIENDA_PALANCA");

                entity.HasOne(d => d.CdPalancaNavigation)
                    .WithMany(p => p.MetaTiendaPalanca)
                    .HasForeignKey(d => d.CdPalanca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_PALANCA_META_TIENDA_PALANCA");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaPalanca)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_PALANCA");
            });

            modelBuilder.Entity<MetaTiendaPersonal>(entity =>
            {
                entity.HasKey(e => new { e.CdPersona, e.CdTienda })
                    .HasName("XPKMETA_TIENDA_PERSONAL");

                entity.ToTable("META_TIENDA_PERSONAL");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDA_PERSONAL");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_PERSONAL")
                    .IsUnique();

                entity.Property(e => e.CdPersona).HasColumnName("CD_PERSONA");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.DsNombre)
                    .IsRequired()
                    .HasColumnName("DS_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservaciones)
                    .HasColumnName("DS_OBSERVACIONES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsPuesto)
                    .HasColumnName("DS_PUESTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefono)
                    .HasColumnName("DS_TELEFONO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaPersonal)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_PERSONAL");
            });

            modelBuilder.Entity<MetaTiendaPersonalTrato>(entity =>
            {
                entity.HasKey(e => new { e.CdPersona, e.CdTienda, e.CdEmpleado })
                    .HasName("XPKMETA_TIENDA_PERSONAL_TRATO");

                entity.ToTable("META_TIENDA_PERSONAL_TRATO");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIF3META_TIENDA_PERSONAL_TRATO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_PERSONAL_TRATO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdPersona, e.CdTienda })
                    .HasName("XIF2META_TIENDA_PERSONAL_TRATO");

                entity.Property(e => e.CdPersona).HasColumnName("CD_PERSONA");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.ItTrato)
                    .IsRequired()
                    .HasColumnName("IT_TRATO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdEmpleadoNavigation)
                    .WithMany(p => p.MetaTiendaPersonalTrato)
                    .HasForeignKey(d => d.CdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_EMPLEADO_META_TIENDA_PERSONAL_TRATO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaTiendaPersonalTrato)
                    .HasForeignKey(d => new { d.CdPersona, d.CdTienda })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_PERSONAL_META_TIENDA_PERSONAL_TRATO");
            });

            modelBuilder.Entity<MetaTiendaPotencialCategoria>(entity =>
            {
                entity.HasKey(e => new { e.CdFamilia, e.CdSector, e.CdCategoria, e.CdTienda })
                    .HasName("XPKMETA_TIENDA_POTENCIAL_CATEGORIA");

                entity.ToTable("META_TIENDA_POTENCIAL_CATEGORIA");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDA_POTENCIAL_CATEGORIA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_POTENCIAL_CATEGORIA")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF2META_TIENDA_POTENCIAL_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.NmPotencial)
                    .HasColumnName("NM_POTENCIAL")
                    .HasColumnType("numeric(14, 13)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaPotencialCategoria)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_POTENCIAL_CATEGORIA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaTiendaPotencialCategoria)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_TIENDA_POTENCIAL_CATEGORIA");
            });

            modelBuilder.Entity<MetaTiendaPotencialFamilia>(entity =>
            {
                entity.HasKey(e => new { e.CdFamilia, e.CdSector, e.CdTienda })
                    .HasName("XPKMETA_TIENDA_POTENCIAL_FAMILIA");

                entity.ToTable("META_TIENDA_POTENCIAL_FAMILIA");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDA_POTENCIAL_FAMILIA");

                entity.HasIndex(e => new { e.CdFamilia, e.CdSector })
                    .HasName("XIF2META_TIENDA_POTENCIAL_FAMILIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.NmPotencial).HasColumnName("NM_POTENCIAL");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaPotencialFamilia)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_POTENCIAL_FAMILIA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaTiendaPotencialFamilia)
                    .HasForeignKey(d => new { d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_FAMILIA_META_TIENDA_POTENCIAL_FAMILIA");
            });

            modelBuilder.Entity<MetaTiendaSeccion>(entity =>
            {
                entity.HasKey(e => e.CdDato)
                    .HasName("XPKMETA_TIENDA_SECCION");

                entity.ToTable("META_TIENDA_SECCION");

                entity.HasIndex(e => e.CdSeccion)
                    .HasName("XIF1META_TIENDA_SECCION");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF2META_TIENDA_SECCION");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_SECCION")
                    .IsUnique();

                entity.Property(e => e.CdDato)
                    .HasColumnName("CD_DATO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdSeccion).HasColumnName("CD_SECCION");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.NmCabecerasGondola).HasColumnName("NM_CABECERAS_GONDOLA");

                entity.Property(e => e.NmModulos).HasColumnName("NM_MODULOS");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdSeccionNavigation)
                    .WithMany(p => p.MetaTiendaSeccion)
                    .HasForeignKey(d => d.CdSeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SECCION_META_TIENDA_SECCION");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaSeccion)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_SECCION");
            });

            modelBuilder.Entity<MetaTiendaSegmento>(entity =>
            {
                entity.HasKey(e => e.CdDato)
                    .HasName("XPKMETA_TIENDA_SEGMENTO");

                entity.ToTable("META_TIENDA_SEGMENTO");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF2META_TIENDA_SEGMENTO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_TIENDA_SEGMENTO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF1META_TIENDA_SEGMENTO");

                entity.Property(e => e.CdDato)
                    .HasColumnName("CD_DATO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.NmBaldas).HasColumnName("NM_BALDAS");

                entity.Property(e => e.NmMedidaBalda).HasColumnName("NM_MEDIDA_BALDA");

                entity.Property(e => e.NmModulos).HasColumnName("NM_MODULOS");

                entity.Property(e => e.NmMueblesFijos).HasColumnName("NM_MUEBLES_FIJOS");

                entity.Property(e => e.NmSeparacionBaldas).HasColumnName("NM_SEPARACION_BALDAS");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendaSegmento)
                    .HasForeignKey(d => d.CdTienda)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_SEGMENTO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaTiendaSegmento)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_SEGMENTO_META_TIENDA_SEGMENTO");
            });

            modelBuilder.Entity<MetaTiendaToken>(entity =>
            {
                entity.HasKey(e => e.CdTienda)
                    .HasName("XPKMETA_TIENDA_TOKEN");

                entity.ToTable("META_TIENDA_TOKEN");

                entity.HasIndex(e => e.DsUsertoken)
                    .HasName("XIF1META_TIENDA_TOKEN");

                entity.Property(e => e.CdTienda)
                    .HasColumnName("CD_TIENDA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsUsertoken)
                    .HasColumnName("DS_USERTOKEN")
                    .HasMaxLength(256);

                entity.Property(e => e.FcUltModificacionTienda)
                    .HasColumnName("FC_ULT_MODIFICACION_TIENDA")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithOne(p => p.MetaTiendaToken)
                    .HasForeignKey<MetaTiendaToken>(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDA_TOKEN");

                entity.HasOne(d => d.DsUsertokenNavigation)
                    .WithMany(p => p.MetaTiendaToken)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.DsUsertoken)
                    .HasConstraintName("FK_ASPNET_USERS_META_TIENDA_TOKEN2");
            });

            modelBuilder.Entity<MetaTiendasRuta>(entity =>
            {
                entity.HasKey(e => new { e.CdTienda, e.CdRuta })
                    .HasName("XPKMETA_TIENDAS_RUTA");

                entity.ToTable("META_TIENDAS_RUTA");

                entity.HasIndex(e => e.CdRuta)
                    .HasName("XIF2META_TIENDAS_RUTA");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_TIENDAS_RUTA");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_TIENDAS_RUTA");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XIE1_META_TIENDAS_RUTA");

                entity.HasIndex(e => new { e.ItHistorico, e.FcBaja })
                    .HasName("XIE2_META_TIENDAS_RUTA");

                entity.HasIndex(e => new { e.CdTienda, e.DsNombreEquipo, e.ItHistorico })
                    .HasName("XMI0_META_TIENDAS_RUTA");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.CdRuta).HasColumnName("CD_RUTA");

                entity.Property(e => e.DsNombreEquipo)
                    .HasColumnName("DS_NOMBRE_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FcAlta)
                    .HasColumnName("FC_ALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcBaja)
                    .HasColumnName("FC_BAJA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.Property(e => e.NmDuracionVisita).HasColumnName("NM_DURACION_VISITA");

                entity.Property(e => e.NmOrden)
                    .HasColumnName("NM_ORDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdRutaNavigation)
                    .WithMany(p => p.MetaTiendasRuta)
                    .HasForeignKey(d => d.CdRuta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_RUTA_META_TIENDAS_RUTA");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaTiendasRuta)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_TIENDAS_RUTA");
            });

            modelBuilder.Entity<MetaUsuarioCliente>(entity =>
            {
                entity.HasKey(e => e.Idenid);

                entity.ToTable("META_USUARIO_CLIENTE");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF3META_USUARIO_CLIENTE");

                entity.Property(e => e.Idenid).HasColumnName("idenid");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.DsApellido1)
                    .HasColumnName("DS_APELLIDO1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsApellido2)
                    .HasColumnName("DS_APELLIDO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsNombre)
                    .IsRequired()
                    .HasColumnName("DS_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsPuesto)
                    .HasColumnName("DS_PUESTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<MetaUsuarioClienteCategoria>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XPKMETA_USUARIO_CLIENTE_CATEGORIA");

                entity.ToTable("META_USUARIO_CLIENTE_CATEGORIA");

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF2META_USUARIO_CLIENTE_CATEGORIA");

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF3META_USUARIO_CLIENTE_CATEGORIA");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaUsuarioClienteCategoria)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_CATEGORIA_META_USUARIO_CLIENTE_CATEGORIA");
            });

            modelBuilder.Entity<MetaUsuarioClienteEnsena>(entity =>
            {
                entity.HasKey(e => new { e.CdEnsena, e.CdCadena, e.UserName })
                    .HasName("XPKMETA_USUARIO_CLIENTE_ENSENA");

                entity.ToTable("META_USUARIO_CLIENTE_ENSENA");

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF1META_USUARIO_CLIENTE_ENSENA");

                entity.HasIndex(e => new { e.CdEnsena, e.CdCadena })
                    .HasName("XIF2META_USUARIO_CLIENTE_ENSENA");

                entity.Property(e => e.CdEnsena).HasColumnName("CD_ENSENA");

                entity.Property(e => e.CdCadena).HasColumnName("CD_CADENA");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaUsuarioClienteEnsena)
                    .HasForeignKey(d => new { d.CdEnsena, d.CdCadena })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ENSENA_META_USUARIO_CLIENTE_ENSENA");
            });

            modelBuilder.Entity<MetaUsuarioClienteZona>(entity =>
            {
                entity.HasKey(e => new { e.CdZona, e.UserName })
                    .HasName("XPKMETA_USUARIO_CLIENTE_ZONA");

                entity.ToTable("META_USUARIO_CLIENTE_ZONA");

                entity.HasIndex(e => e.CdZona)
                    .HasName("XIF2META_USUARIO_CLIENTE_ZONA");

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF1META_USUARIO_CLIENTE_ZONA");

                entity.Property(e => e.CdZona).HasColumnName("CD_ZONA");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CdZonaNavigation)
                    .WithMany(p => p.MetaUsuarioClienteZona)
                    .HasForeignKey(d => d.CdZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ZONA_META_USUARIO_CLIENTE_ZONA");
            });

            modelBuilder.Entity<MetaUsuarioEquipo>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.DsNombreEquipo })
                    .HasName("XPKMETA_USUARIO_EQUIPO");

                entity.ToTable("META_USUARIO_EQUIPO");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XAK2META_USUARIO_EQUIPO")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_USUARIO_EQUIPO")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF1META_USUARIO_EQUIPO");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.DsNombreEquipo)
                    .HasColumnName("DS_NOMBRE_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaUsuarioEquipo)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Users_META_USUARIO_EQUIPO");
            });

            modelBuilder.Entity<MetaUsuarioGrupoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CdGrupoUsuario, e.UserName })
                    .HasName("XPKMETA_USUARIO_GRUPO_USUARIO");

                entity.ToTable("META_USUARIO_GRUPO_USUARIO");

                entity.HasIndex(e => e.CdGrupoUsuario)
                    .HasName("XIF1META_USUARIO_GRUPO_USUARIO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_USUARIO_GRUPO_USUARIO")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF2META_USUARIO_GRUPO_USUARIO");

                entity.Property(e => e.CdGrupoUsuario).HasColumnName("CD_GRUPO_USUARIO");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdGrupoUsuarioNavigation)
                    .WithMany(p => p.MetaUsuarioGrupoUsuario)
                    .HasForeignKey(d => d.CdGrupoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_GRUPO_USUARIO_META_USUARIO_GRUPO_USUARIO");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaUsuarioGrupoUsuario)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNET_USERS_META_USUARIO_GRUPO_USUARIO");
            });

            modelBuilder.Entity<MetaVisita>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_VISITA");

                entity.ToTable("META_VISITA");

                entity.HasIndex(e => e.CdCausaNoVisita)
                    .HasName("XIF2META_VISITA");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("XIF7META_VISITA");

                entity.HasIndex(e => e.CdEmpleado)
                    .HasName("XIE2META_VISITA");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF4META_VISITA");

                entity.HasIndex(e => e.FcVisita)
                    .HasName("XIE1META_VISITA");

                entity.HasIndex(e => e.ItHistorico)
                    .HasName("XIE0META_VISITA");

                entity.HasIndex(e => new { e.CdTarea, e.CdEmpleado })
                    .HasName("XIF6META_VISITA");

                entity.HasIndex(e => new { e.ItHistorico, e.FcVisita })
                    .HasName("XIE3_META_VISITA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdCausaNoVisita).HasColumnName("CD_CAUSA_NO_VISITA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdTarea)
                    .HasColumnName("CD_TAREA")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.DsCausaNoVisita)
                    .HasColumnName("DS_CAUSA_NO_VISITA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FcFinVisita)
                    .HasColumnName("FC_FIN_VISITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcPlanificacionInicial)
                    .HasColumnName("FC_PLANIFICACION_INICIAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcVisita)
                    .HasColumnName("FC_VISITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItHistorico).HasColumnName("it_historico");

                entity.HasOne(d => d.CdCausaNoVisitaNavigation)
                    .WithMany(p => p.MetaVisita)
                    .HasForeignKey(d => d.CdCausaNoVisita)
                    .HasConstraintName("FK_META_CAUSA_NO_VISITA_META_VISITA");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.MetaVisita)
                    .HasForeignKey(d => d.CdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CLIENTE_META_VISITA");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaVisita)
                    .HasForeignKey(d => d.CdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TIENDA_META_VISITA");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaVisita)
                    .HasPrincipalKey(p => new { p.CdTarea, p.CdEmpleado })
                    .HasForeignKey(d => new { d.CdTarea, d.CdEmpleado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_TAREA_META_VISITA");
            });

            modelBuilder.Entity<MetaVisitaDisponible>(entity =>
            {
                entity.HasKey(e => e.Rowguid)
                    .HasName("XPKMETA_VISITA_DISPONIBLE");

                entity.ToTable("META_VISITA_DISPONIBLE");

                entity.HasIndex(e => e.CdTienda)
                    .HasName("XIF1META_VISITA_DISPONIBLE");

                entity.HasIndex(e => new { e.CdTarea, e.CdEmpleado })
                    .HasName("XIF2META_VISITA_DISPONIBLE");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdEmpleado).HasColumnName("CD_EMPLEADO");

                entity.Property(e => e.CdTarea)
                    .HasColumnName("CD_TAREA")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CdTienda).HasColumnName("CD_TIENDA");

                entity.Property(e => e.FcPeticion)
                    .HasColumnName("FC_PETICION")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItEstado).HasColumnName("IT_ESTADO");

                entity.HasOne(d => d.CdTiendaNavigation)
                    .WithMany(p => p.MetaVisitaDisponible)
                    .HasForeignKey(d => d.CdTienda)
                    .HasConstraintName("FK_META_TIENDA_META_VISITA_DISPONIBLE");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaVisitaDisponible)
                    .HasPrincipalKey(p => new { p.CdTarea, p.CdEmpleado })
                    .HasForeignKey(d => new { d.CdTarea, d.CdEmpleado })
                    .HasConstraintName("FK_META_TAREA_META_VISITA_DISPONIBLE");
            });

            modelBuilder.Entity<MetaVisitaObjeto>(entity =>
            {
                entity.HasKey(e => e.CdVisitaObjeto)
                    .HasName("XPKMETA_VISITA_OBJETO");

                entity.ToTable("META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdCluster)
                    .HasName("XIF14META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdCuestionario)
                    .HasName("XIF13META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdMaterial)
                    .HasName("XIF10META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdPregunta)
                    .HasName("XIF12META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdPromocion)
                    .HasName("XIF11META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdReferencia)
                    .HasName("XIF2META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdSubcategoria)
                    .HasName("XIF6META_VISITA_OBJETO");

                entity.HasIndex(e => e.CdSubsegmento)
                    .HasName("XIF7META_VISITA_OBJETO");

                entity.HasIndex(e => e.ItObjeto)
                    .HasName("XIE1META_VISITA_OBJETO");

                entity.HasIndex(e => e.RowguidVisita)
                    .HasName("XIF3META_VISITA_OBJETO");

                entity.HasIndex(e => new { e.CdMarca, e.CdCliente })
                    .HasName("XIF8META_VISITA_OBJETO");

                entity.HasIndex(e => new { e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF4META_VISITA_OBJETO");

                entity.HasIndex(e => new { e.CdSegmento, e.CdCategoria, e.CdFamilia, e.CdSector })
                    .HasName("XIF5META_VISITA_OBJETO");

                entity.HasIndex(e => new { e.CdCuestionario, e.CdPregunta, e.CdFamilia, e.CdSector, e.CdCategoria, e.CdSubcategoria, e.CdSegmento, e.CdSubsegmento, e.CdReferencia, e.CdPromocion, e.CdMaterial, e.CdMarca, e.CdCliente, e.RowguidVisita })
                    .HasName("XAK1META_VISITA_OBJETO")
                    .IsUnique();

                entity.Property(e => e.CdVisitaObjeto)
                    .HasColumnName("CD_VISITA_OBJETO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCategoria).HasColumnName("CD_CATEGORIA");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdCluster).HasColumnName("CD_CLUSTER");

                entity.Property(e => e.CdCuestionario).HasColumnName("CD_CUESTIONARIO");

                entity.Property(e => e.CdFamilia).HasColumnName("CD_FAMILIA");

                entity.Property(e => e.CdMarca).HasColumnName("CD_MARCA");

                entity.Property(e => e.CdMaterial).HasColumnName("CD_MATERIAL");

                entity.Property(e => e.CdPregunta).HasColumnName("CD_PREGUNTA");

                entity.Property(e => e.CdPromocion).HasColumnName("CD_PROMOCION");

                entity.Property(e => e.CdReferencia).HasColumnName("CD_REFERENCIA");

                entity.Property(e => e.CdSector).HasColumnName("CD_SECTOR");

                entity.Property(e => e.CdSegmento).HasColumnName("CD_SEGMENTO");

                entity.Property(e => e.CdSubcategoria).HasColumnName("CD_SUBCATEGORIA");

                entity.Property(e => e.CdSubsegmento).HasColumnName("CD_SUBSEGMENTO");

                entity.Property(e => e.ItDwh).HasColumnName("IT_DWH");

                entity.Property(e => e.ItObjeto).HasColumnName("IT_OBJETO");

                entity.Property(e => e.ItSurtido).HasColumnName("IT_SURTIDO");

                entity.Property(e => e.RowguidVisita).HasColumnName("ROWGUID_VISITA");

                entity.HasOne(d => d.CdClusterNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdCluster)
                    .HasConstraintName("FK_META_C_CLUSTER_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdCuestionarioNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdCuestionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CUESTIONARIO_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdMaterialNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdMaterial)
                    .HasConstraintName("FK_META_MATERIAL_VISIBILIDAD_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdPreguntaNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdPregunta)
                    .HasConstraintName("FK_META_PREGUNTAS_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdPromocionNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdPromocion)
                    .HasConstraintName("FK_META_PROMOCION_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdReferenciaNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdReferencia)
                    .HasConstraintName("FK_META_REFERENCIA_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdSubcategoriaNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdSubcategoria)
                    .HasConstraintName("FK_META_C_SUBCATEGORIA_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdSubsegmentoNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.CdSubsegmento)
                    .HasConstraintName("FK_META_C_SUBSEGMENTO_META_VISITA_OBJETO");

                entity.HasOne(d => d.RowguidVisitaNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => d.RowguidVisita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_VISITA_META_VISITA_OBJETO");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => new { d.CdMarca, d.CdCliente })
                    .HasConstraintName("FK_META_MARCA_META_VISITA_OBJETO");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => new { d.CdCategoria, d.CdFamilia, d.CdSector })
                    .HasConstraintName("FK_META_C_CATEGORIA_META_VISITA_OBJETO");

                entity.HasOne(d => d.Cd1)
                    .WithMany(p => p.MetaVisitaObjeto)
                    .HasForeignKey(d => new { d.CdSegmento, d.CdCategoria, d.CdFamilia, d.CdSector })
                    .HasConstraintName("FK_META_C_SEGMENTO_META_VISITA_OBJETO");
            });

            modelBuilder.Entity<MetaVisitaVuelta>(entity =>
            {
                entity.HasKey(e => e.RowguidVisita)
                    .HasName("XPKMETA_VISITA_VUELTA");

                entity.ToTable("META_VISITA_VUELTA");

                entity.Property(e => e.RowguidVisita)
                    .HasColumnName("ROWGUID_VISITA")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItEstadoDwh).HasColumnName("IT_ESTADO_DWH");

                entity.Property(e => e.NmVuelta).HasColumnName("NM_VUELTA");

                entity.HasOne(d => d.RowguidVisitaNavigation)
                    .WithOne(p => p.MetaVisitaVuelta)
                    .HasForeignKey<MetaVisitaVuelta>(d => d.RowguidVisita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_VISITA_META_VISITA_VUELTA");
            });

            modelBuilder.Entity<MetaVistaCuboBi>(entity =>
            {
                entity.HasKey(e => e.CdVistaCubo)
                    .HasName("XPKMETA_VISTA_CUBO_BI");

                entity.ToTable("META_VISTA_CUBO_BI");

                entity.HasIndex(e => e.CdCubo)
                    .HasName("XIF1META_VISTA_CUBO_BI");

                entity.Property(e => e.CdVistaCubo)
                    .HasColumnName("CD_VISTA_CUBO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCubo).HasColumnName("CD_CUBO");

                entity.Property(e => e.DsConfiguracion)
                    .HasColumnName("DS_CONFIGURACION")
                    .HasColumnType("text");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItDefecto)
                    .HasColumnName("IT_DEFECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CdCuboNavigation)
                    .WithMany(p => p.MetaVistaCuboBi)
                    .HasForeignKey(d => d.CdCubo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_CUBO_BI_META_VISTA_CUBO_BI");
            });

            modelBuilder.Entity<MetaVistaInforme>(entity =>
            {
                entity.HasKey(e => e.CdVistaInforme)
                    .HasName("XPKMETA_VISTA_INFORME");

                entity.ToTable("META_VISTA_INFORME");

                entity.HasIndex(e => e.CdInforme)
                    .HasName("XIF1META_VISTA_INFORME");

                entity.HasIndex(e => e.UserName)
                    .HasName("XIF2META_VISTA_INFORME");

                entity.Property(e => e.CdVistaInforme)
                    .HasColumnName("CD_VISTA_INFORME")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdInforme).HasColumnName("CD_INFORME");

                entity.Property(e => e.DsConfiguracion)
                    .HasColumnName("DS_CONFIGURACION")
                    .HasColumnType("text");

                entity.Property(e => e.DsDescripcion)
                    .HasColumnName("DS_DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItDefecto)
                    .HasColumnName("IT_DEFECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CdInformeNavigation)
                    .WithMany(p => p.MetaVistaInforme)
                    .HasForeignKey(d => d.CdInforme)
                    .HasConstraintName("FK_META_INFORME_META_VISTA_INFORME");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.MetaVistaInforme)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_ASPNET_USERS_META_VISTA_INFORME");
            });

            modelBuilder.Entity<MetaZonaEmpleado>(entity =>
            {
                entity.HasKey(e => e.CdZonaEmpleado)
                    .HasName("XPKMETA_ZONA_EMPLEADO");

                entity.ToTable("META_ZONA_EMPLEADO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_ZONA_EMPLEADO")
                    .IsUnique();

                entity.Property(e => e.CdZonaEmpleado)
                    .HasColumnName("CD_ZONA_EMPLEADO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsZonaEmpleado)
                    .HasColumnName("DS_ZONA_EMPLEADO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<MetaZonaMunicipios>(entity =>
            {
                entity.HasKey(e => new { e.CdZona, e.CdProv, e.CdMuni })
                    .HasName("XPKMETA_ZONA_MUNICIPIOS");

                entity.ToTable("META_ZONA_MUNICIPIOS");

                entity.HasIndex(e => e.CdZona)
                    .HasName("XIF1META_ZONA_MUNICIPIOS");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("XAK1META_ZONA_MUNICIPIOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.CdProv, e.CdMuni })
                    .HasName("XIF2META_ZONA_MUNICIPIOS");

                entity.HasIndex(e => new { e.CdZona, e.CdMuni })
                    .HasName("IE1_META_ZONA_MUNICIPIOS");

                entity.Property(e => e.CdZona).HasColumnName("CD_ZONA");

                entity.Property(e => e.CdProv)
                    .HasColumnName("CD_PROV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CdMuni)
                    .HasColumnName("CD_MUNI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("ROWGUID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.CdZonaNavigation)
                    .WithMany(p => p.MetaZonaMunicipios)
                    .HasForeignKey(d => d.CdZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_ZONA_META_ZONA_MUNICIPIOS");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MetaZonaMunicipios)
                    .HasForeignKey(d => new { d.CdProv, d.CdMuni })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_META_C_MUNICIPIO_META_ZONA_MUNICIPIOS");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PromocionCdm>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("promocionCDM");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Respuesta).HasColumnName("RESPUESTA");
            });

            modelBuilder.Entity<PromocionCdmg1>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("PromocionCDMG1");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Promocion)
                    .HasColumnName("PROMOCION")
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Respuesta).HasColumnName("RESPUESTA");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PromocionCdmg1fechas>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("promocionCDMG1Fechas");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Cumple).HasColumnName("%CUMPLE");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(150);

                entity.Property(e => e.Promocion)
                    .HasColumnName("PROMOCION")
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Respuesta).HasColumnName("RESPUESTA");

                entity.Property(e => e.Tienda).HasColumnName("TIENDA");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PromocionCdmg2>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("promocionCDMG2");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Cumple).HasColumnName("%CUMPLE");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(150);

                entity.Property(e => e.Promocion)
                    .HasColumnName("PROMOCION")
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Respuesta).HasColumnName("RESPUESTA");

                entity.Property(e => e.Tienda).HasColumnName("TIENDA");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<SurtidoCdm>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("surtidoCDM");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("NonClusteredIndex-20190824-040400");

                entity.HasIndex(e => e.CdUsuario)
                    .HasName("NonClusteredIndex-20190824-040411");

                entity.HasIndex(e => e.Mes)
                    .HasName("NonClusteredIndex-20190824-040345");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Distribucion).HasColumnName("DISTRIBUCION");

                entity.Property(e => e.Distribucion1).HasColumnName("%DISTRIBUCION");

                entity.Property(e => e.Fuerastock).HasColumnName("%FUERASTOCK");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Oos).HasColumnName("OOS");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Potencial).HasColumnName("POTENCIAL");
            });

            modelBuilder.Entity<SurtidoCdmg2>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("SurtidoCDMG2");

                entity.HasIndex(e => e.Cadena)
                    .HasName("IX_SurtidoCDMG2_2");

                entity.HasIndex(e => e.Canal)
                    .HasName("IX_SurtidoCDMG2_1");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("IX_SurtidoCDMG2_7");

                entity.HasIndex(e => e.CdUsuario)
                    .HasName("IX_SurtidoCDMG2_8");

                entity.HasIndex(e => e.Ensena)
                    .HasName("IX_SurtidoCDMG2_3");

                entity.HasIndex(e => e.Marca)
                    .HasName("IX_SurtidoCDMG2_5");

                entity.HasIndex(e => e.Provincia)
                    .HasName("IX_SurtidoCDMG2_4");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("IX_SurtidoCDMG2");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.Categoria)
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdUsuario).HasColumnName("CD_USUARIO");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Distribucion).HasColumnName("DISTRIBUCION");

                entity.Property(e => e.Distribucion1).HasColumnName("%DISTRIBUCION");

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("date");

                entity.Property(e => e.Fuerastock).HasColumnName("%FUERASTOCK");

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .HasMaxLength(150);

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Oos).HasColumnName("OOS");

                entity.Property(e => e.Pdv).HasColumnName("PDV");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(150);

                entity.Property(e => e.Potencial).HasColumnName("POTENCIAL");

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Referencia)
                    .HasColumnName("REFERENCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Segmento)
                    .HasColumnName("SEGMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.Tienda).HasColumnName("TIENDA");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VisitaCdmg2>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("visitaCDMG2");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(150);

                entity.Property(e => e.CdCliente).HasColumnName("CD_CLIENTE");

                entity.Property(e => e.CdEstado).HasColumnName("cd_estado");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Ensena)
                    .HasColumnName("ENSENA")
                    .HasMaxLength(150);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItEstado)
                    .HasColumnName("it_estado")
                    .HasMaxLength(50);

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Realizada).HasColumnName("realizada");

                entity.Property(e => e.Tienda).HasColumnName("TIENDA");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(150);
            });
        }
    }
}
