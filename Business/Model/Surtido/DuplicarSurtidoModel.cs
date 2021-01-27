using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Surtido
{
    public class DuplicarSurtidoModel : BaseModel
    {
        public int idsurtido { get; set; }
        public int cliente { get; set; }
        public string canal { get; set; }
        public List<int> cadena { get; set; }
        public List<int> ensena { get; set; }
    }
}
