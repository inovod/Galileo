using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaNivelCategoriaCliente
    {
        public MetaNivelCategoriaCliente()
        {
            MetaCategoriaClienteCdNivel1Navigation = new HashSet<MetaCategoriaCliente>();
            MetaCategoriaClienteCdNivel2Navigation = new HashSet<MetaCategoriaCliente>();
            MetaCategoriaClienteCdNivel3Navigation = new HashSet<MetaCategoriaCliente>();
            MetaCategoriaClienteCdNivel4Navigation = new HashSet<MetaCategoriaCliente>();
            MetaCategoriaClienteCdNivel5Navigation = new HashSet<MetaCategoriaCliente>();
            MetaCategoriaClienteCdNivel6Navigation = new HashSet<MetaCategoriaCliente>();
        }

        public int CdNivel { get; set; }
        public int CdCliente { get; set; }
        public string DsNivel { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual ICollection<MetaCategoriaCliente> MetaCategoriaClienteCdNivel1Navigation { get; set; }
        public virtual ICollection<MetaCategoriaCliente> MetaCategoriaClienteCdNivel2Navigation { get; set; }
        public virtual ICollection<MetaCategoriaCliente> MetaCategoriaClienteCdNivel3Navigation { get; set; }
        public virtual ICollection<MetaCategoriaCliente> MetaCategoriaClienteCdNivel4Navigation { get; set; }
        public virtual ICollection<MetaCategoriaCliente> MetaCategoriaClienteCdNivel5Navigation { get; set; }
        public virtual ICollection<MetaCategoriaCliente> MetaCategoriaClienteCdNivel6Navigation { get; set; }
    }
}
