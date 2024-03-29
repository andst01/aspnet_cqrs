using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly SGASContext _db;

        public UsuarioRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
