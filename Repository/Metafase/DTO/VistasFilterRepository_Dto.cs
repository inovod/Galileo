using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Metafase.DTO
{
   public  class VistasFilterRepository_Dto
    {
        public int cdcliente { get; set; }
        public int cdvendedor { get; set; }
        public int cdtienda { get; set; }
        public int cdcadena { get; set; }
        public int cdensena { get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechafin { get; set; }

    }
}
