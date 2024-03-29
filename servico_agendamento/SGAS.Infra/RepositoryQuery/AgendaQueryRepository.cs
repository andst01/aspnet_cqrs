using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class AgendaQueryRepository : RepositoryQueryBase<AgendaNotification>, IAgendaQueryRepository
    {
        public AgendaQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
