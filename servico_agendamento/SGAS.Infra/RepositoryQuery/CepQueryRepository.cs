using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class CepQueryRepository : RepositoryQueryBase<CepNotification>, ICepQueryRepository
    {
        public CepQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
