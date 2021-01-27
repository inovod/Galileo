using System;
using System.Collections.Generic;
using System.Text;
using Domain.Metafase.Model;
using Repository.interfaces;
using Repository.Metafase.interfaces;

namespace Repository.Metafase
{
   public class MetafaseUnitOfWork : IMetafaseUnitOfWork
    {
        private Domain.Metafase.Model.Metafase _contextMetafase;
        private IGenericDataRespositoryBase<MetaRespuestasCuestionario, Guid> _respuestaCuestionarioRepository;
        public MetafaseUnitOfWork(Domain.Metafase.Model.Metafase contextMetafase)
        {
            _contextMetafase = contextMetafase;
        }

        public IGenericDataRespositoryBase<MetaRespuestasCuestionario,Guid> RespuestaCuestionarioRepository
        {
            get {
                return _respuestaCuestionarioRepository = _respuestaCuestionarioRepository ?? new MetafaseRepository<MetaRespuestasCuestionario, Guid>(_contextMetafase);
            }
        }

    }
}
