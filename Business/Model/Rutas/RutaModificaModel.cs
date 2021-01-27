using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Rutas
{
    public class RutaModificaModel : BaseModel
    {
        public int IdRuta { get; set; }
        public string Descripcion { get; set; }
    }
}
