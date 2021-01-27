using Business.Interfaces;
using Business.Logs;
using Business.Model.common;
using Business.Model.Surtido;
using Newtonsoft.Json;
using Repository.Identity.interfaces;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SRSurtido : SRBase , ISurtido
    {
        private readonly IIdentityUnitOfWork _identityUnitOfWork;
        private readonly IMetafaseUnitOfWork _metafaseUnitOfWork;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private MapperSurtido _mpSurtidos;
        public SRSurtido(IIdentityUnitOfWork identityUnitOfWork , 
            IMetafaseUnitOfWork metafaseUnitOfWork ,
            IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor) : base(identityUnitOfWork)
        {
            _identityUnitOfWork = identityUnitOfWork;
            _metafaseUnitOfWork = metafaseUnitOfWork;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _mpSurtidos = new MapperSurtido();
        }

        public async Task<ValidationModel> GetSurtido(SurtidoFilterModel surtidoModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetSurtido, surtidoModel.RequestHttp);
                #region Validation
                #endregion
                SurtidoFiltroRepository_Dto filtro = _mpSurtidos.Parse(surtidoModel);
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewSurtido(filtro).Result.Select(x => _mpSurtidos.Parse(x)).ToAsyncEnumerable();
                SurtidoCollectionModel _response = new SurtidoCollectionModel() { ItemCollection = new List<ItemSurtidoModel>() };
                _response.ItemCollection = await _colection.ToList();
                return _response;
            }
            catch (CError ce) {
                throw AddError(IdTransaction, Errores._10062_SRSurtido_GetSurtido, 10062, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(surtidoModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10061_SRSurtido_Generico, 10061, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(surtidoModel));
            }
        }

        public async Task<ValidationModel> DuplicarSurtidos(DuplicarSurtidoModel duplicarModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.DuplicarSurtido, duplicarModel.RequestHttp);
                #region Validation
                #endregion
                DuplicarSurtidoRepository_Dto itemDuplicados = _mpSurtidos.Parse(duplicarModel);
                var respuesta = await _metafaseStoreProcedureRepor.Pr2rDuplicarSurtidos(itemDuplicados);
                ResponseProcedureModel _response = new ResponseProcedureModel();
                _response.retorno = respuesta;
                return _response;

            }
            catch (CError ce) {
                throw AddError(IdTransaction, Errores._10063_SRSurtido_DuplicarSurtidos, 10063, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(duplicarModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10061_SRSurtido_Generico, 10061, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(duplicarModel));
            }
        }

        public async Task<ValidationModel> BajaSurtidos(SurtidoBorrarModel borrarModel)
        {
            try {
                SurtidoItemBorrarRespository_Dto itemborrado = _mpSurtidos.Parse(borrarModel);
                var respuesta = await _metafaseStoreProcedureRepor.BajaSurtidos(itemborrado);
                ResponseProcedureModel _response = new ResponseProcedureModel();
                _response.retorno = respuesta;
                return _response;

            }
            catch(CError ce) {
                throw AddError(IdTransaction, Errores._10064_SRSurtido_BajaSurtido, 10064, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(borrarModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10061_SRSurtido_Generico, 10061, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(borrarModel));
            }
        }

        public async Task<ValidationModel> SurtidoMaxivo(SurtidoMaximoModel modelo)
        {
            try {
                SurtidoMaxivoRespuestaModel _response = new SurtidoMaxivoRespuestaModel();
                List<SurtidoItemMaximoModel> colectionSurtidos = new List<SurtidoItemMaximoModel>();

                var rootFolder = @"C:\Files";
                var fileName = modelo.file.FileName;
                var filePath = Path.Combine(rootFolder, fileName);
                var fileLocation = new FileInfo(filePath);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await modelo.file.CopyToAsync(fileStream);
                }
                if(modelo.file.Length <= 0)
                {
                    _response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10065", new[] { Errores._10065_SRSurtido_Longitud_Fichero }), (int)HttpStatusCode.BadRequest, IdTransaction));
                }
                _response.respuesta = "Ok";
                return _response;
            }
            catch(CError ce) {
                // 10066_SRSurtido_SurtidoMaxivo
                throw AddError(IdTransaction, Errores._10066_SRSurtido_SurtidoMaxivo, 10066, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(modelo));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10061_SRSurtido_Generico, 10061, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(modelo));
            }
        }
    }
    public class MapperSurtido
    {
        public DuplicarSurtidoRepository_Dto Parse(DuplicarSurtidoModel source)
        {
            DuplicarSurtidoRepository_Dto response = new DuplicarSurtidoRepository_Dto();
            response.ID_SURTIDO = source.idsurtido;
            response.ID_CLIENTE = source.cliente;
            foreach (var item in source.ensena)
                response.ENSENA += item.ToString() + "@";

            return response;
        }

        public ItemSurtidoModel Parse(SurtidoRepository_Dto source)
        {
            return new ItemSurtidoModel()
            {
                idSurtido = source.CD_SURTIDO,
                Cliente = source.DS_CLIENTE,
                idCliente = source.CD_CLIENTE,
                Cadena = source.DS_CADENA,
                Ensena = source.DS_ENSENA,
                FechaAlta = source.FC_ALTA.ToShortDateString(),
                FechaBaja = source.FC_BAJA == DateTime.MinValue ? "" : source.FC_BAJA.ToShortDateString(),
                Publicado = source.IT_PUBLICADO,
                NumeroReferencias = source.NM_REFERENCIAS
            };
        }

        public SurtidoFiltroRepository_Dto Parse(SurtidoFilterModel source)
        {
            SurtidoFiltroRepository_Dto retorno = new SurtidoFiltroRepository_Dto();
            retorno.CD_Cliente = int.Parse(source.cliente);
            retorno.Candena = int.Parse(source.cadena);
            retorno.FechaDesde = source.fechaDesde;
            retorno.FechaHasta = source.fechaHasta;
            foreach (var item in source.ensena)
                retorno.Ensena += item.ToString() + "@";

            return retorno;
        }

        public SurtidoItemBorrarRespository_Dto Parse(SurtidoBorrarModel source)
        {
            SurtidoItemBorrarRespository_Dto response = new SurtidoItemBorrarRespository_Dto();
            foreach (var item in source.surtidos)
                response.idsurtidos += item.ToString() + '@';
            response.fechaBaja = DateTime.Parse(source.fechaBaja);
            return response;
        }
    }
}
