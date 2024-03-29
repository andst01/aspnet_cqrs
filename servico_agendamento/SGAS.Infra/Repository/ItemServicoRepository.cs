using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Repository
{
    public class ItemServicoRepository : BaseRepository<ItemServico>, IItemServicoRepository
    {
        private readonly SGASContext _db;

        public ItemServicoRepository(SGASContext db) : base(db)
        {
            this._db = db;
        }
    }
}
