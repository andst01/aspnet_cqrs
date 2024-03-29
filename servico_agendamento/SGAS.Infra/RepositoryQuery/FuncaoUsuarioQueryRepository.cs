using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class FuncaoUsuarioQueryRepository : RepositoryQueryBase<FuncaoUsuarioNotification>, IFuncaoUsuarioQueryRepository
    {
        public FuncaoUsuarioQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
