using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FornecedorUpdateCommand : FornecedorCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new FornecedorUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
