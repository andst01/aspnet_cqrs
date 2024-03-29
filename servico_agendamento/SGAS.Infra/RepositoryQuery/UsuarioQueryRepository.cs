using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class UsuarioQueryRepository : RepositoryQueryBase<UsuarioNotification>, IUsuarioQueryRepository
    {
        public UsuarioQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
