using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Cluster.DTO;
using ApiGalileo.Features.Cluster.Services;
using Business.Interfaces;
using Business.Model.Cluster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiGalileo.Features.Cluster.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/Cluster")]
    [ApiController]
    public class ClusterController : Controller
    {

        // private readonly IClusterService _clusterService;
        private readonly ICluster _srvCluster;
        private readonly ILog _log;
        private readonly ILogTransaction _srvLogTransaction;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvCluster"></param>
        /// <param name="log"></param>
        /// <param name="srvLogTransaction"></param>
        public ClusterController(ICluster srvCluster
            , ILog log
            , ILogTransaction srvLogTransaction)
        {
            _srvCluster = srvCluster;
            _log = log;
            _srvLogTransaction = srvLogTransaction;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerOperation(Summary = "Asignar Tienda", Description = "Asignación de tiendas", OperationId = "AsignarConfigTienda")]
        public async Task<IActionResult> AsignarConfigTienda([FromBody]AsignarConfigTienda_Dto request)
        {
            try {
                var _response = await _srvCluster.AsignarConfiguracionTienda(new AsignarConfTiendaModel() { 
                    cadena = request.cadena,
                    canal = request.canal,
                    categoria = request.categoria,
                    cluster  = request.cluster,
                    ensena = request.ensena,
                    familia = request.familia,
                    poblacion = request.poblacion,
                    provincia = request.provincia,
                    sector = request.sector,
                    segmento = request.segmento,
                    RequestHttp = "api/Cluster:" + JsonConvert.SerializeObject(request)
                });

                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                return new OkObjectResult(_response);
            }
            catch(Business.Logs.CError ce) {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }


           //var result = Newtonsoft.Json.JsonConvert.SerializeObject(request);
           // _log.Information("Add Cluster " + result);
           // var _response = await _clusterService.AsignarConfiguracionTienda(request);
            
           // if (_response.bOK)
           //     return Ok(new ApiOkResponse(_response));
           // else
           //     return NotFound(new ApiResponse(404, $"No se ha podido realizar la operacion"));
        }
       
    }
}