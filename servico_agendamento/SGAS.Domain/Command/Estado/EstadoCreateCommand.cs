using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class EstadoCreateCommand : EstadoCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new EstadoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
