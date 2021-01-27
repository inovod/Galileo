using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Visitas.Services
{
    public interface IVisitasService
    {
        Task<List<DTO.ItemVisitaResponse>> GetVisitas(DTO.VistasFilterRequest filter);
    }
}
