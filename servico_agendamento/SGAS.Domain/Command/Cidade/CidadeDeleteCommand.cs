using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class CidadeDeleteCommand : CidadeCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new CidadeDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
