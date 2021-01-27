using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Surtido.DTO
{
    public class BorrarSurtidoRequest
    {
        public List<int> surtidos { get; set; }

        public string fechaBaja { get; set; }
    }
}
