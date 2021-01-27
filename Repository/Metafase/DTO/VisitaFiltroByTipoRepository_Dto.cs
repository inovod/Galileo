using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Metafase.DTO
{
    public class VisitaFiltroByTipoRepository_Dto
    {
        public Guid Visita { get; set; }
        public int IdTipo { get; set; }
        public string Cadena { get; set; }
        public bool Surtido { get; set; }
    }
}
