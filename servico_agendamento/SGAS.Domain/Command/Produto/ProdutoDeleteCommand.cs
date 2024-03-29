using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class ProdutoDeleteCommand : ProdutoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new ProdutoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
