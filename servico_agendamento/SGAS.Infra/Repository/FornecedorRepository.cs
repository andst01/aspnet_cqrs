using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly SGASContext _db;

        public FornecedorRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
