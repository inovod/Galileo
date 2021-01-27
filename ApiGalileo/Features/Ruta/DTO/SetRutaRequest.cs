using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Ruta.DTO
{
    public class SetRutaRequest
    {
        public int IdRuta { get; set; }
        public string Descripcion { get; set; }
    }
}
