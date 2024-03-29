using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class EmpresaQueryRepository : RepositoryQueryBase<EmpresaNotification>, IEmpresaQueryRepository
    {
        public EmpresaQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
