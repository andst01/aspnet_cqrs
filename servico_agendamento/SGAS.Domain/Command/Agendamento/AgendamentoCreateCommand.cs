using FluentValidation.Results;
using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class AgendamentoCreateCommand : AgendamentoCommand
    {
      

        public override bool IsValid()
        {

            ValidationResult = new AgendamentoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
