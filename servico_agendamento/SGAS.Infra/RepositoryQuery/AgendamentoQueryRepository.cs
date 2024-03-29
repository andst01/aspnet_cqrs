using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class AgendamentoQueryRepository : RepositoryQueryBase<AgendamentoNotification>, IAgendamentoQueryRepository
    {
        public AgendamentoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
