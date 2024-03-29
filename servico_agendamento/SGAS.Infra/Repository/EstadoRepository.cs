using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(SGASContext context) : base(context)
        {
        }
    }
}
