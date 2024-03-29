using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class AgendaCreateCommand : AgendaCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new AgendaCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
