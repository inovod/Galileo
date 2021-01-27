using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MejoraCdmg2
    {
        public DateTime? Mes { get; set; }
        public string Respuesta { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public int? CdUsuario { get; set; }
        public string Pregunta { get; set; }
        public string Canal { get; set; }
        public string Cadena { get; set; }
        public string Ensena { get; set; }
        public string Provincia { get; set; }
        public string Vendedor { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public int? Tienda { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Cantidad { get; set; }
        public string Segmento { get; set; }
        public string Categoria { get; set; }
    }
}
