using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class CargoDeleteCommand : CargoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CargoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
