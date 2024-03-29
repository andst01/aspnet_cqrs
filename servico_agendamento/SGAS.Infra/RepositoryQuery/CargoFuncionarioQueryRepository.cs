using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class CargoFuncionarioQueryRepository : RepositoryQueryBase<CargoFuncionarioNotification>, ICargoFuncionarioQueryRepository
    {
        public CargoFuncionarioQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
