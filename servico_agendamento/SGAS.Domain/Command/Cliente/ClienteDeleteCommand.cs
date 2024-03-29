using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class ClienteDeleteCommand : ClienteCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new ClienteDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
