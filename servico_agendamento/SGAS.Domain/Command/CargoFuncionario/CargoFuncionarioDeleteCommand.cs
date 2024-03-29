using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class CargoFuncionarioDeleteCommand : CargoFuncionarioCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CargoFuncionarioDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
