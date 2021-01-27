using Microsoft.EntityFrameworkCore;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Metafase
{
    public class MetafaseRepository<T,KeyT> : IGenericDataRespositoryBase<T,KeyT>
        where T : class
    {
        protected  Domain.Metafase.Model.Metafase context;
        public MetafaseRepository(Domain.Metafase.Model.Metafase ctx) => context = ctx;

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await context.Set<T>().AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await context.AddAsync<T>(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(KeyT id)
        {
            var entity = await GetAsync(id);
            context.Remove<T>(entity);
        }
        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().Where(match).ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().SingleOrDefaultAsync(match);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(KeyT id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task InsertEntity(T entity)
        {
            await context.AddAsync<T>(entity);
        }

        public async Task SaverChangeAsyc()
        {
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T changedDataObject)
        {
            context.Update<T>(changedDataObject);
            await context.SaveChangesAsync();
        }
    }
}
