using ApiGalileo.Api.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGalileo.Features.Base;
using Repository.Metafase.interfaces;
using ApiGalileo.Features.Visitas.DTO;
using Repository.Metafase.DTO;

namespace ApiGalileo.Features.Visitas.Services
{
    public class VisitasServices : IVisitasService
    {
        private readonly ILog _log;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private MapperVisitas _mpvisitas;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        /// <param name="metafaseStoreProcedureRepors"></param>
        public VisitasServices(ILog log , IMetafaseStoreProcedureRepository metafaseStoreProcedureRepors)
        {
            _log = log;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepors;
            _mpvisitas = new MapperVisitas();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<List<DTO.ItemVisitaResponse>> GetVisitas(DTO.VistasFilterRequest filter) 
        {
            VistasFilterRepository_Dto _filter = new VistasFilterRepository_Dto()
            {
                cdcadena = filter.cdcadena,
                cdcliente = filter.cdcliente,
                cdensena = filter.cdensena,
                cdtienda = filter.cdtienda,
                cdvendedor = filter.cdvendedor,
                //fechafin = filter.fechafin,
                //fechainicio = filter.fechainicio
            };
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewVisitas(_filter).Result.Select(x => _mpvisitas.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class MapperVisitas
    {
        public ItemVisitaResponse Parse(VisitaRepository_Dto source)
        {
            return new ItemVisitaResponse()
            {
                cadena = source.cadena,
                canal = source.canal,
                ciudad = source.ciudad,
                codigodetienda = source.codigodetienda,
                direccion = source.direccion,
                DS_cliente = source.DS_cliente,
                ensena  = source.ensena,
                fecha = source.Fecha_Visita,
                provincia = source.provincia,
                vendedor = source.vendedor,
                visita = source.visita
            };
        }
    }
}
