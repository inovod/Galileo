using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Visita
{
    public class VisitaColectionModel : ValidationModel
    {
        public List<ItemVisitaModel> ItemCollection { get; set; }
    }
    public class ItemVisitaModel
    {
        public string fechaPlanificada { get; set; }

        public string fechaVisita { get; set; }

        public string horaInicio { get; set; }

        public string horaFin { get; set; }

        public string vendedor { get; set; }

        public int codigodetienda { get; set; }
        public string canal { get; set; }

        public string cadena { get; set; }

        public string ensena { get; set; }

        public string provincia { get; set; }

        public string ciudad { get; set; }

        public string direccion { get; set; }

        public string clienteDs { get; set; }

        public Guid visita { get; set; }
    }
}
