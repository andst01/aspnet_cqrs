using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class UnidadeVendaQueryRepository : RepositoryQueryBase<UnidadeVendaNotification>, IUnidadeVendaQueryRepository
    {
        public UnidadeVendaQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
