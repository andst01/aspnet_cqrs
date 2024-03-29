using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class EmpresaCreateCommand : EmpresaCommand
    {

        

        public override bool IsValid()
        {
            ValidationResult = new EmpresaCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
