using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class CargoCommand : BaseCommand, IRequest<Cargo>, IBaseRequest
    {

        public int Id { get; set; }
        public string Descricao { get; set; }

        public int Ativo { get; set; }

        public List<CargoFuncionarioCommand> CargosFuncionario { get; set; }
    }
}
