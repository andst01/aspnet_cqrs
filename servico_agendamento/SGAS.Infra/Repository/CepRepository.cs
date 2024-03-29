using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class CepRepository : BaseRepository<Cep>, ICepRepository
    {
        public CepRepository(SGASContext context) : base(context) { }

    }
}
