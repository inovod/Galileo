using ApiGalileo.Features.Base;
using ApiGalileo.Features.Cluster.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Cluster.Services
{
   public interface IClusterService
    {

        Task<ResponseBase> AsignarConfiguracionTienda(AsignarConfigTienda_Dto request);
    }
}
