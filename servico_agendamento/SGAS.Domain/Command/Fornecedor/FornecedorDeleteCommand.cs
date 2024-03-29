using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FornecedorDeleteCommand : FornecedorCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new FornecedorDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
