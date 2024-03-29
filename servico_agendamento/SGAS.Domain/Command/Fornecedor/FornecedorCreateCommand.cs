using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FornecedorCreateCommand : FornecedorCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new FornecedorCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
