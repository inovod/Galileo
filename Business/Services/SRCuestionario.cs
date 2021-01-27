using Business.Interfaces;
using Business.Logs;
using Business.Model.common;
using Business.Model.Cuestionario;
using Newtonsoft.Json;
using Repository.Identity.interfaces;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SRCuestionario : SRBase , ICuestionario
    {
        private readonly IIdentityUnitOfWork _indentityOfWork;
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        MapperCuestionario _mpCuestionario;
        public SRCuestionario(IIdentityUnitOfWork indentityOfWork ,
            IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor) 
            : base(indentityOfWork)
        {
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _indentityOfWork = indentityOfWork;
            _mpCuestionario = new MapperCuestionario();
        }
        public async Task<ValidationModel> BorrarCuestionario(BorrarCuestionarioModel request)
        {
            try {
                await InitOperation(Enums.OperationEnum.BorrarCuestionario, request.RequestHttp);
                #region Validation
                #endregion
                var retorno = await _metafaseStoreProcedureRepor.BajaCuestionarios(_mpCuestionario.Parse(request));
                ResponseProcedureModel _response = new ResponseProcedureModel();
                _response.retorno = retorno;
                return _response;
            }
            catch(CError ce) {
                throw AddError(IdTransaction, Errores._10055_SRCuestionario_BorrarCuestionario, 10055, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(request));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10054_SRCuestionario_Generico, 10054, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(request));
            }
        }

        public async Task<ValidationModel> GetCuestionarios(CuestionarioFilterModel filterModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetCuestionario, filterModel.RequestHttp);
                #region Validation
                #endregion
                CuestionarioColectionModel cuestionarioColection = new CuestionarioColectionModel()
                {
                    CuestionarioCollection = new List<ItemCuestionario>()
                };
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCuestionario(filterModel.fechaInc, filterModel.fechaHasta, filterModel.cdcliente).Result.Select(x => _mpCuestionario.Parse(x)).ToAsyncEnumerable();
                cuestionarioColection.CuestionarioCollection = await _colection.ToList();
                return cuestionarioColection;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction, Errores._10056_SRCuestionario_GetCuestionarios, 10056, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filterModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10054_SRCuestionario_Generico, 10054, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(filterModel));
            }
        }
    }

    public class MapperCuestionario
    {
        public ItemCuestionario Parse(CuestionarioRepository_Dto source)
        {
            return new ItemCuestionario()
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
        public CuestionarioItemBorrarRepository_Dto Parse(BorrarCuestionarioModel source)
        {
            CuestionarioItemBorrarRepository_Dto response = new CuestionarioItemBorrarRepository_Dto();
            foreach (var item in source.cuestionarios)
                response.idcuestionarios += item.ToString() + '@';
            response.fechaBaja = DateTime.Parse(source.fechaBaja);
            return response;
        }
    }


}
