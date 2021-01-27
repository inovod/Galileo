using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Cluster
{
    public class AsignarConfTiendaModel : BaseModel
    {
        public string canal { get; set; }
        public string cadena { get; set; }
        public List<int> ensena { get; set; }
        public string poblacion { get; set; }
        public string provincia { get; set; }
        public List<int> sector { get; set; }
        public List<int> familia { get; set; }
        public List<int> categoria { get; set; }
        public List<int> segmento { get; set; }
        public string cluster { get; set; }
    }
}
