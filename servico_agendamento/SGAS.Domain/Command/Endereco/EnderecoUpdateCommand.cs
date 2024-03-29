using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class EnderecoUpdateCommand : EnderecoCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new EnderecoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
