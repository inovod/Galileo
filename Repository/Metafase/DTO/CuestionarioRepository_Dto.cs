using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Metafase.DTO
{
    public class CuestionarioRepository_Dto
    {
        public int CD_CUESTIONARIO { get; set; }

        public int CD_CLIENTE { get; set; }

        public string CLIENTE { get; set; }

        public int CD_COMPETIDOR { get; set; }

        public string Competidor { get; set; }

        public DateTime FC_ALTA { get; set; }

        public DateTime FC_BAJA { get; set; }

        public int CD_CADENA { get; set; }
        
        public string Cadena { get; set; }

        public int CD_ENSENA { get; set; }

        public string Ensena { get; set; }

        public int CD_CANAL { get; set; }

        public string Canal { get; set; }

        public int CD_ZONA { get; set; }

        public string ZONA { get; set; }

        public string Publicado { get; set; }

        public int NM_PREGUNTAS { get; set; }

    }
}
