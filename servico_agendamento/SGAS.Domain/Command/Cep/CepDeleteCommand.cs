using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class CepDeleteCommand : CepCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new CepDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
