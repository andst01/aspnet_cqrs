using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class AgendamentoUpdateCommand : AgendamentoCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new AgendamentoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
