using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FuncaoUsuarioDeleteCommand : FuncaoUsuarioCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new AspNetUserRolesDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
