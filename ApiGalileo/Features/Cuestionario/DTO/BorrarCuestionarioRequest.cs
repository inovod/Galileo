using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Cuestionario.DTO
{
    public class BorrarCuestionarioRequest
    {
        public List<int> cuestionarios { get; set; }

        public string fechaBaja { get; set; }
    }
}
