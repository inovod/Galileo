using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Surtido.DTO;
using ApiGalileo.Features.Surtido.Services;
using Business.Interfaces;
using Business.Model.Surtido;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
// using OfficeOpenXml;

namespace ApiGalileo.Features.Surtido.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/Surtidos")]
    [ApiController]
    public class SurtidosController : ControllerBase
    {
        //private readonly ISurtidoService _surtidoservice;
        private readonly ISurtido _srvSurtido;
        private readonly ILog _log;
        private readonly ILogTransaction _srvLogTransaction;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvSurtido"></param>
        /// <param name="log"></param>
        /// <param name="srvLogTransaction"></param>
        public SurtidosController(ISurtido srvSurtido, 
            ILog log , ILogTransaction srvLogTransaction)
        {
            _srvSurtido = srvSurtido;
            _srvLogTransaction = srvLogTransaction;
            _log = log;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("GetSurtidos")]
        [SwaggerOperation(Summary = "Dame Surtidos", Description = "Dame Surtidos", OperationId = "GetSurtidos")]
        public async Task<IActionResult> GetSurtidos([FromBody]ItemFilterSurtidoRequest request)
        {
            try {
                var _response = await _srvSurtido.GetSurtido(new SurtidoFilterModel() { 
                    cadena = request.cadena,
                    canal = request.canal,
                    cliente = request.cliente,
                    ensena = request.ensena,
                    fechaDesde = request.fechaDesde,
                    fechaHasta = request.fechaHasta,
                    RequestHttp = "Surtidos/GetSurtidos:"+ JsonConvert.SerializeObject(request)
                });
                SurtidoCollectionModel _retorno = _response as SurtidoCollectionModel;
                return new OkObjectResult(_retorno);
            }
            catch(Business.Logs.CError ce) {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }

           // var _response = await _surtidoservice.GetSurtido(request);
           //if (_response.Count == 0)
           //     return NotFound(new ApiResponse(404, $"Cuestionario not found"));
           // return Ok(new ApiOkResponse(_response));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DuplicarSurtidos")]
        [SwaggerOperation(Summary = "Duplica Surtidos", Description = "Duplica Surtidos", OperationId = "DuplicarSurtidos")]
        public async Task<IActionResult> DuplicarSurtidos([FromBody]DuplicarSurtidosRequest request)
        {
            try {
                var _response = await _srvSurtido.DuplicarSurtidos(new DuplicarSurtidoModel()
                {
                    cadena = request.cadena,
                    canal = request.canal,
                    cliente = request.cliente,
                    ensena = request.ensena,
                    idsurtido = request.idsurtido,
                    RequestHttp = "Surtidos/DuplicarSurtidos:" + JsonConvert.SerializeObject(request)
                });

                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }

                return new OkObjectResult(_response);

                // return new OkObjectResult("true");
            }
            catch(Business.Logs.CError ce) {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            //var _response = await _surtidoservice.DuplicarSurtidos(request);
            //_log.Information("Duplicar Surtidos " + _response);
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
        [HttpPost("BorrarSurtido")]
        [SwaggerOperation(Summary = "Borrar Surtido", Description = "Borrar Surtidos", OperationId = "BorrarSurtido")]
        public async Task<IActionResult> BorrarSurtido([FromBody]BorrarSurtidoRequest request)
        {
            try
            {
                var _response = await _srvSurtido.BajaSurtidos(new SurtidoBorrarModel() { 
                    fechaBaja = request.fechaBaja,
                    surtidos  = request.surtidos,
                    RequestHttp = "Surtidos/BorrarSurtido:" + JsonConvert.SerializeObject(request)

                });
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }

                return new OkObjectResult(_response);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }



            //var _response = await _surtidoservice.BajaSurtidos(request);
            //_log.Information("Borrado Surtido " + request);
            //if (_response.bOK)
            //    return Ok(new ApiOkResponse(_response));
            //else
            //    return NotFound(new ApiResponse(404, $"No se ha podido realizar la operacion"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost("SurtidoMaximo")]
        [SwaggerOperation(Summary = "Surtido Maximo", Description = "Surtido Maximo", OperationId = "Surtido Maximo")]
        public async Task<IActionResult> SurtidoMaxivo(IFormFile file)
        {
            try {
                var _response = await _srvSurtido.SurtidoMaxivo(new SurtidoMaximoModel() { 
                    file =  file,
                    RequestHttp = "Surtidos/SurtidoMaxivo"
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

            //List<ItemSurtidoMasivo> colectionSurtidos = new List<ItemSurtidoMasivo>();
            //var rootFolder = @"C:\Files";
            //var fileName = file.FileName;
            //var filePath = Path.Combine(rootFolder, fileName);
            //var fileLocation = new FileInfo(filePath);
            //using (var fileStream = new FileStream(filePath, FileMode.Create))
            //{
            //    await file.CopyToAsync(fileStream);
            //}
            //if (file.Length <= 0)
            //    return NotFound(new ApiResponse(404, $"Sutido Maximo not found"));

            //using (ExcelPackage package = new ExcelPackage(fileLocation))
            //{
            //    ExcelWorksheet workSheet = package.Workbook.Worksheets["Hoja1"];
            //    int totalRows = workSheet.Dimension.Rows;
            //    for (int i = 2; i <= totalRows; i++)
            //    {
            //        colectionSurtidos.Add(new ItemSurtidoMasivo() { 
            //            Cliente = workSheet.Cells[i, 1].Value.ToString(),
            //            Canal = workSheet.Cells[i, 2].Value.ToString(),
            //            Cadena = workSheet.Cells[i, 3].Value.ToString(),
            //            Ensena = workSheet.Cells[i, 4].Value.ToString(),
            //            Referencia = workSheet.Cells[i, 5].Value.ToString(),
            //            Cluster = workSheet.Cells[i, 6].Value.ToString(),
            //            FAlta = workSheet.Cells[i, 7].Value.ToString(),
            //            FBaja = workSheet.Cells[i, 8].Value.ToString()
            //        });
            //    }
            //}

            // return Ok(new ApiOkResponse("ok"));


            /* var _response = await _surtidoservice.GetSurtido(request);
             /// return Ok(new ApiOkResponse("ok"));
             /// 
             /// var _response = await _surtidoservice.GetSurtido(cdcliente, fechaIni, fechaFin, idcadena, ensena);
             if (_response.Count == 0)
                 return NotFound(new ApiResponse(404, $"Cuestionario not found"));
             return Ok(new ApiOkResponse(_response));*/
        }
    }
}