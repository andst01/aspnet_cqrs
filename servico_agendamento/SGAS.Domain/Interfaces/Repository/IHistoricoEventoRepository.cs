using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.Repository
{
    public interface IHistoricoEventoRepository : IBaseRepository<HistoricoEvento>
    {
        Task<bool?> Store(HistoricoEvento theEvent);
        Task<IList<HistoricoEvento>> All(string nomeTabela);
        List<string> ListarTabelas();
        List<HistoricoEvento> ListarHistorico(string nomeTable, DateTime? dataCadastro);
    }
}
