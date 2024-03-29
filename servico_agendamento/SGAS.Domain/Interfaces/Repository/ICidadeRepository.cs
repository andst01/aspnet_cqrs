using SGAS.Domain.Entity;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.Repository
{
    public interface ICidadeRepository : IBaseRepository<Cidade>
    {
        Task<int> InserirCidadeDapper(Cidade cidade);

        Task<bool> TesteInsert();
    }
}
