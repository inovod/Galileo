using System.Collections.Generic;
using System.Threading.Tasks;
using ApiGalileo.Features.Admin.DTO;
using Repository.Metafase.DTO;
using Repository.Metafase.interfaces;
using System.Linq;
namespace ApiGalileo.Features.Admin.Servicios
{
    public class AdminServiceOld : IAdminService
    {
        private readonly IMetafaseStoreProcedureRepository _metafaseStoreProcedureRepor;
        private MapperAdmin _mpadmin;
        public AdminServiceOld(IMetafaseStoreProcedureRepository metafaseStoreProcedureRepor)
        {
            _metafaseStoreProcedureRepor = metafaseStoreProcedureRepor;
            _mpadmin = new MapperAdmin();
        }

        public async Task<List<ItemBaseResponse>> GetCadena(int cdcanal)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCadena(cdcanal).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetCanales()
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCanal().Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetCategora(string cdsector, string cdfamilia)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCategoria(cdsector, cdfamilia).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetCluster(string cdcadena, string cdensena)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCluster(cdensena, cdcadena).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetEnsena(int cdcadena)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewEnsena(cdcadena).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetEnsenaMultile(string cdcadena)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewEnsenaMultipe(cdcadena).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetFamilia(string cdsector)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewFamilia(cdsector).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<LocalidadResponse>> GetMunicipio(string cdProvincia)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewMunicipio(cdProvincia).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<LocalidadResponse>> GetProvincia()
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewProvincia().Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetSector()
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewSector().Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetSegmento(string cdsector, string cdfamilia, string cdcategorias)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewSegmento(cdsector, cdfamilia, cdcategorias).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetClientes()
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewCliente().Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }

        public async Task<List<ItemBaseResponse>> GetVendedores(int idcliente)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewVendedor(idcliente).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }
        public async Task<List<ItemBaseResponse>> GetTiendas(string cdcliente , string cdvendedor)
        {
            var _colection = _metafaseStoreProcedureRepor.Pr2r0NewTiendas(cdcliente,cdvendedor).Result.Select(x => _mpadmin.Parse(x)).ToAsyncEnumerable();
            return await _colection.ToList();
        }
    }
    public class MapperAdmin
    {
        public ItemBaseResponse Parse(CanalRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Name = source.DS_CANAL,
                Id = source.CD_CANAL
            };

        }


        public ItemBaseResponse Parse(CadenaRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Id = source.CD_CADENA,
                Name = source.DS_CADENA
            };

        }

        public ItemBaseResponse Parse(EnsenaRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Id = source.CD_ENSENA,
                Name = source.DS_ENSENA
            };
        }

        public LocalidadResponse Parse(ProvinciaRepository_Dto source)
        {
            return new LocalidadResponse()
            {
                codigo = source.CD_PROV,
                descripcion = source.DS_PROV
            };
        }

        public LocalidadResponse Parse(MunicipioRepository_Dto source)
        {
            return new LocalidadResponse()
            {
                descripcion = source.DS_MUNI,
                codigo = source.CD_MUNI.ToString()
            };
        }

        public ItemBaseResponse Parse(SectorRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Id = source.CD_SECTOR,
                Name = source.DS_SECTOR
            };
        }

        public ItemBaseResponse Parse(FamiliaRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Name = source.DS_FAMILIA,
                Id = source.CD_FAMILIA
            };
        }

        public ItemBaseResponse Parse(CategoriaRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Name = source.DS_CATEGORIA,
                Id = source.CD_CATEGORIA
            };
        }

        public ItemBaseResponse Parse(SegmentoRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Id = source.CD_SEGMENTO,
                Name = source.DS_SEGMENTO
            };
        }

        public ItemBaseResponse Parse(ClusterRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Name = source.DS_CLUSTER,
                Id = source.CD_CLUSTER
            };
        }

        public ItemBaseResponse Parse(ClienteRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Name = source.DS_CLIENTE,
                Id = source.CD_CLIENTE
            };
        }
        public ItemBaseResponse Parse(VendedorRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Name = source.NOMBRE,
                Id = source.CD_EMPLEADO
            };
        }

        public ItemBaseResponse Parse(TiendasRepository_Dto source)
        {
            return new ItemBaseResponse()
            {
                Name = source.ds_via,
                Id = source.CD_TIENDA
            };
        }
    }
}
