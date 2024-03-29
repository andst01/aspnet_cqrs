using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class PessoaCreateCommand : PessoaCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new PessoaCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
