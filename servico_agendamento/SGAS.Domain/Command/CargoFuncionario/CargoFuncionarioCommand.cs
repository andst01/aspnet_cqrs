using MediatR;
using SGAS.Domain.Entity;
using System;

namespace SGAS.Domain.Command
{
    public  class CargoFuncionarioCommand : BaseCommand, 
        IRequest<CargoFuncionario>, IBaseRequest
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public FuncionarioCommand Funcionario { get; set; }
        public int IdCargo { get; set; }
        public CargoCommand Cargo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
