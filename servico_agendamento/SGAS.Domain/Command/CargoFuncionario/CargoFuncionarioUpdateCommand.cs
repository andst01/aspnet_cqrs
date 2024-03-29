using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class CargoFuncionarioUpdateCommand : CargoFuncionarioCommand
    {

        public CargoFuncionarioUpdateCommand(int id, int idFuncionario, int idCargo, DateTime dataInicio, DateTime? dataFim)
        {
            Id = id;
            IdFuncionario = idFuncionario;
            IdCargo = idCargo;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public override bool IsValid()
        {
            ValidationResult = new CargoFuncionarioUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
