using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGalileo.Features.Admin.Servicios;
using Microsoft.AspNetCore.Mvc;
using ApiGalileo.Exception;
using ApiGalileo.Features.Base;
using Business.Interfaces;
using System.Data.SqlClient;
using Business.Model.Master;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiGalileo.Features.Admin.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // private readonly IAdminService _adminservice;
        private readonly IMaster _srvMaster;
        private ILogTransaction _srvLogTransaction;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvMaster"></param>
        /// <param name="srvLogTransaction"></param>
        public AdminController(IMaster srvMaster ,
            ILogTransaction srvLogTransaction)
        {
            // _adminservice = adminservice;
            _srvMaster = srvMaster;
            _srvLogTransaction = srvLogTransaction;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCanales")]
        [SwaggerOperation(Summary ="Canales" , Description ="Get Canales" , OperationId = "GetCanales")]
        public async Task<IActionResult> GetCanales()
        {
            try {

                var _response = await _srvMaster.GetCanales(new CanalesModel() { 
                    RequestHttp = "admin/GetCadenas"
                });
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);

               // return new OkObjectResult(_response);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdcanal"></param>
        /// <returns></returns>
        [HttpGet("GetCadenas")]
        [SwaggerOperation(Summary = "Cadenas", Description = "Get Cadenas", OperationId = "GetCadenas")]
        public async Task<IActionResult> GetCadenas(int cdcanal)
        {
            try {
                var _response = await _srvMaster.GetCadena(new CanalModel()
                {
                    Id = cdcanal,
                    RequestHttp = "admin/GetCadenas/" + cdcanal.ToString()
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdCadena"></param>
        /// <returns></returns>
        [HttpGet("GetEnsena")]
        [SwaggerOperation(Summary = "Ensena", Description = "Get Ensena", OperationId = "GetEnsena")]
        public async Task<IActionResult> GetEnsena(int cdCadena)
        {
            try
            {
                var _response = await _srvMaster.GetEnsena(new EnsenaModel()
                {
                    CdCadena = cdCadena,
                    RequestHttp = "admin/GetEnsena/" + cdCadena.ToString()
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            //var _response = await _adminservice.GetEnsena(cdCadena);
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Ensena not found with Enseña {cdCadena}"));

            //return Ok(new ApiOkResponse(_response));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdCadena"></param>
        /// <returns></returns>
        [HttpGet("GetEnsenaMultiple")]
        [SwaggerOperation(Summary = "Ensena Multiple", Description = "Get Multiple", OperationId = "GetEnsenaMultiple")]
        
        public async Task<IActionResult> GetEnsenaMultiple(string cdCadena)
        {

            try
            {
                var _response = await _srvMaster.GetEnsenaMultiple(new EnsenaMultipleModel()
                {
                    cdCadena = cdCadena,
                    RequestHttp = "admin/GetEnsenaMultiple/" + cdCadena.ToString()
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            //var _response = await _adminservice.GetEnsenaMultile(cdCadena);
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Ensena not found with Enseña {cdCadena}"));

            //return Ok(new ApiOkResponse(_response));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetProvincia")]
        [SwaggerOperation(Summary = "Provincia", Description = "Get Provincia", OperationId = "GetProvincia")]
        public async Task<IActionResult> GetProvincia()
        {
            try
            {
                var _response = await _srvMaster.GetProvincia(new ProvinciaModel()
                {
                    RequestHttp = "admin/GetProvincia/" 
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionLocalidaModel retorno = _response as CollectionLocalidaModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            //var _response = await _adminservice.GetProvincia();
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Provincia not found."));

            //return Ok(new ApiOkResponse(_response));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdProvincia"></param>
        /// <returns></returns>
        [HttpGet("GetMunicipio")]
        [SwaggerOperation(Summary = "Municipio", Description = "Get Municipio", OperationId = "GetMunicipio")]
        public async Task<IActionResult> GetMunicipio(string cdProvincia)
        {
            try
            {
                var _response = await _srvMaster.GetMunicipio(new MunicipioModel()
                {
                    CdProvincia = cdProvincia,
                    RequestHttp = "admin/GetProvincia/"+cdProvincia.ToString()
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionLocalidaModel retorno = _response as CollectionLocalidaModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }


            //var _response = await _adminservice.GetMunicipio(cdProvincia);
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Municipio not found with Provincia {cdProvincia}."));

            //return Ok(new ApiOkResponse(_response));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetSector")]
        [SwaggerOperation(Summary = "Sector", Description = "Get Sector", OperationId = "GetSector")]
        public async Task<IActionResult> GetSector()
        {
            try
            {
                var _response = await _srvMaster.GetSector(new SectorModel()
                {
                    RequestHttp = "admin/GetSector/"
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }


            //var _response = await _adminservice.GetSector();
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Sector not found."));

            //return Ok(new ApiOkResponse(_response));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdsector"></param>
        /// <returns></returns>
        [HttpGet("GetFamilia")]
        [SwaggerOperation(Summary = "Familia", Description = "Get Familia", OperationId = "GetFamilia")]
        public async Task<IActionResult> GetFamilia(string cdsector)
        {

            try
            {
                string _cdSector = cdsector == null ? string.Empty : cdsector.ToString();
                var _response = await _srvMaster.GetFamilia(new FamiliaModel()
                {
                    RequestHttp = "admin/GetFamilia/" + _cdSector,
                    Cdsector = _cdSector
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            //var _response = await _adminservice.GetFamilia(cdsector);
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Familia not found with Sector {cdsector}."));

            //return Ok(new ApiOkResponse(_response));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdsector"></param>
        /// <param name="cdfamilia"></param>
        /// <returns></returns>
        [HttpGet("GetCategoria")]
        [SwaggerOperation(Summary = "Categoria", Description = "Get Categoria", OperationId = "GetCategoria")]
        public async Task<IActionResult> GetCategoria(string cdsector, string cdfamilia)
        {
            try
            {
                string _cdSector = cdsector == null ? string.Empty : cdsector.ToString();
                string _cdFamilia = cdfamilia == null ? string.Empty : cdfamilia.ToString();
                var _response = await _srvMaster.GetCategorias(new CategoriaModel()
                {
                    RequestHttp = "admin/GetCategoria/cdsector=" + _cdSector.ToString()+"cdfamilia"+ _cdFamilia.ToString(),
                    CdSector = _cdSector,
                    CdFamilia = _cdFamilia
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            //var _response = await _adminservice.GetCategora(cdsector, cdfamilia);
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Categoria not found with Sector y Familia  {cdsector} , {cdfamilia}."));

            //return Ok(new ApiOkResponse(_response));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdsector"></param>
        /// <param name="cdfamilia"></param>
        /// <param name="cdcategorias"></param>
        /// <returns></returns>
        [HttpGet("GetSegmento")]
        [SwaggerOperation(Summary = "Segmento", Description = "Get Segmento", OperationId = "GetSegmento")]
        public async Task<IActionResult> GetSegmento(string cdsector, string cdfamilia, string cdcategorias)
        {
            try
            {
                var _response = await _srvMaster.GetSegmento(new SegmentoModel()
                {
                    RequestHttp = "admin/GetSegmento/cdsector:" + cdsector.ToString() + "cdfamilia:" + cdfamilia.ToString()+"cdcategorias:"+cdcategorias.ToString(),
                    cdcategorias = cdcategorias,
                    cdfamilia = cdfamilia,
                    cdsector = cdsector
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            //var _response = await _adminservice.GetSegmento(cdsector, cdfamilia, cdcategorias);
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Segmento not found with Sector , Familia y Categoria   {cdsector} , {cdfamilia} , {cdcategorias}."));

            //return Ok(new ApiOkResponse(_response));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetTiposRespuestas")]
        [SwaggerOperation(Summary = "TipoRespuestas", Description = "Get Tipo Respuestas", OperationId = "GetTiposRespuestas")]

        public async Task<IActionResult> GetTiposRespuestas()
        {
            try
            {
                var _response = await _srvMaster.GetTipoPregutasRespuestas(new TipoRespuestasVisitaModel()
                {
                    RequestHttp = "admin/GetTipoRespuestas"
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="cdcadena"></param>
        /// <param name="cdensena"></param>
        /// <returns></returns>
        [HttpGet("GetCluster")]
        [SwaggerOperation(Summary = "Cluster", Description = "Get Cluster", OperationId = "GetCluster")]
        public async Task<IActionResult> GetCluster(string cdcadena, string cdensena)
        {
            try
            {
                var _response = await _srvMaster.GetCluster(new ClusterModel()
                {
                    RequestHttp = "admin/GetCluster/cdcadena:" + cdcadena.ToString() + "cdensena:" + cdensena.ToString(),
                    CdCandena = cdcadena,
                    CdEnsena = cdensena

                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }


            //var _response = await _adminservice.GetCluster(cdcadena, cdensena);
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Cluster not found with Cadena y Ensena  {cdcadena} , {cdensena}."));

            //return Ok(new ApiOkResponse(_response));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetClientes")]
        [SwaggerOperation(Summary = "Clientes", Description = "Get Clientes", OperationId = "GetClientes")]
        public async Task<IActionResult> GetCliente()
        {
            try
            {
                var _response = await _srvMaster.GetClientes(new ClientesModel()
                {
                    RequestHttp = "admin/GetCliente:",
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            //var _response = await _adminservice.GetClientes();
            ////if (_response.Count == 0)
            ////    return NotFound(new ApiResponse(404, $"Clientes not found."));

            //return Ok(new ApiOkResponse(_response));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idcliente"></param>
        /// <returns></returns>
        [HttpGet("GetVendedores")]
        [SwaggerOperation(Summary = "Vendedores", Description = "Get Vendedores", OperationId = "GetVendedores")]
        public async Task<IActionResult> GetVendedor(int idcliente)
        {

            try
            {
                var _response = await _srvMaster.GetVendedores(new VendedoresModel()
                {
                    RequestHttp = "admin/GetCliente:",
                    idcliente = idcliente
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            //var _response = await _adminservice.GetVendedores(idcliente);
            //return Ok(new ApiOkResponse(_response));
            ////if (_response.Count == 0)
            ////    return Ok(new ApiOkResponse(new ApiResponse(201, $"Vendedor not found with Cliente {idcliente}.")));
            ////    //return NotFound(new ApiResponse(200, $"Vendedor not found with Cliente {idcliente}."));

            /////return Ok(new ApiOkResponse(_response));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdcliente"></param>
        /// <param name="cdvendedor"></param>
        /// <returns></returns>
        [HttpGet("GetTiendas")]
        [SwaggerOperation(Summary = "Tiendas", Description = "Get Tiendas", OperationId = "GetTiendas")]
        public async Task<IActionResult> GetTiendas(string cdcliente , string cdvendedor)
        {
            try
            {
                var _response = await _srvMaster.GetTiendas(new TiendasModel()
                {
                    RequestHttp = "admin/GetTiendas/cdcliente"+ cdcliente+ "cdvendedor:"+cdvendedor,
                    cdcliente = cdcliente,
                    cdVendedor = cdvendedor
                }); ;
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                CollectionItemMaserModel retorno = _response as CollectionItemMaserModel;
                return new OkObjectResult(retorno);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }



            //var _response = await _adminservice.GetTiendas(cdcliente, cdvendedor);
            //return Ok(new ApiOkResponse(_response));
        }
    }
}