using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Business.Model.Visita
{
    public class RespuestaSetModel : BaseModel
    {
        public ItemRespuestaModel Respuesta { get; set; }
        public string ValueRespuesta { get; set; }

      

    }

    public class ItemRespuestaModel
    {
        public bool selecionado { get; set; }
        public string cdReferencia { get; set; }
        public string referencia { get; set;}
        public string cdPreguntaCuestionario { get; set; }

        public string cdCuestionario { get; set; }

        public string cdPregunta { get; set; }

        public string pregunta { get; set; }

        public string surtido { get; set; }

        public string uiRespuestaCuestionario { get; set; }

        public string respuesta { get; set; }

        public int cdTienda { get; set; }

        public Guid rowGuidVisita { get; set; }

        public string fcVisita { get; set; }

    }
}
