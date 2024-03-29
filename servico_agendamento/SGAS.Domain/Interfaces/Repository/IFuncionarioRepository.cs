using SGAS.Domain.Entity;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.Repository
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario>
    {
        Task<Funcionario> AdicionarEntidades(Funcionario request);
    }
}
