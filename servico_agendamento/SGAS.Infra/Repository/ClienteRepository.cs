using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly SGASContext _db;

        public ClienteRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
