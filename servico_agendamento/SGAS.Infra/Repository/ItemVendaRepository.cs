using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;

namespace SGAS.Infra.Repository
{
    public class ItemVendaRepository : BaseRepository<ItemVenda>, IItemVendaRepository    
    {
        public ItemVendaRepository(SGASContext db) : base(db)
        {
        }
    }
}
