using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class MicroRegiaoRepository : BaseRepository<MicroRegiao>, IMicroRegiaoRepository
    {
        public MicroRegiaoRepository(SGASContext context) : base(context)
        {
        }
    }
}
