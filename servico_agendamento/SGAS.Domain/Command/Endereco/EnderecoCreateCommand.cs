using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class EnderecoCreateCommand : EnderecoCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new EnderecoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
