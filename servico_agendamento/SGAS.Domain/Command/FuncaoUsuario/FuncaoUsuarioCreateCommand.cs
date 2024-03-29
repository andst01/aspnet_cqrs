using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FuncaoUsuarioCreateCommand : FuncaoUsuarioCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new FuncaoUsuarioCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
