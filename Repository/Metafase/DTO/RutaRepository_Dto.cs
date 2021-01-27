using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Metafase.DTO
{
    public class RutaRepository_Dto
    {
        public int CD_RUTA { get; set; }
        public string DS_CLIENTE { get; set; }
        public string DS_RUTA { get; set; }

        public string DS_PROV { get; set; }
        public string ds_empleado { get; set; }

        public DateTime FC_ALTA { get; set; }

        public DateTime FC_BAJA { get; set; }

    }
}
