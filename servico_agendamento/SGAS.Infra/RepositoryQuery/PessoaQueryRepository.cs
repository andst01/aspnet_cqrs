using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class PessoaQueryRepository : RepositoryQueryBase<PessoaNotification>, IPessoaQueryRepository
    {
        public PessoaQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
