using Business.Model.common;
using Business.Model.Cuestionario;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICuestionario
    {
        Task<ValidationModel> GetCuestionarios(CuestionarioFilterModel filterModel);

        Task<ValidationModel> BorrarCuestionario(BorrarCuestionarioModel request);
    }
}
