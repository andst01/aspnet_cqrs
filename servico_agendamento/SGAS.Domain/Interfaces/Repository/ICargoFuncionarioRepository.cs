using SGAS.Domain.Entity;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.Repository
{
    public interface ICargoFuncionarioRepository : IBaseRepository<CargoFuncionario>
    {
        Task<CargoFuncionario> ObterCargoFuncionario(int idCargo, int idFuncionario);

        Task<CargoFuncionario> ObterCargoValido(int idFuncionario);

        CargoFuncionario DesativarCargo(CargoFuncionario cargoFuncionario);
    }
}
