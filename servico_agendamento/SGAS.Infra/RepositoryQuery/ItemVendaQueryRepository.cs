using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class ItemVendaQueryRepository : RepositoryQueryBase<ItemVendaNotification>, IItemVendaQueryRepository
    {
        public ItemVendaQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
