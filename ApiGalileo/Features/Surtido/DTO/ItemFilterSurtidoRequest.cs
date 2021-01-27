using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Surtido.DTO
{
    public class ItemFilterSurtidoRequest
    {
        public string cliente;
        public string cadena;
        public string canal;
        public List<int> ensena;
        public string fechaDesde;
        public string fechaHasta;

        
    }
}
