using Business.Model.common;
using Business.Model.Rutas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
   public interface IRutas
    {
        Task<ValidationModel> GetRutas(RutasFilterModel filterModel);

        Task<ValidationModel> DuplicarRutas(DuplicarRutasColectionModel duplicarRutasModel);

        Task<ValidationModel> ModificarRutas(RutaModificaModel rutaModel);

    }
}
