using Microsoft.EntityFrameworkCore;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System.Threading.Tasks;



namespace SGAS.Infra.Repository
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly SGASContext _db;

        public PessoaRepository(SGASContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Pessoa> AdicionarPessoaFuncionario(Pessoa entidade)
        {

            using (var context = new SGASContext())
            {
                var ctx = context;

                var teste = context.Set<Pessoa>()
                    .Include(x => x.Funcionario)
                    .Include(x => x.Endereco);
                   

                var teste2 = teste;
            }
           
            
            Pessoa retorno = null;

            

            return retorno;
        }
    }
    
}
