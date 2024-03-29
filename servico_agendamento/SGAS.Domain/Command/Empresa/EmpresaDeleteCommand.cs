using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class EmpresaDeleteCommand : EmpresaCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new EmpresaDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
