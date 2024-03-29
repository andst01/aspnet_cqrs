using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class CidadeQueryRepository : RepositoryQueryBase<CidadeNotification>, ICidadeQueryRepository
    {
        public CidadeQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
