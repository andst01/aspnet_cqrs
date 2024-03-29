using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class UsuarioUpdateCommand : UsuarioCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new UsuarioUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
