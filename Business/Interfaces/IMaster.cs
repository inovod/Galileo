using Business.Model.common;
using Business.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IMaster
    {
        Task<ValidationModel> GetCadena(CanalModel canalModel);
        Task<ValidationModel> GetCanales(CanalesModel canalesModel);
        Task<ValidationModel> GetCategorias(CategoriaModel categoriaModel);
        Task<ValidationModel> GetCluster(ClusterModel clusterModel);
        Task<ValidationModel> GetEnsena(EnsenaModel ensenaModel);
        Task<ValidationModel> GetEnsenaMultiple(EnsenaMultipleModel ensenaMtpModel);

        Task<ValidationModel> GetFamilia(FamiliaModel familiaModel);

        Task<ValidationModel> GetMunicipio(MunicipioModel municipioModel);

        Task<ValidationModel> GetProvincia(ProvinciaModel provinciaModel);
        Task<ValidationModel> GetSector(SectorModel sectorModel);

        Task<ValidationModel> GetClientes(ClientesModel clienteModel);
        Task<ValidationModel> GetVendedores(VendedoresModel vendedorModel);
        Task<ValidationModel> GetTiendas(TiendasModel tiendaModel);

        Task<ValidationModel> GetSegmento(SegmentoModel segmentoModel);
        Task<ValidationModel> GetTipoPregutasRespuestas(TipoRespuestasVisitaModel model);
    }
}
