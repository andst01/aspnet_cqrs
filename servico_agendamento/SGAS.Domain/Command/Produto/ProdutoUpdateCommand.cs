using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class ProdutoUpdateCommand : ProdutoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new ProdutoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
