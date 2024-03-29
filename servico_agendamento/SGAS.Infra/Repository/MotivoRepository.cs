using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Repository
{
    public class MotivoRepository : BaseRepository<Motivo>, IMotivoRepository
    {
        private readonly SGASContext _db;

        public MotivoRepository(SGASContext db) : base(db)
        {
            _db = db;
        }
    }
}
