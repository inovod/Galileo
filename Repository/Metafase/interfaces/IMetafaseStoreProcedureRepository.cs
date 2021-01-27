using Repository.Metafase.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Metafase.interfaces
{
    public interface IMetafaseStoreProcedureRepository
    {
        Task<List<CanalRepository_Dto>> Pr2r0NewCanal();

        Task<List<CadenaRepository_Dto>> Pr2r0NewCadena(int cdcadena);

        Task<List<EnsenaRepository_Dto>> Pr2r0NewEnsena(int cdcadena);

        Task<List<ProvinciaRepository_Dto>> Pr2r0NewProvincia();

        Task<List<MunicipioRepository_Dto>> Pr2r0NewMunicipio(string cdprovincia);

        Task<List<SectorRepository_Dto>> Pr2r0NewSector();

        Task<List<FamiliaRepository_Dto>> Pr2r0NewFamilia(string cdsector);

        Task<List<CategoriaRepository_Dto>> Pr2r0NewCategoria(string cdsector, string cdfamilia);
        Task<List<SegmentoRepository_Dto>> Pr2r0NewSegmento(string cdsector, string cdfamilia, string cdcategorias);
        Task<List<ClusterRepository_Dto>> Pr2r0NewCluster(string cdensena, string cdcadena);

        Task<List<ClienteRepository_Dto>> Pr2r0NewCliente();

        Task<List<VendedorRepository_Dto>> Pr2r0NewVendedor(int cdcliente);

        Task<List<RutaRepository_Dto>> Pr2r0NewRuta(int cdcliente, int idvendedor, bool rutasbaja);

        Task<string> Pr2r0AsignarConfigTienda(AsignarConfigTiendaRespository_Dto dto);

        Task<string> Pr2r0CrearRuta(DuplicarRutasRepository_Dto dto);

        Task<string> Pr2r0CambiarNombreRuta(SetRutaRepository_Dto dto);

        Task<List<CuestionarioRepository_Dto>> Pr2r0NewCuestionario(string fechaIni, string fechaFin, int cdcliente);
        Task<List<SurtidoRepository_Dto>> Pr2r0NewSurtido(SurtidoFiltroRepository_Dto request);

        Task<string> BajaCuestionarios(CuestionarioItemBorrarRepository_Dto dto);
        Task<List<EnsenaRepository_Dto>> Pr2r0NewEnsenaMultipe(string cdcadena);

        Task<string> Pr2rDuplicarSurtidos(DuplicarSurtidoRepository_Dto dto);

        Task<string> BajaSurtidos(SurtidoItemBorrarRespository_Dto dto);

        Task<List<TiendasRepository_Dto>> Pr2r0NewTiendas(string cdcliente, string cdvendedor);
        Task<List<VisitaRepository_Dto>> Pr2r0NewVisitas(VistasFilterRepository_Dto request);

        Task<List<VisitaRespuestaRepository_Dto>> Pr2r0NewVisitaSelByTipo(VisitaFiltroByTipoRepository_Dto request);
    }
}
