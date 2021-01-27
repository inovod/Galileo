using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Metafase.DTO
{
    public class VisitaRespuestaRepository_Dto
    {
        public int CD_REFERENCIA { get; set; }

        public string DS_REFERENCIA { get; set; }

        public int CD_PREGUNTA_CUESTIONARIO { get; set; }

        public int CD_CUESTIONARIO { get; set; }

        public int CD_PREGUNTA { get; set; }

        public string DS_PREGUNTA { get; set; }

        public string SURTIDO { get; set; }

        public Guid ROWGUID { get; set; }

        public string DS_RESPUESTA { get; set; }

        public int CD_TIENDA { get; set; }

        public DateTime FC_VISITA { get; set; }
    }
}
