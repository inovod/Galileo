using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Business.Model.Master
{
    public class SegmentoModel : BaseModel
    {
        public string cdsector { get; set; }

        public string cdfamilia { get; set; }

        public string cdcategorias { get; set; }
    }
}
