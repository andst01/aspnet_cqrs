using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using SGAS.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Repository
{
    public class AgendamentoRepository : BaseRepository<SGAS.Domain.Entity.Agendamento>, IAgendamentoRepository
    {
        private readonly SGASContext _db;
        public AgendamentoRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
