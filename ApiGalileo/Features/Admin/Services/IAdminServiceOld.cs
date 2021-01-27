
using ApiGalileo.Features.Admin.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Admin.Servicios
{
    public interface IAdminService
    {
        Task<List<ItemBaseResponse>> GetCanales();

        Task<List<ItemBaseResponse>> GetCadena(int cdcanal);

        Task<List<ItemBaseResponse>> GetEnsena(int cdcadena);

        Task<List<ItemBaseResponse>> GetEnsenaMultile(string cdcadena);

        Task<List<LocalidadResponse>> GetProvincia();

        Task<List<LocalidadResponse>> GetMunicipio(string cdProvincia);

        Task<List<ItemBaseResponse>> GetSector();

        Task<List<ItemBaseResponse>> GetFamilia(string cdsector);

        Task<List<ItemBaseResponse>> GetCategora(string cdsector, string cdfamilia);

        Task<List<ItemBaseResponse>> GetSegmento(string cdsector, string cdfamilia, string cdcategorias);

        Task<List<ItemBaseResponse>> GetCluster(string cdcadena, string cdensena);

        Task<List<ItemBaseResponse>> GetClientes();

        Task<List<ItemBaseResponse>> GetVendedores(int idcliente);

        Task<List<ItemBaseResponse>> GetTiendas(string cdcliente, string cdvendedor);
    }

}
