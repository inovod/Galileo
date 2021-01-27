using Business.Model.Cluster;
using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICluster
    {
        Task<ValidationModel> AsignarConfiguracionTienda(AsignarConfTiendaModel asignarModel);
    }
}
