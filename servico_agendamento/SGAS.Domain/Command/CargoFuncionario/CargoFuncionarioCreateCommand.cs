using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class CargoFuncionarioCreateCommand : CargoFuncionarioCommand
    {

        //public CargoFuncionarioCreateCommand(int idFuncionario, int idCargo, DateTime dataInicio, DateTime? dataFim)
        //{
        //    IdFuncionario = idFuncionario;
        //    IdCargo = idCargo;
        //    DataInicio = dataInicio;
        //    DataFim = dataFim;
        //}

        public override bool IsValid()
        {
            ValidationResult = new CargoFuncionarioCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
