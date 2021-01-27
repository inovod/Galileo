using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Visita
{
    public class RespuestaModel : ValidationModel
    {
        public Guid uidVisita { get; set; }

        public string ValueRespuesta { get; set; }
    }
}
