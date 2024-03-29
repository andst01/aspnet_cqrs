using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.RepositoryQuery
{
    public class CategoriaQueryRepository : RepositoryQueryBase<CategoriaNotification>, ICategoriaQueryRepository
    {
        public CategoriaQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
