using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Surtido
{
    public class SurtidoFilterModel :BaseModel
    {
        public string cliente;
        public string cadena;
        public string canal;
        public List<int> ensena;
        public string fechaDesde;
        public string fechaHasta;
    }
}
