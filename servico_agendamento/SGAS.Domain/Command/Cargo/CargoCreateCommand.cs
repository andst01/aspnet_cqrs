using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class CargoCreateCommand : CargoCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new CargoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
