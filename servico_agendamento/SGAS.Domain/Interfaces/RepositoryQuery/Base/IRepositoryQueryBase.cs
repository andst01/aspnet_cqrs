using MongoDB.Driver;
using SGAS.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.RepositoryMongo.Base
{
    public interface IRepositoryQueryBase<TEntity> where TEntity : EventBase
    {
        void Add(TEntity obj);
        Task AddAsync(TEntity obj);
        Task<TEntity> GetById(int id);
        Task<TEntity> GetByCode(string codigo);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(TEntity obj);
        void Remove(string id);
        Task RemoveAsync(string id);
        Task<IEnumerable<TEntity>> GetByFilter(FilterDefinition<TEntity> filter);
        Task Update(FilterDefinition<TEntity> filter, TEntity obj);
        Task Remove(FilterDefinition<TEntity> filter);

    }
}
