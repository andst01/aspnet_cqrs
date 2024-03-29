using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class ProdutoQueryRepository : RepositoryQueryBase<ProdutoNotification>, IProdutoQueryRepository
    {
        public ProdutoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
