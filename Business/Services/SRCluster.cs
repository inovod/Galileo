using Business.Interfaces;
using Business.Logs;
using Business.Model.Cluster;
using Business.Model.common;
using Newtonsoft.Json;
using Repository.Identity.interfaces;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SRCluster : SRBase  , ICluster
    {
        private readonly IIdentityUnitOfWork _indentityOfWork;
        private readonly IMetafaseUnitOfWork _metafaseUnitOfWork;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        MapperCluster _mpCluster;
        public SRCluster(IIdentityUnitOfWork indentityOfWork,
            IMetafaseUnitOfWork metafaseUnitOfWork , IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor) : base(indentityOfWork)
        {
            _indentityOfWork = indentityOfWork;
            _metafaseUnitOfWork = metafaseUnitOfWork;
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _mpCluster = new MapperCluster();
        }
        public async Task<ValidationModel> AsignarConfiguracionTienda(AsignarConfTiendaModel asignarModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.AsignarConfiguracionTienda, asignarModel.RequestHttp);
                AsignarConfigTiendaRespository_Dto entity = _mpCluster.Parse(asignarModel);
                #region Validation
                #endregion
                var respuesta = await _metafaseStoreProcedureRepor.Pr2r0AsignarConfigTienda(entity);
                ResponseProcedureModel _response = new ResponseProcedureModel();
                _response.retorno = respuesta;
                return _response;
            }
            catch(CError e)
            {
                throw AddError(IdTransaction, Errores._10052_SRCluster_AsignarConfiguracionTienda, 10052, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(asignarModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10053_SRCluster_Generico, 10053, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(asignarModel));
            }
        }
    }
    public class MapperCluster
    {

        public AsignarConfigTiendaRespository_Dto Parse(AsignarConfTiendaModel source)
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
