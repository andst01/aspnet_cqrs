using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class FornecedorQueryRepository : RepositoryQueryBase<FornecedorNotification>, IFornecedorQueryRepository
    {
        public FornecedorQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
