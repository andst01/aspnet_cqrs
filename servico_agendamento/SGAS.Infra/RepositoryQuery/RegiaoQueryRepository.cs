using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class RegiaoQueryRepository : RepositoryQueryBase<RegiaoNotification>, IRegiaoQueryRepository
    {
        public RegiaoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
