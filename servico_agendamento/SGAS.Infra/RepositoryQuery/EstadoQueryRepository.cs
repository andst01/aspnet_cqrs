using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class EstadoQueryRepository : RepositoryQueryBase<EstadoNotification>, IEstadoQueryRepository
    {
        public EstadoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
