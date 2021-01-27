using Domain.Metafase.Model;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Metafase.interfaces
{
   public interface IMetafaseUnitOfWork
    {
        IGenericDataRespositoryBase<MetaRespuestasCuestionario, Guid> RespuestaCuestionarioRepository { get; }
    }
}
