using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class CargoQueryRepository : RepositoryQueryBase<CargoNotification>, ICargoQueryRepository
    {
        public CargoQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
