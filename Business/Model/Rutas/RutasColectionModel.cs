using Business.Model.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.Rutas
{
    public class RutasColectionModel : ValidationModel
    {
        public List<ItemRutaColection> RutasCollection { get; set; }
        public override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }

    public class ItemRutaColection
    {
        public string Cliente { get; set; }
        public string Ruta { get; set; }
        public string provincia { get; set; }

        public string FechaAlta { get; set; }

        public string FechaBaja { get; set; }

        public string vendedor { get; set; }

        public int idRuta { get; set; }
    }
}
