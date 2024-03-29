using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class ProdutoCreateCommand : ProdutoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new ProdutoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
