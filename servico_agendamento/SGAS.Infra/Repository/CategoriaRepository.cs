using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(SGASContext db) : base(db)
        {
        }
    }
}
