using SGAS.Domain.Validations;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class FuncionarioCreateCommand :  FuncionarioCommand
    {
        
        public override bool IsValid()
        {
            ValidationResult = new FuncionarioCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
