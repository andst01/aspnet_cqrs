using SGAS.Domain.Entity;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.Repository
{
    public interface IPessoaRepository : IBaseRepository<Pessoa>
    {
        Task<Pessoa> AdicionarPessoaFuncionario(Pessoa entidade);
    }
}
