using MongoDB.Driver;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces
{
    public interface IMongoDBContext : IDisposable
    {
        IMongoDatabase db { get; set; }
        void AddCommand(Func<Task> func);
        Task<int> SaveChanges();
        IMongoCollection<T> GetCollection<T>(string name);

        string GetCollectionName(Type documentType);

    }
}
