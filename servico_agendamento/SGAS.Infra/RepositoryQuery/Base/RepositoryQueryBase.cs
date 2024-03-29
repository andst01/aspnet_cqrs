using MongoDB.Driver;
using SGAS.Domain.Notifications;
using SGAS.Domain.Interfaces.RepositoryMongo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGAS.Domain.Utils;
using SGAS.Domain.Interfaces;

namespace SGAS.Infra.RepositoryMongo.Base
{
    public class RepositoryQueryBase<TEntity> : IDisposable, IRepositoryQueryBase<TEntity> where TEntity : EventBase
    {
        protected readonly IMongoDBContext _context;
        protected IMongoCollection<TEntity> collection;
       // MongoDatabaseBase
       
        protected RepositoryQueryBase(IMongoDBContext context)
        {
            _context = context;
            collection = _context.db.GetCollection<TEntity>(GetCollectionName(typeof(TEntity)));

        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)

                .FirstOrDefault())?.CollectionName;
        }

        public virtual void Add(TEntity obj)
        {          
            collection.InsertOne(obj);
        }

        public virtual async Task AddAsync(TEntity obj)
        {
           await  collection.InsertOneAsync(obj);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await collection.FindAsync(Builders<TEntity>.Filter.Empty);
            return all.ToList();
        }

        public virtual async Task<TEntity> GetByCode(string codigo)
        {
            var data = await collection.FindAsync(Builders<TEntity>.Filter.Eq(doc => doc._Id.ToString(), codigo));
            return data.SingleOrDefault();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            var data = await collection.FindAsync(Builders<TEntity>.Filter.Eq(doc => doc.Id, id));
            return data.SingleOrDefault();
        }

        public virtual async Task<IEnumerable<TEntity>> GetByFilter(FilterDefinition<TEntity> filter)
        {
            var data = await collection.FindAsync(filter);
            return data.ToEnumerable();
        }

        public virtual void Remove(string id)
        {
            Task.Run(() => collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq(doc => doc._Id.ToString(), id)));
        }

        public async Task RemoveAsync(string id)
        {
            await collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq(doc => doc._Id.ToString(), id));
        }

        public virtual async Task Update(TEntity obj)
        {
            await collection.ReplaceOneAsync(x => x._Id == obj._Id, obj);
        }

        public virtual async Task Update(FilterDefinition<TEntity> filter, TEntity obj)
        {
            var data = await collection.FindAsync(filter);
            obj._Id = data.FirstOrDefault()._Id;

            await collection.ReplaceOneAsync(filter, obj);
        }

        public virtual async Task Remove(FilterDefinition<TEntity> filter)
        {
            var data = await collection.FindAsync(filter);
            var id = data.FirstOrDefault()._Id;

            await collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq(x => x._Id, id));
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
