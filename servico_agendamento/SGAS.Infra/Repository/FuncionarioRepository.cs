using Microsoft.EntityFrameworkCore;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SGAS.Infra.Repository
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        protected readonly SGASContext _db;

        public FuncionarioRepository(SGASContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Funcionario> AdicionarEntidades(Funcionario request)
        {
           
            Funcionario retorno = null;

            using (var scope = _db.Database.BeginTransaction())
            {
                try
                {
                    var pessoa = _db.Pessoa.Add(request.Pessoa);
                    await _db.Commit();

                    request.Pessoa.Endereco.IdPessoa = pessoa.Entity.Id;
                    _db.Endereco.Add(request.Pessoa.Endereco);
                    await _db.Commit();

                    request.IdPessoa = pessoa.Entity.Id;
                    retorno = _db.Funcionario.Add(request).Entity;
                    await _db.Commit();

                    scope.Commit();

                    return retorno;
                }
                catch (Exception ex)
                {
                    scope.Rollback();
                    return null;
                }
            }

            return retorno;
        }
    }
}
