using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiGalileo.Features.Visitas.Services;
using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using Business.Interfaces;
using Business.Model.Visita.filters;
using Newtonsoft.Json;
using Business.Model.Visita;
using Swashbuckle.AspNetCore.Annotations;
using Remotion.Linq.Utilities;
using ApiGalileo.Features.Visitas.DTO;

namespace ApiGalileo.Features.Visitas.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/Visita")]
    [ApiController]
    public class VisitaController : ControllerBase
    {
        // private readonly IVisitasService _visitaService;
        private readonly IVisita _srvVisita;
        private readonly ILogTransaction _srvLogTransaction;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvVisita"></param>
        /// <param name="srvLogTransaction"></param>
        public VisitaController(IVisita srvVisita,
             ILogTransaction srvLogTransaction)
        {
            _srvVisita = srvVisita;
            _srvLogTransaction = srvLogTransaction;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idcliente"></param>
        /// <param name="idvendedor"></param>
        /// <param name="idtienda"></param>
        /// <param name="fechadesde"></param>
        /// <param name="fechahasta"></param>
        /// <param name="surtido"></param>
        /// <param name="tipoRespuesta"></param>
        /// <returns></returns>
        [HttpGet("GetVisitas")]
        [SwaggerOperation(Summary = "Dame Visitas", Description = "Dame Visitas", OperationId = "GetVisitas")]
        public async Task<IActionResult> GetVisitas(int idcliente , int idvendedor , int idtienda ,string fechadesde , string fechahasta,bool surtido , int tipoRespuesta)
        {
            try {

                string _fdesde = string.IsNullOrEmpty(fechadesde) ? string.Empty : fechadesde;
                string _fhasta = string.IsNullOrEmpty(fechahasta) ? string.Empty : fechahasta;

                var _response = await _srvVisita.Get(new VisitaFilterModel()
                {
                    cdcliente = idcliente,
                    cdvendedor = idvendedor,
                    fechainicio = _fdesde,
                    fechafin = _fhasta,
                    cdtienda = idtienda,
                    surtido = surtido,
                    tipoRespuesta = tipoRespuesta,
                    RequestHttp = "Visita/GetVisitas:idcliente" + idcliente.ToString() + "&idvendedor:" + idvendedor.ToString() + "&fdesde:" + _fdesde + "&fhasta:" + _fhasta + "&Surtido:" + surtido.ToString() + "&tipoRespuesta:" + tipoRespuesta
                });
                VisitaColectionModel _retorno = _response as VisitaColectionModel;
                return new OkObjectResult(_retorno);
            }
            catch(Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visita"></param>
        /// <param name="idtipo"></param>
        /// <param name="cadena"></param>
        /// <param name="surtido"></param>
        /// <returns></returns>
        [HttpGet("GetVisitasRespuestas")]
        [SwaggerOperation(Summary = "Dame Visitas", Description = "Dame Visitas", OperationId = "GetVisitas")]
        public async Task<IActionResult> GetVisitasRespuestas(string visita, int idtipo, string cadena, string surtido)
        {
            try
            {
                var _response = await _srvVisita.GetVisitasRespuesta(new VisitaFilterRespuestas()
                {
                    Visita = visita,
                    Cadena = cadena,
                    IdTipo = idtipo,
                    Surtido = surtido == "1" ? true : false,
                    RequestHttp = "Visita/GetVisitasRespuestas:visita" + visita + "&idtipo:" + idtipo.ToString() + "&cadena" + cadena + "&surtido" + surtido

                });
                VisitaRespuestasColectionModel _retorno = _response as VisitaRespuestasColectionModel;
                return new OkObjectResult(_retorno);
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
        }

        /// <summary>
        /// Modificar la respuesta
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("SetVisitasRespuestas")]
        [SwaggerOperation(Summary = "Modificar la respuesta", Description = "modifica la respuesta", OperationId = "SetVisitasRespuestas")]
        public async Task<IActionResult> SetVisitaRespuesta(RespuestaSetRequest request)
        {
            try {
                Guid _rowid = Guid.Parse(request.Respuesta.uiRespuestaCuestionario);
                if(_rowid == Guid.Empty) {
                    var _response =  await  _srvVisita.AddVisitaRespuesta(new RespuestaSetModel()
                    {
                        RequestHttp = "Visita/SetVisitaRespuesta" + JsonConvert.SerializeObject(request),
                        Respuesta = new ItemRespuestaModel() { 
                            cdPreguntaCuestionario = request.Respuesta.cdPreguntaCuestionario,
                            cdCuestionario = request.Respuesta.cdCuestionario,
                            cdPregunta = request.Respuesta.cdPregunta,
                            cdReferencia = request.Respuesta.cdReferencia,
                            pregunta = request.Respuesta.pregunta,
                            referencia = request.Respuesta.referencia,
                            respuesta = request.ValueName,
                            surtido = request.Respuesta.surtido,
                            rowGuidVisita = Guid.Parse(request.rowGuidVisita),
                            cdTienda = request.Respuesta.cdTienda,
                            fcVisita = request.Respuesta.fcVisita
                        } ,
                        ValueRespuesta = request.ValueName
                    });
                    return new OkObjectResult(_response);
                }
                else
                {

                    var _response = await _srvVisita.SetVisitaRespuesta(new RespuestaSetModel()
                    {
                        RequestHttp = "Visita/SetVisitaRespuesta" + JsonConvert.SerializeObject(request),
                        ///uiRespuesta = request.Respuesta.uiRespuestaCuestionario,ç
                        Respuesta = new ItemRespuestaModel()
                        {
                            uiRespuestaCuestionario = request.Respuesta.uiRespuestaCuestionario,
                        },
                        ValueRespuesta = request.ValueName
                    });
                    return new OkObjectResult(_response);
                }

                // return new OkObjectResult("OK");
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
        }
    }
}