using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Visita
{
    public class VisitaRespuestasColectionModel : ValidationModel
    {
        public List<ItemVisitaRespuesta> ItemCollection { get; set; }
    }

    public class ItemVisitaRespuesta
    {
        public Guid uiRespuestaCuestionario { get; set; }

        public int cdReferencia { get; set; }

        public string Referencia { get; set; }

        public int cdPreguntaCuestionario { get; set; }

        public int cdCuestionario { get; set; }

        public int cdPregunta { get; set; }

        public string Pregunta { get; set; }

        public string Surtido { get; set; }

        public string Respuesta { get; set; }

        public int cdTienda { get; set; }

        public DateTime fcVisita { get; set; }
    }
}
