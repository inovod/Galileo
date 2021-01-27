using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Master
{
    public class LocalidadModel
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
    }
    public class CollectionLocalidaModel : ValidationModel
    {
        public List<LocalidadModel> CollectionItem { get; set; }
    }
}
