using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class FuncaoQueryRepository : RepositoryQueryBase<FuncaoNotification>, IFuncaoQueryRepository
    {
        public FuncaoQueryRepository(IMongoDBContext context) : base(context)
        {
            
        }
    }
}
