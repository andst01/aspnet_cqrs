using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class AgendaUpdateCommand : AgendaCommand
    {

        
        public override bool IsValid()
        {
            ValidationResult = new AgendaUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
