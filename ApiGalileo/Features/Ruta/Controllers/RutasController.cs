using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Ruta.DTO;
using ApiGalileo.Features.Ruta.Services;
using Business.Interfaces;
using Business.Model.Rutas;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiGalileo.Features.Ruta.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/rutas")]
    [ApiController]
    public class RutasController : ControllerBase
    {
        // private readonly IRutaService _rutaservice;
        private readonly IRutas _srvRuta;
        private readonly ILogTransaction _srvLogTransaction;
        private readonly ILog _log;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvRuta"></param>
        /// <param name="log"></param>
        /// <param name="srvLogTransaction"></param>
        public RutasController(IRutas srvRuta, 
            ILog log ,
            ILogTransaction srvLogTransaction)
        {
            _srvRuta = srvRuta;
            _log = log;
            _srvLogTransaction = srvLogTransaction;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idcliente"></param>
        /// <param name="idvendedor"></param>
        /// <param name="rutasbaja"></param>
        /// <returns></returns>
        [HttpGet("GetRutas")]
        [SwaggerOperation(Summary = "Dame Rutas", Description = "Dame Rutas", OperationId = "GetRutas")]
        public async Task<IActionResult> GetRutas(int idcliente , int idvendedor , bool rutasbaja)
        {
            try {
                var paramRequest = JsonConvert.SerializeObject("idcliente:" + idcliente + " idvendedor:" + idvendedor + " rutasbaja:" + rutasbaja);
                var _response = await _srvRuta.GetRutas(new RutasFilterModel() { 
                    idcliente = idcliente,
                    idvendedor = idvendedor,
                    rutasBaja = rutasbaja ,
                    RequestHttp = "rutas/GetRutas:" + paramRequest
                });
                RutasColectionModel rutasColectionModel = _response as RutasColectionModel;
                return new OkObjectResult(rutasColectionModel.RutasCollection);
            }
            catch(Business.Logs.CError ce){
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex){
                throw ex;
            }
            //var _response = await _rutaservice.GetRutas(idcliente,idvendedor,rutasbaja);
            //if (_response.Count == 0)
            //    return NotFound(new ApiResponse(404, $"Rutas not found"));
            //return Ok(new ApiOkResponse(_response));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DuplicarRutas")]
        [SwaggerOperation(Summary = "Duplicar Rutas", Description = "Duplicar Rutas", OperationId = "DuplicarRutas")]
        public async Task<IActionResult> DuplicarRutas([FromBody]DuplicarRutaRequest request)
        {
            try {
                var _response = await _srvRuta.DuplicarRutas(new DuplicarRutasColectionModel() { 
                    cliente = request.cliente,
                    rutas = request.rutas,
                    vendedor = request.vendedor,
                    RequestHttp = "rutas/DuplicarRutas:"+ JsonConvert.SerializeObject(request)
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
            //_log.Information("Duplicar Rutas " + result);
            //var _response = await _rutaservice.DuplicarRutas(request);
            //if (_response.bOK)
            //    return Ok(new ApiOkResponse(_response));
            //else
            //    return NotFound(new ApiResponse(404, $"No se ha podido realizar la operacion"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("UpdateDescription")]
        [SwaggerOperation(Summary = "Modificar Descripcion", Description = "Modificar Descripcion", OperationId = "Modificar Descripcion")]
        public async Task<IActionResult> UpdateDescription([FromBody]SetRutaRequest request)
        {
            try {
                var _response = await _srvRuta.ModificarRutas(new RutaModificaModel() { 
                    Descripcion = request.Descripcion,
                    IdRuta = request.IdRuta,
                    RequestHttp = "rutas/UpdateDescription:" + JsonConvert.SerializeObject(request)
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
            //_log.Information("Modificar Rutas " + result);
            //var _response = await _rutaservice.ModificarRutas(request);
            //if (_response.bOK)
            //    return Ok(new ApiOkResponse(_response));
            //else
            //    return NotFound(new ApiResponse(404, $"No se ha podido realizar la operacion"));
        }
    }
}