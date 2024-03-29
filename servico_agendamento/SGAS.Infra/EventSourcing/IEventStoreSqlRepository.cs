using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Infra.EventSourcing
{
    public interface IEventStoreSqlRepository
    {
        Task<bool?> Store(HistoricoEvento theEvent);
        Task<IList<HistoricoEvento>> All(int aggregateId, string action);
    }
}
