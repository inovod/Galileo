using ApiGalileo.Features.Base;
using ApiGalileo.Features.Surtido.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Surtido.Services
{
    public interface ISurtidoService
    {
        Task<List<ItemSurtidoResponse>> GetSurtido(ItemFilterSurtidoRequest request);

        Task<ResponseBase> DuplicarSurtidos(DuplicarSurtidosRequest request);

        Task<ResponseBase> BajaSurtidos(BorrarSurtidoRequest request);
    }
}
