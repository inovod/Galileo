using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.Cluster.DTO;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Cluster.Services
{
    public class ClusterService : IClusterService
    {
        private readonly IMetafaseUnitOfWork _metafaseUnitOfWork;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private readonly ILog _log;
        MapperCluster _mpCluster;
        public ClusterService(IMetafaseUnitOfWork metafaseUnitOfWork, 
            IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor,
            ILog log)
        {
            _metafaseUnitOfWork = metafaseUnitOfWork;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _log = log;
            _mpCluster = new MapperCluster();
        }


        public async Task<ResponseBase> AsignarConfiguracionTienda(AsignarConfigTienda_Dto request)
        {
            ResponseBase _response;
            try
            {
                AsignarConfigTiendaRespository_Dto entity = _mpCluster.Parse(request);
                var respuesta = await _metafaseStoreProcedureRepor.Pr2r0AsignarConfigTienda(entity);
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            }
            catch (System.Exception e)
            {
                string error = "AsignarConfiguracion " + e.Message;
                _log.Error(error);
                _response = new ResponseBase() { Response = "No se ha podido realizar la operacion", bOK = false };
            }
            return _response;
        }
    }
    public class MapperCluster
    {

        public AsignarConfigTiendaRespository_Dto Parse(AsignarConfigTienda_Dto source)
        {
            AsignarConfigTiendaRespository_Dto retorno = new AsignarConfigTiendaRespository_Dto();
            retorno.CD_CANAL = int.Parse(source.canal);
            retorno.CD_CADENA = int.Parse(source.cadena);
            foreach (var item in source.ensena)
                retorno.CD_ENSENA += item.ToString() + "@";

            retorno.CD_PROVINCIA = source.provincia;
            retorno.CD_MUNICIPIO = source.poblacion;
            retorno.CD_CLUSTER = int.Parse(source.cluster);

            foreach (var item in source.sector)
                retorno.CD_SECTOR += item.ToString() + "@";

            foreach (var item in source.familia)
                retorno.CD_FAMILIA += item.ToString() + "@";

            foreach (var item in source.categoria)
                retorno.CD_CATEGORIA += item.ToString() + "@";

            foreach (var item in source.segmento)
                retorno.CD_SEGMENTO += item.ToString() + "@";
            return retorno;
        }
    }
}
