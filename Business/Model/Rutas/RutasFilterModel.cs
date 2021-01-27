using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Rutas
{
   public class RutasFilterModel : BaseModel
    {
        public int idcliente { get; set; }

        public int idvendedor { get; set; }

        public bool rutasBaja { get; set; }
    }
}
