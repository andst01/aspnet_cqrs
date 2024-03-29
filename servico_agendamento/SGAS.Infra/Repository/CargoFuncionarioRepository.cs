using Microsoft.EntityFrameworkCore;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System;
using System.Threading.Tasks;

namespace SGAS.Infra.Repository
{
    public class CargoFuncionarioRepository : BaseRepository<CargoFuncionario>, ICargoFuncionarioRepository
    {
        private readonly SGASContext _db;

        public CargoFuncionarioRepository(SGASContext db) : base(db)
        {
            _db = db;
        }

        public async Task<CargoFuncionario> ObterCargoFuncionario(int idCargo, int idFuncionario)
        {
            return await _db.Set<CargoFuncionario>().FirstOrDefaultAsync(x => x.IdCargo == idCargo && x.IdFuncionario == idFuncionario);
        }

        public async Task<CargoFuncionario> ObterCargoValido(int idFuncionario)
        {
            return await _db.Set<CargoFuncionario>().FirstOrDefaultAsync(x => x.IdFuncionario == idFuncionario && x.DataFim == null);
        }

        public CargoFuncionario DesativarCargo(CargoFuncionario cargoFuncionario)
        {
            cargoFuncionario.DataFim = DateTime.Now;
            var retorno = this.Atualizar(cargoFuncionario);
            return retorno;
        }
    }
}
