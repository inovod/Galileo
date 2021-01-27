using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Cuestionario.DTO
{
    public class BorrarItemCuestionarioRequest
    {
        public bool seleccionado { get; set; }
        public int idcuestionario { get; set; }

        public string cliente { get; set; }

        public string fechaIni { get; set; }

        public string fechaFin { get; set; }

        public string cadena { get; set; }

        public string ensena { get; set; }

        public string publicado { get; set; }
        
        public int numeroPreguntas { get; set; }

    }

    
}
