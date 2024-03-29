using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FuncaoCreateCommand : FuncaoCommand
    {


        public override bool IsValid()
        {
            ValidationResult = new FuncaoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
