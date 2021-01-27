using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Visita.filters
{
    public class VisitaFilterRespuestas : BaseModel
    {
        public string Visita { get; set; }
        public int IdTipo { get; set; }
        public string Cadena { get; set; }
        public bool Surtido { get; set; }
    }
}
