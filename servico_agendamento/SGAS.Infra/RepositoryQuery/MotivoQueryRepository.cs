using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class MotivoQueryRepository : RepositoryQueryBase<MotivoNotification>, IMotivoQueryRepository
    {
        public MotivoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
