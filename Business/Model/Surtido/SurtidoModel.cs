using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Surtido
{
    public class SurtidoModel
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
