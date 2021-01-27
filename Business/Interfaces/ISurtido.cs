using Business.Model.common;
using Business.Model.Surtido;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISurtido
    {
        Task<ValidationModel> GetSurtido(SurtidoFilterModel surtidoModel);
        Task<ValidationModel> DuplicarSurtidos(DuplicarSurtidoModel duplicarModel);
        Task<ValidationModel> BajaSurtidos(SurtidoBorrarModel borrarModel);
        Task<ValidationModel> SurtidoMaxivo(SurtidoMaximoModel modelo);

    }
}
