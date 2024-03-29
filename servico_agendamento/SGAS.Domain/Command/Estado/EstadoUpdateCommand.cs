using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class EstadoUpdateCommand : EstadoCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new EstadoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
