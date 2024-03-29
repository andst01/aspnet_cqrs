using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class UsuarioDeleteCommand : UsuarioCommand
    {
        

        public override bool IsValid()
        {
            ValidationResult = new UsuarioDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
