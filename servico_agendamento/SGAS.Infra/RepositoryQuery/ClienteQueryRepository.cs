using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class ClienteQueryRepository : RepositoryQueryBase<ClienteNotification>, IClienteQueryRepository
    {
        public ClienteQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
