using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Surtido.DTO
{
    public class ItemSurtidoResponse
    {
        public int idSurtido { get; set; }
        public int idCliente { get; set; }
        public string Cliente { get; set; }

        public string Cadena { get; set; }

        public string Ensena { get; set; }

        public string FechaAlta { get; set; }

        public string FechaBaja { get; set; }

        public string Publicado { get; set; }

        public int NumeroReferencias { get; set; }
    }
}
