using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class CategoriaDeleteCommand : CategoriaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CategoriaDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
