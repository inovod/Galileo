using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Business.Model.Surtido
{
    public class SurtidoCollectionModel : ValidationModel
    {
        public List<ItemSurtidoModel> ItemCollection { get; set; }

        public override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }

    public class ItemSurtidoModel
    {
        public int idSurtido { get; set; }
        public int idCliente { get; set; }
        public string Cliente { get; set; }

        public string Cadena { get; set; }

        public string Ensena { get; set; }

        public string FechaAlta { get; set; }

        public string FechaBaja { get; set; }

        public string Publicado { get; set; }

        public int NumeroReferencias { get; set; }
    }

}
