using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class EnderecoQueryRepository : RepositoryQueryBase<EnderecoNotification>, IEnderecoQueryRepository
    {
        public EnderecoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
