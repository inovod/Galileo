using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Ruta.DTO
{
    public class ItemRutaResponse
    {
        public string Cliente { get; set; }
        public string Ruta { get; set; }
        public string provincia { get; set; }

        public string FechaAlta { get; set; }

        public string FechaBaja { get; set; }

        public string vendedor { get; set; }

        public int idRuta { get; set; }

    }
}
