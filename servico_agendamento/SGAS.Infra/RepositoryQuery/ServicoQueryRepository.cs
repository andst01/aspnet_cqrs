using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class ServicoQueryRepository : RepositoryQueryBase<ServicoNotification>, IServicoQueryRepository
    {
        public ServicoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
