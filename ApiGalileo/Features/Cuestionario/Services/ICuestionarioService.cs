using ApiGalileo.Features.Base;
using ApiGalileo.Features.Cuestionario.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Cuestionario.Services
{
   public  interface ICuestionarioService
    {
        Task<List<ItemCuestionarioResponse>> GetCuestionarios(string fechaInc, string fechaHasta, int cdcliente);
        Task<ResponseBase> BorrarCuestionario(BorrarCuestionarioRequest request);
    }
}
