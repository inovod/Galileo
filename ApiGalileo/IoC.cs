using Microsoft.Extensions.DependencyInjection;
using ApiGalileo.Features.User.Services;
using Repository.Identity;
using Repository.Identity.interfaces;
using ApiGalileo.Features.oAuth.Services;
using ApiGalileo.Api.Log;
using Repository.Metafase.interfaces;
using Repository.Metafase;
using ApiGalileo.Features.Visitas.Services;
using Business.Interfaces;
using Business.Services;
using Business.Model.common;

namespace ApiGalileo
{
    /// <summary>
    /// 
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterSRServices(IServiceCollection services)
        {
            services.AddScoped<IIdentityUnitOfWork, IdentityUnitOfWork>();
            services.AddSingleton<ILog, GalileoLog>();
            services.AddScoped<IMetafaseUnitOfWork, MetafaseUnitOfWork>();
            services.AddScoped<IMetafaseStoreProcedureRepository, MetafaseStoreProcedureRepository>();
            
            // services.AddScoped<IoAuthServices, oAuthServices>();
            // services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IUserServices, UserServices>();
            //services.AddScoped<IRutaService, RutaServices>();
            //services.AddScoped<IRutaService, RutaServices>();
            //services.AddScoped<ICuestionarioService, CuestionarioServiceOld>();
/*            services.AddScoped<IClusterService, ClusterService>()*/;
            //services.AddScoped<ISurtidoService, SurtidoService>();
            // services.AddScoped<IVisitasService, VisitasServices>();

            /* Controles sobre Business */
            services.AddScoped<ILogTransaction, SRLogTransaction>();
            services.AddScoped<IOauth, SROauth>();
            services.AddScoped<IErrorManager, ErrorManager>();
            services.AddScoped<IMaster, SRMaster>();
            services.AddScoped<ICluster, SRCluster>();
            services.AddScoped<ICuestionario, SRCuestionario>();
            services.AddScoped<IRutas, SRRutas>();
            services.AddScoped<ISurtido, SRSurtido>();
            services.AddScoped<IVisita, SRVisitas>();
        }
    }
}
