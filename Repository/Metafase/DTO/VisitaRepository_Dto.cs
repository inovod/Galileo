using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Metafase.DTO
{
    public class VisitaRepository_Dto
    {
        public string Fecha_Planificada { get; set; }
        public string Fecha_Visita { get; set; }

        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public string vendedor { get; set; }

        public int codigodetienda { get; set; }
        public string canal { get; set; }

        public string cadena { get; set; }

        public string ensena { get; set; }

        public string provincia { get; set; }

        public string ciudad { get; set; }

        public string direccion { get; set; }

        public string DS_cliente { get; set; }

        public Guid visita { get; set; }
    }
}
