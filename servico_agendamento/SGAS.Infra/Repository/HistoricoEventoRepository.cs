using SGAS.Domain.Entity;
using SGAS.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGAS.Infra.EventSourcing;
using SGAS.Domain.Interfaces.Repository;
using System;

namespace SGAS.Infra.Repository
{
    public class HistoricoEventoRepository
        : BaseRepository<HistoricoEvento>,
          IHistoricoEventoRepository
    {
        private readonly SGASContext _context;

        public HistoricoEventoRepository(SGASContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IList<HistoricoEvento>> All(string nomeTabela)
        {
            return await (from e in _context.HistoricoEventos where e.NomeTabela.ToUpper() == nomeTabela select e).ToListAsync();
        }

        public async Task<bool?> Store(HistoricoEvento theEvent)
        {

            await _context.HistoricoEventos.AddAsync(theEvent);
            return (await _context.SaveChangesAsync() > 0);
        }

        public List<string> ListarTabelas()
        {
            var domainEntities = _context.ChangeTracker
              .Entries<EntidadeBase>()
              .Where(x =>
                          x.Entity.DomainEvents != null &&
                          x.Entity.DomainEvents.Any());

            var response = domainEntities.Select(x => x.Metadata.GetTableName())
                                         .OrderBy(x => x).ToList();

            return response;
        }

        public List<HistoricoEvento> ListarHistorico(string nomeTable, DateTime? dataCadastro)
        {
            var query = _context.HistoricoEventos.Where(x => x.NomeTabela == nomeTable).AsNoTracking();

            if (dataCadastro != null)
            {
                query = query.Where(x => x.DataCadastro >= dataCadastro);
            }

            return query.OrderBy(x => new { x.NomeTabela, x.DataCadastro }).ToList();

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
