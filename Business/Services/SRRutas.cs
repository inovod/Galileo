using Business.Interfaces;
using Business.Logs;
using Business.Model.common;
using Business.Model.Rutas;
using Newtonsoft.Json;
using Repository.Identity.interfaces;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SRRutas : SRBase , IRutas
    {
        private readonly IIdentityUnitOfWork _indentityOfWork;
        private readonly IMetafaseUnitOfWork _metafaseUnitOfWork;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private MapperRutas _mpRutas;
        public SRRutas(IIdentityUnitOfWork indentityOfWork,
            IMetafaseUnitOfWork metafaseUnitOfWork,
            IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor) : base(indentityOfWork)
        {
            _indentityOfWork = indentityOfWork;
            _metafaseUnitOfWork = metafaseUnitOfWork;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _mpRutas = new MapperRutas();
        }

        public async Task<ValidationModel> GetRutas(RutasFilterModel filterModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetRutas, filterModel.RequestHttp);
                #region Validation
                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewRuta(filterModel.idcliente, filterModel.idvendedor, filterModel.rutasBaja).Result.Select(x => _mpRutas.Parse(x)).ToAsyncEnumerable();
                RutasColectionModel _response = new RutasColectionModel() { RutasCollection = new List<ItemRutaColection>() };
                _response.RutasCollection = await _colection.ToList();
                return _response;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction, Errores._10058_SRRutas_GetRutas, 10058, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filterModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10057_SRRutas_Generico, 10057, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filterModel));
            }
        }

        public async Task<ValidationModel> DuplicarRutas(DuplicarRutasColectionModel duplicarRutasModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.DuplicarRutas, duplicarRutasModel.RequestHttp);
                #region Validation
                #endregion
                var respuesta = await _metafaseStoreProcedureRepor.Pr2r0CrearRuta(_mpRutas.Parse(duplicarRutasModel));
                ResponseProcedureModel _response = new ResponseProcedureModel();
                _response.retorno = respuesta;
                return _response;
            }
            catch(CError ce)
            {
                throw AddError(IdTransaction, Errores._10059_SRRutas_DuplicarRutas, 10059, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(duplicarRutasModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10057_SRRutas_Generico, 10057, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(duplicarRutasModel));
            }
            //ResponseBase _response;
            //try
            //{
            //    DuplicarRutasRepository_Dto entity = _mprutas.Parse(request);
            //    var repuesta = await _metafaseStoreProcedureRepor.Pr2r0CrearRuta(entity);
            //    _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            //}
            //catch (System.Exception e)
            //{
            //    string error = "DuplicarRutas " + e.Message;
            //    _log.Error(error);
            //    _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            //}
            //return _response;
        }

        public async Task<ValidationModel> ModificarRutas(RutaModificaModel rutaModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.ModificarRutas, rutaModel.RequestHttp);
                var respuesta = await _metafaseStoreProcedureRepor.Pr2r0CambiarNombreRuta(_mpRutas.Parse(rutaModel));
                ResponseProcedureModel _response = new ResponseProcedureModel();
                _response.retorno = respuesta;
                return _response;
            }
            catch(CError ce) {
                throw AddError(IdTransaction, Errores._10060_SRRutas_ModificarRutas, 10060, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(rutaModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10057_SRRutas_Generico, 10057, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(rutaModel));
            }
            //ResponseBase _response;
            //try
            //{
            //    SetRutaRepository_Dto entity = _mprutas.Parse(request);
            //    var repuesta = await _metafaseStoreProcedureRepor.Pr2r0CambiarNombreRuta(entity);
            //    _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            //}
            //catch (System.Exception e)
            //{
            //    string error = "DuplicarRutas " + e.Message;
            //    _log.Error(error);
            //    _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            //}
            //return _response;
        }
    }
    public class MapperRutas
    {
        public ItemRutaColection Parse(RutaRepository_Dto source)
        {
            return new ItemRutaColection()
            {
                Ruta = source.DS_RUTA,
                Cliente = source.DS_CLIENTE,
                vendedor = source.ds_empleado,
                provincia = source.DS_PROV,
                idRuta = source.CD_RUTA,
                FechaAlta = source.FC_ALTA.ToShortDateString(),
                FechaBaja = source.FC_BAJA == DateTime.MinValue ? "" : source.FC_BAJA.ToShortDateString()
            };
        }

        public DuplicarRutasRepository_Dto Parse(DuplicarRutasColectionModel source)
        {
            DuplicarRutasRepository_Dto retorno = new DuplicarRutasRepository_Dto();
            retorno.CD_Cliente = source.cliente;
            retorno.CD_Vendedor = source.vendedor;
            foreach (var ruta in source.rutas)
                retorno.CD_Ruta += ruta.idRuta.ToString() + '@';
            return retorno;
        }

        public SetRutaRepository_Dto Parse(RutaModificaModel source)
        {
            SetRutaRepository_Dto retorno = new SetRutaRepository_Dto();
            retorno.IdRuta = source.IdRuta;
            retorno.Descripcion = source.Descripcion;

            return retorno;
        }
    }


}
