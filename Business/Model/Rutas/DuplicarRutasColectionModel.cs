using Business.Model.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.Rutas
{
    public class DuplicarRutasColectionModel : BaseModel
    {
        public int cliente { get; set; }
        public int vendedor { get; set; }
        public List<ItemRutaColection> rutas { get; set; }

   }
}
