using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class UnidadeVendaRepository : BaseRepository<UnidadeVenda>, IUnidadeVendaRepository
    {
        private readonly SGASContext _db;

        public UnidadeVendaRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
