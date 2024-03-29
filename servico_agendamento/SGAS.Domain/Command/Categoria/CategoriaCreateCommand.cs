using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class CategoriaCreateCommand : CategoriaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CategoriaCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
