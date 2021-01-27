using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Surtido
{
    public class SurtidoBorrarModel : BaseModel
    {
        public List<int> surtidos { get; set; }

        public string fechaBaja { get; set; }
    }
}
