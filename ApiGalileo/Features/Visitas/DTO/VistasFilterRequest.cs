using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Visitas.DTO
{
    public class VistasFilterRequest
    {
        public int cdcliente { get; set; }
        public int cdvendedor { get; set; }
        public int cdtienda { get; set; }
        public int cdcadena { get; set; }
        public int cdensena { get; set; }
        public string fechainicio { get; set; }
        public string fechafin { get; set; }
    }
}
