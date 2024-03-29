using SGAS.Domain.Command;
using System.Collections.Generic;

namespace SGAS.Application.ViewModels
{
    public class CargoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int Ativo { get; set; }

        public List<CargoFuncionarioViewModel> CargosFuncionario { get; set; }
    }

    public static class CargoViewModelToRequest
    {
        public static CargoCreateCommand ToCreateCommand(this CargoViewModel request)
        {
            var command = new CargoCreateCommand();

            command.Id = request.Id;
            command.Descricao = request.Descricao;
            command.Ativo = request.Ativo;

            return command;
        }

        public static CargoUpdateCommand ToUpdateCommand(this CargoViewModel request)
        {
            var command = new CargoUpdateCommand();

            command.Id = request.Id;
            command.Descricao = request.Descricao;
            command.Ativo = request.Ativo;

            return command;
        }
    }
}
