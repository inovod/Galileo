using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Ruta.DTO;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Ruta.Services
{
    public class RutaServices : IRutaService
    {
        private readonly IMetafaseUnitOfWork _metafaseUnitOfWork;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private readonly ILog _log;
        private MapperRutas _mprutas;
        public RutaServices(IMetafaseUnitOfWork metafaseUnitOfWork,
            IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor,
            ILog log)
        {
            _metafaseUnitOfWork = metafaseUnitOfWork;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _log = log;
            _mprutas = new MapperRutas();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idcliente"></param>
        /// <param name="idvendedor"></param>
        /// <param name="rutasbaja"></param>
        /// <returns></returns>
        public async Task<List<ItemRutaResponse>> GetRutas(int idcliente, int idvendedor, bool rutasbaja)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewRuta(idcliente, idvendedor, rutasbaja).Result.Select(x => _mprutas.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ResponseBase> DuplicarRutas(DuplicarRutaRequest request) {
            ResponseBase _response;
            try
            {
                DuplicarRutasRepository_Dto entity = _mprutas.Parse(request);
                var repuesta = await _metafaseStoreProcedureRepor.Pr2r0CrearRuta(entity);
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion" , bOK = true};
            }
            catch(System.Exception e)
            {
                string error = "DuplicarRutas " + e.Message;
                _log.Error(error);
                _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            }
            return _response;
        }

        public async Task<ResponseBase> ModificarRutas(SetRutaRequest request)
        {
            ResponseBase _response;
            try
            {
                SetRutaRepository_Dto entity = _mprutas.Parse(request);
                var repuesta = await _metafaseStoreProcedureRepor.Pr2r0CambiarNombreRuta(entity);
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            }
            catch (System.Exception e)
            {
                string error = "DuplicarRutas " + e.Message;
                _log.Error(error);
                _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            }
            return _response;
        }

    }

    public class MapperRutas
    {
        public ItemRutaResponse Parse(RutaRepository_Dto source)
        {
            return new ItemRutaResponse()
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

        public DuplicarRutasRepository_Dto Parse(DuplicarRutaRequest source)
        {
            DuplicarRutasRepository_Dto retorno = new DuplicarRutasRepository_Dto();
            retorno.CD_Cliente = source.cliente;
            retorno.CD_Vendedor = source.vendedor;
            foreach (var ruta in source.rutas)
                retorno.CD_Ruta += ruta.idRuta.ToString() + '@';
            return retorno;
        }

        public SetRutaRepository_Dto Parse(SetRutaRequest source)
        {
            SetRutaRepository_Dto retorno = new SetRutaRepository_Dto();
            retorno.IdRuta = source.IdRuta;
            retorno.Descripcion = source.Descripcion;
            
            return retorno;
        }
    }
}
