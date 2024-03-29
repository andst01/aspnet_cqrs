using SGAS.Domain.Entity;
using SGAS.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGAS.Infra.EventSourcing
{
    public class EventStoreSqlRepository : IEventStoreSqlRepository
    {
        private readonly EventStoreSqlContext _context;

        public EventStoreSqlRepository(EventStoreSqlContext context)
        {
            _context = context;
        }

        public async Task<IList<HistoricoEvento>> All(int aggregateId, string action)
        {
            return await (from e in _context.HistoricoEventoAgendamento where e.CodigoMensagem == aggregateId && e.TipoMensagem.Contains(action) select e).ToListAsync();
        }

        public async Task<bool?> Store(HistoricoEvento theEvent)
        {
            await _context.HistoricoEventoAgendamento.AddAsync(theEvent);
            return  (await _context.SaveChangesAsync() > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
