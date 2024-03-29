using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class FuncaoRepository : BaseRepository<Funcao>, IFuncaoRepository
    {
        private readonly SGASContext _db;

        public FuncaoRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
