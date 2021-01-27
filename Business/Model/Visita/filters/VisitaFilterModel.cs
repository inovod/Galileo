using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Visita.filters
{
    public class VisitaFilterModel : BaseModel
    {
        public int cdcliente { get; set; }
        public int cdvendedor { get; set; }
        public int cdtienda { get; set; }
        public int cdcadena { get; set; }
        public int cdensena { get; set; }
        public string fechainicio { get; set; }
        public string fechafin { get; set; }

        public bool surtido { get; set; }

        public int tipoRespuesta { get; set; }
    }
}
