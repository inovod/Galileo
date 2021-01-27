using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Visitas.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class RespuestaSetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public ItemRespuestaRequestModel Respuesta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ValueName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rowGuidVisita { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ItemRespuestaRequestModel
    {
        public bool selecionado { get; set; }
        public string cdReferencia { get; set; }
        public string referencia { get; set; }
        public string cdPreguntaCuestionario { get; set; }

        public string cdCuestionario { get; set; }

        public string cdPregunta { get; set; }

        public string pregunta { get; set; }

        public string surtido { get; set; }

        public string uiRespuestaCuestionario { get; set; }

        public string respuesta { get; set; }

        public int cdTienda { get; set; }

        public string fcVisita { get; set; }

    }
}
