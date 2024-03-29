using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FuncaoUsuarioUpdateCommand : FuncaoUsuarioCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new FuncaoUsuarioUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
