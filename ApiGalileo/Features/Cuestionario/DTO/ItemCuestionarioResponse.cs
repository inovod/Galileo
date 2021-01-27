using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Cuestionario.DTO
{
    public class ItemCuestionarioResponse
    {
        public int idcuestionario { get; set; }
        public string Cliente { get; set; }
        public string FechaIni { get; set; }
        public string FechaFin { get; set; }
        public string Cadena { get; set; }
        public string Ensena { get; set; }
        public string Publicado { get; set; }
        public int NumeroPreguntas { get; set; }
    }
}
