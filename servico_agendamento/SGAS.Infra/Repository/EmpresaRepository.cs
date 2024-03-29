using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        private readonly SGASContext _db;

        public EmpresaRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
