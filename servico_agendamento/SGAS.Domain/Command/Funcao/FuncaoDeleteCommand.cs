using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FuncaoDeleteCommand : FuncaoCommand
    {
      

        public override bool IsValid()
        {
            ValidationResult = new FuncaoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
