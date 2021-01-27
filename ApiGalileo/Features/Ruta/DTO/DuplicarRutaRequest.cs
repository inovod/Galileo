using Business.Model.Rutas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Ruta.DTO
{
    public class DuplicarRutaRequest
    {
        public int cliente { get; set; }
        public int vendedor { get; set; }
        public List<ItemRutaColection> rutas { get; set; }
    }
    //public class ItemRutas
    //{
    //    public string Cliente { get; set; }
    //    public string provincia { get; set; }

    //    public string FechaAlta { get; set; }

    //    public string FechaBaja { get; set; }

    //    public string vendedor { get; set; }

    //    public int idRuta { get; set; }
    //}
}
