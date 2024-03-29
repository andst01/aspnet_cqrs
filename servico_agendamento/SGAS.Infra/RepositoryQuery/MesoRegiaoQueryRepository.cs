using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class MesoRegiaoQueryRepository : RepositoryQueryBase<MesoRegiaoNotification>, IMesoRegiaoQueryRepository
    {
        public MesoRegiaoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
