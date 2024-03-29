using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class MesoRegiaoRepository : BaseRepository<MesoRegiao>, IMesoRegiaoRepository
    {
        public MesoRegiaoRepository(SGASContext context) : base(context)
        {
        }
    }
}
