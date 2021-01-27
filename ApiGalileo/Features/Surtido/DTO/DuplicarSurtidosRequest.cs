using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Surtido.DTO
{
    public class DuplicarSurtidosRequest
    {
        public int idsurtido { get; set; }
        public int cliente { get; set; }
        public string canal { get; set; }
        public List<int> cadena { get; set; }
        public List<int> ensena { get; set; }
    }
}
