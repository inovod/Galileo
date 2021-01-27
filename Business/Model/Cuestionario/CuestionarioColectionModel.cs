using Business.Model.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.Cuestionario
{
    public class CuestionarioColectionModel : ValidationModel
    {
        public List<ItemCuestionario> CuestionarioCollection { get; set; }
        public override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }

    public class ItemCuestionario
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
