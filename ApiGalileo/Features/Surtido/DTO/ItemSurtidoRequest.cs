using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Surtido.DTO
{
   public class ItemSurtidoRequest
    {
        public bool selecionado { get; set; }

        public int idsurtido { get; set; }

        public string cadena { get; set; }
        public string cliente { get; set; }
        public string ensena { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }

        public int numeroReferencias { get; set; }
        public string publicado { get; set; }
    }
}
