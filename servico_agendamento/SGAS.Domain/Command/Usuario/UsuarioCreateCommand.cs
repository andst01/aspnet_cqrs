using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class UsuarioCreateCommand : UsuarioCommand
    {

       
        public override bool IsValid()
        {
            ValidationResult = new UsuarioCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
