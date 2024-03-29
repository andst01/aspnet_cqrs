using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Repository
{
    public class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        private readonly SGASContext _db;

        public AgendaRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
