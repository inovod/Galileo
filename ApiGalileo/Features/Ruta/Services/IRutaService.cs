using ApiGalileo.Features.Base;
using ApiGalileo.Features.Ruta.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Ruta.Services
{
   public interface IRutaService
    {
        Task<List<ItemRutaResponse>> GetRutas(int idcliente, int idvendedor, bool rutasbaja);
        Task<ResponseBase> DuplicarRutas(DuplicarRutaRequest request);
        Task<ResponseBase> ModificarRutas(SetRutaRequest request);
    }
}
