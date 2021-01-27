using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Surtido.DTO;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ApiGalileo.Features.Surtido.Services
{
    public class SurtidoService : ISurtidoService
    {
        private readonly IMetafaseUnitOfWork _metafaseUnitOfWork;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private readonly ILog _log;
        private MapperSurtido _mpsurtido;

        public SurtidoService(IMetafaseUnitOfWork metafaseUnitOfWork,
            IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor,
            ILog log)
        {
            _metafaseUnitOfWork = metafaseUnitOfWork;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _log = log;
            _mpsurtido = new MapperSurtido();
        }

        public async Task<List<ItemSurtidoResponse>> GetSurtido(ItemFilterSurtidoRequest request)
        {
            
            SurtidoFiltroRepository_Dto filtro = _mpsurtido.Parse(request);
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewSurtido(filtro).Result.Select(x => _mpsurtido.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
            
        }

        public async Task<ResponseBase> DuplicarSurtidos(DuplicarSurtidosRequest request)
        {
            ResponseBase _response;
            try {
                DuplicarSurtidoRepository_Dto itemDuplicados = _mpsurtido.Parse(request);
                var _colection = await _metafaseStoreProcedureRepor.Pr2rDuplicarSurtidos(itemDuplicados);
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            }
            catch(System.Exception e)
            {
                string error = "DuplicarRutas " + e.Message;
                _log.Error(error);
                _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            }
            return _response;
        }

        public async Task<ResponseBase> BajaSurtidos(BorrarSurtidoRequest request)
        {
            ResponseBase _response;
            try
            {
                SurtidoItemBorrarRespository_Dto itemborrado = _mpsurtido.Parse(request);
                var resultado = await _metafaseStoreProcedureRepor.BajaSurtidos(itemborrado);
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            }
            catch(System.Exception e)
            {
                string error = "BorrarSurtidos " + e.Message;
                _log.Error(error);
                _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            }
            return _response;
        }
    }
    public class MapperSurtido
    {
        public DuplicarSurtidoRepository_Dto Parse(DuplicarSurtidosRequest source)
        {
            DuplicarSurtidoRepository_Dto response = new DuplicarSurtidoRepository_Dto();
            response.ID_SURTIDO = source.idsurtido;
            response.ID_CLIENTE = source.cliente;
            foreach (var item in source.ensena)
                response.ENSENA += item.ToString() + "@";

            return response;
        }

        public ItemSurtidoResponse Parse(SurtidoRepository_Dto source)
        {
            return new ItemSurtidoResponse()
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

        public SurtidoFiltroRepository_Dto Parse(ItemFilterSurtidoRequest source)
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

        public SurtidoItemBorrarRespository_Dto Parse(BorrarSurtidoRequest source)
        {
            SurtidoItemBorrarRespository_Dto response = new SurtidoItemBorrarRespository_Dto();
            foreach (var item in source.surtidos)
                response.idsurtidos += item + '@';
            response.fechaBaja = DateTime.Parse(source.fechaBaja);
            return response;
        }
    }
}
