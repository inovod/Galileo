using Business.Interfaces;
using Business.Logs;
using Business.Model.common;
using Business.Model.Master;
using Newtonsoft.Json;
using Repository.Identity.interfaces;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SRMaster : SRBase ,  IMaster
    {
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private readonly IIdentityUnitOfWork _indentityOfWork;
        private MapperMaster _mpMaster;
        public SRMaster(IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor ,
            IIdentityUnitOfWork indentityOfWork) : base(indentityOfWork)
        {
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _indentityOfWork = indentityOfWork;
            _mpMaster = new MapperMaster();
        }   
        public async Task<ValidationModel> GetCadena(CanalModel canalModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetCadena, canalModel.RequestHttp);

                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };
                #region Validation
                if (canalModel.Id <= 0)
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10025", new[] { Errores._10025_SRMaster_CadenaVacia }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                #endregion

                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCadena(canalModel.Id).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10023_SRMaster_GetCadena, 10023, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(canalModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(canalModel));
            }
            
        }

        public async Task<ValidationModel> GetCanales(CanalesModel canalesModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetCanales, canalesModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCanal().Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch(CError e) {
                throw AddError(IdTransaction, Errores._10025_SRMaster_Canales, 10025, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(canalesModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(canalesModel));
            }
        }

        public async Task<ValidationModel> GetCategorias(CategoriaModel categoriaModel)
        {
            try {

                await InitOperation(Enums.OperationEnum.GetCategorias, categoriaModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                #region Validation
                if (string.IsNullOrEmpty(categoriaModel.CdFamilia))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10026", new[] { Errores._10026_SRMaster_Categorias_CdFamilia }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }

                if (string.IsNullOrEmpty(categoriaModel.CdSector))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10027", new[] { Errores._10027_SRMaster_Categorias_CdSector }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                #endregion


                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCategoria(categoriaModel.CdSector, categoriaModel.CdFamilia).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10028_SRMaster_Categorias, 10028, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(categoriaModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(categoriaModel));
            }

        }

        public async Task<ValidationModel> GetCluster(ClusterModel clusterModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetCluster, clusterModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };
                #region Validation
                if(string.IsNullOrEmpty(clusterModel.CdEnsena))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10029", new[] { Errores._10029_SRMaster_Cluster_CdEnsena }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                if (string.IsNullOrEmpty(clusterModel.CdCandena))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10030", new[] { Errores._10030_SRMaster_Cluster_CdCadena }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;

                }

                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCluster(clusterModel.CdEnsena, clusterModel.CdCandena).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10031_SRMaster_Cluster, 10031, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(clusterModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(clusterModel));
            }
           
        }

        public async Task<ValidationModel> GetEnsena(EnsenaModel ensenaModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetCluster, ensenaModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };
                #region Validation
                if (ensenaModel.CdCadena <= 0)
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10033", new[] { Errores._10033_SRMaster_Ensena_CdCandena }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewEnsena(ensenaModel.CdCadena).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
                #endregion
            }
            catch (CError e) {
                throw AddError(IdTransaction, Errores._10032_SRMaster_Ensena, 10032, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(ensenaModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(ensenaModel));
            }
        }

        public async Task<ValidationModel> GetEnsenaMultiple(EnsenaMultipleModel ensenaMtpModel)
        {


            try
            {
                await InitOperation(Enums.OperationEnum.GetEnsenaMultiple, ensenaMtpModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };
                #region Validation
                if (string.IsNullOrEmpty(ensenaMtpModel.cdCadena))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10035", new[] { Errores._10035_SRMaster_EnsenaMultiple_CdCadena }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }

                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewEnsenaMultipe(ensenaMtpModel.cdCadena).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10034_SRMaster_EnsenaMultiple, 10034, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(ensenaMtpModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(ensenaMtpModel));
            }

        }


        public async Task<ValidationModel> GetFamilia(FamiliaModel familiaModel)
        {

            try
            {
                await InitOperation(Enums.OperationEnum.GetFamilia, familiaModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                #region Validation
                if (string.IsNullOrEmpty(familiaModel.Cdsector))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10037", new[] { Errores._10037_SRMaster_Familia_CdSector}), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewFamilia(familiaModel.Cdsector).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10036_SRMaster_Familia, 10036, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(familiaModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(familiaModel));
            }

        }

        public async Task<ValidationModel> GetMunicipio(MunicipioModel municipioModel)
        {
            try
            {
                await InitOperation(Enums.OperationEnum.GetMunicipio, municipioModel.RequestHttp);
                CollectionLocalidaModel response = new CollectionLocalidaModel() { CollectionItem = new List<LocalidadModel>() };

                #region Validation
                if (string.IsNullOrEmpty(municipioModel.CdProvincia))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10039", new[] { Errores._10039_SRMaster_Municipio_CdProvincia }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewMunicipio(municipioModel.CdProvincia).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10038_SRMaster_Municipio, 10038, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(municipioModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(municipioModel));
            }

        }


        public async Task<ValidationModel> GetProvincia(ProvinciaModel provinciaModel)
        {
            try
            {
                await InitOperation(Enums.OperationEnum.GetProvincia, provinciaModel.RequestHttp);
                CollectionLocalidaModel response = new CollectionLocalidaModel() { CollectionItem = new List<LocalidadModel>() };

                #region Validation

                #endregion

                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewProvincia().Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10040_SRMaster_Provincia, 10040, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(provinciaModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(provinciaModel));
            }

            //var _colection = _metafaseStoreProcedureRepor.Pr2r0NewProvincia().Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
            //return await _colection.ToList();
        }

        public async Task<ValidationModel> GetSector(SectorModel sectorModel)
        {
            try
            {
                await InitOperation(Enums.OperationEnum.GetSector, sectorModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                #region Validation
               
                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewSector().Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10041_SRMaster_Sector, 10041, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(sectorModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(sectorModel));
            }
        }

        public async Task<ValidationModel> GetClientes(ClientesModel clienteModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetCliente, clienteModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                #region Validation

                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCliente().Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch(CError e) {
                throw AddError(IdTransaction, Errores._10042_SRMaster_Clientes, 10042, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(clienteModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(clienteModel));
            }
            
        }

        public async Task<ValidationModel> GetVendedores(VendedoresModel vendedorModel)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetVendedores, vendedorModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                #region Validation
                if (vendedorModel.idcliente <= 0)
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10044", new[] { Errores._10044_SRMaster_Vendedores_IdCliente }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewVendedor(vendedorModel.idcliente).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;

            }
            catch(CError ce) {
                throw AddError(IdTransaction, Errores._10043_SRMaster_Vendedores, 10043, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(vendedorModel));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(vendedorModel));
            }
            
            /// return await _colection.ToList();
        }

        public async Task<ValidationModel> GetTiendas(TiendasModel tiendaModel)
        {

            try
            {
                await InitOperation(Enums.OperationEnum.GetTiendas, tiendaModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                #region Validation
                if (string.IsNullOrEmpty(tiendaModel.cdcliente)) {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10046", new[] { Errores._10046_SRMaster_Tiendas_CdCliente }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                if (string.IsNullOrEmpty(tiendaModel.cdVendedor)) {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10047", new[] { Errores._10047_SRMaster_Tiendas_CdVendedor }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewTiendas(tiendaModel.cdcliente, tiendaModel.cdVendedor).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10045_SRMaster_Tiendas, 10045, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(tiendaModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(tiendaModel));
            }
        }

        public async Task<ValidationModel> GetSegmento(SegmentoModel segmentoModel)
        {
            try
            {
                await InitOperation(Enums.OperationEnum.GetSegmento, segmentoModel.RequestHttp);
                CollectionItemMaserModel response = new CollectionItemMaserModel() { CollectionItem = new List<ItemMasterModel>() };

                #region Validation
                if (string.IsNullOrEmpty(segmentoModel.cdsector))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10049", new[] { Errores._10049_SRMaster_Segmentos_cdsector }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                if (string.IsNullOrEmpty(segmentoModel.cdfamilia))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10050", new[] { Errores._10050_SRMaster_Segmentos_cdfamilia }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                if (string.IsNullOrEmpty(segmentoModel.cdcategorias))
                {
                    response.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10051", new[] { Errores._10051_SRMaster_Segmentos_cdcategorias }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    return response;
                }
                #endregion
                var _colection = _metafaseStoreProcedureRepor.Pr2r0NewSegmento(segmentoModel.cdsector,segmentoModel.cdfamilia, segmentoModel.cdcategorias).Result.Select(x => _mpMaster.Parse(x)).ToAsyncEnumerable();
                response.CollectionItem = await _colection.ToList();
                return response;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10048_SRMaster_Segmentos, 10048, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(segmentoModel));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(segmentoModel));
            }
        }

        public async Task<ValidationModel> GetTipoPregutasRespuestas(TipoRespuestasVisitaModel model)
        {
            try {
                await InitOperation(Enums.OperationEnum.GetTipoRespuesta, model.RequestHttp);
                #region validation
                #endregion
                var _collection = CollectionTipoPreguntas();
                return await Task.Run(() => _collection);
            }
            catch (CError e)
            {
                throw AddError(IdTransaction, Errores._10068_SRMaster_TiposRespuestas, 10068, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(model));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction, Errores._10024_SRMaster_Generico, 10024, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(model));
            }
        }

        #region Private Function
        private CollectionItemMaserModel CollectionTipoPreguntas()
        {
            CollectionItemMaserModel collection = new CollectionItemMaserModel();
            collection.CollectionItem = new List<ItemMasterModel>();
            collection.CollectionItem.Add(new ItemMasterModel() { 
                Id = 0,
                Name = "Categoria"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 1,
                Name = "Subcategoria"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 2,
                Name = "Segmento"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 3,
                Name = "Subsegmento"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 4,
                Name = "Referencia"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 5,
                Name = "Promociones"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 6,
                Name = "Material de Visibilidad. Informativo"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 7,
                Name = "Material de Visibilidad. Proactivo"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 8,
                Name = "Marca"
            });
            collection.CollectionItem.Add(new ItemMasterModel()
            {
                Id = 9,
                Name = "Tienda"
            });

            return collection;
        }
        #endregion 
    }
    public class MapperMaster
    {
        public ItemMasterModel Parse(CanalRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Name = source.DS_CANAL,
                Id = source.CD_CANAL
            };

        }


        public ItemMasterModel Parse(CadenaRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Id = source.CD_CADENA,
                Name = source.DS_CADENA
            };

        }

        public ItemMasterModel Parse(EnsenaRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Id = source.CD_ENSENA,
                Name = source.DS_ENSENA
            };
        }

        public LocalidadModel Parse(ProvinciaRepository_Dto source)
        {
            return new LocalidadModel()
            {
                codigo = source.CD_PROV,
                descripcion = source.DS_PROV
            };
        }

        public LocalidadModel Parse(MunicipioRepository_Dto source)
        {
            return new LocalidadModel()
            {
                descripcion = source.DS_MUNI,
                codigo = source.CD_MUNI.ToString()
            };
        }

        public ItemMasterModel Parse(SectorRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Id = source.CD_SECTOR,
                Name = source.DS_SECTOR
            };
        }

        public ItemMasterModel Parse(FamiliaRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Name = source.DS_FAMILIA,
                Id = source.CD_FAMILIA
            };
        }

        public ItemMasterModel Parse(CategoriaRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Name = source.DS_CATEGORIA,
                Id = source.CD_CATEGORIA
            };
        }

        public ItemMasterModel Parse(SegmentoRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Id = source.CD_SEGMENTO,
                Name = source.DS_SEGMENTO
            };
        }

        public ItemMasterModel Parse(ClusterRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Name = source.DS_CLUSTER,
                Id = source.CD_CLUSTER
            };
        }

        public ItemMasterModel Parse(ClienteRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Name = source.DS_CLIENTE,
                Id = source.CD_CLIENTE
            };
        }
        public ItemMasterModel Parse(VendedorRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Name = source.NOMBRE,
                Id = source.CD_EMPLEADO
            };
        }

        public ItemMasterModel Parse(TiendasRepository_Dto source)
        {
            return new ItemMasterModel()
            {
                Name = source.ds_via,
                Id = source.CD_TIENDA
            };
        }
    }
}
