using Business.Model.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.Surtido
{
   public class SurtidoMaxivoRespuestaModel : ValidationModel
    {
        public string respuesta { get; set; }
        public override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }
}
