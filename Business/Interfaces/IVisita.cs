using Business.Model.common;
using Business.Model.Visita;
using Business.Model.Visita.filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IVisita
    {
        Task<ValidationModel> Get(VisitaFilterModel filter);

        Task<ValidationModel> GetVisitasRespuesta(VisitaFilterRespuestas filter);

        Task<ValidationModel> SetVisitaRespuesta(RespuestaSetModel dto);
        Task<ValidationModel> AddVisitaRespuesta(RespuestaSetModel dto);
    }
}
