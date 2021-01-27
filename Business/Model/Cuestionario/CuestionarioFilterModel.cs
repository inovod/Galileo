using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Cuestionario
{
    public class CuestionarioFilterModel : BaseModel
    {
        public string fechaInc { get; set; }

        public string fechaHasta { get; set; }
        public int cdcliente { get; set; }
    }
}
