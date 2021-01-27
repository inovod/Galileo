using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Cuestionario.DTO;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Cuestionario.Services
{
   
    public class CuestionarioServiceOld : ICuestionarioService
    {
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private readonly ILog _log;
        MapperCuestionario _mapperCuestionario;
        public CuestionarioServiceOld(
            IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor,
            ILog log)
        {
            _log = log;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _mapperCuestionario = new MapperCuestionario();

        }

        public async Task<ResponseBase> BorrarCuestionario(BorrarCuestionarioRequest request)
        {
            ResponseBase _response;
            try {
                CuestionarioItemBorrarRepository_Dto itemborrado = _mapperCuestionario.Parse(request);
                var retorno = await _metafaseStoreProcedureRepor.BajaCuestionarios(itemborrado);
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            }
            catch (System.Exception e)
            {
                string error = "Borrar Cuestionarios " + e.Message;
                _log.Error(error);
                _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            }
            return _response;
        }

        public async Task<List<ItemCuestionarioResponse>> GetCuestionarios(string fechaInc, string fechaHasta , int cdcliente)
        {
           
            DateTime dInc = DateTime.Parse(fechaInc);
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCuestionario(fechaInc, fechaHasta, cdcliente).Result.Select(x => _mapperCuestionario.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }
    }

    public class MapperCuestionario
    {
        public ItemCuestionarioResponse Parse(CuestionarioRepository_Dto source)
        {
            return new ItemCuestionarioResponse()
            {
                idcuestionario = source.CD_CUESTIONARIO,
                Cadena = source.Cadena,
                Cliente = source.CLIENTE,
                Ensena = source.Ensena,
                FechaIni = source.FC_ALTA.ToString(),
                FechaFin = source.FC_BAJA.ToString(),
                NumeroPreguntas = source.NM_PREGUNTAS,
                Publicado = source.Publicado

            };

        }

        public CuestionarioItemBorrarRepository_Dto Parse(BorrarCuestionarioRequest source)
        {
            CuestionarioItemBorrarRepository_Dto response = new CuestionarioItemBorrarRepository_Dto();
            foreach (var item in source.cuestionarios)
                response.idcuestionarios += item.ToString() + '@';
            response.fechaBaja = DateTime.Parse(source.fechaBaja);
            return response;
        }
    }
}
