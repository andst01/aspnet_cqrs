using SGAS.Domain.Validations;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class CidadeUpdateCommand : CidadeCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new CidadeUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
