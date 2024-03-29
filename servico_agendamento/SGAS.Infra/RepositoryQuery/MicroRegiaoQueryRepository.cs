using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class MicroRegiaoQueryRepository : RepositoryQueryBase<MicroRegiaoNotification>, IMicroRegiaoQueryRepository
    {
        public MicroRegiaoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
