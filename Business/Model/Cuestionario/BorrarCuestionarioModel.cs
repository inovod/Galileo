using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Cuestionario
{
    public class BorrarCuestionarioModel : BaseModel
    {
        public List<int> cuestionarios { get; set; }

        public string fechaBaja { get; set; }
    }
}
