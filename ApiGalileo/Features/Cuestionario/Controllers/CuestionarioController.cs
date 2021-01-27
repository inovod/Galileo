using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Cuestionario.DTO;
using ApiGalileo.Features.Cuestionario.Services;
using Business.Interfaces;
using Business.Model.Cuestionario;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiGalileo.Features.Cuestionario.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/Cuestionario")]
    [ApiController]
    public class CuestionarioController : ControllerBase
    {
        // private readonly ICuestionarioService _cuestionarioService;
        private readonly ILog _log;
        private readonly ICuestionario _srvCuestionario;
        private readonly ILogTransaction _srvLogTransaction;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvCuestionario"></param>
        /// <param name="log"></param>
        /// <param name="srvLogTransaction"></param>
        public CuestionarioController(ICuestionario srvCuestionario,
            ILog log ,
            ILogTransaction srvLogTransaction)
        {
            _srvCuestionario = srvCuestionario;
            _log = log;
            _srvLogTransaction = srvLogTransaction;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fechaIni"></param>
        /// <param name="fechaFin"></param>
        /// <param name="cdCliente"></param>
        /// <returns></returns>
        [HttpGet("GetCuestionarios")]
        [SwaggerOperation(Summary = "Dar Cuestionario", Description = "Dar Cuestionario", OperationId = "GetCuestionarios")]
        public async Task<IActionResult> GetCuestionarios(string fechaIni, string fechaFin, int cdCliente)
        {
            try {
                var paramRequest = JsonConvert.SerializeObject("fechaIni:" + fechaIni + " fechaFin:" + fechaFin + " cdCliente:" + cdCliente.ToString());
                var _response = await _srvCuestionario.GetCuestionarios(new CuestionarioFilterModel() { 
                   cdcliente = cdCliente,
                   fechaHasta = fechaFin,
                   fechaInc = fechaIni,
                   RequestHttp = "Cuestionario/GetCuestionarios:"+ paramRequest
                });
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CuestionarioColectionModel _retorno = _response as CuestionarioColectionModel;
                return new OkObjectResult(_retorno.CuestionarioCollection);
            }
            catch(Business.Logs.CError ce) {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex) {
                throw ex;
            }
            //var _response = await _cuestionarioService.GetCuestionarios(fechaIni, fechaFin, cdCliente);
            //if (_response.Count == 0)
            //    return NotFound(new ApiResponse(404, $"Cuestionarios not found"));
            //return Ok(new ApiOkResponse(_response));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerOperation(Summary = "Borrar Cuestionario", Description = "Borrar Cuestionario", OperationId = "BorrarCuestionarios")]
        public async Task<IActionResult> BorrarCuestionarios([FromBody]BorrarCuestionarioRequest request)
        {
            try {
                var _response = await _srvCuestionario.BorrarCuestionario(new BorrarCuestionarioModel() { 
                    cuestionarios = request.cuestionarios,
                    fechaBaja = request.fechaBaja,
                    RequestHttp = "Cuestionario/BorrarCuestionarios:" + JsonConvert.SerializeObject(request)
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

            //var _response = await _cuestionarioService.BorrarCuestionario(request);
            //_log.Information("Borrado Cuestionario " + request);
            //if (_response.bOK)
            //    return Ok(new ApiOkResponse(_response));
            //else
            //    return NotFound(new ApiResponse(404, $"No se ha podido realizar la operacion"));
        }
    }
}