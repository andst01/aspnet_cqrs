using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class FuncaoUsuarioRepository : BaseRepository<FuncaoUsuario>, IFuncaoUsuarioRepository
    {
        private readonly SGASContext _db;

        public FuncaoUsuarioRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
