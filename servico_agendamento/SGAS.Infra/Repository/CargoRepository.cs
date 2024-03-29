using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class CargoRepository : BaseRepository<Cargo>, ICargoRepository
    {
        private readonly SGASContext _db;

        public CargoRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
