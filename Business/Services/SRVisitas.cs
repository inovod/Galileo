using Business.Interfaces;
using Business.Logs;
using Business.Model.common;
using Business.Model.Visita;
using Business.Model.Visita.filters;
using Domain.Metafase.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Newtonsoft.Json;
using Repository.Identity.interfaces;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SRVisitas : SRBase, IVisita 
    {
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private IIdentityUnitOfWork _identityUnitOfWork;
        private readonly IMetafaseUnitOfWork _metafaseUnitOfWork;
        public SRVisitas(IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor ,
            IIdentityUnitOfWork identityUnitOfWork,
            IMetafaseUnitOfWork metafaseUnitOfWork) : base(identityUnitOfWork)
        {
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _identityUnitOfWork = identityUnitOfWork;
            _metafaseUnitOfWork = metafaseUnitOfWork;
        }

        public async Task<ValidationModel> Get(VisitaFilterModel filter)
        {

            try {
                await InitOperation(Enums.OperationEnum.GetVisita, filter.RequestHttp);
                #region Validation
                #endregion
                var filterDto = ParseVisitaFilter(filter);
                var _collection = _metafaseStoreProcedureRepor.Pr2r0NewVisitas(filterDto).Result.Select(x => ParseVisitaModel(x)).ToAsyncEnumerable();
                VisitaColectionModel _response = new VisitaColectionModel() { ItemCollection = new List<ItemVisitaModel>() };
                _response.ItemCollection = await _collection.ToList();
                return _response;
            }
            catch(CError ce)
            {
                throw AddError(IdTransaction,Errores._10018_SRVisitas_Get, 10018, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filter));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10018_SRVisitas_Get, 10018, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filter));
            }
        }

        public async Task<ValidationModel> GetVisitasRespuesta(VisitaFilterRespuestas filter)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetRespuestasVisita, filter.RequestHttp);
                #region Validation
                #endregion
                var filterDto = ParseVisitaFilter(filter);
                var _collection = _metafaseStoreProcedureRepor.Pr2r0NewVisitaSelByTipo(filterDto).Result.Select(x => ParseVisitaModel(x)).ToAsyncEnumerable();
                VisitaRespuestasColectionModel _response = new VisitaRespuestasColectionModel() { ItemCollection = new List<ItemVisitaRespuesta>() };
                _response.ItemCollection = await _collection.ToList();
                return _response;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction, Errores._10067_SRVisita_GetVisitasRespuesta, 10067, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filter));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10018_SRVisitas_Get, 10018, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filter));
            }
        }

        public async Task<ValidationModel> SetVisitaRespuesta(RespuestaSetModel dto)
        {
            try {
                await InitOperation(Enums.OperationEnum.SetVisita, dto.RequestHttp);
                #region Validation
                #endregion
                Guid _uidRowin = Guid.Parse(dto.Respuesta.uiRespuestaCuestionario);
                MetaRespuestasCuestionario custionarioDto =  await _metafaseUnitOfWork.RespuestaCuestionarioRepository.GetAsync(_uidRowin);
                if(custionarioDto != null)
                {
                    custionarioDto.DsRespuesta = dto.ValueRespuesta;
                }
                await _metafaseUnitOfWork.RespuestaCuestionarioRepository.UpdateAsync(custionarioDto);
                RespuestaModel respuestaModelo = new RespuestaModel();
                respuestaModelo.uidVisita = _uidRowin;
                respuestaModelo.ValueRespuesta = dto.ValueRespuesta;
                return respuestaModelo;
            }
            catch (CError ce) {
                throw AddError(IdTransaction, Errores._10068_SRVisita_SetVisitaRespuesta, 10068, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10018_SRVisitas_Get, 10018, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
        }

        public async Task<ValidationModel> AddVisitaRespuesta(RespuestaSetModel dto)
        {
            try
            {
                await InitOperation(Enums.OperationEnum.AddVisita, dto.RequestHttp);
                #region Validation
                #endregion
                MetaRespuestasCuestionario addCuestionatioDto = new MetaRespuestasCuestionario() {
                    CdPreguntaCuestionario = int.Parse(dto.Respuesta.cdPreguntaCuestionario),
                    CdCuestionario = int.Parse(dto.Respuesta.cdCuestionario),
                    CdTienda = dto.Respuesta.cdTienda,
                    DsRespuesta = dto.Respuesta.respuesta,
                    ItSurtido = dto.Respuesta.surtido == "1" ? true : false,
                    UserName = "METAFASE0\administrador",
                    RowguidVisita = dto.Respuesta.rowGuidVisita,
                    FcFecha = DateTime.Parse(dto.Respuesta.fcVisita),
                };
                await _metafaseUnitOfWork.RespuestaCuestionarioRepository.InsertEntity(addCuestionatioDto);
                await _metafaseUnitOfWork.RespuestaCuestionarioRepository.SaverChangeAsyc();
                RespuestaModel respuestaModelo = new RespuestaModel();
                respuestaModelo.uidVisita = dto.Respuesta.rowGuidVisita;
                respuestaModelo.ValueRespuesta = dto.ValueRespuesta;
                return respuestaModelo;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction, Errores._10068_SRVisita_SetVisitaRespuesta, 10068, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10018_SRVisitas_Get, 10018, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
        }
     

        #region Private Function
        private VistasFilterRepository_Dto ParseVisitaFilter(VisitaFilterModel dto)
        {
            try
            {
                VistasFilterRepository_Dto _filterDto = new VistasFilterRepository_Dto();
                _filterDto.cdcadena = dto.cdcadena;
                _filterDto.cdcliente = dto.cdcliente;
                _filterDto.cdensena = dto.cdensena;
                _filterDto.cdtienda = dto.cdtienda;
                _filterDto.cdvendedor = dto.cdvendedor;
                _filterDto.fechafin = string.IsNullOrEmpty(dto.fechafin) ? DateTime.MinValue : DateTime.Parse(dto.fechafin);
                _filterDto.fechainicio = string.IsNullOrEmpty(dto.fechainicio) ? DateTime.MinValue : DateTime.Parse(dto.fechainicio);
                return _filterDto;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction,Errores._10019_SRVisitas_Mapper_Get, 10019, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
            catch (System.Exception e)
            {
                throw AddError(IdTransaction,Errores._10019_SRVisitas_Mapper_Get, 10019, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
        }

        private VisitaFiltroByTipoRepository_Dto ParseVisitaFilter(VisitaFilterRespuestas dto)
        {
            try
            {
                VisitaFiltroByTipoRepository_Dto _filterDto = new VisitaFiltroByTipoRepository_Dto();
                _filterDto.Visita = !string.IsNullOrEmpty(dto.Visita) ? Guid.Parse(dto.Visita) : Guid.Empty;
                _filterDto.IdTipo = dto.IdTipo;
                _filterDto.Cadena = dto.Cadena;
                _filterDto.Surtido = dto.Surtido;
                return _filterDto;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction, Errores._10019_SRVisitas_Mapper_Get, 10019, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
            catch (System.Exception e)
            {
                throw AddError(IdTransaction, Errores._10019_SRVisitas_Mapper_Get, 10019, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
        }

        private ItemVisitaModel ParseVisitaModel(VisitaRepository_Dto dto)
        {
            try {
                ItemVisitaModel response = new ItemVisitaModel();
                response.cadena = dto.cadena;
                response.canal = dto.canal;
                response.ciudad = dto.ciudad;
                response.codigodetienda = dto.codigodetienda;
                response.direccion = dto.direccion;
                response.clienteDs = dto.DS_cliente;
                response.ensena = dto.ensena;
                response.fechaVisita = dto.Fecha_Visita;
                response.fechaPlanificada = dto.Fecha_Planificada;
                response.horaInicio = dto.Hora_Inicio;
                response.horaFin = dto.Hora_Fin;
                response.provincia = dto.provincia;
                response.vendedor = dto.vendedor;
                response.visita = dto.visita;
                return response;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction,Errores._10020_SRVisitas_Mapper_Get_Retorno, 10020, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));

            }
            catch(System.Exception ex) {
                throw AddError(IdTransaction,Errores._10020_SRVisitas_Mapper_Get_Retorno, 10020, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
        }

        private ItemVisitaRespuesta ParseVisitaModel(VisitaRespuestaRepository_Dto dto)
        {
            try
            {
                ItemVisitaRespuesta response = new ItemVisitaRespuesta();
                response.cdCuestionario = dto.CD_CUESTIONARIO;
                response.cdPregunta = dto.CD_PREGUNTA;
                response.cdPreguntaCuestionario = dto.CD_PREGUNTA_CUESTIONARIO;
                response.cdReferencia = dto.CD_REFERENCIA;
                response.Pregunta = dto.DS_PREGUNTA;
                response.Referencia = dto.DS_REFERENCIA;
                response.Surtido = dto.SURTIDO;
                response.uiRespuestaCuestionario = dto.ROWGUID;
                response.Respuesta = dto.DS_RESPUESTA;
                response.cdTienda = dto.CD_TIENDA;
                response.fcVisita = dto.FC_VISITA;
                return response;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction, Errores._10020_SRVisitas_Mapper_Get_Retorno, 10020, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));

            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10020_SRVisitas_Mapper_Get_Retorno, 10020, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(dto));
            }
        }
        #endregion
    }

    
}
