using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Visitas.DTO
{
    public class ItemVisitaResponse
    {
        public string fecha { get; set; }

        public string vendedor { get; set; }

        public int codigodetienda { get; set; }
        public string canal { get; set; }

        public string cadena { get; set; }

        public string ensena { get; set; }

        public string provincia { get; set; }

        public string ciudad { get; set; }

        public string direccion { get; set; }

        public string DS_cliente { get; set; }

        public Guid visita { get; set; }
    }
}
